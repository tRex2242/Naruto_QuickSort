using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort
{
    class ListItem
    {
        private Image image;
        private string name;
        public Image Image
        {
            get 
            {
                return image;
            }
        }
        public string Name
        {
            get
            {
                return name;
            }
        }
        public ListItem(Image image, string name)
        {
            this.name = name;
            this.image = image;
        }
    }
}
