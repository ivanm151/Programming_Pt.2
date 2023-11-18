using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4.Model
{
    public class Task : INotifyPropertyChanged
    {
        
        private int id;
        private string path;
        private int param_num;
        private int button_num;
        private List<string> answers;

        public int Id
        {
            get { return id; }
            set
            {
                id = value;
                OnPropertyChanged("Id");
            }
        }
        public string Path
        {
            get { return path; }
            set
            {
                path = value;
                OnPropertyChanged("Path");
            }
        }
        public int ParamNum
        {
            get { return param_num; }
            set
            {
                param_num = value;
                OnPropertyChanged("ParamNum");
            }
        }
        public int ButtonNum
        {
            get { return button_num; }
            set
            {
                button_num = value;
                OnPropertyChanged("ButtonNum");
            }
        }
        public List<string> Answers
        {
            get { return answers; }
            set
            {
                answers = value;
                OnPropertyChanged("Answers");
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
