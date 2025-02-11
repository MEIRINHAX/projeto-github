using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Data;

namespace M11_Ficha3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<funcionarioN1> ListafuncionarioN1 = new List<funcionarioN1>();
        List<funcionarioN2> ListafuncionarioN2 = new List<funcionarioN2>();
        List<funcionarioN3> ListafuncionarioN3 = new List<funcionarioN3>();

        private void btninserir_Click(object sender, EventArgs e)
        {

            int telefone;
            int idade;

            // Verificar se o valor introduzido no telefone é um número válido
            if (!int.TryParse(txttele.Text, out telefone))
            {
                MessageBox.Show("Por favor, insira apenas números no campo Telefone.", "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Interrompe a execução do código
            }

            // Verificar se o valor introduzido no telefone é um número válido
            if (!int.TryParse(txtidade.Text, out idade))
            {
                MessageBox.Show("Por favor, insira apenas números no campo Idade.", "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Interrompe a execução do código
            }

            switch ((cbotipo.Text))
            {
                case "N1":
                    funcionarioN1 funcionarioN1 = new funcionarioN1();
                    funcionarioN1.NomeP = txtnome.Text;
                    funcionarioN1.IdadeP = int.Parse(txtidade.Text);
                    funcionarioN1.TelefoneP = int.Parse(txttele.Text);
                    funcionarioN1.TipofuncP = cbotipo.Text;
                    funcionarioN1.valor = funcionarioN1.ParticipacaoLucro();
                    ListafuncionarioN1.Add(funcionarioN1);
                    break;

                case "N2":
                    funcionarioN2 funcionarioN2 = new funcionarioN2();
                    funcionarioN2.NomeP = txtnome.Text;
                    funcionarioN2.IdadeP = int.Parse(txtidade.Text);
                    funcionarioN2.TelefoneP = int.Parse(txttele.Text);
                    funcionarioN2.TipofuncP = cbotipo.Text;
                    funcionarioN2.valor = funcionarioN2.ParticipacaoLucro();
                    ListafuncionarioN2.Add(funcionarioN2);
                    break;

                case "N3":
                    funcionarioN3 funcionarioN3 = new funcionarioN3();
                    funcionarioN3.NomeP = txtnome.Text;
                    funcionarioN3.IdadeP = int.Parse(txtidade.Text);
                    funcionarioN3.TelefoneP = int.Parse(txttele.Text);
                    funcionarioN3.TipofuncP = cbotipo.Text;
                    funcionarioN3.valor = funcionarioN3.ParticipacaoLucro();
                    ListafuncionarioN3.Add(funcionarioN3);
                    break;

            }
        }

        private void btnlistar_Click(object sender, EventArgs e)
        {
            frmlistar janela = new frmlistar();
            //funcionario1
            for (int posicao = 0; posicao <= ListafuncionarioN1.Count - 1; posicao++)
            {
                janela.dgvlista.Rows.Add(ListafuncionarioN1[posicao].NomeP,
                ListafuncionarioN1[posicao].IdadeP,
                ListafuncionarioN1[posicao].TelefoneP,
               ListafuncionarioN1[posicao].TipofuncP,
               ListafuncionarioN1[posicao].valor);
            }
            // funcionario2
            for (int posicao = 0; posicao <= ListafuncionarioN2.Count - 1; posicao++)
            {
                janela.dgvlista.Rows.Add(ListafuncionarioN2[posicao].NomeP,
                ListafuncionarioN2[posicao].IdadeP,
                ListafuncionarioN1[posicao].TelefoneP,
               ListafuncionarioN2[posicao].TipofuncP,
               ListafuncionarioN2[posicao].valor);
            }
            //funcionario3
            for (int posicao = 0; posicao <= ListafuncionarioN3.Count - 1; posicao++)
            {
                janela.dgvlista.Rows.Add(ListafuncionarioN3[posicao].NomeP,
                ListafuncionarioN3[posicao].IdadeP,
                ListafuncionarioN3[posicao].TelefoneP,
               ListafuncionarioN3[posicao].TipofuncP,
               ListafuncionarioN3[posicao].valor);
            }
            janela.Show();
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtnome.ResetText();
            txtidade.ResetText();
            txttele.ResetText();
            cbotipo.ResetText();
        }

        private void txttele_TextChanged(object sender, EventArgs e)
        {

        }

        private void txttele_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir apenas dígitos e teclas de controle (como backspace)
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }

}
