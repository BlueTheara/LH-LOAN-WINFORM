﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Reporting.WinForms;
using forListBox;
namespace Micro_Finance
{
    public partial class frmNewCus : Form
    {
        public bool vDet = false;
        public frmNewCus()
        {
            InitializeComponent();
            forList.ColorDataGridView(dgv, Color.White, Color.WhiteSmoke);
            dgv.RowTemplate.Height = 30;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadData(0);
        }

        private void frmCOIncome_Load(object sender, EventArgs e)
        {
            DataSet ds = ClsGlouble.GetDataset("PRO_DATA_MANAGER", new string[] { "LOAD_FORM_DAILY", "" });
            c_co_id.DisplayMember = "int_id";
            c_co_id.ValueMember = "int_id";
            c_co_id.DataSource = ds.Tables[0];

            c_co_name.DisplayMember = "var_name";
            c_co_name.ValueMember = "int_id";
            c_co_name.DataSource = ds.Tables[0];
            t_from.Value = DateTime.Now;
            t_to.Value = DateTime.Now;
        }

        private void LoadData(int vAllCo)
        {
            string vDateTo = t_to.Value.ToString("yyyy-MM-dd");
            string vDateFrom = t_from.Value.ToString("yyyy-MM-dd");
            int vCoid = ClsGlouble.f_integer(c_co_id.SelectedValue);
            DataSet ds = ClsGlouble.GetDataset("PRO_DATA_MANAGER", new string[] { "LOAD_CO_NEW_CUS", vAllCo + "[.,;TNC,;.]" + vCoid + "[.,;TNC,;.]" + vDateFrom + "[.,;TNC,;.]" + vDateTo + "[.,;TNC,;.]" + (this.vDet ? "DET" : "SUM") });
            dgv.DataSource = ds.Tables[0].Copy();
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
                        c.HeaderText = "លេខកូដអតិថិជន";
                        break;
                    case "var_cusname":
                        c.HeaderText = "ឈ្មោះអតិថិជន";
                        break;
                    case "int_coid":
                        c.HeaderText = "លេខCO";
                        break;
                    case "var_coname":
                        c.HeaderText = "ឈ្មោះCO";
                        break;
                    case "dou_total":
                        c.HeaderText = "ប្រាក់បញ្ចេញសរុប";
                        break;
                    case "dou_prin":
                        c.HeaderText = "ប្រាក់ដើមបញ្ចេញ";
                        break;
                    case "dou_int":
                        c.HeaderText = "ការប្រាក់បញ្ចេញ";
                        break;
                    case "dat_date":
                        c.HeaderText = "ថ្ងៃបញ្ចេញប្រាក់";
                        break;
                    case "var_type":
                        c.HeaderText = "ប្រភេទ";
                        break;
                    case "int_cus_count":
                        c.HeaderText = "ចំនួនអតិថិជន";
                        break;
                    case "var_tel":
                        c.HeaderText = "លេខទូរស៍ព្ធ";
                        break;
                    default:
                        c.Visible = false;
                        break;
                }
            });

            if (ds.Tables[1].Rows.Count <= 0)
            {
                ClsGlouble.ClearCtrl(new Control[] { t_total, t_count, t_prin, t_int });
            }
            else
            {
                DataRow r = ds.Tables[1].Rows[0];
                t_total.Text = ClsGlouble.f_string(r["dou_total"]);
                t_int.Text = ClsGlouble.f_string(r["dou_int"]);
                t_prin.Text = ClsGlouble.f_string(r["dou_prin"]);
                t_count.Text = ClsGlouble.f_string(r["int_cus_count"]);
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            LoadData(1);
        }

        private void btnPrintTow_Click(object sender, EventArgs e)
        {
            LoadDataPrint(0);
        }

        private void b_print_all_Click(object sender, EventArgs e)
        {
            LoadDataPrint(1);
        }

        private void LoadDataPrint(int vAllCo)
        {
            string vDateTo = t_to.Value.ToString("yyyy-MM-dd");
            string vDateFrom = t_from.Value.ToString("yyyy-MM-dd");
            int vCoid = ClsGlouble.f_integer(c_co_id.SelectedValue);
            DataSet ds = ClsGlouble.GetDataset("PRO_DATA_MANAGER", new string[] { "LOAD_CO_NEW_CUS", vAllCo + "[.,;TNC,;.]" + vCoid + "[.,;TNC,;.]" + vDateFrom + "[.,;TNC,;.]" + vDateTo + "[.,;TNC,;.]" + (this.vDet ? "DET" : "SUM") });

            if (vAllCo == 0 && c_co_id.SelectedIndex < 0)
            {
                MessageBox.Show("Please Select CO_ID!");
                return;
            }

            ds.Tables[0].TableName = "RPT";
            CrystalView obj = new CrystalView();
            obj.RepName = vDet ? "RPT_CO_CUS_DET" : "RPT_CO_CUS_MAS";
            obj.ds = ds;
            obj.ShowDialog();
        }
    }
}
