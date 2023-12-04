using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Management
{
    public partial class frmAdd_listOrder : Form
    {
        public frmAdd_listOrder()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmAdd_listOrder_Load(object sender, EventArgs e)
        {
            pn_Detail.Visible = false;
        }
        public void Add_txtCus()
        {

            BindingList<Cls_Cus> CusName = new BindingList<Cls_Cus>();
            SqlConnection objConn = new SqlConnection(@"Server=VCS-IT-CHARINTH;UID=sa;PASSWORD=1234;database=Inventory");
            objConn.Open();
            if (objConn.State == ConnectionState.Open)
            {
                SqlCommand command = new SqlCommand("SELECT Cus_id,Cus_name FROM CUS_NAME order by Cus_id", objConn);
                using (SqlDataReader r = command.ExecuteReader())
                {
                    while (r.Read())
                    {
                        Cls_Cus data = new Cls_Cus();
                        data.Cus_id = r["Cus_id"].ToString().Trim();
                        data.Cus_name = r["Cus_name"].ToString().Trim();
                        CusName.Add(data);
                    }
                }
            }
            objConn.Close();
            comboBox1.DataSource = CusName;
            comboBox1.DisplayMember = "Cus_id";
            comboBox1.ValueMember = "Cus_id";
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
            comboBox2.DataSource = CusName;
            comboBox2.DisplayMember = "Goods_id";
            comboBox2.ValueMember = "Goods_id";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                if (comboBox1.SelectedIndex != -1)
                {
                    string sql = "SELECT * FROM CUS_NAME WHERE Cus_id = '" + comboBox1.SelectedValue.ToString() + "'";
                    DataTable dt = new Cls_DB().GetData(sql, "tbl");
                    if (dt.Rows.Count > 0)
                    {
                        lb_Cusname.Text = dt.Rows[0]["Cus_name"].ToString();
                    }

                }
            }
            catch (Exception ex)
            {

            }
        }

        private void btn_CreateOrderNo_Click_1(object sender, EventArgs e)
        {
            try
            {

                if (comboBox1.SelectedValue != "" & lb_Cusname.Text != "")
                {
                    string SQL = "SELECT * FROM H_ORDER";
                    DataTable dt = new Cls_DB().GetData(SQL, "tbl");

                    if (dt.Rows.Count > 0)
                    {
                      
                        string sql_Save = "INSERT INTO H_ORDER (Cus_id, Order_Date) VALUES ('"
                                          + comboBox1.SelectedValue.ToString().Trim() + "' , '"
                                          + date_Order.Value.ToString("dd/MM/yyyy") + "')";

                        int a = new Cls_DB().ExecuteData(sql_Save);

                        // ดึงค่า Order_no ที่ถูกสร้างขึ้นล่าสุด
                        object newOrderNoObj = new Cls_DB().GetScalar("SELECT TOP 1 Order_no FROM H_ORDER ORDER BY Order_no DESC");

                        string newOrderNo = newOrderNoObj != DBNull.Value ? newOrderNoObj.ToString() : "";

                        lb_Orderno.Text = newOrderNo;
                        pn_Detail.Visible = true;
                    }
                    else
                    {
                        string sql_Save = "INSERT INTO H_ORDER (Cus_id, Order_Date) VALUES ('" + comboBox1.SelectedValue.ToString().Trim() + "' , '" + date_Order.Value.ToString("dd/MM/yyyy") + "')";

                        int a = new Cls_DB().ExecuteData(sql_Save);

                        object newOrderNoObj = new Cls_DB().GetScalar("SELECT TOP 1 Order_no FROM H_ORDER ORDER BY Order_no DESC");

                        string newOrderNo = newOrderNoObj != DBNull.Value ? newOrderNoObj.ToString() : "";

                        lb_Orderno.Text = newOrderNo;
                        pn_Detail.Visible = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void comboBox1_Click(object sender, EventArgs e)
        {
            Add_txtCus();
        }

        private void comboBox2_Click(object sender, EventArgs e)
        {
            Add_txtGoods();
        }

        private void btn_AddOrderList_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox2.SelectedValue != "" & lb_Goodsname.Text != "" & lb_Orderno.Text != "" & txtQty.Text != "")
                {
                    if (dataGridView1.Rows.Count > 0)
                    {
                        string sql = "SELECT * FROM GOODS_NAME WHERE Goods_id = '" + comboBox2.SelectedValue.ToString() + "'";
                        DataTable dt = new Cls_DB().GetData(sql, "tbl");
                        if (dt.Rows.Count > 0)
                        {
                            dataGridView1.Rows.Add(dataGridView1.Rows.Count + 1, comboBox2.SelectedValue.ToString(), lb_Goodsname.Text.ToString(), date_due.Value.ToString("dd/MM/yyyy"), date_DL.Value.ToString("dd/MM/yyyy"), Convert.ToInt32(txtQty.Text).ToString(), Convert.ToDecimal(dt.Rows[0]["cost_unit"]), (Convert.ToDecimal(dt.Rows[0]["cost_unit"])) * Convert.ToInt32(txtQty.Text), "ลบ");

                            int totalQtyOrder = 0;
                            decimal totalPrice = 0;

                            foreach (DataGridViewRow row in dataGridView1.Rows)
                            {
                                if (row.Index < dataGridView1.Rows.Count) // ตรวจสอบว่าไม่ใช่แถวสุดท้าย (ที่ใช้สำหรับการเพิ่มข้อมูล)
                                {
                                    totalQtyOrder += Convert.ToInt32(row.Cells["qty"].Value);
                                    totalPrice += Convert.ToDecimal(row.Cells["price_total"].Value);
                                }
                            }

                            lb_totalQtyOrder.Text = totalQtyOrder.ToString();
                            lb_totalPrice.Text = totalPrice.ToString();


                            comboBox2.SelectedValue = "";
                            lb_Goodsname.Text = "";
                            txtQty.Clear();
                        }

                    }
                    else
                    {
                        string sql = "SELECT * FROM GOODS_NAME WHERE Goods_id = '" + comboBox2.SelectedValue.ToString() + "'";
                        DataTable dt = new Cls_DB().GetData(sql, "tbl");
                        if (dt.Rows.Count > 0)
                        {
                            dataGridView1.Rows.Add(dataGridView1.Rows.Count + 1, comboBox2.SelectedValue.ToString(), lb_Goodsname.Text.ToString(), date_due.Value.ToString("dd/MM/yyyy"), date_DL.Value.ToString("dd/MM/yyyy"), Convert.ToInt32(txtQty.Text).ToString(), Convert.ToDecimal(dt.Rows[0]["cost_unit"]), (Convert.ToDecimal(dt.Rows[0]["cost_unit"])) * Convert.ToInt32(txtQty.Text), "ลบ");

                            int totalQtyOrder = 0;
                            decimal totalPrice = 0;

                            foreach (DataGridViewRow row in dataGridView1.Rows)
                            {
                                if (row.Index < dataGridView1.Rows.Count) // ตรวจสอบว่าไม่ใช่แถวสุดท้าย (ที่ใช้สำหรับการเพิ่มข้อมูล)
                                {
                                    totalQtyOrder += Convert.ToInt32(row.Cells["qty"].Value);
                                    totalPrice += Convert.ToDecimal(row.Cells["price_total"].Value);
                                }
                            }

                            lb_totalQtyOrder.Text = totalQtyOrder.ToString();
                            lb_totalPrice.Text = totalPrice.ToString();
                            comboBox2.SelectedValue = "";
                            lb_Goodsname.Text = "";
                            txtQty.Clear();
                        }

                    }


                }
                else
                {
                    MessageBox.Show("กรุณากรอกข้อมูลให้ครบถ้วน");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.Rows.Count > 0)
                {
                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        string sql_Save;
                        sql_Save = "INSERT INTO D_ORDER (Order_no,Goods_id,Ord_date,Fin_date,Amount,COST_UNIT,TOT_PRC) VALUES ('"
                        + lb_Orderno.Text.ToString() + "' , '"
                        + dataGridView1.Rows[i].Cells["goods_no"].Value.ToString() + "' , '"
                        + date_Order.Value.ToString("dd/MM/yyyy") + "' , '"
                        + date_due.Value.ToString("dd/MM/yyyy") + "' , '"
                        + dataGridView1.Rows[i].Cells["qty"].Value.ToString() + "' , '"
                        + dataGridView1.Rows[i].Cells["cost_unit"].Value.ToString() + "' , '"
                        + dataGridView1.Rows[i].Cells["price_total"].Value.ToString() + "')";
                        int a = new Cls_DB().ExecuteData(sql_Save);
                    }
                    MessageBox.Show("บันทึกข้อมูลเรียบร้อย");
                }
                else
                {
                    MessageBox.Show("กรุณาเพิ่มรายการสั่งซื้อ");
                }
                
                comboBox1.Enabled = true;
                lb_Cusname.Enabled = true;
                date_Order.Enabled = true;
                pn_Detail.Visible = false;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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

                if (dataGridView1.Rows[rowIndex].Cells[colIndex].Value.ToString() == "ลบ")
                {
                    if (MessageBox.Show("ต้องการลบข้อมูลสินค้ารหัส '" + Goods_id + "' ใช่หรือไม่ ? ", "ยืนยันการลบ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {

                        dataGridView1.Rows.RemoveAt(rowIndex);

                        MessageBox.Show("ลบข้อมูลเรียบร้อย");

                        int totalQtyOrder = 0;
                        decimal totalPrice = 0;

                        foreach (DataGridViewRow row in dataGridView1.Rows)
                        {
                            if (row.Index < dataGridView1.Rows.Count) // ตรวจสอบว่าไม่ใช่แถวสุดท้าย 
                            {
                                totalQtyOrder -= Convert.ToInt32(row.Cells["qty"].Value);
                                totalPrice -= Convert.ToDecimal(row.Cells["price_total"].Value);
                            }
                        }

                        lb_totalQtyOrder.Text = Math.Abs(totalQtyOrder).ToString();
                        lb_totalPrice.Text = Math.Abs(totalPrice).ToString();

                    }

                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                if (comboBox2.SelectedIndex != -1)
                {
                    string sql = "SELECT * FROM GOODS_NAME WHERE Goods_id = '" + comboBox2.SelectedValue.ToString() + "'";
                    DataTable dt = new Cls_DB().GetData(sql, "tbl");
                    if (dt.Rows.Count > 0)
                    {
                        lb_Goodsname.Text = dt.Rows[0]["Goods_name"].ToString();
                    }

                }
            }
            catch (Exception ex)
            {

            }
        }
    }
}