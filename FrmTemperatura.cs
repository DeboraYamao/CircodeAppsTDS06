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
    public partial class FrmTemperatura : Form
    {
        public FrmTemperatura()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConverter_Click(object sender, EventArgs e)
        {
            int opcao = cbxOpcao.SelectedIndex;
            double temperatura = Convert.ToDouble(txtTemperatura.Text);

            switch (opcao)
            {
                case 0:
                    lblEscala.Text = "Fahrenheit"; 
                    double resultFah = (temperatura - 32) * 5 / 9;
                    lblResult.Text = resultFah.ToString("F");
                    break;
                case 1:
                    lblEscala.Text = "Celcius";
                    double resultCel = (temperatura * 1.8) + 32;
                    lblResult.Text = resultCel.ToString("F");
                    break;
            }          
         }

        private void FrmTemperatura_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txtTemperatura;
            txtTemperatura.Focus();
        }
    }
}
