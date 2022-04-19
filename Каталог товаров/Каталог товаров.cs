using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Каталог_товаров
{
    public partial class Parent : Form
    {
        Товар t = null;
        public Parent()
        {
            InitializeComponent();
        }

        private void bt_clear_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void bt_delete_Click(object sender, EventArgs e)
        {
            //проверяем не равен ли он 
            if (listBox1.SelectedIndex == -1) MessageBox.Show("Error");
            listBox1.Items.RemoveAt(listBox1.SelectedIndex);
        }

        private void bt_add_Click(object sender, EventArgs e)
        {
            t = new Товар();
            Child addform = new Child(t, true);
            if (addform.ShowDialog() == DialogResult.OK) listBox1.Items.Add(t);
            
        }

    }
}
