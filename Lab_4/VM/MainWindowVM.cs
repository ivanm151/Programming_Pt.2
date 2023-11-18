using Lab_4.Model;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Lab_4.VM
{
    public class MainWindowVM : INotifyPropertyChanged
    {       
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
            List<string> paths = new List<string>();
            for (int i = 1; i < 16; i++)
            {
                paths.Add("C:\\Users\\ivmed\\source\\repos\\Lab_4\\Шаблоны заданий\\" + i.ToString() + ".png");
            }

            Testik = new Test { Count = 4, Right = 4 /*получить значения из StartVM*/ };
            for (int i = 1; i < Testik.Count; i++)
            {
                Task task = new Task {Id = i, Path = paths[i]};

                if (i == 3 || i == 8)
                {
                    task.ButtonNum = 2;
                    if (i == 3) { task.ParamNum = 1; }
                    else { task.ParamNum = 0; }
                }
                else { task.ButtonNum = 4; }

                if (i == 3 || i == 11 || i == 12 || i == 15) { task.ParamNum = 1; }

                Testik.Tasks.Add(task);
            }
            

            
            
        }



        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
