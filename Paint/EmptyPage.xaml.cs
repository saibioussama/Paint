using Paint.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text.RegularExpressions;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Media.Capture;
using Windows.Storage;
using Windows.Storage.Pickers;
using Windows.Storage.Streams;
using Windows.UI;
using Windows.UI.Core;
using Windows.UI.Input.Inking;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Paint
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class EmptyPage : Page
    {
        InkDrawingAttributes attr = new InkDrawingAttributes();
        bool v2 = true;
        public EmptyPage()
        {
            this.InitializeComponent();            
            InkCanvas1.InkPresenter.InputDeviceTypes = CoreInputDeviceTypes.Mouse | CoreInputDeviceTypes.Touch | CoreInputDeviceTypes.Pen;
            IntiInk();
            UpdateInkPresenter();
            SetBackground();
             
        }
        
        private void IntiInk()
        {
            try
            {
                int a = Convert.ToInt16(ApplicationData.Current.RoamingSettings.Values["Background"].ToString());
                if (a == 5 || a == 10 || a == 1 || a== 3 || a== 11  || a== 0) 
                    attr.Color = Colors.White;
                else
                    attr.Color = Colors.Black;
            }
            catch
            {
                attr.Color = Colors.Black;
            }

            attr.IgnorePressure = true;
            attr.PenTip = PenTipShape.Circle;
            attr.Size = new Size(4, 10);
            attr.PenTipTransform = Matrix3x2.CreateRotation((float)(70 * Math.PI / 180));
        }

        private void SetBackground()
        {
            SolidColorBrush c = new SolidColorBrush();
            c = BackgroundColor.GetBackground();            
            Grid1.Background = c;
        }
        //private async void save()
        //{
        //    if (InkCanvas1.InkPresenter.StrokeContainer.GetStrokes().Count > 0)
        //    {
        //        var savePicker = new Windows.Storage.Pickers.FileSavePicker();
        //        savePicker.SuggestedStartLocation = Windows.Storage.Pickers.PickerLocationId.PicturesLibrary;
        //        savePicker.FileTypeChoices.Add("PNG", new System.Collections.Generic.List<string> { ".png" });

        //        Windows.Storage.StorageFile file = await savePicker.PickSaveFileAsync();
        //        if (null != file)
        //        {
        //            try
        //            {
        //                using (IRandomAccessStream stream = await file.OpenAsync(FileAccessMode.ReadWrite))
        //                {
        //                    await InkCanvas1.InkPresenter.StrokeContainer.SaveAsync(stream);
        //                }
        //            }
        //            catch (Exception ex)
        //            {
        //                MessageDialog mbox = new MessageDialog("error");
        //                await mbox.ShowAsync();
        //            }
        //        }
        //    }
        //}
        private void MyGridView_ItemClick(object sender, ItemClickEventArgs e)
        {
            var color = e.ClickedItem as ToolBarColor;
            attr.Color = ToolBarColor.GetColor(color.Id);
            UpdateInkPresenter();
        }
        
        private void RestartButton_Click(object sender, RoutedEventArgs e)
        {
            if (v2)
            {
                InkCanvas1.InkPresenter.InputProcessingConfiguration.Mode = Windows.UI.Input.Inking.InkInputProcessingMode.Erasing;
                v2 = !v2;
                RestartButton.Content = "";
            }
            else
            {
                InkCanvas1.InkPresenter.InputProcessingConfiguration.Mode = InkInputProcessingMode.Inking;
                v2 = !v2;
                RestartButton.Content = "";
            }
        }

        private void SmallPen_Click(object sender, RoutedEventArgs e)
        {
            attr.PenTip = PenTipShape.Circle;
            attr.Size = new Size(2, 2);
            UpdateInkPresenter();
        }

        private void BigPen_Click(object sender, RoutedEventArgs e)
        {
            attr.IgnorePressure = true;
            attr.PenTip = PenTipShape.Circle;
            attr.Size = new Size(4, 10);
            attr.PenTipTransform = Matrix3x2.CreateRotation((float)(70 * Math.PI / 180));
            UpdateInkPresenter();
        }

        void UpdateInkPresenter()
        {
            InkCanvas1.InkPresenter.UpdateDefaultDrawingAttributes(attr);             
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            ObservableCollection<ToolBarColor> ListOfColor = new ObservableCollection<ToolBarColor>(ToolBarColor.AllColor());
            MyGridView.ItemsSource = ListOfColor;
        }
    }
}
