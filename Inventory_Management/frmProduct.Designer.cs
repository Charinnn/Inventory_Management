namespace Inventory_Management
{
    partial class frmProduct
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            btnSave = new Button();
            txtPrice = new TextBox();
            txtGood_name = new TextBox();
            txtGood_id = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel3 = new Panel();
            panel4 = new Panel();
            btnExit = new Button();
            panel5 = new Panel();
            dataGridView1 = new DataGridView();
            no = new DataGridViewTextBoxColumn();
            goods_id = new DataGridViewTextBoxColumn();
            goods_name = new DataGridViewTextBoxColumn();
            price = new DataGridViewTextBoxColumn();
            edit = new DataGridViewTextBoxColumn();
            delete = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 0, 192);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1177, 49);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(1177, 49);
            label1.TabIndex = 0;
            label1.Text = "การบันทึก/แก้ไข ข้อมูลสินค้า";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(btnSave);
            panel2.Controls.Add(txtPrice);
            panel2.Controls.Add(txtGood_name);
            panel2.Controls.Add(txtGood_id);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 49);
            panel2.Name = "panel2";
            panel2.Size = new Size(1177, 128);
            panel2.TabIndex = 1;
            // 
            // btnSave
            // 
            btnSave.BackColor = SystemColors.MenuHighlight;
            btnSave.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(789, 58);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(96, 29);
            btnSave.TabIndex = 5;
            btnSave.Text = "บันทึก";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // txtPrice
            // 
            txtPrice.BorderStyle = BorderStyle.FixedSingle;
            txtPrice.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPrice.Location = new Point(630, 58);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(137, 29);
            txtPrice.TabIndex = 4;
            // 
            // txtGood_name
            // 
            txtGood_name.BorderStyle = BorderStyle.FixedSingle;
            txtGood_name.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtGood_name.Location = new Point(376, 58);
            txtGood_name.Name = "txtGood_name";
            txtGood_name.Size = new Size(175, 29);
            txtGood_name.TabIndex = 3;
            // 
            // txtGood_id
            // 
            txtGood_id.BorderStyle = BorderStyle.FixedSingle;
            txtGood_id.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtGood_id.Location = new Point(96, 58);
            txtGood_id.Name = "txtGood_id";
            txtGood_id.Size = new Size(175, 29);
            txtGood_id.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(584, 60);
            label5.Name = "label5";
            label5.Size = new Size(40, 21);
            label5.TabIndex = 1;
            label5.Text = "ราคา";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(307, 60);
            label4.Name = "label4";
            label4.Size = new Size(63, 21);
            label4.TabIndex = 1;
            label4.Text = "ชื่อสินค้า";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(20, 58);
            label3.Name = "label3";
            label3.Size = new Size(70, 21);
            label3.TabIndex = 1;
            label3.Text = "รหัสสินค้า";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(20, 11);
            label2.Name = "label2";
            label2.Size = new Size(143, 25);
            label2.TabIndex = 0;
            label2.Text = "เพิ่มข้อมูลสินค้า";
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(panel4);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 635);
            panel3.Name = "panel3";
            panel3.Size = new Size(1177, 68);
            panel3.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.Controls.Add(btnExit);
            panel4.Dock = DockStyle.Right;
            panel4.Location = new Point(936, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(239, 66);
            panel4.TabIndex = 0;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Firebrick;
            btnExit.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnExit.ForeColor = Color.White;
            btnExit.Location = new Point(46, 12);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(124, 44);
            btnExit.TabIndex = 0;
            btnExit.Text = "ออก";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(dataGridView1);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(0, 177);
            panel5.Name = "panel5";
            panel5.Size = new Size(1177, 458);
            panel5.TabIndex = 3;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.Navy;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { no, goods_id, goods_name, price, edit, delete });
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.White;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle5;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.GridColor = Color.White;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Control;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 27;
            dataGridView1.Size = new Size(1175, 456);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellMouseClick += dataGridView1_CellMouseClick;
            // 
            // no
            // 
            no.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.ForeColor = Color.Black;
            no.DefaultCellStyle = dataGridViewCellStyle2;
            no.HeaderText = "ลำดับ";
            no.Name = "no";
            no.Width = 69;
            // 
            // goods_id
            // 
            goods_id.HeaderText = "รหัสสินค้า";
            goods_id.Name = "goods_id";
            // 
            // goods_name
            // 
            goods_name.HeaderText = "ชื่อสินค้า";
            goods_name.Name = "goods_name";
            // 
            // price
            // 
            price.HeaderText = "ราคา";
            price.Name = "price";
            // 
            // edit
            // 
            edit.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(0, 192, 0);
            dataGridViewCellStyle3.ForeColor = Color.White;
            edit.DefaultCellStyle = dataGridViewCellStyle3;
            edit.HeaderText = "แก้ไข";
            edit.Name = "edit";
            edit.Width = 68;
            // 
            // delete
            // 
            delete.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle4.BackColor = Color.Red;
            dataGridViewCellStyle4.ForeColor = Color.White;
            delete.DefaultCellStyle = dataGridViewCellStyle4;
            delete.HeaderText = "ลบ";
            delete.Name = "delete";
            delete.Width = 53;
            // 
            // frmProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1177, 703);
            Controls.Add(panel5);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmProduct";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmProduct";
            Load += frmProduct_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Button btnExit;
        private Panel panel5;
        private DataGridView dataGridView1;
        private Label label2;
        private Button btnSave;
        private TextBox txtPrice;
        private TextBox txtGood_name;
        private TextBox txtGood_id;
        private Label label5;
        private Label label4;
        private Label label3;
        private DataGridViewTextBoxColumn no;
        private DataGridViewTextBoxColumn goods_id;
        private DataGridViewTextBoxColumn goods_name;
        private DataGridViewTextBoxColumn price;
        private DataGridViewTextBoxColumn edit;
        private DataGridViewTextBoxColumn delete;
    }
}