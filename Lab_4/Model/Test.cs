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
        public int Success { get; set; }
        public List<Task> Tasks { get; set; }
        
    }
}
