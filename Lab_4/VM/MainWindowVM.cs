using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Lab_4.Model;

namespace Lab_4.VM
{
    public class MainWindowVM : INotifyPropertyChanged
    {
        private Model.Task task1;

        public Model.Task Task1
        {
            get { return task1; }
            set
            {
                task1 = value;
                OnPropertyChanged("Task1");
            }
        }

        private Test testik;
        
        public Test Testik
        {
            get { return testik; }
            set
            {
                testik = value;
                OnPropertyChanged("Testik");
            }
        }
        public MainWindowVM()
        {
            Task1 = new Model.Task();
            Testik = new Test { Count = 4, Right = 4   /*, Tasks = massiv zadaniy, обЪявить выше!!!;*/  };
        }



        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
