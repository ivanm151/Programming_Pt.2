using Lab_4.Model;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;


namespace Lab_4.VM
{
    public class MainWindowVM : VM1
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
        /*public MainWindowVM()
        {
            List<string> paths = new List<string>();
            for (int i = 1; i < 16; i++)
            {
                paths.Add("C:\\Users\\ivmed\\source\\repos\\Lab_4\\Шаблоны заданий\\" + i.ToString() + ".png");
            }

            Testik = new Test { Count = 4, Right = 4 /*получить значения из StartVM*/ };
            /*for (int i = 1; i < Testik.Count; i++)
            {
                Task task = new Task {Id = i, Path = paths[i]};

                if (i == 3 || i == 8) { task.ButtonNum = 2; }                
                else { task.ButtonNum = 4; }

                if (i == 3 || i == 12) { task.Paramtrs.Add("a"); };
                if (i == 11 || i == 15) { task.Paramtrs.Add("r"); };
                if (i == 6) { task.Paramtrs.Add("a"); task.Paramtrs.Add("b"); };
                if (i == 13) { task.Paramtrs.Add("r"); task.Paramtrs.Add("h"); };
                if (i == 14) { task.Paramtrs.Add("B"); task.Paramtrs.Add("C"); };
                if (i == 1 || i == 2 || i == 4 || i == 5 || i == 9 || i == 10)
                {
                    task.Paramtrs.Add("a"); task.Paramtrs.Add("b"); task.Paramtrs.Add("c");
                }
                // 7-матрица
                // answers

                Testik.Tasks.Add(task);
            }   
        }
        public void FillParam()
        {

        }
        public void Answers()
        {

        }
            */


        
    
}
