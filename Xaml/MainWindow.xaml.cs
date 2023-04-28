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

namespace Xaml
{
    /// <summary>
    /// coment. I'm bit weak today. But it seem ok. Nice even.
    /// Interaction logic for Window.xaml
    /// ClassTest.cs
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// MainWindow is the main window :)
        /// <see cref="MainWindow"/>
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
            string s = Properties.Resources.MainWindow_MainWindow_string_in_resource;
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

 
    }
}
