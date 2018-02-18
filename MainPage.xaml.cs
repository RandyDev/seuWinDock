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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace seuWinDock
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            BackButton.Visibility = Visibility.Collapsed;
            SearchTextBox.Visibility = Visibility.Collapsed;
            SearchButton.Visibility = Visibility.Collapsed;
            //MyFrame.Navigate(typeof(MainPage));
            //TitleTextBlock.Text = "Home";
        }

        private void HamburgerButton_Click(object sender, RoutedEventArgs e)
        {
            MySplitView.IsPaneOpen = !MySplitView.IsPaneOpen;
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            if (MyFrame.CanGoBack)
            {
                MyFrame.GoBack();
            }
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (AddNewLoad.IsSelected)
            {
                SearchTextBox.Visibility = Visibility.Collapsed;
                SearchButton.Visibility = Visibility.Collapsed;
                MyFrame.Navigate(typeof(AddEditLoad));
                TitleTextBlock.Text = "Add Load";
            }
            else if (EditLoads.IsSelected)
            {
                SearchTextBox.Visibility = Visibility.Visible;
                SearchButton.Visibility = Visibility.Visible;
                MyFrame.Navigate(typeof(LoadList));
                TitleTextBlock.Text = "Edit Loads";
            }
            else if (ICE.IsSelected)
            {
                SearchTextBox.Visibility = Visibility.Collapsed;
                SearchButton.Visibility = Visibility.Collapsed;
                MyFrame.Navigate(typeof(ICE));
                TitleTextBlock.Text = "Who's Here - In Case of an Emergency";
            }
            else if (ClockIN.IsSelected)
            {
                SearchTextBox.Visibility = Visibility.Collapsed;
                SearchButton.Visibility = Visibility.Collapsed;
                MyFrame.Navigate(typeof(TimeClock));
                TitleTextBlock.Text = "Clock IN";
            }
            else if (ClockOUT.IsSelected)
            {
                SearchTextBox.Visibility = Visibility.Collapsed;
                SearchButton.Visibility = Visibility.Collapsed;
                MyFrame.Navigate(typeof(TimeClock));
                TitleTextBlock.Text = "Clock OUT";
            }
            else if (Settings.IsSelected)
            {
                SearchTextBox.Visibility = Visibility.Collapsed;
                SearchButton.Visibility = Visibility.Collapsed;
                MyFrame.Navigate(typeof(Settings));
                TitleTextBlock.Text = "Settings";
            }
        }

    }
}
