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


// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace seuWinDock
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class LoadList : Page
    {
        private List<ActiveWorkOrder> ActiveLoads;
        public LoadList()
        {
            this.InitializeComponent();
            ActiveLoads= ActiveWorkOrder.GetLoads();
        }

        private void GridView_ItemClick(object sender, ItemClickEventArgs e)
        {
            var wo = (ActiveWorkOrder)e.ClickedItem;
            txtresult.Text = "You Selected " + wo.PurchaseOrder;

        }
    }
}

