namespace Inventory_Management
{
    partial class frmEdit_Oder
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            groupBox1 = new GroupBox();
            lb_CusNo = new Label();
            lb_OderNo = new Label();
            label8 = new Label();
            lb_Cusname = new Label();
            date_order = new DateTimePicker();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel4 = new Panel();
            panel5 = new Panel();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            panel6 = new Panel();
            lb_totalPrice = new Label();
            label18 = new Label();
            lb_TotalQty = new Label();
            label16 = new Label();
            label15 = new Label();
            panel7 = new Panel();
            dataGridView1 = new DataGridView();
            no = new DataGridViewTextBoxColumn();
            goods_no = new DataGridViewTextBoxColumn();
            good_d = new DataGridViewTextBoxColumn();
            date_due = new DataGridViewTextBoxColumn();
            date_DL = new DataGridViewTextBoxColumn();
            order_qty = new DataGridViewTextBoxColumn();
            price = new DataGridViewTextBoxColumn();
            price_total = new DataGridViewTextBoxColumn();
            id = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            groupBox1.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
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
            panel1.Size = new Size(1308, 61);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(1308, 61);
            label1.TabIndex = 0;
            label1.Text = "การบันทึก/แก้ไข การสั่งซื้อสินค้า";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(groupBox1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 61);
            panel2.Name = "panel2";
            panel2.Size = new Size(1308, 146);
            panel2.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lb_CusNo);
            groupBox1.Controls.Add(lb_OderNo);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(lb_Cusname);
            groupBox1.Controls.Add(date_order);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Enabled = false;
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1306, 144);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "สถานะ แก้ไขรายการรับคำสั่งซื้อสินค้าเดิม";
            // 
            // lb_CusNo
            // 
            lb_CusNo.BackColor = Color.FromArgb(224, 224, 224);
            lb_CusNo.Enabled = false;
            lb_CusNo.Location = new Point(105, 34);
            lb_CusNo.Name = "lb_CusNo";
            lb_CusNo.Size = new Size(186, 29);
            lb_CusNo.TabIndex = 2;
            // 
            // lb_OderNo
            // 
            lb_OderNo.BackColor = Color.FromArgb(224, 224, 224);
            lb_OderNo.Enabled = false;
            lb_OderNo.Location = new Point(760, 34);
            lb_OderNo.Name = "lb_OderNo";
            lb_OderNo.Size = new Size(116, 29);
            lb_OderNo.TabIndex = 2;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(696, 37);
            label8.Name = "label8";
            label8.Size = new Size(64, 21);
            label8.TabIndex = 0;
            label8.Text = "เลขที่สั่ง :";
            // 
            // lb_Cusname
            // 
            lb_Cusname.BackColor = Color.FromArgb(224, 224, 224);
            lb_Cusname.Enabled = false;
            lb_Cusname.Location = new Point(395, 34);
            lb_Cusname.Name = "lb_Cusname";
            lb_Cusname.Size = new Size(286, 29);
            lb_Cusname.TabIndex = 2;
            // 
            // date_order
            // 
            date_order.Format = DateTimePickerFormat.Short;
            date_order.Location = new Point(105, 87);
            date_order.Name = "date_order";
            date_order.Size = new Size(186, 29);
            date_order.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(6, 87);
            label4.Name = "label4";
            label4.Size = new Size(93, 21);
            label4.TabIndex = 0;
            label4.Text = "วันที่สั่งสินค้า :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(320, 37);
            label3.Name = "label3";
            label3.Size = new Size(69, 21);
            label3.TabIndex = 0;
            label3.Text = "ชื่อลูกค้า :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(23, 37);
            label2.Name = "label2";
            label2.Size = new Size(76, 21);
            label2.TabIndex = 0;
            label2.Text = "รหัสลูกค้า :";
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(panel5);
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(0, 718);
            panel4.Name = "panel4";
            panel4.Size = new Size(1308, 67);
            panel4.TabIndex = 2;
            // 
            // panel5
            // 
            panel5.Controls.Add(button4);
            panel5.Controls.Add(button3);
            panel5.Controls.Add(button2);
            panel5.Dock = DockStyle.Right;
            panel5.Location = new Point(690, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(616, 65);
            panel5.TabIndex = 3;
            // 
            // button4
            // 
            button4.BackColor = Color.Firebrick;
            button4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = Color.White;
            button4.Location = new Point(309, 12);
            button4.Name = "button4";
            button4.Size = new Size(132, 41);
            button4.TabIndex = 0;
            button4.Text = "ออกจากหน้าจอ";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.MenuHighlight;
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.White;
            button3.Location = new Point(171, 12);
            button3.Name = "button3";
            button3.Size = new Size(132, 41);
            button3.TabIndex = 0;
            button3.Text = "บันทึก";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.MenuHighlight;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(33, 12);
            button2.Name = "button2";
            button2.Size = new Size(132, 41);
            button2.TabIndex = 0;
            button2.Text = "ลบรายการ";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // panel6
            // 
            panel6.BackColor = Color.White;
            panel6.BorderStyle = BorderStyle.FixedSingle;
            panel6.Controls.Add(lb_totalPrice);
            panel6.Controls.Add(label18);
            panel6.Controls.Add(lb_TotalQty);
            panel6.Controls.Add(label16);
            panel6.Controls.Add(label15);
            panel6.Dock = DockStyle.Bottom;
            panel6.Location = new Point(0, 607);
            panel6.Name = "panel6";
            panel6.Size = new Size(1308, 111);
            panel6.TabIndex = 3;
            // 
            // lb_totalPrice
            // 
            lb_totalPrice.BorderStyle = BorderStyle.FixedSingle;
            lb_totalPrice.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lb_totalPrice.Location = new Point(1120, 54);
            lb_totalPrice.Name = "lb_totalPrice";
            lb_totalPrice.Size = new Size(174, 32);
            lb_totalPrice.TabIndex = 0;
            lb_totalPrice.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label18
            // 
            label18.BackColor = Color.FromArgb(255, 224, 192);
            label18.BorderStyle = BorderStyle.FixedSingle;
            label18.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label18.Location = new Point(1120, 22);
            label18.Name = "label18";
            label18.Size = new Size(174, 32);
            label18.TabIndex = 0;
            label18.Text = "ราคารวม";
            label18.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lb_TotalQty
            // 
            lb_TotalQty.BorderStyle = BorderStyle.FixedSingle;
            lb_TotalQty.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lb_TotalQty.Location = new Point(1020, 54);
            lb_TotalQty.Name = "lb_TotalQty";
            lb_TotalQty.Size = new Size(100, 32);
            lb_TotalQty.TabIndex = 0;
            lb_TotalQty.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label16
            // 
            label16.BackColor = Color.FromArgb(255, 224, 192);
            label16.BorderStyle = BorderStyle.FixedSingle;
            label16.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label16.Location = new Point(1020, 22);
            label16.Name = "label16";
            label16.Size = new Size(100, 32);
            label16.TabIndex = 0;
            label16.Text = "จำนวนสั่ง";
            label16.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            label15.BackColor = Color.FromArgb(255, 224, 192);
            label15.BorderStyle = BorderStyle.FixedSingle;
            label15.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label15.Location = new Point(921, 22);
            label15.Name = "label15";
            label15.Size = new Size(100, 64);
            label15.TabIndex = 0;
            label15.Text = "รวม";
            label15.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel7
            // 
            panel7.BackColor = Color.White;
            panel7.BorderStyle = BorderStyle.FixedSingle;
            panel7.Controls.Add(dataGridView1);
            panel7.Dock = DockStyle.Fill;
            panel7.Location = new Point(0, 207);
            panel7.Name = "panel7";
            panel7.Size = new Size(1308, 400);
            panel7.TabIndex = 4;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { no, goods_no, good_d, date_due, date_DL, order_qty, price, price_total, id });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 27;
            dataGridView1.Size = new Size(1306, 398);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellEndEdit += dataGridView1_CellEndEdit;
            // 
            // no
            // 
            no.HeaderText = "ลำดับ";
            no.Name = "no";
            no.ReadOnly = true;
            // 
            // goods_no
            // 
            goods_no.HeaderText = "รหัสสินค้า";
            goods_no.Name = "goods_no";
            // 
            // good_d
            // 
            good_d.HeaderText = "รายละเอียดสินค้า";
            good_d.Name = "good_d";
            good_d.ReadOnly = true;
            // 
            // date_due
            // 
            date_due.HeaderText = "วันกำหนดส่ง";
            date_due.Name = "date_due";
            // 
            // date_DL
            // 
            date_DL.HeaderText = "วันที่ส่งสินค้าจริง";
            date_DL.Name = "date_DL";
            // 
            // order_qty
            // 
            order_qty.HeaderText = "จำนวนสั่ง";
            order_qty.Name = "order_qty";
            // 
            // price
            // 
            price.HeaderText = "ราคา/หน่วย";
            price.Name = "price";
            price.ReadOnly = true;
            // 
            // price_total
            // 
            price_total.HeaderText = "ราคารวม";
            price_total.Name = "price_total";
            price_total.ReadOnly = true;
            // 
            // id
            // 
            id.HeaderText = "id";
            id.Name = "id";
            id.Visible = false;
            // 
            // frmEdit_Oder
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1308, 785);
            Controls.Add(panel7);
            Controls.Add(panel6);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "frmEdit_Oder";
            Text = "frmEdit_Oder";
            Load += frmEdit_Oder_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private GroupBox groupBox1;
        private Label label2;
        private Label label3;
        private Label label4;
        private DateTimePicker date_order;
        private Label lb_Cusname;
        private Label label8;
        private Label lb_OderNo;
        private Panel panel4;
        private Panel panel5;
        private Button button2;
        private Button button3;
        private Label lb_CusNo;
        private Button button4;
        private Panel panel6;
        private Panel panel7;
        private DataGridView dataGridView1;
        private Label lb_totalPrice;
        private Label label18;
        private Label lb_TotalQty;
        private Label label16;
        private Label label15;
        private DataGridViewTextBoxColumn no;
        private DataGridViewTextBoxColumn goods_no;
        private DataGridViewTextBoxColumn good_d;
        private DataGridViewTextBoxColumn date_due;
        private DataGridViewTextBoxColumn date_DL;
        private DataGridViewTextBoxColumn order_qty;
        private DataGridViewTextBoxColumn price;
        private DataGridViewTextBoxColumn price_total;
        private DataGridViewTextBoxColumn id;
    }
}