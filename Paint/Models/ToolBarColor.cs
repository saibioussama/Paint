using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI;
using Windows.UI.Xaml.Media;

namespace Paint.Models
{
    class ToolBarColor
    {
        public int Id { get; set; }
        public string NameColor { get; set; }

        static public ObservableCollection<ToolBarColor> AllColor()
        {
            ObservableCollection<ToolBarColor> ListOfColor = new ObservableCollection<ToolBarColor>();

            ListOfColor.Add(new ToolBarColor { Id = 0, NameColor = "Red" });
            ListOfColor.Add(new ToolBarColor { Id = 1, NameColor = "Blue"  });
            ListOfColor.Add(new ToolBarColor { Id = 2, NameColor = "Green" });
            ListOfColor.Add(new ToolBarColor { Id = 3, NameColor = "Yellow" });
            ListOfColor.Add(new ToolBarColor { Id = 4, NameColor = "LightGray" });
            ListOfColor.Add(new ToolBarColor { Id = 5, NameColor = "Black" });
            ListOfColor.Add(new ToolBarColor { Id = 6, NameColor = "Gray"  });
            ListOfColor.Add(new ToolBarColor { Id = 7, NameColor = "White" });

            return ListOfColor;
        }

        static public Color GetColor(int x)
        {
            Color c = new Color();
            switch (x)
            {
                case 0:  c = Colors.Red; break;
                case 1:  c = Colors.Blue; break;
                case 2:  c = Colors.Green; break;
                case 3:  c = Colors.Yellow; break;
                case 4:  c = Colors.LightGray; break;
                case 5:  c = Colors.Black; break;
                case 6:  c = Colors.Gray; break;
                case 7:  c = Colors.White; break;
                default: c = Colors.White; break;
            }
            return c;
        }    
    }
}
