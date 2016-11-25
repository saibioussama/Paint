using System;
using System.Collections.Generic;
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
            
            
        }

        private void MyGridView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch(MyGridView.SelectedIndex)
            {
                case 0 : ApplicationData.Current.RoamingSettings.Values["Background"] = "0"; break;
                case 1 : ApplicationData.Current.RoamingSettings.Values["Background"] = "1"; break;
                case 2 : ApplicationData.Current.RoamingSettings.Values["Background"] = "2"; break;
                case 3 : ApplicationData.Current.RoamingSettings.Values["Background"] = "3"; break;
                case 4 : ApplicationData.Current.RoamingSettings.Values["Background"] = "4"; break;
                case 5 : ApplicationData.Current.RoamingSettings.Values["Background"] = "5"; break;
                case 6 : ApplicationData.Current.RoamingSettings.Values["Background"] = "6"; break;
                case 7 : ApplicationData.Current.RoamingSettings.Values["Background"] = "7"; break;
                case 8 : ApplicationData.Current.RoamingSettings.Values["Background"] = "8"; break;
                case 9 : ApplicationData.Current.RoamingSettings.Values["Background"] = "9"; break;
                case 10: ApplicationData.Current.RoamingSettings.Values["Background"] = "10"; break;
                case 11: ApplicationData.Current.RoamingSettings.Values["Background"] = "11"; break;
                case 12: ApplicationData.Current.RoamingSettings.Values["Background"] = "12"; break;
                case 13: ApplicationData.Current.RoamingSettings.Values["Background"] = "13"; break;
                case 14: ApplicationData.Current.RoamingSettings.Values["Background"] = "14"; break;
                case 15: ApplicationData.Current.RoamingSettings.Values["Background"] = "15"; break;
                case 16: ApplicationData.Current.RoamingSettings.Values["Background"] = "16"; break;

                default: break;
            }
           
        }

        

        
    }
}
