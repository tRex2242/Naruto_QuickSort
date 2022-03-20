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
                    new ListItem(Properties.Resources.n, "Наруто"),
                    new ListItem(Properties.Resources.b, "Боруто"),
                    new ListItem(Properties.Resources.m, "Минато"),
                    new ListItem(Properties.Resources.f, "Фугаку"),
                    new ListItem(Properties.Resources.i, "Итачи"),
                    new ListItem(Properties.Resources.s, "Саске"),
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
            is_sorted = false;
            binary_search_actions(false);
            set_default_colors();
        }

        List<int> get_indexies()
        {
            List<int> indexies = new List<int>();
            for(int i = 0;i < elements.Count; i++)
            {
                indexies.Add(i);
            }
            return indexies;
        }

        private void btnMixed_Click(object sender, EventArgs e)
        {
            List<int> free_indexies = get_indexies();
            Random random = new Random();
            for(int i = 0; i <form_elements.Count; i++)
            {
                int index = random.Next(0, free_indexies.Count);
                int elem_index = free_indexies[index];
                form_elements[i].PictureBox.Image = elements[elem_index].Image;
                form_elements[i].TextBox.Text = elements[elem_index].Name;
                free_indexies.RemoveAt(index);
            }
            is_sorted = false;
            binary_search_actions(false);
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            QuickSort.quick_sort(elements);
            is_sorted = true;
            binary_search_actions(true);
            show_elements();
        }

        void set_default_colors()
        {
            for(int i = 0; i < form_elements.Count; i++)
            {
                form_elements[i].TextBox.BackColor = Color.White;
            }
        }
        void binary_search_actions(bool value)
        {
            btnBinSearch.Enabled = value;
            tbBinarySearch.ReadOnly = !value;
            tbBinarySearch.Text = "";
        }

        void binary_search(string key)
        {
            int index = BinSearch.binary_seach(elements, key);
            if(index != -1)
            {
                form_elements[index].TextBox.BackColor = Color.Yellow;
            }
            else
            {
                MessageBox.Show("Элемент не найден!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBinSearch_Click(object sender, EventArgs e)
        {
            if (is_sorted)
            {
                set_default_colors();
                binary_search(tbBinarySearch.Text);
            }
        }
    }

}
