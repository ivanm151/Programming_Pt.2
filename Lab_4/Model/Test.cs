using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using static System.Net.Mime.MediaTypeNames;

namespace Lab_4.Model
{
   
    public class Test 
    {
        public int Count { get; set; }     
        public int Right { get; set; }
        //private int success;
        public List<Task> Tasks { get; set; }

        //public Test() { }
        public Test(int count, int right, List<Task> tasks)
        {
            Count = count;
            Right = right;
            Tasks = tasks;
        }
    }
}
