namespace Inventory_Management
{
    partial class frmReport
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
            btnShow_data = new Button();
            label3 = new Label();
            label2 = new Label();
            dateTimePicker2 = new DateTimePicker();
            dateTimePicker1 = new DateTimePicker();
            panel3 = new Panel();
            panel4 = new Panel();
            btnExit = new Button();
            btnPrint = new Button();
            panel5 = new Panel();
            dataGridView1 = new DataGridView();
            no = new DataGridViewTextBoxColumn();
            detail_cus = new DataGridViewTextBoxColumn();
            detail_goods = new DataGridViewTextBoxColumn();
            doc_date = new DataGridViewTextBoxColumn();
            order_no = new DataGridViewTextBoxColumn();
            ord_date = new DataGridViewTextBoxColumn();
            amount = new DataGridViewTextBoxColumn();
            UNIT_COST = new DataGridViewTextBoxColumn();
            TOT_PRC = new DataGridViewTextBoxColumn();
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
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1225, 64);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(1223, 62);
            label1.TabIndex = 0;
            label1.Text = "รายงานแสดงข้อมูลที่ครบกำหนดส่งสินค้าแล้วยังไม่ได้ส่งสินค้า";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(btnShow_data);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(dateTimePicker2);
            panel2.Controls.Add(dateTimePicker1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 64);
            panel2.Name = "panel2";
            panel2.Size = new Size(1225, 131);
            panel2.TabIndex = 1;
            // 
            // btnShow_data
            // 
            btnShow_data.BackColor = Color.DodgerBlue;
            btnShow_data.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnShow_data.ForeColor = Color.White;
            btnShow_data.Location = new Point(461, 32);
            btnShow_data.Name = "btnShow_data";
            btnShow_data.Size = new Size(105, 74);
            btnShow_data.TabIndex = 3;
            btnShow_data.Text = "แสดง";
            btnShow_data.UseVisualStyleBackColor = false;
            btnShow_data.Click += btnShow_data_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(152, 79);
            label3.Name = "label3";
            label3.Size = new Size(58, 21);
            label3.TabIndex = 2;
            label3.Text = "ถึงวันที่ :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(55, 35);
            label2.Name = "label2";
            label2.Size = new Size(155, 21);
            label2.TabIndex = 2;
            label2.Text = "วันที่กำหนดสังตามแผน :";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker2.Format = DateTimePickerFormat.Short;
            dateTimePicker2.Location = new Point(227, 77);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(200, 29);
            dateTimePicker2.TabIndex = 0;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(227, 32);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 29);
            dateTimePicker1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(panel4);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 741);
            panel3.Name = "panel3";
            panel3.Size = new Size(1225, 81);
            panel3.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(btnExit);
            panel4.Controls.Add(btnPrint);
            panel4.Dock = DockStyle.Right;
            panel4.Location = new Point(975, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(248, 79);
            panel4.TabIndex = 0;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.FromArgb(192, 0, 0);
            btnExit.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnExit.ForeColor = Color.White;
            btnExit.Location = new Point(126, 19);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(105, 45);
            btnExit.TabIndex = 3;
            btnExit.Text = "ออก";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnPrint
            // 
            btnPrint.BackColor = Color.DodgerBlue;
            btnPrint.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnPrint.ForeColor = Color.White;
            btnPrint.Location = new Point(3, 19);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(105, 45);
            btnPrint.TabIndex = 3;
            btnPrint.Text = "พิมพ์";
            btnPrint.UseVisualStyleBackColor = false;
            btnPrint.Click += btnPrint_Click;
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(dataGridView1);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(0, 195);
            panel5.Name = "panel5";
            panel5.Size = new Size(1225, 546);
            panel5.TabIndex = 3;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridView1.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { no, detail_cus, detail_goods, doc_date, order_no, ord_date, amount, UNIT_COST, TOT_PRC });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 27;
            dataGridView1.Size = new Size(1223, 544);
            dataGridView1.TabIndex = 0;
            // 
            // no
            // 
            no.HeaderText = "ลำดับ";
            no.Name = "no";
            no.ReadOnly = true;
            no.Width = 60;
            // 
            // detail_cus
            // 
            detail_cus.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            detail_cus.HeaderText = "รายละเอียดลูกค้า";
            detail_cus.Name = "detail_cus";
            detail_cus.ReadOnly = true;
            // 
            // detail_goods
            // 
            detail_goods.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            detail_goods.HeaderText = "รายละเอียดสินค้า";
            detail_goods.Name = "detail_goods";
            detail_goods.ReadOnly = true;
            // 
            // doc_date
            // 
            doc_date.HeaderText = "วันที่สั่ง";
            doc_date.Name = "doc_date";
            doc_date.ReadOnly = true;
            doc_date.Width = 70;
            // 
            // order_no
            // 
            order_no.HeaderText = "เลขที่สั่ง";
            order_no.Name = "order_no";
            order_no.ReadOnly = true;
            order_no.Width = 68;
            // 
            // ord_date
            // 
            ord_date.HeaderText = "วันกำหนดส่ง";
            ord_date.Name = "ord_date";
            ord_date.ReadOnly = true;
            ord_date.Width = 88;
            // 
            // amount
            // 
            amount.HeaderText = "จำนวน";
            amount.Name = "amount";
            amount.ReadOnly = true;
            amount.Width = 67;
            // 
            // UNIT_COST
            // 
            UNIT_COST.HeaderText = "ราคา/หน่วย";
            UNIT_COST.Name = "UNIT_COST";
            UNIT_COST.ReadOnly = true;
            UNIT_COST.Width = 82;
            // 
            // TOT_PRC
            // 
            TOT_PRC.HeaderText = "ราคารวม";
            TOT_PRC.Name = "TOT_PRC";
            TOT_PRC.ReadOnly = true;
            TOT_PRC.Width = 73;
            // 
            // frmReport
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1225, 822);
            Controls.Add(panel5);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmReport";
            Text = "frmReport";
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
        private Label label2;
        private DateTimePicker dateTimePicker1;
        private Button btnShow_data;
        private Label label3;
        private DateTimePicker dateTimePicker2;
        private Panel panel3;
        private Panel panel4;
        private Button btnPrint;
        private Button btnExit;
        private Panel panel5;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn no;
        private DataGridViewTextBoxColumn detail_cus;
        private DataGridViewTextBoxColumn detail_goods;
        private DataGridViewTextBoxColumn doc_date;
        private DataGridViewTextBoxColumn order_no;
        private DataGridViewTextBoxColumn ord_date;
        private DataGridViewTextBoxColumn amount;
        private DataGridViewTextBoxColumn UNIT_COST;
        private DataGridViewTextBoxColumn TOT_PRC;
    }
}