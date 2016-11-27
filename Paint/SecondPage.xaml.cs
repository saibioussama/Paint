using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Paint.Models;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Paint
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class SecondPage : Page
    {
        public SecondPage()
        {
            this.InitializeComponent();
            MyGridView.ItemsSource = MyTemplates.AllTemplate();           
        }
         
        private void MyGridView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch(MyGridView.SelectedIndex)
            {
                case 0:Frame.Navigate(typeof(EmptyPage));break;
                case 1:Frame.Navigate(typeof(Y_Symetrie));break;
                case 2:Frame.Navigate(typeof(MainPage));break;
                case 3: Frame.Navigate(typeof(X_Y_Z_Symetrie)); break;
                default:break;
            }
        }
    }
}
