using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CircodeApp
{
    public partial class FrmCarro : Form
    {
        public FrmCarro()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double gasolina = Convert.ToDouble(txtGasolina.Text);
            double alcool = Convert.ToDouble(txtAlcool.Text);
            double distancia = Convert.ToDouble(txtTrecho.Text);
            double mediagas = Convert.ToDouble(txtConsumoGas.Text);
            double mediaalc = Convert.ToDouble(txtConsumoAlc.Text);
            double resultgas = (distancia / mediagas) * gasolina;
            double resultalc = (distancia / mediaalc) * alcool;

            if (resultgas > resultalc)
            {
                lblGasBest.Text = "Álcool";
                lblPrice.Text = resultalc.ToString("n2");
            }
            else
            {
                lblGasBest.Text = "Gasolina";
                lblPrice.Text = resultgas.ToString("n2");
            }
            txtGasolina.Text = "";
            txtAlcool.Text = "";
            txtTrecho.Text = "";
            txtConsumoGas.Text = "";
            txtConsumoAlc.Text = "";
        }

        private void txtAlcool_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44)
            {
                e.Handled = true;
            }
        }

        private void txtGasolina_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44)
            {
                e.Handled = true;
            }
        }

        private void txtTrecho_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44)
            {
                e.Handled = true;
            }
        }

        private void txtConsumoGas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44)
            {
                e.Handled = true;
            }
        }

        private void txtConsumoAlc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44)
            {
                e.Handled = true;
            }
        }

        private void FrmCarro_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txtAlcool;
            txtAlcool.Focus();
        }
    }
}
