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

namespace WpfDemo
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        private string name;
        public Window2(String _name)
        {
            InitializeComponent();
            name = _name;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            welcome.Text = "Welcome "+name;
        }
    }
}
