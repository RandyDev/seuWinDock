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
using seuWinDock.Models;
using seuWinDock.BL;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace seuWinDock
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class TimeClock : Page
    {

        private List<Unloader> empList;
        public TimeClock()
        {
            this.InitializeComponent();
            empList = Employees.GetEmployees();
            perspic.Visibility = Visibility.Collapsed;
        }

        private void ListView_ItemClick(object sender, ItemClickEventArgs e)
        {
            var emp = (Unloader)e.ClickedItem;
            txtresult.Text = "You Selected " + emp.EmployeeName + " : " + emp.EmployeeID ;
            perspic.Visibility = Visibility.Visible;
        }
    }
}
