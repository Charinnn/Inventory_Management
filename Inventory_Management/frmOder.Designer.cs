namespace Inventory_Management
{
    partial class frmOder
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
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            button4 = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            btnExit = new Button();
            dataGridView1 = new DataGridView();
            no = new DataGridViewTextBoxColumn();
            cus_id = new DataGridViewTextBoxColumn();
            cus_name = new DataGridViewTextBoxColumn();
            order_no = new DataGridViewTextBoxColumn();
            list_order = new DataGridViewTextBoxColumn();
            qty_order = new DataGridViewTextBoxColumn();
            panel5 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 0, 192);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1143, 55);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(1141, 53);
            label1.TabIndex = 0;
            label1.Text = "แสดงข้อมูลการสั่งซื้อสินค้า";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 662);
            panel2.Name = "panel2";
            panel2.Size = new Size(1143, 74);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(button4);
            panel3.Controls.Add(btnEdit);
            panel3.Controls.Add(btnDelete);
            panel3.Controls.Add(btnExit);
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(405, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(736, 72);
            panel3.TabIndex = 0;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.Highlight;
            button4.FlatStyle = FlatStyle.Popup;
            button4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = Color.Transparent;
            button4.Location = new Point(8, 19);
            button4.Name = "button4";
            button4.Size = new Size(218, 37);
            button4.TabIndex = 0;
            button4.Text = "เพิ่มข้อมูลการสั่งซื้อสินค้า";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = SystemColors.Highlight;
            btnEdit.FlatStyle = FlatStyle.Popup;
            btnEdit.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnEdit.ForeColor = Color.White;
            btnEdit.Location = new Point(227, 19);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(194, 37);
            btnEdit.TabIndex = 0;
            btnEdit.Text = "แก้ไขข้อมูล";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = SystemColors.Highlight;
            btnDelete.FlatStyle = FlatStyle.Popup;
            btnDelete.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(422, 19);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(184, 37);
            btnDelete.TabIndex = 0;
            btnDelete.Text = "ลบข้อมูลทั้งบิล";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Firebrick;
            btnExit.FlatStyle = FlatStyle.Popup;
            btnExit.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnExit.ForeColor = Color.White;
            btnExit.Location = new Point(607, 19);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(110, 37);
            btnExit.TabIndex = 0;
            btnExit.Text = "ออก";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(255, 224, 192);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { no, cus_id, cus_name, order_no, list_order, qty_order });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 27;
            dataGridView1.Size = new Size(1141, 605);
            dataGridView1.TabIndex = 0;
            // 
            // no
            // 
            no.HeaderText = "ลำดับ";
            no.Name = "no";
            // 
            // cus_id
            // 
            cus_id.HeaderText = "รหัสลูกค้า";
            cus_id.Name = "cus_id";
            // 
            // cus_name
            // 
            cus_name.HeaderText = "ชื่อลูกค้า";
            cus_name.Name = "cus_name";
            // 
            // order_no
            // 
            order_no.HeaderText = "Order No";
            order_no.Name = "order_no";
            // 
            // list_order
            // 
            list_order.HeaderText = "จำนวนรายการที่สั่ง";
            list_order.Name = "list_order";
            // 
            // qty_order
            // 
            qty_order.HeaderText = "จำนวนที่สั่ง";
            qty_order.Name = "qty_order";
            // 
            // panel5
            // 
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(dataGridView1);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(0, 55);
            panel5.Name = "panel5";
            panel5.Size = new Size(1143, 607);
            panel5.TabIndex = 3;
            // 
            // frmOder
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 736);
            Controls.Add(panel5);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmOder";
            Text = "frmOder";
            WindowState = FormWindowState.Maximized;
            Load += frmOder_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel5.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Panel panel3;
        private Button btnExit;
        private Button button4;
        private Button btnEdit;
        private Button btnDelete;
        private DataGridView dataGridView1;
        private Panel panel5;
        private DataGridViewTextBoxColumn no;
        private DataGridViewTextBoxColumn cus_id;
        private DataGridViewTextBoxColumn cus_name;
        private DataGridViewTextBoxColumn order_no;
        private DataGridViewTextBoxColumn list_order;
        private DataGridViewTextBoxColumn qty_order;
    }
}