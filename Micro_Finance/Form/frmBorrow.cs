﻿using System;
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
    public partial class frmBorrow : Form
    {
        public int vPage = 1, vPageMax = 1;
        public frmBorrow()
        {
            InitializeComponent();
            forList.ColorDataGridView(dgv, Color.White, Color.WhiteSmoke);
            dgv.RowTemplate.Height = 35;
            dgv.Columns.Clear();
            t_from.Value = DateTime.Now;
            t_to.Value = DateTime.Now;
            b_first.Click += PaginationClick;
            b_pre.Click += PaginationClick;
            b_next.Click += PaginationClick;
            b_last.Click += PaginationClick;
            t_search.KeyPress += t_search_KeyPress;
        }

        private void t_search_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                LoadData("SEARCH");
            }
        }

        void PaginationClick(object sender, EventArgs e)
        {
            if (sender == b_first)
            {
                LoadData("FIRST");
            }
            else if (sender == b_pre)
            {
                LoadData("PRE");
            }
            else if (sender == b_next)
            {
                LoadData("NEXT");
            }
            else if (sender == b_last)
            {
                LoadData("LAST");
            }
        }

        public void LoadData(string pAction)
        {
            try
            {
                string vDateTo = t_to.Value.ToString("yyyy-MM-dd");
                string vDateFrom = t_from.Value.ToString("yyyy-MM-dd");
                string vClear = k_clear.Checked? "1":"0";
                DataSet ds = ClsGlouble.GetDataset("PRO_DATA_MANAGER", new string[] { "LOAD_DATA_LOAN", t_search.Text.Trim() + "[.,;TNC,;.]" + pAction + "[.,;TNC,;.]" + vPage + "[.,;TNC,;.]" + vDateFrom + "[.,;TNC,;.]" + vDateTo + "[.,;TNC,;.]" + vClear });
                dgv.DataSource = ds.Tables[0];
                vPage = ClsGlouble.f_integer(ds.Tables[1].Rows[0]["int_page"]);
                vPageMax = ClsGlouble.f_integer(ds.Tables[1].Rows[0]["int_page_max"]);
                lbPage.Text = vPage + " - " + vPageMax;
                dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Khmer OS System", 9);
                dgv.Columns.Cast<DataGridViewColumn>().ToList().ForEach(c =>
                {
                    c.DefaultCellStyle.Font = new Font("Khmer OS System",9);
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void tsbAdd_Click(object sender, EventArgs e)
        {
            frmBorrowSub frmbs = new frmBorrowSub();
            frmbs.vAction = "ADD";
            frmbs.fCus = this;
            frmbs.ShowDialog();
        }

        private void frmBorrow_Load(object sender, EventArgs e)
        {
            LoadData("SEARCH");
        }

        private void tsbEdit_Click(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count <= 0)
            {
                MessageBox.Show("No Record Selected!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int vId = ClsGlouble.f_integer(dgv.SelectedRows[0].Cells[1].Value);
            DataSet ds = ClsGlouble.GetDataset("PRO_DATA_MANAGER", new string[] { "CHECK_ALLOW_EDIT_LOAN", vId + "" });
            if (ClsGlouble.f_integer(ds.Tables[0].Rows[0]["int_result"]) == 0)
            {
                MessageBox.Show(ClsGlouble.f_string(ds.Tables[0].Rows[0]["var_msg"]), "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else {
                frmBorrowSub frmbs = new frmBorrowSub();
                frmbs.vAction = "SAVE";
                frmbs.t_id.Text = vId + "";
                frmbs.fCus = this;
                frmbs.ShowDialog();
            }

        }

        private void tsbDelete_Click(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count <= 0)
            {
                MessageBox.Show("No Record Selected!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int vId = ClsGlouble.f_integer(dgv.SelectedRows[0].Cells[1].Value);
            DataSet ds = ClsGlouble.GetDataset("PRO_DATA_MANAGER", new string[] { "CHECK_ALLOW_EDIT_LOAN", vId + "" });
            if (ClsGlouble.f_integer(ds.Tables[0].Rows[0]["int_result"]) == 0)
            {
                MessageBox.Show(ClsGlouble.f_string(ds.Tables[0].Rows[0]["var_msg"]), "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                frmBorrowDelete frmbs = new frmBorrowDelete();
                frmbs.vId = vId;
                frmbs.l_title.Text = "លុបឥណទានលេខ " + vId;
                if (frmbs.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
                    LoadData("");
                }
            }
        }

        private void dgvBorrow_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //index = dgvBo.SelectedCells[0].RowIndex;
            //frmPay.BID = int.Parse(dgvBo.Rows[index].Cells[1].Value.ToString());
            //frmPay.cusName = dgvBo.Rows[index].Cells[3].Value + "";
            //frmPay obj = new frmPay();
            //obj.Show();
            
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            LoadData("SEARCH");
        }

        private void bPrintSchedule_Click(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count <= 0) {
                MessageBox.Show("No Record Selected!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DataSet ds = ClsGlouble.GetDataset("PRO_DATA_MANAGER", new string[] { "PRINT_SCHEDULE", ClsGlouble.f_string(dgv.SelectedRows[0].Cells[1].Value) });
            ds.Tables[0].TableName = "RPT";
            CrystalView obj = new CrystalView();
            obj.RepName = "RPT_SCHEDULE";
            obj.ds = ds;
            obj.ShowDialog();
        }

        private void bPrintHistory_Click(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count <= 0)
            {
                MessageBox.Show("No Record Selected!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            frmAlert obj = new frmAlert();
            obj.vId = ClsGlouble.f_integer(dgv.SelectedRows[0].Cells[1].Value);
            obj.ShowDialog();
        }

        private void dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) {
                int vId = ClsGlouble.f_integer(dgv.SelectedRows[0].Cells[1].Value);
                frmPay frmco = new frmPay();
                frmco.MdiParent = this.MdiParent;
                frmco.t_id.Text = vId + "";
                frmco.WindowState = FormWindowState.Maximized;
                this.Close();
                frmco.Show();
                frmco.LoadData();
            }
        }

   
    }
}
