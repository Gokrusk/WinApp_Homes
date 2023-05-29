using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinApp_Homes {
    public partial class ReportesForm : Form {
        readonly string PathFile = Application.StartupPath + "\\assets\\files\\";

        public ReportesForm() {
            InitializeComponent();
            dataSetVenta.ReadXml(PathFile + "clientes.xml");
        }

        private void ReportesForm_Load(object sender, EventArgs e) {
            this.reportViewer1.RefreshReport();
        }
    }
}
