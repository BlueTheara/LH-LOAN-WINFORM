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

namespace Micro_Finance
{
    public partial class frmDepositSub : Form
    {
        public frmDepositSub()
        {
            InitializeComponent();
        }
        public string vAction = "ADD";
        public frmDeposit fCo;
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if ( t_desc.Text == "" || t_amt.Text == "" || c_coa.SelectedIndex < 0)
                {
                    MessageBox.Show("Please Input All the Informations !!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (ClsGlouble.checkdayend(t_date.Value))
                    {
                        return;
                    }
                    DataSet ds = ClsGlouble.GetDataset("PRO_DATA_MANAGER", new string[] { "ADD_CAPITAL_DEPOSIT", vAction + "[.,;TNC,;.]" + ClsGlouble.f_integer(t_id.Text.Trim()) + "[.,;TNC,;.]" + ClsGlouble.f_integer(c_coa.SelectedValue) + "[.,;TNC,;.]" + t_date.Value.ToString("yyyy-MM-dd") + "[.,;TNC,;.]" + t_desc.Text.Trim() + "[.,;TNC,;.]" + ClsGlouble.f_double(t_amt.Text.Trim()) });
                    int result = ClsGlouble.f_integer(ds.Tables[0].Rows[0]["int_result"]);
                    if (result == 0)
                    {
                        MessageBox.Show(ClsGlouble.f_string(ds.Tables[0].Rows[0]["var_msg"]), "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MessageBox.Show(ClsGlouble.f_string(ds.Tables[0].Rows[0]["var_msg"]), "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (vAction.Equals("ADD"))
                        {
                            fCo.LoadData();
                            t_id.Text = "";
                            t_desc.Text = "";
                            t_amt.Text = "";
                            c_coa.SelectedIndex = -1;
                            c_coa.Focus();
                        }
                        else
                        {
                            this.Close();
                        }
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
            t_date.Value = fCo.t_date.Value;
            DataSet tempDs = ClsGlouble.GetDataset("PRO_DATA_MANAGER", new string[] { "ADD_CAPITAL_DEPOSIT_LOAD", ClsGlouble.f_integer(t_id.Text.Trim()) + "" });
            c_coa.DataSource = tempDs.Tables[0];
            c_coa.DisplayMember = "var_name";
            c_coa.ValueMember = "int_id";
            if (vAction.Equals("EDIT"))
            {
                DataRow r = tempDs.Tables[1].Rows[0];
                t_id.Text = ClsGlouble.f_string(r["int_id"]);
                t_desc.Text = ClsGlouble.f_string(r["var_desc"]);
                t_amt.Text = ClsGlouble.f_string(r["dou_amt"]);
                t_date.Value = DateTime.ParseExact(ClsGlouble.f_string(r["dat_date"]), "yyyy-MM-dd", null);
                c_coa.SelectedValue = ClsGlouble.f_integer(r["int_accid"]);
                c_coa.Focus();
            }
        }

        private void t_amt_KeyPress(object sender, KeyPressEventArgs e)
        {
            ClsGlouble.DoubleInput(e, t_amt);
        }
    }
}
