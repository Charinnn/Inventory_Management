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
    public partial class frmEdit_Goods : Form
    {
        public string Goods_id { get; set; }
        public string Goods_name { get; set; }
        public decimal Cost { get; set; }
        public frmEdit_Goods()
        {
            InitializeComponent();
        }

        private void frmEdit_Good_Load(object sender, EventArgs e)
        {
            try
            {
                txtGoods_id.Text = Goods_id;
                txtGoods_name.Text = Goods_name;
                txtPrice.Text = Convert.ToString(Cost);
            }
            catch (Exception ex)
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string sql_Update;
                if (txtGoods_id.Text != "" && txtGoods_name.Text != "" && txtPrice.Text != "")
                {

                    if (Convert.ToDecimal(txtPrice.Text) > 0 & Convert.ToDecimal(txtPrice.Text) <= 999999.99M)
                    {
                        double priceValue;
                        if (double.TryParse(txtPrice.Text, out priceValue))
                        {
                            sql_Update = "UPDATE GOODS_NAME SET ";
                            sql_Update += "Goods_id = '" + txtGoods_id.Text.Trim() + "'";
                            sql_Update += ",Goods_name = '" + txtGoods_name.Text.Trim() + "'";
                            sql_Update += ",cost_unit = '" + priceValue.ToString() + "'";
                            sql_Update += " WHERE Goods_id = '" + txtGoods_id.Text.Trim() + "'";

                            int rowsAffected = new Cls_DB().ExecuteData(sql_Update);

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("บันทึกการแก้ไขเรียบร้อย");
                            }
                            else
                            {
                                MessageBox.Show("ไม่พบข้อมูลหรือมีข้อผิดพลาดในการบันทึกการแก้ไข");
                            }
                        }

                    }
                    else
                    {
                        MessageBox.Show("ราคาที่กำหนดไม่ถูกต้อง");
                    }

                }
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
