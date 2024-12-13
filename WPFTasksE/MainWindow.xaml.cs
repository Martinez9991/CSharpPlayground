﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
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
using System.Threading;

namespace WPFTasksE
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static readonly DependencyProperty HtmlProperty = DependencyProperty.RegisterAttached(
            "Html",
            typeof(string),
            typeof(MainWindow),
            new FrameworkPropertyMetadata(OnHtmlChanged));

        public MainWindow()
        {
            InitializeComponent();
        }

        //private void Mybutton_Click(object sender, RoutedEventArgs e)
        //{
        //    Task.Run(() =>
        //    {
        //        Debug.WriteLine($"Thread Nr. {Thread.CurrentThread.ManagedThreadId}");
        //        HttpClient webClient = new HttpClient();
        //        string html = webClient.GetStringAsync("https://google.com").Result;
        //        Mybutton.Dispatcher.Invoke(() =>
        //        {
        //            Debug.WriteLine($"Thread Nr. {Thread.CurrentThread.ManagedThreadId} owns myButton");
        //            Mybutton.Content = "Done";
        //        });
        //    });
        //}

        private async void Mybutton_Click(object sender, RoutedEventArgs e)
        {
            string myHtml = "text";

            Debug.WriteLine($"Thread Nr. {Thread.CurrentThread.ManagedThreadId} before await task");
            await Task.Run(async() => 
            {
                Debug.WriteLine($"Thread Nr. {Thread.CurrentThread.ManagedThreadId} during wait task");
                HttpClient webClient = new HttpClient();
                string html = webClient.GetStringAsync("https://google.com").Result;
                myHtml = html;
            });
            Debug.WriteLine($"Thread Nr. {Thread.CurrentThread.ManagedThreadId} after wait task");
            Mybutton.Content = "Done Downloading";
            MyWebBrowser.SetValue(HtmlProperty, myHtml);
        }

        static void OnHtmlChanged(DependencyObject dependencyObject, DependencyPropertyChangedEventArgs e)
        {
            WebBrowser webBrowser = dependencyObject as WebBrowser;
            if (webBrowser != null) 
            {
                webBrowser.NavigateToString(e.NewValue as string);
            }
        }
    }
}