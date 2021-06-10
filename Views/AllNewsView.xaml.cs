using MvvmCross.Commands;
using MvvmCross.Platforms.Wpf.Views;
using NewsApp.Core;
using NewsApp.Core.Helpers;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
namespace NewsApp.WPF.Views
{
    /// <summary>
    /// Interaction logic for AllNewsView.xaml
    /// </summary>
    public partial class AllNewsView : MvxWpfView, ISecure
    {
        public AllNewsView()
        {
            InitializeComponent();
        }

        public SecureString Password { get; set; }

    }
}
