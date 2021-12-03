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
    public partial class FrmIMC : Form
    {
        public FrmIMC()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmIMC_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txtaltura;
            txtaltura.Focus();
        }

        private void txtaltura_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44)
            {
                e.Handled = true;
            }
        }

        private void txtpeso_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44)
            {
                e.Handled = true;
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Double peso, altura, resultado;
            if (txtaltura.Text == "" || txtpeso.Text =="")
            {
                MessageBox.Show("Não há calculos sem valores! Por favor, digite os campos altura e peso!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                altura = Convert.ToDouble(txtaltura.Text);
                peso = Convert.ToDouble(txtpeso.Text);
                resultado = peso / (altura * altura);
                lblIMCResult.Text = resultado.ToString("F");
                txtaltura.Text = "";
                txtpeso.Text = "";
                if (resultado < 18.5)
                {
                    lblIMCResultado.Text = "Abaixo do peso";
                }
                else if (resultado > 18.49 && resultado <= 25)
                {
                    lblIMCResultado.Text = "Peso ideal (parabéns)";
                }
                else if (resultado > 25 && resultado <= 30)
                {
                    lblIMCResultado.Text = "Levemente acima do peso";
                }
                else if (resultado > 30 && resultado <= 35)
                {
                    lblIMCResultado.Text = "Obesidade grau I";
                }
                else if (resultado > 35 && resultado <= 40)
                {
                    lblIMCResultado.Text = "Obesidade grau II (severa)";
                }
                else
                {
                    lblIMCResultado.Text = "Obesidade grau III (mórbida)";
                }
            }
        }
    }
}
