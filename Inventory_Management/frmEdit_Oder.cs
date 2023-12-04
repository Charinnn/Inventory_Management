using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Inventory_Management
{
    public partial class frmEdit_Oder : Form
    {
        public string Order_no { get; set; }
        public frmEdit_Oder()
        {
            InitializeComponent();
        }

        private void frmEdit_Oder_Load(object sender, EventArgs e)
        {
            try
            {

                string sql = "SELECT H_ORDER.* , CUS_NAME.Cus_name  FROM H_ORDER INNER JOIN CUS_NAME ON CUS_NAME.Cus_id = H_ORDER.Cus_id WHERE Order_no = '" + Order_no + "'";
                DataTable dt = new Cls_DB().GetData(sql, "tbl");

                if (dt.Rows.Count > 0)
                {
                    lb_CusNo.Text = dt.Rows[0]["Cus_id"].ToString();
                    lb_Cusname.Text = dt.Rows[0]["Cus_name"].ToString();
                    date_order.Value = Convert.ToDateTime(dt.Rows[0]["Order_Date"].ToString());
                    lb_OderNo.Text = dt.Rows[0]["Order_no"].ToString();

                    string sql_D = "SELECT D_ORDER.*, H_ORDER.Cus_id, CUS_NAME.Cus_name, GOODS_NAME.Goods_name FROM D_ORDER INNER JOIN H_ORDER ON D_ORDER.Order_no = H_ORDER.Order_no INNER JOIN CUS_NAME ON CUS_NAME.Cus_id = H_ORDER.Cus_id INNER JOIN GOODS_NAME ON GOODS_NAME.Goods_id = D_ORDER.Goods_id WHERE D_ORDER.Order_no = '" + Order_no + "'";
                    DataTable dt_D = new Cls_DB().GetData(sql_D, "tbl");
                    if (dt_D.Rows.Count > 0)
                    {
                        if (dataGridView1.Rows.Count == 0)
                        {
                            for (int i = 0; i < dt_D.Rows.Count; i++)
                            {
                                dataGridView1.Rows.Add(dataGridView1.Rows.Count + 1, dt_D.Rows[i]["Goods_id"].ToString(), dt_D.Rows[i]["Goods_name"].ToString(), dt_D.Rows[i]["Ord_date"].ToString(), dt_D.Rows[i]["Fin_date"].ToString(), dt_D.Rows[i]["Amount"].ToString(), Convert.ToDecimal(dt_D.Rows[i]["COST_UNIT"].ToString()), (Convert.ToDecimal(dt_D.Rows[i]["COST_UNIT"])) * Convert.ToInt32(dt_D.Rows[i]["Amount"]), dt_D.Rows[i]["id"].ToString());

                            }

                            decimal totalQtyOrder = 0;
                            decimal totalPrice = 0;

                            foreach (DataGridViewRow row in dataGridView1.Rows)
                            {
                                if (row.Index < dataGridView1.Rows.Count)
                                {
                                    totalQtyOrder += Convert.ToDecimal(row.Cells["order_qty"].Value);
                                    totalPrice += Convert.ToDecimal(row.Cells["price_total"].Value);
                                }
                            }

                            lb_TotalQty.Text = totalQtyOrder.ToString();
                            lb_totalPrice.Text = totalPrice.ToString();

                        }

                    }
                }

            }
            catch { }
        }

        public void Add_txtGoods()
        {

            BindingList<Cls_Goods> CusName = new BindingList<Cls_Goods>();
            SqlConnection objConn = new SqlConnection(@"Server=VCS-IT-CHARINTH;UID=sa;PASSWORD=1234;database=Inventory");
            objConn.Open();
            if (objConn.State == ConnectionState.Open)
            {
                SqlCommand command = new SqlCommand("SELECT Goods_id,Goods_name FROM GOODS_NAME order by Goods_id", objConn);
                using (SqlDataReader r = command.ExecuteReader())
                {
                    while (r.Read())
                    {
                        Cls_Goods data = new Cls_Goods();
                        data.Goods_id = r["Goods_id"].ToString().Trim();
                        data.Goods_name = r["Goods_name"].ToString().Trim();
                        CusName.Add(data);
                    }
                }
            }
            objConn.Close();

        }

        private void cmb_goodsID_Click(object sender, EventArgs e)
        {
            Add_txtGoods();
        }


        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            
            {
                if (dataGridView1.Rows.Count > 0)
                {
                    if (e.ColumnIndex == dataGridView1.Columns["goods_no"].Index || e.ColumnIndex == dataGridView1.Columns["order_qty"].Index)
                    {
                        string goods_id = dataGridView1.Rows[e.RowIndex].Cells["goods_no"].Value.ToString();
                        decimal order_qty = Convert.ToDecimal(dataGridView1.Rows[e.RowIndex].Cells["order_qty"].Value);

                        string sql = $"SELECT * FROM GOODS_NAME WHERE Goods_ID = '{goods_id}'";
                        DataTable dt = new Cls_DB().GetData(sql, "tbl");

                        if (dt.Rows.Count > 0)
                        {
                            decimal cost_unit = Convert.ToDecimal(dt.Rows[0]["cost_unit"]);
                            dataGridView1.Rows[e.RowIndex].Cells["good_d"].Value = dt.Rows[0]["Goods_name"].ToString();
                            dataGridView1.Rows[e.RowIndex].Cells["price"].Value = cost_unit;
                            dataGridView1.Rows[e.RowIndex].Cells["price_total"].Value = cost_unit * order_qty;

                            decimal totalQtyOrder = 0;
                            decimal totalPrice = 0;

                            foreach (DataGridViewRow row in dataGridView1.Rows)
                            {
                                if (row.Index < dataGridView1.Rows.Count)
                                {
                                    totalQtyOrder += Convert.ToDecimal(row.Cells["order_qty"].Value);
                                    totalPrice += Convert.ToDecimal(row.Cells["price_total"].Value);
                                }
                            }

                            lb_TotalQty.Text = totalQtyOrder.ToString();
                            lb_totalPrice.Text = totalPrice.ToString();
                        }
                     
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

                if (dataGridView1.SelectedCells.Count > 0)
                {
                    int selectedRowIndex = dataGridView1.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = dataGridView1.Rows[selectedRowIndex];

                    string no = selectedRow.Cells["no"].Value.ToString();
                    string goods_no = selectedRow.Cells["goods_no"].Value.ToString();
                    string order_no = lb_OderNo.Text;

                    if (MessageBox.Show($"ต้องการลบรายการสินค้าลำดับที่ : {no} รหัสสินค้า : {goods_no} ใช่หรือไม่ ?", "แก้รายการสั่งซื้อ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        string del_Sql;
                        del_Sql = "DELETE FROM D_ORDER WHERE Goods_id = '" + goods_no + "' AND Order_no = '" + order_no + "'";
                        int a = new Cls_DB().ExecuteData(del_Sql);
                        dataGridView1.Rows.RemoveAt(selectedRowIndex);
                        MessageBox.Show("ลบรายการเรียบร้อยแล้ว");

                        decimal totalQtyOrder = 0;
                        decimal totalPrice = 0;

                        foreach (DataGridViewRow row in dataGridView1.Rows)
                        {
                            if (row.Index < dataGridView1.Rows.Count)
                            {
                                totalQtyOrder -= Convert.ToDecimal(row.Cells["order_qty"].Value);
                                totalPrice -= Convert.ToDecimal(row.Cells["price_total"].Value);
                            }
                        }

                        lb_TotalQty.Text = Math.Abs(totalQtyOrder).ToString();
                        lb_totalPrice.Text = Math.Abs(totalPrice).ToString();
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

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {

                if (dataGridView1.Rows.Count > 0)
                {
                    string sql_Dsave;
                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        sql_Dsave = "UPDATE D_ORDER SET ";
                        sql_Dsave += "Order_no = '" + lb_OderNo.Text.ToString() + "'";
                        sql_Dsave += ",Goods_id = '" + dataGridView1.Rows[i].Cells["goods_no"].Value.ToString() + "'";
                        sql_Dsave += ",Ord_date = '" + Convert.ToDateTime(dataGridView1.Rows[i].Cells["date_due"].Value).ToString("yyyy-MM-dd") + "'";
                        sql_Dsave += ",Fin_date = '" + Convert.ToDateTime(dataGridView1.Rows[i].Cells["date_DL"].Value).ToString("yyyy-MM-dd") + "'";
                        sql_Dsave += ",Amount = '" + dataGridView1.Rows[i].Cells["order_qty"].Value.ToString() + "'";
                        sql_Dsave += ",COST_UNIT = '" + dataGridView1.Rows[i].Cells["price"].Value.ToString() + "'";
                        sql_Dsave += ",TOT_PRC = '" + dataGridView1.Rows[i].Cells["price_total"].Value.ToString() + "'";
                        sql_Dsave += " WHERE id = '" + dataGridView1.Rows[i].Cells["id"].Value.ToString() + "'";
                        int a = new Cls_DB().ExecuteData(sql_Dsave);
                    }
                }

                MessageBox.Show("บันทึกเรียบร้อย");
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();  
        }
    }
}
