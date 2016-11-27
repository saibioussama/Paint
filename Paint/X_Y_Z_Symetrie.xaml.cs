using Paint.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
using Windows.UI;
using Windows.UI.Core;
using Windows.UI.Input.Inking;
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
    public sealed partial class X_Y_Z_Symetrie : Page
    {
        InkDrawingAttributes attr = new InkDrawingAttributes();
        bool v = true;
        bool v2 = true;
       
        public X_Y_Z_Symetrie()
        {
            this.InitializeComponent();
            InkCanvas1.InkPresenter.InputDeviceTypes = CoreInputDeviceTypes.Mouse | CoreInputDeviceTypes.Touch| CoreInputDeviceTypes.Pen;
            InkCanvas2.InkPresenter.InputDeviceTypes = CoreInputDeviceTypes.Mouse | CoreInputDeviceTypes.Touch| CoreInputDeviceTypes.Pen;
            InkCanvas3.InkPresenter.InputDeviceTypes = CoreInputDeviceTypes.Mouse | CoreInputDeviceTypes.Touch| CoreInputDeviceTypes.Pen;
            InkCanvas4.InkPresenter.InputDeviceTypes = CoreInputDeviceTypes.Mouse | CoreInputDeviceTypes.Touch| CoreInputDeviceTypes.Pen;
            InkCanvas5.InkPresenter.InputDeviceTypes = CoreInputDeviceTypes.Mouse | CoreInputDeviceTypes.Touch| CoreInputDeviceTypes.Pen;
            InkCanvas6.InkPresenter.InputDeviceTypes = CoreInputDeviceTypes.Mouse | CoreInputDeviceTypes.Touch| CoreInputDeviceTypes.Pen;
            InkCanvas7.InkPresenter.InputDeviceTypes = CoreInputDeviceTypes.Mouse | CoreInputDeviceTypes.Touch| CoreInputDeviceTypes.Pen;
            InkCanvas8.InkPresenter.InputDeviceTypes = CoreInputDeviceTypes.Mouse | CoreInputDeviceTypes.Touch | CoreInputDeviceTypes.Pen;

            InkCanvas2.InkPresenter.StrokeContainer = InkCanvas1.InkPresenter.StrokeContainer;
            InkCanvas3.InkPresenter.StrokeContainer = InkCanvas1.InkPresenter.StrokeContainer;
            InkCanvas4.InkPresenter.StrokeContainer = InkCanvas1.InkPresenter.StrokeContainer;
            InkCanvas5.InkPresenter.StrokeContainer = InkCanvas1.InkPresenter.StrokeContainer;
            InkCanvas6.InkPresenter.StrokeContainer = InkCanvas1.InkPresenter.StrokeContainer;
            InkCanvas7.InkPresenter.StrokeContainer = InkCanvas1.InkPresenter.StrokeContainer;
            InkCanvas8.InkPresenter.StrokeContainer = InkCanvas1.InkPresenter.StrokeContainer;
            IntiInk();
            UpdateInkPresenter();
            SetBackground();
            
        }

        private void IntiInk()
        {
            try
            {
                int a = Convert.ToInt16(ApplicationData.Current.RoamingSettings.Values["Background"].ToString());
                if (a == 5 || a == 10 || a == 1 || a == 3 || a == 11 || a == 0)
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
            Grid2.Background = c;
            Grid3.Background = c;
            Grid4.Background = c;
        }
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
                InkCanvas1.InkPresenter.InputProcessingConfiguration.Mode = InkInputProcessingMode.Erasing;
                InkCanvas2.InkPresenter.InputProcessingConfiguration.Mode = InkInputProcessingMode.Erasing;
                InkCanvas3.InkPresenter.InputProcessingConfiguration.Mode = InkInputProcessingMode.Erasing;
                InkCanvas4.InkPresenter.InputProcessingConfiguration.Mode = InkInputProcessingMode.Erasing;
                InkCanvas5.InkPresenter.InputProcessingConfiguration.Mode = InkInputProcessingMode.Erasing;
                InkCanvas6.InkPresenter.InputProcessingConfiguration.Mode = InkInputProcessingMode.Erasing;
                InkCanvas7.InkPresenter.InputProcessingConfiguration.Mode = InkInputProcessingMode.Erasing;
                InkCanvas8.InkPresenter.InputProcessingConfiguration.Mode = InkInputProcessingMode.Erasing;
                v2 = !v2;
                RestartButton.Content = "";
            }
            else
            {
                InkCanvas1.InkPresenter.InputProcessingConfiguration.Mode = InkInputProcessingMode.Inking;
                InkCanvas2.InkPresenter.InputProcessingConfiguration.Mode = InkInputProcessingMode.Inking;
                InkCanvas3.InkPresenter.InputProcessingConfiguration.Mode = InkInputProcessingMode.Inking;
                InkCanvas4.InkPresenter.InputProcessingConfiguration.Mode = InkInputProcessingMode.Inking;
                InkCanvas5.InkPresenter.InputProcessingConfiguration.Mode = InkInputProcessingMode.Inking;
                InkCanvas6.InkPresenter.InputProcessingConfiguration.Mode = InkInputProcessingMode.Inking;
                InkCanvas7.InkPresenter.InputProcessingConfiguration.Mode = InkInputProcessingMode.Inking;
                InkCanvas8.InkPresenter.InputProcessingConfiguration.Mode = InkInputProcessingMode.Inking;
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
            InkCanvas2.InkPresenter.UpdateDefaultDrawingAttributes(attr);
            InkCanvas3.InkPresenter.UpdateDefaultDrawingAttributes(attr);
            InkCanvas4.InkPresenter.UpdateDefaultDrawingAttributes(attr);
            InkCanvas5.InkPresenter.UpdateDefaultDrawingAttributes(attr);
            InkCanvas6.InkPresenter.UpdateDefaultDrawingAttributes(attr);
            InkCanvas7.InkPresenter.UpdateDefaultDrawingAttributes(attr);
            InkCanvas8.InkPresenter.UpdateDefaultDrawingAttributes(attr);
        }

        private void HideBorder_Click(object sender, RoutedEventArgs e)
        {
            if (v)
            {
                v = !v;
                 
                Rect1.Visibility = Visibility.Collapsed;
                Rect2.Visibility = Visibility.Collapsed;
                Rect3.Visibility = Visibility.Collapsed;
                Rect4.Visibility = Visibility.Collapsed;
                HideBorder.Content = "";
            }
            else
            {
                v = !v;
                Rect3.Visibility = Visibility.Visible;
                Rect4.Visibility = Visibility.Visible;
                Rect1.Visibility = Visibility.Visible;
                Rect2.Visibility = Visibility.Visible;
                HideBorder.Content = "";
            }
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            ObservableCollection<ToolBarColor> ListOfColor = new ObservableCollection<ToolBarColor>(ToolBarColor.AllColor());
            MyGridView.ItemsSource = ListOfColor;
        }
    }
}
