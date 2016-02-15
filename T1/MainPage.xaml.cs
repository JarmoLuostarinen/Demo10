using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace T1
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            item_textBlock.Text = "";
        
            if ((bool)checkBox_chicken IsChecked)
             {
                    item_textBlock.Text = "Milk";
                }

        else
        private void checkBox_chicken_Checked(object sender, RoutedEventArgs e)
        {

        }
        private void checkBox_beer_Checked(object sender, RoutedEventArgs e)
        {

        }
        private void checkBox_Lemon_Checked(object sender, RoutedEventArgs e)
        {

        }
        private void checkBox_egs_Checked(object sender, RoutedEventArgs e)
        {

        }
    }
    }
    
