using MvvmCross.Platforms.Wpf.Views;
using NewsApp.Core;
using NewsApp.Core.Helpers;
using NewsApp.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
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

namespace NewsApp.WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MvxWindow,ISecure
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public SecureString Password { get; set; }
    }
}
