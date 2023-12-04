using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Management
{
    public partial class frmOder : Form
    {
        public frmOder()
        {
            InitializeComponent();
        }

        private void frmOder_Load(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.Rows.Clear();
                string sql = "SELECT H.Cus_id, C.Cus_name, H.Order_no, COUNT(*) AS CNT, SUM(D.Amount) AS Amount FROM H_ORDER H JOIN D_ORDER D ON H.Order_no = D.Order_no JOIN CUS_NAME C ON H.Cus_id = C.Cus_id GROUP BY H.Cus_id, C.Cus_name, H.Order_no;";
                DataTable dt = new Cls_DB().GetData(sql, "tbl");
                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        dataGridView1.Rows.Add(dataGridView1.Rows.Count + 1, dt.Rows[i]["Cus_id"].ToString(), dt.Rows[i]["Cus_name"].ToString(), dt.Rows[i]["Order_no"].ToString(), dt.Rows[i]["CNT"].ToString(), dt.Rows[0]["Amount"].ToString());
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                frmAdd_listOrder frm = new frmAdd_listOrder();
                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedCells.Count > 0)
                {
                    int selectedRowIndex = dataGridView1.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = dataGridView1.Rows[selectedRowIndex];

                    string Order_no = selectedRow.Cells["order_no"].Value.ToString();

                    if (MessageBox.Show($"ต้องการแก้ไขรายการสินค้า Order No : {Order_no} ใช่หรือไม่ ?", "แก้รายการสั่งซื้อ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        frmEdit_Oder frm = new frmEdit_Oder();
                        frm.Order_no = Order_no;
                        frm.ShowDialog();


                    }

                }
                else
                {
                    MessageBox.Show("กรุณาเลือกรายการสั่งซื้อที่ต้องการแก้ไข");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try 
            {

                if (dataGridView1.SelectedCells.Count > 0)
                {
                    int selectedRowIndex = dataGridView1.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = dataGridView1.Rows[selectedRowIndex];

                    string Order_no = selectedRow.Cells["order_no"].Value.ToString();

                    if (MessageBox.Show($"ต้องการลบรายการสินค้าทั้งบิล ของหมายเลขสั่งซื้อ : {Order_no} ใช่หรือไม่ ?", "ลบบิล", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        string del_SqlD;
                        del_SqlD = "DELETE FROM D_ORDER WHERE Order_no = '" + Order_no + "'";
                        int a = new Cls_DB().ExecuteData(del_SqlD);
                        dataGridView1.Rows.RemoveAt(selectedRowIndex);

                        string del_SqlH;
                        del_SqlH = "DELETE FROM H_ORDER WHERE Order_no = '" + Order_no + "'";
                        int a_ = new Cls_DB().ExecuteData(del_SqlH);
                        MessageBox.Show("ลบรายการเรียบร้อยแล้ว");

                    }

                }
                else
                {
                    MessageBox.Show("กรุณาเลือกรายการสั่งซื้อที่ต้องการลบ");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
