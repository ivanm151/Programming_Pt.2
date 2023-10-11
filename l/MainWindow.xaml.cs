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
        Domino obj;
        Domino copy;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void buttonNewGame_Click(object sender, RoutedEventArgs e)
        {
            listBoxGame.Items.Clear();
            //buttonStart.Visible = true;
            //buttonStep.Visible = false;
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
            //buttonStep.Enabled = true;
        }

        private void buttonRand_Click(object sender, RoutedEventArgs e)
        {
            obj = new Domino();
            listBoxCurrent.Items.Clear();
            listBoxCurrent.Items.Add(Convert.ToString(obj.get_value()[0]) + "-----" + Convert.ToString(obj.get_value()[1]));
            //buttonStep.Enabled = true;
        }

        private void buttonStep_Click(object sender, RoutedEventArgs e)
        {
            if (listBoxCurrent.Items.Count == 0)
            {
                MessageBox.Show("Задайте кость!");
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
            //buttonStep.Enabled = false;
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
            //buttonStart.Visible = false;
            //buttonStep.Visible = true;
        }
    }
}
