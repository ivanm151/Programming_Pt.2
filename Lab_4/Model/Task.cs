using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4.Model
{
    public class Task 
    {
        
        public int Id { get; set; }
        public string Path { get; set; }
        public List<string> Paramtrs { get; set; }
        public int ButtonNum { get; set; }
        //private List<string> answers = new();

        public Task() { }
        public Task(int id, string path, List<string> paramtrs, int buttonNum)
        {
            Id = id;
            Path = path;
            Paramtrs = paramtrs;
            ButtonNum = buttonNum;
        }
    }
}
