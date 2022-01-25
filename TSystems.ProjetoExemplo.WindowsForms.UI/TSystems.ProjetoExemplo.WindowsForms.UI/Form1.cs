using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TSystems.ProjetoExemplo.WindowsForms.UI
{
    public partial class FFormularioInicial : Form
    {
        public FFormularioInicial()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            var fornecedor = new Fornecedor();

            List<Fornecedor> listaFornecedores = new List<Fornecedor>();
            listaFornecedores.Add(RetornarFornecedor(fornecedor));

            dgvFornecedores.DataSource = listaFornecedores;
        }

        private Fornecedor RetornarFornecedor(Fornecedor fornecedor)
        {
            if (txtNomeFornecedor.Text != string.Empty)
            {
                fornecedor.NomeDoFornecedor = txtNomeFornecedor.Text;
            }
            else
            {
                MessageBox.Show("Você não informou o nome do Fornecedor!");
            }
            if (txtEndereco.Text != string.Empty)
            {
                fornecedor.Endereco = txtEndereco.Text;
            }
            else
            {
                MessageBox.Show("Você não informou o Endereço!");
            }
            if (txtNomeContato.Text != string.Empty)
            {
                fornecedor.NomeContato = txtNomeContato.Text;
            }
            else
            {
                MessageBox.Show("Você não informou o nome do Contato!");
            }
            if (txtTelefone.Text != string.Empty)
            {
                fornecedor.Telefone = txtTelefone.Text;
            }
            else
            {
                MessageBox.Show("Você não informou o Telefone!");
            }
            return fornecedor;
        }
    }
}
