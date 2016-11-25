using Paint.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Paint
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class SettingPage : Page
    {
        public SettingPage()
        {
            this.InitializeComponent();
            if(ApplicationData.Current.RoamingSettings.Values["Background"] == null)
                ApplicationData.Current.RoamingSettings.Values["Background"] = "";

            ObservableCollection<BackgroundColor> ListOfColor = BackgroundColor.AllColor();
            MyGridView.ItemsSource = ListOfColor;
            
        }

        private void MyGridView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            BackgroundColor.SetBackground(MyGridView.SelectedIndex);
           
        }

    }
}
