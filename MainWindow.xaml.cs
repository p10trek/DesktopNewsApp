using NewsApp.Core.Helpers;
using NewsApp.Core.Interfaces;
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

namespace NewsApp.WPF
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

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            await GenericFactory<Services>.CreateInstance().GetNews(new RequestModel
            {
                Categories = "business,tech",
                Search = "President",
                Timeout = -1,
                Limit = 5,
                Token = "HgcpXI8z8J7yLHOCfRxpluxoGgUA7zYbGmq5PdAR",
                Url = "https://api.thenewsapi.com/v1/news/all"

            });
          
        }
    }
}
