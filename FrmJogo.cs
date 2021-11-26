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
    public partial class FrmJogo : Form
    {
        public FrmJogo()
        {
            InitializeComponent();
        }

        private void FrmJogo_Click(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbxOpcao_SelectedIndexChanged(object sender, EventArgs e)
        {
            int opcao = cbxOpcao.SelectedIndex;
            switch (opcao)
            {
                case 0:
                    pbxOpcao.Image = Properties.Resources.papel;
                break;
                case 1:
                    pbxOpcao.Image = Properties.Resources.pedra;
                break;
                case 2:
                    pbxOpcao.Image = Properties.Resources.tesoura;
                break;
            }
        }

        private void btnJogar_Click(object sender, EventArgs e)
        {
            int opcao = cbxOpcao.SelectedIndex;
            Random randonum = new Random();
            int sorteio = Convert.ToInt32(randonum.Next(3));
            switch (sorteio)
            {
                case 0:
                    pbxJogo.Image = Properties.Resources.papel;
                    break;
                case 1:
                    pbxJogo.Image = Properties.Resources.pedra;
                    break;
                case 2:
                    pbxJogo.Image = Properties.Resources.tesoura;
                    break;
            }
            if (opcao == 0 && sorteio == 1 || opcao == 1 && sorteio == 2 || opcao == 2 && sorteio == 0)
            {
                MessageBox.Show("Você ganhou!","Resultado :D",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else if (opcao == 0 && sorteio == 2 || opcao == 1 && sorteio == 0 || opcao == 2 && sorteio == 1)
            {
                MessageBox.Show("Você perdeu!","Resultado :(",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Você empatou!","Resultado :|",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }
    }
}
