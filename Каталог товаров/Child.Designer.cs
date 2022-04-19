
namespace Каталог_товаров
{
    partial class Child
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
            this.bt_cancel = new System.Windows.Forms.Button();
            this.bt_OK = new System.Windows.Forms.Button();
            this.tb_cost = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_manuf = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bt_cancel);
            this.panel1.Controls.Add(this.bt_OK);
            this.panel1.Controls.Add(this.tb_cost);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.tb_manuf);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tb_name);
            this.panel1.Location = new System.Drawing.Point(87, 75);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(216, 198);
            this.panel1.TabIndex = 0;
            // 
            // bt_cancel
            // 
            this.bt_cancel.Location = new System.Drawing.Point(120, 154);
            this.bt_cancel.Name = "bt_cancel";
            this.bt_cancel.Size = new System.Drawing.Size(75, 23);
            this.bt_cancel.TabIndex = 7;
            this.bt_cancel.Text = "ОТМЕНА";
            this.bt_cancel.UseVisualStyleBackColor = true;
         //   this.bt_cancel.Click += new System.EventHandler(this.button2_Click);
            // 
            // bt_OK
            // 
            this.bt_OK.Location = new System.Drawing.Point(28, 154);
            this.bt_OK.Name = "bt_OK";
            this.bt_OK.Size = new System.Drawing.Size(75, 23);
            this.bt_OK.TabIndex = 6;
            this.bt_OK.Text = "ОК";
            this.bt_OK.UseVisualStyleBackColor = true;
            this.bt_OK.Click += new System.EventHandler(this.bt_OK_Click);
            // 
            // tb_cost
            // 
            this.tb_cost.Location = new System.Drawing.Point(31, 105);
            this.tb_cost.Name = "tb_cost";
            this.tb_cost.Size = new System.Drawing.Size(100, 20);
            this.tb_cost.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Стоимость";
            // 
            // tb_manuf
            // 
            this.tb_manuf.Location = new System.Drawing.Point(28, 61);
            this.tb_manuf.Name = "tb_manuf";
            this.tb_manuf.Size = new System.Drawing.Size(100, 20);
            this.tb_manuf.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Страна производитель";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Название";
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(28, 21);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(100, 20);
            this.tb_name.TabIndex = 0;
            // 
            // Child
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Child";
            this.Text = "Товар";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.Button bt_cancel;
        private System.Windows.Forms.Button bt_OK;
        private System.Windows.Forms.TextBox tb_cost;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_manuf;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}