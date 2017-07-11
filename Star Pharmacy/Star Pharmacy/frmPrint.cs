using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Star_Pharmacy
{
    public partial class frmPrint : Form
    {
        public List<PrintBill> _list;
        public string _total, _cash, _change, _date,_invoiceNo;
        public frmPrint(List<PrintBill> dataSource,String total,String cash,String change,String date, String invoiceNO)
        {
            InitializeComponent();
            _list = dataSource;
            _total = total;
            _cash = cash;
            _change = change;
            _date = date;
            _invoiceNo = invoiceNO;


        }

        private void frmPrint_Load(object sender, EventArgs e)
        {
            
            this.reportViewer1.RefreshReport();
        }
    }
}
