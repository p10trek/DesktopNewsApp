using MvvmCross.Commands;
using MvvmCross.Platforms.Wpf.Views;
using NewsApp.Core;
using NewsApp.Core.Helpers;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    public partial class AllNewsView : MvxWpfView
    {
        public AllNewsView()
        {
            InitializeComponent();
        }



        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            //await GenericFactory<AllNewsViewModel>.CreateInstance().GetNews(new RequestModel
            //{
            //    Categories = "business,tech",
            //    Search = "President",
            //    Timeout = -1,
            //    Limit = 5,
            //    Token = "HgcpXI8z8J7yLHOCfRxpluxoGgUA7zYbGmq5PdAR",
            //    Url = "https://api.thenewsapi.com/v1/news/all"
            //});

        }

    }
}
