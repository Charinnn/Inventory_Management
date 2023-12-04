namespace Inventory_Management
{
    partial class frmAdd_listOrder
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            button2 = new Button();
            button1 = new Button();
            panel4 = new Panel();
            pn_Detail = new Panel();
            txtQty = new TextBox();
            comboBox2 = new ComboBox();
            btn_AddOrderList = new Button();
            lb_Orderno = new Label();
            label6 = new Label();
            label9 = new Label();
            label7 = new Label();
            label2 = new Label();
            label8 = new Label();
            label10 = new Label();
            date_DL = new DateTimePicker();
            date_due = new DateTimePicker();
            lb_Goodsname = new Label();
            panel6 = new Panel();
            groupBox1 = new GroupBox();
            label4 = new Label();
            label5 = new Label();
            btn_CreateOrderNo = new Button();
            comboBox1 = new ComboBox();
            lb_Cusname = new Label();
            label3 = new Label();
            date_Order = new DateTimePicker();
            connectDBBindingSource1 = new BindingSource(components);
            panel5 = new Panel();
            dataGridView1 = new DataGridView();
            no = new DataGridViewTextBoxColumn();
            goods_no = new DataGridViewTextBoxColumn();
            goods_d = new DataGridViewTextBoxColumn();
            d_date = new DataGridViewTextBoxColumn();
            c_date = new DataGridViewTextBoxColumn();
            qty = new DataGridViewTextBoxColumn();
            cost_unit = new DataGridViewTextBoxColumn();
            price_total = new DataGridViewTextBoxColumn();
            delete = new DataGridViewTextBoxColumn();
            connectDBBindingSource = new BindingSource(components);
            clsDBBindingSource = new BindingSource(components);
            panel7 = new Panel();
            label15 = new Label();
            label14 = new Label();
            lb_totalPrice = new Label();
            lb_totalQtyOrder = new Label();
            label11 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            pn_Detail.SuspendLayout();
            panel6.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)connectDBBindingSource1).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)connectDBBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)clsDBBindingSource).BeginInit();
            panel7.SuspendLayout();
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
            panel1.Size = new Size(1373, 52);
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
            label1.Size = new Size(1371, 50);
            label1.TabIndex = 0;
            label1.Text = "การบันทึก/แก้ไข การสั่งซื้อสินค้า";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 647);
            panel2.Name = "panel2";
            panel2.Size = new Size(1373, 67);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Controls.Add(button2);
            panel3.Controls.Add(button1);
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(1054, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(317, 65);
            panel3.TabIndex = 0;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.MenuHighlight;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(13, 15);
            button2.Name = "button2";
            button2.Size = new Size(135, 37);
            button2.TabIndex = 0;
            button2.Text = "บันทึก";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Firebrick;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(168, 15);
            button1.Name = "button1";
            button1.Size = new Size(135, 37);
            button1.TabIndex = 0;
            button1.Text = "ออกจากหน้าจอ";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(pn_Detail);
            panel4.Controls.Add(panel6);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 52);
            panel4.Name = "panel4";
            panel4.Size = new Size(1373, 145);
            panel4.TabIndex = 2;
            // 
            // pn_Detail
            // 
            pn_Detail.Controls.Add(txtQty);
            pn_Detail.Controls.Add(comboBox2);
            pn_Detail.Controls.Add(btn_AddOrderList);
            pn_Detail.Controls.Add(lb_Orderno);
            pn_Detail.Controls.Add(label6);
            pn_Detail.Controls.Add(label9);
            pn_Detail.Controls.Add(label7);
            pn_Detail.Controls.Add(label2);
            pn_Detail.Controls.Add(label8);
            pn_Detail.Controls.Add(label10);
            pn_Detail.Controls.Add(date_DL);
            pn_Detail.Controls.Add(date_due);
            pn_Detail.Controls.Add(lb_Goodsname);
            pn_Detail.Dock = DockStyle.Fill;
            pn_Detail.Location = new Point(521, 0);
            pn_Detail.Name = "pn_Detail";
            pn_Detail.Size = new Size(850, 143);
            pn_Detail.TabIndex = 1;
            // 
            // txtQty
            // 
            txtQty.BorderStyle = BorderStyle.FixedSingle;
            txtQty.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtQty.Location = new Point(648, 63);
            txtQty.Name = "txtQty";
            txtQty.Size = new Size(139, 29);
            txtQty.TabIndex = 5;
            // 
            // comboBox2
            // 
            comboBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(89, 9);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(167, 29);
            comboBox2.TabIndex = 1;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            comboBox2.Click += comboBox2_Click;
            // 
            // btn_AddOrderList
            // 
            btn_AddOrderList.BackColor = SystemColors.MenuHighlight;
            btn_AddOrderList.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_AddOrderList.ForeColor = Color.White;
            btn_AddOrderList.Location = new Point(592, 103);
            btn_AddOrderList.Name = "btn_AddOrderList";
            btn_AddOrderList.Size = new Size(195, 31);
            btn_AddOrderList.TabIndex = 5;
            btn_AddOrderList.Text = "เพิ่มรายการสั่งซื้อ";
            btn_AddOrderList.UseVisualStyleBackColor = false;
            btn_AddOrderList.Click += btn_AddOrderList_Click;
            // 
            // lb_Orderno
            // 
            lb_Orderno.BackColor = Color.FromArgb(224, 224, 224);
            lb_Orderno.Enabled = false;
            lb_Orderno.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lb_Orderno.ForeColor = Color.FromArgb(0, 0, 192);
            lb_Orderno.Location = new Point(633, 10);
            lb_Orderno.Name = "lb_Orderno";
            lb_Orderno.Size = new Size(154, 29);
            lb_Orderno.TabIndex = 4;
            lb_Orderno.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(6, 12);
            label6.Name = "label6";
            label6.Size = new Size(77, 21);
            label6.TabIndex = 1;
            label6.Text = "รหัสสินค้า :";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(573, 65);
            label9.Name = "label9";
            label9.Size = new Size(74, 21);
            label9.TabIndex = 1;
            label9.Text = "จำนวนสั่ง :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(304, 65);
            label7.Name = "label7";
            label7.Size = new Size(79, 21);
            label7.TabIndex = 1;
            label7.Text = "วันที่ส่งจริง :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(6, 65);
            label2.Name = "label2";
            label2.Size = new Size(93, 21);
            label2.TabIndex = 1;
            label2.Text = "วันกำหนดส่ง :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(563, 13);
            label8.Name = "label8";
            label8.Size = new Size(64, 21);
            label8.TabIndex = 1;
            label8.Text = "เลขที่สั่ง :";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(269, 12);
            label10.Name = "label10";
            label10.Size = new Size(117, 21);
            label10.TabIndex = 1;
            label10.Text = "รายละเอียดสินค้า :";
            // 
            // date_DL
            // 
            date_DL.CalendarFont = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            date_DL.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            date_DL.Format = DateTimePickerFormat.Short;
            date_DL.Location = new Point(389, 63);
            date_DL.Name = "date_DL";
            date_DL.Size = new Size(167, 29);
            date_DL.TabIndex = 3;
            // 
            // date_due
            // 
            date_due.CalendarFont = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            date_due.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            date_due.Format = DateTimePickerFormat.Short;
            date_due.Location = new Point(104, 63);
            date_due.Name = "date_due";
            date_due.Size = new Size(152, 29);
            date_due.TabIndex = 3;
            // 
            // lb_Goodsname
            // 
            lb_Goodsname.BackColor = Color.FromArgb(224, 224, 224);
            lb_Goodsname.Enabled = false;
            lb_Goodsname.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lb_Goodsname.ForeColor = Color.FromArgb(0, 0, 192);
            lb_Goodsname.Location = new Point(389, 12);
            lb_Goodsname.Name = "lb_Goodsname";
            lb_Goodsname.Size = new Size(167, 29);
            lb_Goodsname.TabIndex = 4;
            lb_Goodsname.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel6
            // 
            panel6.Controls.Add(groupBox1);
            panel6.Dock = DockStyle.Left;
            panel6.Location = new Point(0, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(521, 143);
            panel6.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(btn_CreateOrderNo);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(lb_Cusname);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(date_Order);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(521, 143);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "สถานะ เพิ่มรายการรับคำสั่งซื้อสินค้า";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(6, 86);
            label4.Name = "label4";
            label4.Size = new Size(93, 21);
            label4.TabIndex = 1;
            label4.Text = "วันที่สั่งสินค้า :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(261, 34);
            label5.Name = "label5";
            label5.Size = new Size(69, 21);
            label5.TabIndex = 1;
            label5.Text = "ชื่อลูกค้า :";
            // 
            // btn_CreateOrderNo
            // 
            btn_CreateOrderNo.BackColor = SystemColors.MenuHighlight;
            btn_CreateOrderNo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_CreateOrderNo.ForeColor = Color.White;
            btn_CreateOrderNo.Location = new Point(261, 84);
            btn_CreateOrderNo.Name = "btn_CreateOrderNo";
            btn_CreateOrderNo.Size = new Size(253, 31);
            btn_CreateOrderNo.TabIndex = 5;
            btn_CreateOrderNo.Text = "บันทึกเลขที่รายการ";
            btn_CreateOrderNo.UseVisualStyleBackColor = false;
            btn_CreateOrderNo.Click += btn_CreateOrderNo_Click_1;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(101, 31);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(149, 29);
            comboBox1.TabIndex = 1;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            comboBox1.Click += comboBox1_Click;
            // 
            // lb_Cusname
            // 
            lb_Cusname.BackColor = Color.FromArgb(224, 224, 224);
            lb_Cusname.Enabled = false;
            lb_Cusname.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lb_Cusname.ForeColor = Color.FromArgb(0, 0, 192);
            lb_Cusname.Location = new Point(336, 31);
            lb_Cusname.Name = "lb_Cusname";
            lb_Cusname.Size = new Size(178, 29);
            lb_Cusname.TabIndex = 4;
            lb_Cusname.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(23, 33);
            label3.Name = "label3";
            label3.Size = new Size(76, 21);
            label3.TabIndex = 1;
            label3.Text = "รหัสลูกค้า :";
            // 
            // date_Order
            // 
            date_Order.CalendarFont = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            date_Order.Format = DateTimePickerFormat.Short;
            date_Order.Location = new Point(101, 86);
            date_Order.Name = "date_Order";
            date_Order.Size = new Size(149, 29);
            date_Order.TabIndex = 3;
            // 
            // connectDBBindingSource1
            // 
            connectDBBindingSource1.DataSource = typeof(ConnectDB);
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.Controls.Add(dataGridView1);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(0, 197);
            panel5.Name = "panel5";
            panel5.Size = new Size(1373, 450);
            panel5.TabIndex = 3;
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
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { no, goods_no, goods_d, d_date, c_date, qty, cost_unit, price_total, delete });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 27;
            dataGridView1.Size = new Size(1373, 450);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellMouseClick += dataGridView1_CellMouseClick;
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
            goods_no.ReadOnly = true;
            // 
            // goods_d
            // 
            goods_d.HeaderText = "รายละเอียดสินค้า";
            goods_d.Name = "goods_d";
            goods_d.ReadOnly = true;
            // 
            // d_date
            // 
            d_date.HeaderText = "วันกำหนดส่ง";
            d_date.Name = "d_date";
            d_date.ReadOnly = true;
            // 
            // c_date
            // 
            c_date.HeaderText = "วันที่ส่งสินค้าจริง";
            c_date.Name = "c_date";
            c_date.ReadOnly = true;
            // 
            // qty
            // 
            qty.HeaderText = "จำนวนที่สั่ง";
            qty.Name = "qty";
            qty.ReadOnly = true;
            // 
            // cost_unit
            // 
            cost_unit.HeaderText = "ราคา/หน่วย";
            cost_unit.Name = "cost_unit";
            cost_unit.ReadOnly = true;
            // 
            // price_total
            // 
            price_total.HeaderText = "ราคารวม";
            price_total.Name = "price_total";
            price_total.ReadOnly = true;
            // 
            // delete
            // 
            delete.HeaderText = "Action";
            delete.Name = "delete";
            delete.ReadOnly = true;
            // 
            // connectDBBindingSource
            // 
            connectDBBindingSource.DataSource = typeof(ConnectDB);
            // 
            // clsDBBindingSource
            // 
            clsDBBindingSource.DataSource = typeof(Cls_DB);
            // 
            // panel7
            // 
            panel7.BackColor = Color.White;
            panel7.BorderStyle = BorderStyle.FixedSingle;
            panel7.Controls.Add(label15);
            panel7.Controls.Add(label14);
            panel7.Controls.Add(lb_totalPrice);
            panel7.Controls.Add(lb_totalQtyOrder);
            panel7.Controls.Add(label11);
            panel7.Dock = DockStyle.Bottom;
            panel7.Location = new Point(0, 518);
            panel7.Name = "panel7";
            panel7.Size = new Size(1373, 129);
            panel7.TabIndex = 1;
            // 
            // label15
            // 
            label15.AutoEllipsis = true;
            label15.BackColor = Color.FromArgb(255, 224, 192);
            label15.BorderStyle = BorderStyle.FixedSingle;
            label15.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label15.Location = new Point(1202, 12);
            label15.Name = "label15";
            label15.Size = new Size(155, 38);
            label15.TabIndex = 1;
            label15.Text = "ราคารวม";
            label15.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            label14.AutoEllipsis = true;
            label14.BackColor = Color.FromArgb(255, 224, 192);
            label14.BorderStyle = BorderStyle.FixedSingle;
            label14.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(1092, 12);
            label14.Name = "label14";
            label14.Size = new Size(111, 38);
            label14.TabIndex = 1;
            label14.Text = "จำนวนสั่ง";
            label14.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lb_totalPrice
            // 
            lb_totalPrice.AutoEllipsis = true;
            lb_totalPrice.BorderStyle = BorderStyle.FixedSingle;
            lb_totalPrice.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lb_totalPrice.Location = new Point(1202, 50);
            lb_totalPrice.Name = "lb_totalPrice";
            lb_totalPrice.Size = new Size(155, 38);
            lb_totalPrice.TabIndex = 1;
            lb_totalPrice.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lb_totalQtyOrder
            // 
            lb_totalQtyOrder.AutoEllipsis = true;
            lb_totalQtyOrder.BorderStyle = BorderStyle.FixedSingle;
            lb_totalQtyOrder.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lb_totalQtyOrder.Location = new Point(1092, 50);
            lb_totalQtyOrder.Name = "lb_totalQtyOrder";
            lb_totalQtyOrder.Size = new Size(111, 38);
            lb_totalQtyOrder.TabIndex = 1;
            lb_totalQtyOrder.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            label11.BackColor = Color.FromArgb(255, 224, 192);
            label11.BorderStyle = BorderStyle.FixedSingle;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(1012, 12);
            label11.Name = "label11";
            label11.Size = new Size(81, 76);
            label11.TabIndex = 0;
            label11.Text = "รวม";
            label11.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // frmAdd_listOrder
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1373, 714);
            Controls.Add(panel7);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "frmAdd_listOrder";
            Text = "frmAdd_listOrder";
            Load += frmAdd_listOrder_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            pn_Detail.ResumeLayout(false);
            pn_Detail.PerformLayout();
            panel6.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)connectDBBindingSource1).EndInit();
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)connectDBBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)clsDBBindingSource).EndInit();
            panel7.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Panel panel3;
        private Button button2;
        private Button button1;
        private Panel panel4;
        private Panel panel5;
        private DataGridView dataGridView1;
        private Label label4;
        private Label label5;
        private Label label3;
        private DateTimePicker date_Order;
        private Button btn_CreateOrderNo;
        private Label lb_Orderno;
        private Label lb_Cusname;
        private Label label6;
        private Label label8;
        private Label label10;
        private ComboBox comboBox1;
        private BindingSource connectDBBindingSource;
        private BindingSource connectDBBindingSource1;
        private BindingSource clsDBBindingSource;
        private ComboBox comboBox2;
        private Label lb_Goodsname;
        private Panel pn_Detail;
        private Panel panel6;
        private GroupBox groupBox1;
        private Label label2;
        private DateTimePicker date_due;
        private TextBox txtQty;
        private Label label9;
        private Label label7;
        private DateTimePicker date_DL;
        private Button btn_AddOrderList;
        private Panel panel7;
        private Label lb_totalQtyOrder;
        private Label label11;
        private Label label15;
        private Label label14;
        private Label lb_totalPrice;
        private DataGridViewTextBoxColumn no;
        private DataGridViewTextBoxColumn goods_no;
        private DataGridViewTextBoxColumn goods_d;
        private DataGridViewTextBoxColumn d_date;
        private DataGridViewTextBoxColumn c_date;
        private DataGridViewTextBoxColumn qty;
        private DataGridViewTextBoxColumn cost_unit;
        private DataGridViewTextBoxColumn price_total;
        private DataGridViewTextBoxColumn delete;
    }
}