using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Lab_4.VM
{
    public class StartVM : INotifyPropertyChanged
    {
        public int count;
        public int right;

        public int Count
        {
            get { return count; }
            set
            {
                count = value;
                OnPropertyChanged("Count");
            }
        }
        public int Right
        {
            get { return right; }
            set
            {
                right = value;
                OnPropertyChanged("Right");
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
