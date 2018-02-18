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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace seuWinDock
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Settings : Page
    {
        public Settings()
        {
            this.InitializeComponent();
        }

        private void LocationComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selectedTag = ((ComboBoxItem)LocationComboBox.SelectedItem).Tag.ToString();
            var LocaID = LocationComboBox.SelectedValue;
            var LocaName = ((ComboBoxItem)LocationComboBox.SelectedItem).Content.ToString();
            string locaid = LocaID.ToString();
            Guid loadId = new Guid(locaid);

        }

        private void btnDownloadLocations_Click(object sender, RoutedEventArgs e)
        {
            LocaProgressRing.IsActive = true;
           SnapshotProgressRing.IsActive = false;
        }

        private void btnDownloadSnapshot_Click(object sender, RoutedEventArgs e)
        {
            LocaProgressRing.IsActive = false;
            SnapshotProgressRing.IsActive = true;

        }
    }
}
