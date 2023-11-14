using Lab_4.Model;
using Lab_4.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4.VM
{
    public class ManageVM : INotifyPropertyChanged
    {
        private Test test;
        public Test Test
        {
            get { return test; }
            set
            {
                test = value;
                OnPropertyChanged("Test");
            }
        }
        public ManageVM()
        {
            for (int i = 0; i < test.Count; i++)
            {
                test.Tasks[i].Path = "C:\\Users\\ivmed\\source\\repos\\Lab_4\\Шаблоны заданий\\" + (i + 1).ToString() + ".png";
                i++;
            }
        }

        private void OpenMainWindow()
        {
            MainWindow mainWindow = new MainWindow();
            
        }
        private void OpenFinishWindow()
        {
            Finish finish = new Finish();
        }


        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
