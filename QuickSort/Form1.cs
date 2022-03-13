using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuickSort
{
    public partial class Form1 : Form
    {
        List<ListItem> elements;
        List<FormListItem> form_elements;
        bool is_sorted;
        public Form1()
        {
            InitializeComponent();

            init_form();
        }
        void init_elemets()
        {
            elements = new List<ListItem>()
                {
                    new ListItem(Properties.Resources.n, "Uzumaki Naruto"),
                    new ListItem(Properties.Resources.b, "Uzumaki Boruto"),
                    new ListItem(Properties.Resources.m, "Namikadze Minato"),
                    new ListItem(Properties.Resources.f, "Uchiha Fukaku"),
                    new ListItem(Properties.Resources.i, "Uchiha Itachi"),
                    new ListItem(Properties.Resources.s, "Uchiha Saske"),
                };
        }

        void init_form_elements()
        {
            form_elements = new List<FormListItem>()
                {
                   new FormListItem(pbArray1, tbArray1),
                   new FormListItem(pbArray2, tbArray2),
                   new FormListItem(pbArray3, tbArray3),
                   new FormListItem(pbArray4, tbArray4),
                   new FormListItem(pbArray5, tbArray5),
                   new FormListItem(pbArray6, tbArray6),
                };
        }

        void show_elements()
        {
            for(int i = 0; i < elements.Count; i++)
            {
                form_elements[i].PictureBox.Image = elements[i].Image;
                form_elements[i].TextBox.Text = elements[i].Name;
            }
        }

        void init_form()
        {
            init_elemets();
            init_form_elements();
            show_elements();
        }
    }

}
