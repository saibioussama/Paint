using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
using Windows.UI.Core;
using Windows.UI.ViewManagement;
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
    public sealed partial class SplitViewPage : Page
    {
        public SplitViewPage()
        {
            this.InitializeComponent();
            ApplicationView.GetForCurrentView().SetPreferredMinSize(new Size { Height = 720, Width = 1280 });
            MyFrame.Navigate(typeof(StartPage));
            if (ApplicationData.Current.RoamingSettings.Values["Background"] == null)
                ApplicationData.Current.RoamingSettings.Values["Background"] = "";
            if (ApplicationData.Current.RoamingSettings.Values["Theme"] == null)
                ApplicationData.Current.RoamingSettings.Values["Theme"] = "";
        }


        #region BackNavigation
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            SystemNavigationManager.GetForCurrentView().BackRequested += App_BackRequested;

            MyFrame.Navigated += (s, a) =>
            {
                if (MyFrame.CanGoBack)
                {
                    SystemNavigationManager.GetForCurrentView().AppViewBackButtonVisibility = AppViewBackButtonVisibility.Visible;
                }
                else
                {
                    SystemNavigationManager.GetForCurrentView().AppViewBackButtonVisibility = AppViewBackButtonVisibility.Collapsed;
                }
            };
        }

        public event EventHandler<BackRequestedEventArgs> OnBackRequested;
        private void App_BackRequested(object sender, BackRequestedEventArgs e)
        {
            if (OnBackRequested != null) { OnBackRequested(this, e); }

            if (!e.Handled)
            {
                //MyFrame = Window.Current.Content as Frame;
                if (MyFrame.CanGoBack)
                {
                    MyFrame.GoBack();
                    e.Handled = true;
                }
            }
        }
        #endregion
        private void HamburgerButton_Click(object sender, RoutedEventArgs e)
        {
            MySplitView.IsPaneOpen = !MySplitView.IsPaneOpen;
        }

        
        private void MyListView2_Tapped(object sender, TappedRoutedEventArgs e)
        {
            MyFrame.Navigate(typeof(AboutPage));
            //HamburgerTextBlock.Text = "About";
            MySplitView.IsPaneOpen = false;
        }

        private void ListBoxItem_Tapped(object sender, TappedRoutedEventArgs e)
        {
            MyFrame.Navigate(typeof(StartPage));
            //HamburgerTextBlock.Text = "Home";
            MySplitView.IsPaneOpen = false;
        }

        private void ListBoxItem_Tapped_1(object sender, TappedRoutedEventArgs e)
        {
            MyFrame.Navigate(typeof(SettingPage));
            //HamburgerTextBlock.Text = "Setting";
            MySplitView.IsPaneOpen = false; 
        }

        private async void Page_Loaded(object sender, RoutedEventArgs e)
        {
            if(Windows.Foundation.Metadata.ApiInformation.IsTypePresent("Windows.UI.ViewManagement.StatusBar"))
            await Windows.UI.ViewManagement.StatusBar.GetForCurrentView().HideAsync();
        }
    }
}
