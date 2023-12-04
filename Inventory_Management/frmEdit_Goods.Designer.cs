namespace Inventory_Management
{
    partial class frmEdit_Goods
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
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            button1 = new Button();
            txtPrice = new TextBox();
            txtGoods_name = new TextBox();
            txtGoods_id = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(64, 64, 64);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(450, 52);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(0, 0, 192);
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(450, 52);
            label1.TabIndex = 0;
            label1.Text = "แก้ข้อมูลสินค้า";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(button1);
            panel2.Controls.Add(txtPrice);
            panel2.Controls.Add(txtGoods_name);
            panel2.Controls.Add(txtGoods_id);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 52);
            panel2.Name = "panel2";
            panel2.Size = new Size(450, 396);
            panel2.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Highlight;
            button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(119, 285);
            button1.Name = "button1";
            button1.Size = new Size(235, 45);
            button1.TabIndex = 4;
            button1.Text = "บันทึก";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // txtPrice
            // 
            txtPrice.BorderStyle = BorderStyle.FixedSingle;
            txtPrice.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPrice.Location = new Point(119, 222);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(235, 29);
            txtPrice.TabIndex = 3;
            // 
            // txtGoods_name
            // 
            txtGoods_name.BorderStyle = BorderStyle.FixedSingle;
            txtGoods_name.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtGoods_name.Location = new Point(119, 150);
            txtGoods_name.Name = "txtGoods_name";
            txtGoods_name.Size = new Size(235, 29);
            txtGoods_name.TabIndex = 2;
            // 
            // txtGoods_id
            // 
            txtGoods_id.BorderStyle = BorderStyle.FixedSingle;
            txtGoods_id.Enabled = false;
            txtGoods_id.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtGoods_id.Location = new Point(119, 66);
            txtGoods_id.Name = "txtGoods_id";
            txtGoods_id.Size = new Size(235, 29);
            txtGoods_id.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(119, 194);
            label4.Name = "label4";
            label4.Size = new Size(58, 25);
            label4.TabIndex = 0;
            label4.Text = "ราคา :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(119, 122);
            label3.Name = "label3";
            label3.Size = new Size(83, 25);
            label3.TabIndex = 0;
            label3.Text = "ชื่อสินค้า :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(119, 38);
            label2.Name = "label2";
            label2.Size = new Size(91, 25);
            label2.TabIndex = 0;
            label2.Text = "รหัสสินค้า :";
            // 
            // frmEdit_Goods
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(450, 448);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "frmEdit_Goods";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmEdit_Good";
            Load += frmEdit_Good_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Label label3;
        private Label label2;
        private TextBox txtPrice;
        private TextBox txtGoods_name;
        private TextBox txtGoods_id;
        private Label label4;
        private Button button1;
    }
}