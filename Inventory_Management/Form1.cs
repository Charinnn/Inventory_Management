namespace Inventory_Management
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Show_panel.Controls.Clear();
            frmProduct frm = new frmProduct();
            frm.TopLevel = false;
            Show_panel.Controls.Add(frm);
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Show_panel.Controls.Clear();
            frmOder frm = new frmOder();
            frm.TopLevel = false;
            Show_panel.Controls.Add(frm);
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Show_panel.Controls.Clear();
            frmReport frm = new frmReport();
            frm.TopLevel = false;
            Show_panel.Controls.Add(frm);
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}