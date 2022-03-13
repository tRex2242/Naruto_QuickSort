using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort
{
    class FormListItem
    {
        private PictureBox pb;
        private TextBox tb;

        public PictureBox PictureBox
        {
            get
            {
                return pb;
            }
        }
        public TextBox TextBox
        {
            get
            {
                return tb;
            }
        }

        public FormListItem(PictureBox pb, TextBox tb)
        {
            this.tb = tb;
            this.pb = pb;
        }
    }
}
