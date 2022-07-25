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
    public partial class frmDayEndSub : Form
    {
        public frmDayEndSub()
        {
            InitializeComponent();
            forList.ColorDataGridView(dgv, Color.White, Color.WhiteSmoke);
            dgv.RowTemplate.Height = 35;
            dgv.Columns[0].Width = 50;
            dgv.Columns[1].Width = 150;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv.Rows.Count <= 0)
                {
                    MessageBox.Show("No Record", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (ClsGlouble.checkdayend(t_date.Value))
                    {
                        return;
                    }
                    DataSet ds = ClsGlouble.GetDataset("PRO_DATA_MANAGER", new string[] { "ADD_DAY_END", t_date.Value.ToString("yyyy-MM-dd") + "[.,;TNC,;.]" + t_desc.Text.Trim() });
                    int result = ClsGlouble.f_integer(ds.Tables[0].Rows[0]["int_result"]);
                    if (result == 0)
                    {
                        MessageBox.Show(ClsGlouble.f_string(ds.Tables[0].Rows[0]["var_msg"]), "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MessageBox.Show(ClsGlouble.f_string(ds.Tables[0].Rows[0]["var_msg"]), "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.DialogResult = System.Windows.Forms.DialogResult.OK;
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }  
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmCOSub_Load(object sender, EventArgs e)
        {
            t_date.Value = DateTime.Now;
            DataSet tempDs = ClsGlouble.GetDataset("PRO_DATA_MANAGER", new string[] { "ADD_DAY_END_LOAD", t_date.Value.ToString("yyyy-MM-dd") });
            dgv.Rows.Clear();
            tempDs.Tables[0].Rows.Cast<DataRow>().ToList().ForEach(r => dgv.Rows.Add(dgv.Rows.Count + 1, r["int_accid"], r["var_accname"], r["var_desc"], r["dou_in"], r["dou_out"]));
            DataRow row = tempDs.Tables[1].Rows[0];
            t_open.Text = ClsGlouble.f_string(row["dou_open"]);
            t_in.Text = ClsGlouble.f_string(row["dou_in"]);
            t_out.Text = ClsGlouble.f_string(row["dou_out"]);
            t_bal.Text = ClsGlouble.f_string(row["dou_bal"]);
        }
    }
}
