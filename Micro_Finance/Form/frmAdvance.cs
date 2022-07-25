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
    public partial class frmAdvance : Form
    {
        public frmAdvance()
        {
            InitializeComponent();
            forList.ColorDataGridView(dgv, Color.White, Color.WhiteSmoke);
            dgv.RowTemplate.Height = 35;
            dgv.ColumnHeadersDefaultCellStyle.Font = t_date.Font;
            dgv.Columns[0].Width = 35;
        }

        public void LoadData()
        {
            try
            {
                string vDate = t_date.Value.ToString("yyyy-MM-dd");
                DataSet ds = ClsGlouble.GetDataset("PRO_DATA_MANAGER", new string[] { "LOAD_STAFF_ADVANCE", vDate });
                dgv.Rows.Clear();
                int i = 1;
                ds.Tables[0].Rows.Cast<DataRow>().ToList().ForEach(r =>
                {
                    dgv.Rows.Add(i, r["int_id"], r["int_accid"], r["var_accname"], r["var_desc"], r["dou_amt"]);
                    i++;
                });
                t_total.Text = ClsGlouble.f_string(ds.Tables[1].Rows[0][0]);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void frmCus_Load(object sender, EventArgs e)
        {
            t_date.Value = DateTime.Now;
        }

        private void tsbAdd_Click(object sender, EventArgs e)
        {
            if (ClsGlouble.checkdayend(t_date.Value))
            {
                return;
            }
            frmAdvanceSub obj = new frmAdvanceSub();
            obj.vAction = "ADD";
            obj.fCo = this;
            obj.ShowDialog();
        }

        private void tsbEdit_Click(object sender, EventArgs e)
        {
            if (dgv.CurrentCell != null)
            {
                if (ClsGlouble.checkdayend(t_date.Value))
                {
                    return;
                }
                DataGridViewRow r = dgv.Rows[dgv.CurrentCell.RowIndex];
                frmAdvanceSub obj = new frmAdvanceSub();
                obj.vAction = "EDIT";
                obj.fCo = this;
                obj.t_id.Text = r.Cells[1].Value.ToString();
                obj.ShowDialog();
                LoadData();
            }
            else
            {
                MessageBox.Show("No Row Selected!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void tsbDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv.CurrentCell != null)
                {
                    DialogResult dr;
                    dr = MessageBox.Show("Do You Want to Delete This Once?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        if (ClsGlouble.checkdayend(t_date.Value))
                        {
                            return;
                        }
                        int id = ClsGlouble.f_integer(dgv.Rows[dgv.CurrentCell.RowIndex].Cells[1].Value);
                        DataSet ds = ClsGlouble.GetDataset("PRO_DATA_MANAGER", new string[] { "DELETE_STAFF_ADVANCE", id + "" });
                        int result = ClsGlouble.f_integer(ds.Tables[0].Rows[0]["int_result"]);
                        if (result == 0)
                        {
                            MessageBox.Show(ClsGlouble.f_string(ds.Tables[0].Rows[0]["var_msg"]), "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            MessageBox.Show(ClsGlouble.f_string(ds.Tables[0].Rows[0]["var_msg"]), "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadData();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("No Row Selected!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void t_date_ValueChanged(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}





