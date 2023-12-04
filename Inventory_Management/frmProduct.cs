using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Inventory_Management
{
    public partial class frmProduct : Form
    {
        public frmProduct()
        {
            InitializeComponent();
        }

        private void frmProduct_Load(object sender, EventArgs e)
        {
            ShowProduct();
        }
        public void ShowProduct()
        {
            try
            {
                dataGridView1.Rows.Clear();
                string sql = "SELECT * FROM GOODS_NAME";
                DataTable dt = new Cls_DB().GetData(sql, "tbl");

                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        dataGridView1.Rows.Add((dataGridView1.Rows.Count+1), dt.Rows[i]["Goods_id"], dt.Rows[i]["Goods_name"], dt.Rows[i]["cost_unit"], "แก้ไข", "ลบ");
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtGood_id.Text != "" & txtGood_name.Text != "" & txtPrice.Text != "")
                {
                    if (txtGood_id.Text.Length == 10)
                    {
                        if (Convert.ToDecimal(txtPrice.Text) > 0 & Convert.ToDecimal(txtPrice.Text) <= 999999.99M)
                        {
                            string SQL = $"SELECT * FROM GOODS_NAME WHERE Goods_id = '{txtGood_id.Text}' ";
                            DataTable dt = new Cls_DB().GetData(SQL, "tbl");
                            if (dt.Rows.Count > 0)
                            {
                                MessageBox.Show("รหัสสินค้านี้มีในระบบแล้ว");
                            }
                            else
                            {
                                string sql_Save;
                                sql_Save = "INSERT INTO GOODS_NAME (Goods_id,Goods_name,cost_unit) VALUES ('"
                                + txtGood_id.Text.ToString() + "' , '"
                                + txtGood_name.Text.ToString() + "' , '"
                                + txtPrice.Text.ToString() + "')";
                                int a = new Cls_DB().ExecuteData(sql_Save);
                            }
                        }
                        else
                        {
                            MessageBox.Show("ราคาที่กำหนดไม่ถูกต้อง");
                        }

                    }
                    else
                    {
                        MessageBox.Show("รหัสสินค้าต้องมี 10 หลัก");
                    }
                }
                else
                {
                    MessageBox.Show("กรูณากรอกข้อมูลให้ครบ");
                }
                ShowProduct();
                txtGood_id.Clear();
                txtGood_name.Clear();
                txtPrice.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch
            {

            }

        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (e.RowIndex == -1)
                    return;

                int rowIndex = dataGridView1.CurrentCell.RowIndex;
                int colIndex = dataGridView1.CurrentCell.ColumnIndex;

                string Goods_id = dataGridView1.Rows[rowIndex].Cells[1].Value.ToString();
                string Goods_name = dataGridView1.Rows[rowIndex].Cells[2].Value.ToString();
                string cost = dataGridView1.Rows[rowIndex].Cells[3].Value.ToString();

                //Row Column ที่คลิก มีค่าเป็น DELETE
                if (dataGridView1.Rows[rowIndex].Cells[colIndex].Value.ToString() == "ลบ")
                {
                    if (MessageBox.Show("ต้องการลบข้อมูลสินค้ารหัส '" + Goods_id + "' ใช่หรือไม่ ? ", "ยืนยันการลบ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        string del_Sql;
                        del_Sql = "DELETE FROM GOODS_NAME WHERE Goods_id = '" + Goods_id + "' AND Goods_name = '" + Goods_name + "' AND cost_unit = '" + cost + "'";
                        int a = new Cls_DB().ExecuteData(del_Sql);
                        dataGridView1.Rows.RemoveAt(rowIndex);

                        MessageBox.Show("ลบข้อมูลเรียบร้อย");

                    }

                }
                if (dataGridView1.Rows[rowIndex].Cells[colIndex].Value.ToString() == "แก้ไข")
                {
                    if (MessageBox.Show("ต้องการแก้ไขข้อมูลสินค้ารหัส '" + Goods_id + "' ? ", "แก้ไขข้อมูล", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        frmEdit_Goods frm = new frmEdit_Goods();

                        frm.Goods_id = Goods_id;
                        frm.Goods_name = Goods_name;
                        frm.Cost = Convert.ToDecimal(cost);

                        frm.ShowDialog();
                    }

                }
                ShowProduct();
                txtGood_id.Clear();
                txtGood_name.Clear();
                txtPrice.Clear();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
