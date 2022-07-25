using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Micro_Finance
{
    public partial class CrystalView : Form
    {
        public ReportDocument RepDoc;
        public string RepName;
        public DataSet ds;
        public CrystalView()
        {
            InitializeComponent();
            this.RepDoc = new ReportDocument();
        }

        private void NEWCUS_RPFRM_Load(object sender, EventArgs e)
        {
            //this.CRV.RefreshReport();
        }
        public void AddDataSet() {
            RepDoc = (ReportDocument)this.GetInstance(RepName);
            RepDoc.SetDataSource(ds);
            CRV.ReportSource = RepDoc;
        }

        public object GetInstance(string vName)
        {
            Type t = Type.GetType("Micro_Finance.REPORTFILE." + vName);
            return Activator.CreateInstance(t);
        }

        private void CRV_Load(object sender, EventArgs e)
        {
            this.AddDataSet();
        }
    }
}
