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
using System.Windows.Shapes;

namespace EX_02
{
    /// <summary>
    /// Interaction logic for leapYear.xaml
    /// </summary>
    public partial class leapYear : Window
    {
        public leapYear()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            //int Year=Convert.ToInt32(textBox.Text);
            //string s=textBox.Text;
            int year = Convert.ToInt32(textBox.Text);
            if (DateTime.IsLeapYear(year))
            {
               MessageBox.Show("yes");
            }
            else
            {
                MessageBox.Show("no");

            }
        }
    }
}
