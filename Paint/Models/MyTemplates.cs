using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paint.Models
{
    class MyTemplates
    {
        public int Id { get; set; }
        public string NameTemplate { get; set; }
        public string ImageSource { get; set; }

        static public ObservableCollection<MyTemplates> AllTemplate()
        {
            ObservableCollection<MyTemplates> ListOfTemplate = new ObservableCollection<MyTemplates>();

            ListOfTemplate.Add(new MyTemplates { Id = 0, NameTemplate = "Empty Page", ImageSource = "Images/EmptyPageImg.png" });
            ListOfTemplate.Add(new MyTemplates { Id = 1, NameTemplate = "Symetire_Y page", ImageSource = "Images/Y_Symetrie.png" });
            ListOfTemplate.Add(new MyTemplates { Id = 2, NameTemplate = "Symetrie_X_Y page", ImageSource = "Images/X_Y_Symetrie.png" });
            ListOfTemplate.Add(new MyTemplates { Id = 3, NameTemplate = "Symetrie_X_Y_Z page", ImageSource = "Images/X_Y_Z_Symetrie.png" });
            return ListOfTemplate;
        }
    }
}
