
namespace Каталог_товаров
{
    partial class Parent
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.bt_clear = new System.Windows.Forms.Button();
            this.bt_delete = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.bt_add = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bt_clear);
            this.panel1.Controls.Add(this.bt_delete);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.bt_add);
            this.panel1.Controls.Add(this.listBox1);
            this.panel1.Location = new System.Drawing.Point(57, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(163, 188);
            this.panel1.TabIndex = 0;
            // 
            // bt_clear
            // 
            this.bt_clear.Location = new System.Drawing.Point(54, 145);
            this.bt_clear.Name = "bt_clear";
            this.bt_clear.Size = new System.Drawing.Size(75, 23);
            this.bt_clear.TabIndex = 4;
            this.bt_clear.Text = "Очистить список";
            this.bt_clear.UseVisualStyleBackColor = true;
            this.bt_clear.Click += new System.EventHandler(this.bt_clear_Click);
            // 
            // bt_delete
            // 
            this.bt_delete.Location = new System.Drawing.Point(54, 126);
            this.bt_delete.Name = "bt_delete";
            this.bt_delete.Size = new System.Drawing.Size(75, 23);
            this.bt_delete.TabIndex = 3;
            this.bt_delete.Text = "Удалить товар";
            this.bt_delete.UseVisualStyleBackColor = true;
            this.bt_delete.Click += new System.EventHandler(this.bt_delete_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(54, 105);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Редактировать товар";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // bt_add
            // 
            this.bt_add.Location = new System.Drawing.Point(54, 84);
            this.bt_add.Name = "bt_add";
            this.bt_add.Size = new System.Drawing.Size(75, 23);
            this.bt_add.TabIndex = 1;
            this.bt_add.Text = "Добавить товар";
            this.bt_add.UseVisualStyleBackColor = true;
            this.bt_add.Click += new System.EventHandler(this.bt_add_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(3, 0);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 56);
            this.listBox1.TabIndex = 0;
            // 
            // Parent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 322);
            this.Controls.Add(this.panel1);
            this.Name = "Parent";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bt_clear;
        private System.Windows.Forms.Button bt_delete;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button bt_add;
        private System.Windows.Forms.ListBox listBox1;
    }
}

