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
    public partial class frmCOA : Form
    {
        public frmCOA()
        {
            InitializeComponent();
            forList.ColorDataGridView(dgv, Color.White, Color.WhiteSmoke);
            dgv.RowTemplate.Height = 35;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Khmer OS System",9);
            dgv.Columns[0].Width = 35;
        }

        public void LoadData()
        {
            try
            {
                DataSet ds = ClsGlouble.GetDataset("PRO_DATA_MANAGER", new string[] { "LOAD_ACC", "" });
                dgv.Rows.Clear();
                int i = 1;
                ds.Tables[0].Rows.Cast<DataRow>().ToList().ForEach(r =>
                {
                    dgv.Rows.Add(i, r["int_id"], r["var_name"], r["var_type"]);
                    i++;
                });
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
    }
}





