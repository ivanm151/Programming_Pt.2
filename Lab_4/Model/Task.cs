using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4.Model
{
    public class Task
    {
        public int Id { get; set; }
        public int Params_num { get; set; }
        public int Vars_num { get; set; }
        public string Path { get; set; } = ""; 
    }
}
