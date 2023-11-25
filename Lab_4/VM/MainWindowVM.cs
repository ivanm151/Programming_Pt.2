using Lab_4.Model;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Task = Lab_4.Model.Task;

namespace Lab_4.VM
{
    public class MainWindowVM : VM1
    {
        private Test test1;
        public Test Test1 { get { return test1; } set { test1 = value; } }
        
        private Task current;
        public List<Task> Tasks { get; set; }

        public Task Current { get { return current; } set { current = value; } }




       public MainWindowVM()
        {
            List<string> paths = new List<string>();
            for (int i = 1; i < 16; i++)
            {
                paths.Add("C:\\Users\\ivmed\\source\\repos\\Lab_4\\Шаблоны заданий\\" + i.ToString() + ".png");
            }
                      
            Tasks = new List<Task>();
            for(int i = 0; i < 16; i++)
            {
                Current = new Task { Id = i, Path = paths[i] };
                if (i == 3 || i == 8) { Current.ButtonNum = 2; }
                else { Current.ButtonNum = 4; }
                if (i == 3 || i == 12) { Current.Paramtrs.Add("a"); };
                if (i == 11 || i == 15) { Current.Paramtrs.Add("r"); };
                if (i == 6) { Current.Paramtrs.Add("a"); Current.Paramtrs.Add("b"); };
                if (i == 13) { Current.Paramtrs.Add("r"); Current.Paramtrs.Add("h"); };
                if (i == 14) { Current.Paramtrs.Add("B"); Current.Paramtrs.Add("C"); };
                if (i == 1 || i == 2 || i == 4 || i == 5 || i == 9 || i == 10)
                {
                    Current.Paramtrs.Add("a"); Current.Paramtrs.Add("b"); Current.Paramtrs.Add("c");
                }
            }
            //Test1 = new Test();
            
        }
        public void NextTask()
        {

        }
        public void TwoButtons()
        {

        }








        /*public MainWindowVM()
        {
            

            Testik = new Test { Count = 4, Right = 4 получить значения из StartVM
    };
            

                

                
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
