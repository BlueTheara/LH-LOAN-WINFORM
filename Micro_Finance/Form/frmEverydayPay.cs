using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using System.Data.SqlClient;
using forListBox;
namespace Micro_Finance
{
    public partial class frmEverydayPay : Form
    {
        DataSet ds;
        public frmEverydayPay()
        {
            InitializeComponent();
            forList.ColorDataGridView(dgv, Color.White, Color.WhiteSmoke);
            dgv.RowTemplate.Height = 30;
            t_date.Value = DateTime.Now;
            t_date.ValueChanged += t_date_ValueChanged;
        }

        void t_date_ValueChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        private void frmEverydayPay_Load(object sender, EventArgs e)
        {
            ds = ClsGlouble.GetDataset("PRO_DATA_MANAGER", new string[] { "LOAD_FORM_DAILY", "" });
            c_co_id.DisplayMember = "int_id";
            c_co_id.ValueMember = "int_id";
            c_co_id.DataSource = ds.Tables[0];

            c_co_name.DisplayMember = "var_name";
            c_co_name.ValueMember = "int_id";
            c_co_name.DataSource = ds.Tables[0];

        }   

        private void button1_Click(object sender, EventArgs e)
        {
            ViewReport(0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ViewReport(1);
        }

        private void ViewReport(int vAllCo) {
            if (vAllCo == 0 && c_co_id.SelectedIndex < 0) {
                MessageBox.Show("Please Select CO_ID!");
                return;
            }
            int vCoId = vAllCo == 1 ? 0 : ClsGlouble.f_integer(c_co_id.SelectedValue);
            int vCheckLate = k_late.Checked ? 1 : 0;
            int vLateFrom = ClsGlouble.f_integer(t_late_from.Text.Trim());
            int vLateTo = ClsGlouble.f_integer(t_late_to.Text.Trim());
            string vDate = t_date.Value.ToString("yyyy-MM-dd");
            DataSet temp_ds = ClsGlouble.GetDataset("PRO_DATA_MANAGER", new string[] { "LOAD_DATA_DAILY_PAY", vAllCo + "[.,;TNC,;.]" + vCoId + "[.,;TNC,;.]" + vCheckLate + "[.,;TNC,;.]" + vLateFrom + "[.,;TNC,;.]" + vLateTo + "[.,;TNC,;.]" + vDate });
            temp_ds.Tables[0].TableName = "RPT";
            CrystalView obj = new CrystalView();
            obj.RepName = vAllCo == 0 ? "RPT_CO_DAILY" : "RPT_CO_DAILY_ALL";
            obj.ds = temp_ds;
            obj.ShowDialog();
        }

        private void chLate_CheckedChanged(object sender, EventArgs e)
        {
            t_late_from.Enabled = k_late.Checked ? true : false;
            t_late_to.Enabled = k_late.Checked ? true : false;
        }

        private void txtFLate_KeyPress(object sender, KeyPressEventArgs e)
        {
            ClsGlouble.IntegerInput(e, t_late_from);
        }

        private void txtToLate_KeyPress(object sender, KeyPressEventArgs e)
        {
            ClsGlouble.IntegerInput(e, t_late_to);
        }

        private void cmbCOID_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData(){
            if (c_co_id.SelectedIndex < 0)
            {
                dgv.DataSource = null;
                return;
            }
            int vId = ClsGlouble.f_integer(c_co_id.SelectedValue);
            int vAllCo = 0;
            int vCheckLate = k_late.Checked ? 1 : 0;
            int vLateFrom = ClsGlouble.f_integer(t_late_from.Text.Trim());
            int vLateTo = ClsGlouble.f_integer(t_late_to.Text.Trim());
            string vDate = t_date.Value.ToString("yyyy-MM-dd");
            DataSet temp_ds = ClsGlouble.GetDataset("PRO_DATA_MANAGER", new string[] { "LOAD_DATA_DAILY_PAY", vAllCo + "[.,;TNC,;.]" + vId + "[.,;TNC,;.]" + vCheckLate + "[.,;TNC,;.]" + vLateFrom + "[.,;TNC,;.]" + vLateTo + "[.,;TNC,;.]" + vDate });
            dgv.DataSource = temp_ds.Tables[0];
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Khmer OS System", 9);
            dgv.Columns.Cast<DataGridViewColumn>().ToList().ForEach(c =>
            {
                c.DefaultCellStyle.Font = new Font("Khmer OS System", 9);
                switch (c.Name)
                {
                    case "int_line":
                        c.HeaderText = "ល រ";
                        break;
                    case "int_id":
                        c.HeaderText = "លេខកូដ";
                        break;
                    case "int_cusid":
                        c.HeaderText = "IDអតិថិជន";
                        break;
                    case "var_cusname":
                        c.HeaderText = "ឈ្មោះអតិថិជន";
                        break;
                    case "var_tel":
                        c.HeaderText = "ទូរស័ព្ធ";
                        break;
                    case "var_addr":
                        c.HeaderText = "អាស័យដ្ឋាន";
                        break;
                    case "int_coid":
                        c.HeaderText = "លេខCO";
                        break;
                    case "var_coname":
                        c.HeaderText = "ឈ្មោះCO";
                        break;
                    case "dou_amt":
                        c.HeaderText = "ប្រាក់ខ្ចី";
                        break;
                    case "dat_date":
                        c.HeaderText = "ថ្ងៃខ្ចី";
                        break;
                    case "dat_pay":
                        c.HeaderText = "កាលបរិច្ឆែត";
                        break;
                    case "dou_total":
                        c.HeaderText = "ប្រាក់ត្រូវបង់";
                        break;
                    case "var_type":
                        c.HeaderText = "ប្រភេទ";
                        break;
                    case "int_paid":
                        c.HeaderText = "ថ្ងៃបង់រួច";
                        break;
                    case "int_bal":
                        c.HeaderText = "ថ្ងៃនៅសល់";
                        break;
                    case "int_late":
                        c.HeaderText = "យឹត";
                        break;
                    case "dou_extra":
                        c.HeaderText = "ប្រាក់បង់លើស";
                        break;
                    case "dou_total_pay":
                        c.HeaderText = "ប្រាក់ត្រូវបង់សរុប";
                        break;
                    default:
                        c.Visible = false;
                        break;
                }
            });
            t_count.Text = dgv.Rows.Count + "";
        }
    }
}
