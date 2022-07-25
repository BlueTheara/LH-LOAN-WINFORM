using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using forListBox;

namespace Micro_Finance
{
    public partial class frmDayEnd : Form
    {
        public frmDayEnd()
        {
            InitializeComponent();
            forList.ColorDataGridView(dgv, Color.White, Color.WhiteSmoke);
            dgv.RowTemplate.Height = 35;
            dgv.ColumnHeadersDefaultCellStyle.Font = label1.Font;
            dgv.Columns[0].Width = 35;
            c_year.SelectedItem = DateTime.Now.Year.ToString();
            c_month.SelectedItem = DateTime.Now.Month.ToString();
            c_year.SelectedIndexChanged += c_year_SelectedIndexChanged;
            c_month.SelectedIndexChanged += c_year_SelectedIndexChanged;
            b_print_daily.Click += b_print_daily_Click;
            b_print_monthly_det.Click += b_print_daily_Click;
            b_print_monthly_sum.Click += b_print_daily_Click;
        }

        void b_print_daily_Click(object sender, EventArgs e)
        {
            if (dgv.Rows.Count <= 0)
            {
                MessageBox.Show("No Record", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else {
                if (sender == b_print_daily) {
                    DataSet ds = ClsGlouble.GetDataset("PRO_DATA_MANAGER", new string[] { "PRINT_DAY_END_DAILY", ClsGlouble.f_integer(dgv.SelectedRows[0].Cells[1].Value) + "" });
                    ds.Tables[0].TableName = "RPT";
                    CrystalView obj = new CrystalView();
                    obj.RepName = "RPT_DAY_END";
                    obj.ds = ds;
                    obj.ShowDialog();
                }
                else if (sender == b_print_monthly_sum) {
                    int vYear = ClsGlouble.f_integer(c_year.SelectedItem);
                    int vMonth = ClsGlouble.f_integer(c_month.SelectedItem);
                    DataSet ds = ClsGlouble.GetDataset("PRO_DATA_MANAGER", new string[] { "PRINT_DAY_END_MONTHLY_SUM", vYear + "[.,;TNC,;.]" + vMonth });
                    ds.Tables[0].TableName = "RPT";
                    CrystalView obj = new CrystalView();
                    obj.RepName = "RPT_DAY_END1";
                    obj.ds = ds;
                    obj.ShowDialog();
                }
                else if (sender == b_print_monthly_det)
                {
                    int vYear = ClsGlouble.f_integer(c_year.SelectedItem);
                    int vMonth = ClsGlouble.f_integer(c_month.SelectedItem);
                    DataSet ds = ClsGlouble.GetDataset("PRO_DATA_MANAGER", new string[] { "PRINT_DAY_END_MONTHLY_BY_ACC", vYear + "[.,;TNC,;.]" + vMonth });
                    ds.Tables[0].TableName = "RPT";
                    CrystalView obj = new CrystalView();
                    obj.RepName = "RPT_DAY_END";
                    obj.ds = ds;
                    obj.ShowDialog();
                }
            }
        }

        void c_year_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        public void LoadData()
        {
            try
            {
                int vYear = ClsGlouble.f_integer(c_year.SelectedItem);
                int vMonth = ClsGlouble.f_integer(c_month.SelectedItem);
                DataSet ds = ClsGlouble.GetDataset("PRO_DATA_MANAGER", new string[] { "LOAD_DAY_END", vYear + "[.,;TNC,;.]" + vMonth });
                dgv.Rows.Clear();
                int i = 1;
                ds.Tables[0].Rows.Cast<DataRow>().ToList().ForEach(r =>
                {
                    dgv.Rows.Add(i, r["int_id"], r["dat_date"], r["var_desc"], r["dou_opening"], r["dou_in"], r["dou_out"], r["dou_bal"]);
                    i++;
                });
                t_open.Text = ClsGlouble.f_string(ds.Tables[1].Rows[0]["dou_opening"]);
                t_in.Text = ClsGlouble.f_string(ds.Tables[1].Rows[0]["dou_in"]);
                t_out.Text = ClsGlouble.f_string(ds.Tables[1].Rows[0]["dou_out"]);
                t_bal.Text = ClsGlouble.f_string(ds.Tables[1].Rows[0]["dou_bal"]);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void frmCus_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void tsbAdd_Click(object sender, EventArgs e)
        {
            if (ClsGlouble.checkdayend(DateTime.Now))
            {
                return;
            }
            frmDayEndSub obj = new frmDayEndSub();
            obj.ShowDialog();
            LoadData();
        }
    }
}





