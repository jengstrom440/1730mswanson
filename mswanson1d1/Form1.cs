using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mswanson1d1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtAmountAustraila.Text = "0.00";
            txtAmountBhutan.Text = "0.00";
            txtAmountCostaRica.Text = "0.00";
            txtAmountEuro.Text = "0.00";
            txtAmountKek.Text = "0.00";
            txtRateAustrailia.Text = "0.717976";
            txtRateBhutan.Text = "0.0139831";
            txtRateCostaRica.Text = "0.00176122";
            txtRateEuro.Text = "1.15528";
            txtRateKek.Text = "3.8";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void australiaTextChanged(object sender, EventArgs e)
        {
            txtUSDAustrailia.Text = (
                Convert.ToDecimal(txtAmountAustraila.Text) * Convert.ToDecimal(txtRateAustrailia.Text)
                ).ToString("0.00");
        }

        private void bhutanTextChanged(object sender, EventArgs e)
        {
            txtUSDBhutan.Text = (
               Convert.ToDecimal(txtAmountBhutan.Text) * Convert.ToDecimal(txtRateBhutan.Text)
               ).ToString("0.00");
        }

        private void costaricaTextChanged(object sender, EventArgs e)
        {
            txtUSDCostaRica.Text = (
                Convert.ToDecimal(txtAmountCostaRica.Text) * Convert.ToDecimal(txtRateCostaRica.Text)
                ).ToString("0.00");
        }

        private void euroTextChanged(object sender, EventArgs e)
        {
            txtUSDEuro.Text = (
                Convert.ToDecimal(txtAmountEuro.Text) * Convert.ToDecimal(txtRateEuro.Text)
                ).ToString("0.00");
        }

        private void kekTextChanged(object sender, EventArgs e)
        {
            txtUSDKek.Text = (
                Convert.ToDecimal(txtAmountKek.Text) * Convert.ToDecimal(txtRateKek.Text)
            ).ToString("0.00");
        }

        private void usdTextChanged(object sender, EventArgs e)
        {
            txtTotalUSD.Text = (
                Convert.ToDecimal(txtUSDAustrailia.Text) +
                Convert.ToDecimal(txtUSDBhutan.Text) +
                Convert.ToDecimal(txtUSDCostaRica.Text) +
                Convert.ToDecimal(txtUSDEuro.Text) +
                Convert.ToDecimal(txtUSDKek.Text)
            ).ToString("0.00");
        }
    }
}
