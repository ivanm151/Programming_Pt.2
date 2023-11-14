﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4.Model
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

        }
        


        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
