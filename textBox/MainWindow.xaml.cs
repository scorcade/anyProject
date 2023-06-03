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

namespace textBox
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void buttonHide_Click(object sender, RoutedEventArgs e)
        {
            textBox.Visibility = Visibility.Collapsed;
            
        }

        private void buttonShow_Click(object sender, RoutedEventArgs e)
        {
            textBox.Visibility = Visibility.Visible;
        }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        private void Control1_ClientSizeChanged(Object sender, EventArgs e)
        {

            MessageBox.Show("You are in the Control.ClientSizeChanged event.");
        }

        private void textBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }
    }
}
