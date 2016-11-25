using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;
using Windows.UI;
using Windows.UI.Xaml.Media;

namespace Paint.Models
{
    class BackgroundColor
    {
        public int Id { get; set; }
        public string NameColor { get; set; }

        static public ObservableCollection<BackgroundColor> AllColor()
        {
            ObservableCollection<BackgroundColor> ListOfColor = new ObservableCollection<BackgroundColor>();

            ListOfColor.Add(new BackgroundColor {Id=0,NameColor="DarkRed" });
            ListOfColor.Add(new BackgroundColor { Id = 1, NameColor = "DarkBlue" });
            ListOfColor.Add(new BackgroundColor { Id = 2, NameColor = "DarkGray" });
            ListOfColor.Add(new BackgroundColor { Id = 3, NameColor = "DarkGreen" });
            ListOfColor.Add(new BackgroundColor { Id = 4, NameColor = "White" });
            ListOfColor.Add(new BackgroundColor { Id = 5, NameColor = "Black" });
            ListOfColor.Add(new BackgroundColor { Id = 6, NameColor = "Yellow" });
            ListOfColor.Add(new BackgroundColor { Id = 7, NameColor = "GreenYellow" });
            ListOfColor.Add(new BackgroundColor { Id = 8, NameColor = "DeepSkyBlue" });
            ListOfColor.Add(new BackgroundColor { Id = 9, NameColor = "DeepPink" });
            ListOfColor.Add(new BackgroundColor { Id = 10, NameColor = "Blue" });
            ListOfColor.Add(new BackgroundColor { Id = 11, NameColor = "Red" });
            ListOfColor.Add(new BackgroundColor { Id = 12, NameColor = "AliceBlue" });
            ListOfColor.Add(new BackgroundColor { Id = 13, NameColor = "Coral" });
            ListOfColor.Add(new BackgroundColor { Id = 14, NameColor = "Violet" });
            ListOfColor.Add(new BackgroundColor { Id = 15, NameColor = "YellowGreen" });
            ListOfColor.Add(new BackgroundColor { Id = 16, NameColor = "WhiteSmoke" });

            return ListOfColor;
        } 

        static public void SetBackground(int x)
        {
            switch (x)
            {
                case 0: ApplicationData.Current.RoamingSettings.Values["Background"] = "0"; break;
                case 1: ApplicationData.Current.RoamingSettings.Values["Background"] = "1"; break;
                case 2: ApplicationData.Current.RoamingSettings.Values["Background"] = "2"; break;
                case 3: ApplicationData.Current.RoamingSettings.Values["Background"] = "3"; break;
                case 4: ApplicationData.Current.RoamingSettings.Values["Background"] = "4"; break;
                case 5: ApplicationData.Current.RoamingSettings.Values["Background"] = "5"; break;
                case 6: ApplicationData.Current.RoamingSettings.Values["Background"] = "6"; break;
                case 7: ApplicationData.Current.RoamingSettings.Values["Background"] = "7"; break;
                case 8: ApplicationData.Current.RoamingSettings.Values["Background"] = "8"; break;
                case 9: ApplicationData.Current.RoamingSettings.Values["Background"] = "9"; break;
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

        static public SolidColorBrush GetBackground(int x)
        {
            SolidColorBrush c = new SolidColorBrush();
            switch (x)
            {
                case -1: c = new SolidColorBrush(Colors.White); break;
                case 0: c = new SolidColorBrush(Colors.DarkRed); break;
                case 1: c = new SolidColorBrush(Colors.DarkBlue); break;
                case 2: c = new SolidColorBrush(Colors.DarkGray); break;
                case 3: c = new SolidColorBrush(Colors.DarkGreen); break;
                case 4: c = new SolidColorBrush(Colors.White); break;
                case 5: c = new SolidColorBrush(Colors.Black); break;
                case 6: c = new SolidColorBrush(Colors.Yellow); break;
                case 7: c = new SolidColorBrush(Colors.GreenYellow); break;
                case 8: c = new SolidColorBrush(Colors.DeepSkyBlue); break;
                case 9: c = new SolidColorBrush(Colors.DeepPink); break;
                case 10: c = new SolidColorBrush(Colors.Blue); break;
                case 11: c = new SolidColorBrush(Colors.Red); break;
                case 12: c = new SolidColorBrush(Colors.AliceBlue); break;
                case 13: c = new SolidColorBrush(Colors.Coral); break;
                case 14: c = new SolidColorBrush(Colors.Violet); break;
                case 15: c = new SolidColorBrush(Colors.YellowGreen); break;
                case 16: c = new SolidColorBrush(Colors.WhiteSmoke); break;

                default: c = new SolidColorBrush(Colors.White); break;

            }
            return c;
        }
    }
}
