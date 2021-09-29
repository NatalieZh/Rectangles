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

namespace Rectangles
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ArrayRectangles rectangles;
        public MainWindow()
        {
            InitializeComponent();

        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            if (rectangles == null && textBox2.Text.Length > 0)
            {
                rectangles = new ArrayRectangles(int.Parse(textBox2.Text));
            }
            if(rectangles != null )
            {
                if (textBox.Text.Length > 0 && textBox1.Text.Length > 0)
                {
                    rectangles.AddRectangle(new Rectangle(int.Parse(textBox.Text), int.Parse(textBox1.Text)));
                }
                else if (textBox.Text.Length == 0 && textBox1.Text.Length == 0)
                {
                    rectangles.AddRectangle(new Rectangle());
                }
                else if (textBox.Text.Length == 0)
                {
                    rectangles.AddRectangle(new Rectangle(int.Parse(textBox1.Text), null));
                }
                else if (textBox1.Text.Length == 0)
                {
                    rectangles.AddRectangle(new Rectangle(int.Parse(textBox.Text)));
                }
                textBlock.Text = rectangles.GetInfo();
            }
        }

        private void textBox_keydown(object sender, KeyEventArgs e)
        {
            //e.Handled = !System.Text.RegularExpressions.Regex.IsMatch(e.Key.ToString(), "[0-9]");
        }

        private void btnDel_Click(object sender, RoutedEventArgs e)
        {
            Random random = new Random();
            int i = random.Next(0, rectangles.Length);
            rectangles.DeleteRectangle(i);
            textBlock.Text = rectangles.GetInfo();
        }
    }
}
