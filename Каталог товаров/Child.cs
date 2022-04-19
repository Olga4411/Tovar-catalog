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
    public partial class Child : Form
    {
        //создаем наш объект товар
        Товар t;
        //создадим переменную bool

        bool addnew;

        public Child(Товар _t, bool _addnew)
        {
            InitializeComponent();
            // передаем параметр
            addnew = _addnew;
            t = _t;
            //проверка
            // 
            if (addnew == false)
            {
                tb_name.Text = _t.Name;
                tb_manuf.Text = _t.Made_in;
                tb_cost.Text = _t.Price.ToString();
                //для нашего файла-занесем поля для редактирования
                Text = "Редактирование товара";
            }
            else Text = "Добавление товара";

        }

        private void bt_cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }


        private void bt_OK_Click(object sender, EventArgs e)
        {
            if (tb_name.Text == "" || tb_manuf.Text == "" || tb_cost.Text == "")
            {
                MessageBox.Show("Error");
            }
            //создаем конструктором
            if (t == null) t = new Товар();
            //передаем из текстбоксов
            t.Name = tb_name.Text;
            t.Made_in = tb_manuf.Text;

            try
            {
                t.Price = Convert.ToDouble(tb_cost.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
            DialogResult = DialogResult.OK;
        }

    } 

}

        

    
    

