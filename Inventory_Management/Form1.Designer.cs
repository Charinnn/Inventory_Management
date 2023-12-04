namespace Inventory_Management
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            panel4 = new Panel();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            panel3 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            Show_panel = new Panel();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Location = new Point(0, 465);
            panel1.Name = "panel1";
            panel1.Size = new Size(258, 233);
            panel1.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.BackColor = Color.PaleTurquoise;
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(button4);
            panel4.Controls.Add(button3);
            panel4.Controls.Add(button2);
            panel4.Controls.Add(button1);
            panel4.Dock = DockStyle.Left;
            panel4.Location = new Point(0, 58);
            panel4.Name = "panel4";
            panel4.Size = new Size(235, 640);
            panel4.TabIndex = 0;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Location = new Point(21, 280);
            button4.Name = "button4";
            button4.Size = new Size(190, 55);
            button4.TabIndex = 1;
            button4.Text = "ออกจากระบบ";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(21, 204);
            button3.Name = "button3";
            button3.Size = new Size(190, 55);
            button3.TabIndex = 2;
            button3.Text = "รายงานกำหนดส่งสินค้า";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(21, 128);
            button2.Name = "button2";
            button2.Size = new Size(190, 55);
            button2.TabIndex = 1;
            button2.Text = "บันทึก/แก้ไข การสั่งซื้อสินค้า";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(21, 50);
            button1.Name = "button1";
            button1.Size = new Size(190, 55);
            button1.TabIndex = 0;
            button1.Text = "บันทึก/แก้ไข ข้อมูลสินค้า";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.LightSeaGreen;
            panel3.Controls.Add(label1);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1150, 58);
            panel3.TabIndex = 0;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(1150, 58);
            label1.TabIndex = 0;
            label1.Text = "ระบบโปรแกรมบริหารจัดการสินค้าคงคลัง";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(Show_panel);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1150, 698);
            panel2.TabIndex = 1;
            // 
            // Show_panel
            // 
            Show_panel.Dock = DockStyle.Fill;
            Show_panel.Location = new Point(235, 58);
            Show_panel.Name = "Show_panel";
            Show_panel.Size = new Size(915, 640);
            Show_panel.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1150, 698);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            FormClosed += Form1_FormClosed;
            panel4.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private Label label1;
        private Panel panel2;
        private Panel panel4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Button button4;
        private Panel Show_panel;
    }
}