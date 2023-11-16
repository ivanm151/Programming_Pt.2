using System.Windows;
using Lab_4.VM;
namespace Lab_4.View
{
    /// <summary>
    /// Логика взаимодействия для Start.xaml
    /// </summary>
    public partial class Start : Window
    {
        public Start()
        {
            InitializeComponent();
            DataContext = new StartVM();
        }

       
    }
}
