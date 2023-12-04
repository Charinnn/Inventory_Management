using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace Inventory_Management
{
    public partial class frmReport : Form
    {
        public frmReport()
        {
            InitializeComponent();
        }

        private void btnShow_data_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = $"SELECT H_ORDER.* , D_ORDER.*  FROM H_ORDER, D_ORDER WHERE H_ORDER.Order_no = D_ORDER.Order_no AND D_ORDER.Ord_date >= '{dateTimePicker1.Value}' AND D_ORDER.Ord_date <=  '{dateTimePicker2.Value}' ";
                DataTable dt = new Cls_DB().GetData(sql, "tbl");

                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        dataGridView1.Rows.Add(dataGridView1.Rows.Count + 1, dt.Rows[i]["Cus_id"].ToString(), dt.Rows[i]["Goods_id"].ToString(), dataGridView1.Rows.Count + 1, dt.Rows[0]["Ord_date"].ToString(), dt.Rows[0]["Order_no"].ToString(), dt.Rows[0]["Fin_date"].ToString(), dt.Rows[0]["Amount"].ToString(), dt.Rows[0]["COST_UNIT"].ToString(), dt.Rows[0]["TOT_PRC"].ToString());
                    }
                }
                else
                {
                    MessageBox.Show("ไม่พบข้อมูล");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {

                if (dataGridView1.Rows.Count > 0)
                {
                    DataTable dt = dataGridView1.DataSource as DataTable;
                    SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                    saveFileDialog1.Filter = "Excel Documents (*.xls)|*.xls";
                    string FileName = "Inventory_Report.xls";
                    saveFileDialog1.FileName = FileName;

                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        string fname = saveFileDialog1.FileName;

                        StreamWriter wr = new StreamWriter(fname);

                        int iHeader = dataGridView1.Columns.Count;
                        for (int i = 1; i < iHeader; i++)
                        {
                            if (dataGridView1.Columns[i].Name.ToString().ToUpper() != null && dataGridView1.Columns[i].Visible)
                            {
                                wr.Write(dataGridView1.Columns[i].Name.ToString().ToUpper() + "\t");
                            }
                        }
                        wr.WriteLine();

                        //write rows to excel file
                        for (int i = 0; i < (dataGridView1.Rows.Count); i++)
                        {
                            for (int j = 1; j < dataGridView1.Rows[i].Cells.Count; j++)
                            {
                                if (dataGridView1.Rows[i].Cells[j].Value != null && dataGridView1.Columns[j].Visible)
                                {
                                    wr.Write(Convert.ToString(dataGridView1.Rows[i].Cells[j].Value) + "\t");
                                }
                            }
                            //go to next line
                            wr.WriteLine();
                        }
                        //close file
                        wr.Close();

                        // Open Excel after export success
                        if (File.Exists(fname))
                        {
                            System.Diagnostics.Process.Start(fname);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("ไม่พบข้อมูลรายงาน Excell", "ไม่พบข้อมูล", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show(ex.Message);
                
            }
        }
    }
}
