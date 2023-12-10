using System.Windows;
using System.Windows.Controls;

namespace Lb2_prog_2
{
    internal class NumberButton : Button
    {        
        // Параметр идентификатора символа для распознавания нажатой кнопки
        public string IdData
        {
            get { return (string)GetValue(IdDataProperty); }
            set { SetValue(IdDataProperty, value); }
        }
        public static readonly DependencyProperty IdDataProperty = DependencyProperty.Register(
            nameof(IdData), typeof(string), typeof(NumberButton), new PropertyMetadata(""));

        public NumberButton()
        {
            DefaultStyleKey = typeof(NumberButton);
        }
    }
}
