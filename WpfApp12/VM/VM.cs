using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfApp12.VM
{
    
    public class TestViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<TestQuestion> Questions { get; set; }
        public ICommand SubmitCommand { get; }

        private TestResult _result;
        public TestResult Result
        {
            get { return _result; }
            set
            {
                _result = value;
                OnPropertyChanged(nameof(Result));
            }
        }

        
        public TestViewModel()
        {
            // Initialize Questions and SubmitCommand
            LoadQuestions(); // Метод для загрузки вопросов
            SubmitCommand = new RelayCommand(SubmitTest);
        }

        private void LoadQuestions()
        {
            // Логика загрузки вопросов, включая загрузку изображений и заполнение коллекции Questions
        }

        private void SubmitTest(object parameter)
        {
            // Calculate user answers and percentage correct
            // Set Result property
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
