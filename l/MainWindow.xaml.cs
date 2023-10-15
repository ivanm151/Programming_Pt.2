using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfLibraryLAB3;

namespace l
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Domino obj = new Domino();
        Domino copy = new Domino();
        public MainWindow()
        {
            InitializeComponent();

            foreach(UIElement elem in MainField.Children)
            {
                if(elem is Button)
                {                    
                    ((Button)elem).Click += button_Click;
                    ((Button)elem).Click -= button_Click;
                }
            }
        }
        private void button_Click(object sender, RoutedEventArgs e) 
        {
            if ((string)((Button)e.OriginalSource).Name is "buttonNewGame")             
                ((Button)e.OriginalSource).Click += buttonNewGame_Click;                           
            if ((string)((Button)e.OriginalSource).Name is "buttonGetUser")           
                ((Button)e.OriginalSource).Click += buttonGetUser_Click;                           
            if ((string)((Button)e.OriginalSource).Name is "buttonRand")            
                ((Button)e.OriginalSource).Click += buttonRand_Click;                          
            if ((string)((Button)e.OriginalSource).Name is "buttonStep")            
                ((Button)e.OriginalSource).Click += buttonStep_Click;                           
            if ((string)((Button)e.OriginalSource).Name is "buttonStart")            
                ((Button)e.OriginalSource).Click += buttonStart_Click;                           
        }
        private void buttonNewGame_Click(object sender, RoutedEventArgs e)
        {
            listBoxGame.Items.Clear();
            buttonStep.Visibility = Visibility.Hidden;
            buttonStart.Visibility = Visibility.Visible;
        }

        private void buttonGetUser_Click(object sender, RoutedEventArgs e)
        {
            obj = new Domino();
            int[] nums = new int[2];
            listBoxCurrent.Items.Clear();
            try
            {
                nums[0] = Convert.ToInt32(textBoxLeft.Text);
                nums[1] = Convert.ToInt32(textBoxRight.Text);
                if (nums[0] < 1 || nums[0] > 6 || nums[1] < 1 || nums[1] > 6)
                {
                    MessageBox.Show("Значением может быть только число от 1 до 6");
                    textBoxLeft.Clear();
                    textBoxRight.Clear();
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                textBoxLeft.Clear();
                textBoxRight.Clear();
            }
            obj.set_user_value(nums);
            listBoxCurrent.Items.Add(Convert.ToString(obj.get_value()[0]) + "-----" + Convert.ToString(obj.get_value()[1]));
            buttonStep.Visibility = Visibility.Visible;
        }

        private void buttonRand_Click(object sender, RoutedEventArgs e)
        {
            obj = new Domino();
            listBoxCurrent.Items.Clear();
            listBoxCurrent.Items.Add(Convert.ToString(obj.get_value()[0]) + "-----" + Convert.ToString(obj.get_value()[1]));
            buttonStep.IsEnabled = true;
        }

        private void buttonStep_Click(object sender, RoutedEventArgs e)
        {
            if (listBoxCurrent.Items.Count == 0)
            {
                MessageBox.Show("Задайте кость!");
                return;
            }
            if(listBoxGame.Items.Count == 0)
            {
                MessageBox.Show("Сначала начните игру!");
                return;
            }
            if (obj.get_value()[0] == copy.get_value()[1] || obj.get_value()[1] == copy.get_value()[1])
            {
                copy.set_user_value(obj.get_value());
                listBoxGame.Items.Add(Convert.ToString(obj.get_value()[0]) + "-----" + Convert.ToString(obj.get_value()[1]));
                listBoxCurrent.Items.Clear();
            }
            else
            {
                MessageBox.Show("Ход невозможен!");
                listBoxCurrent.Items.Clear();
            }
            buttonStep.IsEnabled=false;
        }

        private void buttonStart_Click(object sender, RoutedEventArgs e)
        {
            if (listBoxCurrent.Items.Count == 0)
            {
                MessageBox.Show("Задайте кость!");
                return;
            }
            copy = new Domino();
            copy.set_user_value(obj.get_value());
            listBoxGame.Items.Add(Convert.ToString(obj.get_value()[0]) + "-----" + Convert.ToString(obj.get_value()[1]));
            listBoxCurrent.Items.Clear();           
            buttonStep.Visibility = Visibility.Visible;
            buttonStart.Visibility = Visibility.Hidden;
        }
    }
}
