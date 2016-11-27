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
using Windows.UI.Popups;
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
        int v = 0;
        public SettingPage()
        {
            this.InitializeComponent();
            if(ApplicationData.Current.RoamingSettings.Values["Background"] == null)
                ApplicationData.Current.RoamingSettings.Values["Background"] = "";
            
            MyGridView.ItemsSource = BackgroundColor.AllColor();
            
            if(App.Current.RequestedTheme == ApplicationTheme.Dark)
            {
                ToggleTheme.IsOn = false;
                v++;
            }
            else
            {
                ToggleTheme.IsOn = true;
                v++;
            }
        }

        private void MyGridView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            BackgroundColor.SetBackground(MyGridView.SelectedIndex);
           
        }
 
        private void ToggleSwitch_Toggled(object sender, RoutedEventArgs e)
        {
            if(ToggleTheme.IsOn)
            {
                ApplicationData.Current.RoamingSettings.Values["Theme"] = "Light";
                
            }
            else
            {
                ApplicationData.Current.RoamingSettings.Values["Theme"] = "Dark";
                
            }
            if(v>0)
            {
                var i = new MessageDialog("Restart application to see changes !").ShowAsync();
            }
        }
        
        
    }
}
