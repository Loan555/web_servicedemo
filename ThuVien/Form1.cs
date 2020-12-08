using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThuVien
{
    public partial class Form1 : Form
    {
        private ServiceReference1.WebService1SoapClient ws;
        public Form1()
        {
            InitializeComponent();
            ws = new ServiceReference1.WebService1SoapClient();
        }

        private void VND2USD_Click(object sender, EventArgs e)
        {
            double mon = Double.Parse(txtMoney.Text);

            double usd = ws.VND2USD(mon);

            lblKetQua.Text = usd.ToString();
        }

        private void VND2EUR_Click(object sender, EventArgs e)
        {
            double mon = Double.Parse(txtMoney.Text);

            double usd = ws.VND2EUR(mon);

            lblKetQua.Text = usd.ToString();
        }

        private void USD2VND_Click(object sender, EventArgs e)
        {
            double mon = Double.Parse(txtMoney.Text);

            double usd = ws.USD2VND(mon);

            lblKetQua.Text = usd.ToString();
        }

        private void EUR2VND_Click(object sender, EventArgs e)
        {
            double mon = Double.Parse(txtMoney.Text);

            double usd = ws.EUR2VND(mon);

            lblKetQua.Text = usd.ToString();
        }
    }
}
