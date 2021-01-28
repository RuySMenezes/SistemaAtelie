using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Data.SqlClient;

namespace SistemaAtelie.Formularios
{
    public partial class frmProduto : Form
    {

        Thread voltar;
        int idProduto;

        public frmProduto()
        {
            InitializeComponent();
            listagem();

        }


        //Listagem de Produtos
        private void listagem()
        {
            Classes.Produto list = new Classes.Produto();
            try
            {
                dgProduto.DataSource = list.listarProduto();
            }
            catch (Exception)
            {
                Console.WriteLine("Listagem Falhou! Verifique a conexão com o banco");
            }

        }



        #region Eventos

        //Selecionar Dados na DataGridView

        private void dgProduto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dgProduto.SelectedRows[0];

            idProduto = Int32.Parse(row.Cells["idProduto"].Value.ToString());
            tbNome.Text = row.Cells["Nome"].Value.ToString();
            tbValor.Text = row.Cells["Valor"].Value.ToString();
            tbDescricao.Text = row.Cells["Descricao"].Value.ToString();
            tbQuantidade.Text = row.Cells["Quantidade"].Value.ToString();
        }


        //Botão Voltar
        private void novoform()
        {
            Application.Run(new frmTelaPrincipal());
        }

        private void btVoltar_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
            voltar = new Thread(novoform);
            voltar.SetApartmentState(ApartmentState.STA);
            voltar.Start();
        }


        //Botão Cadastrar
        private void btCadastrar_MouseClick(object sender, MouseEventArgs e)
        {
            string nome= tbNome.Text, valor = tbValor.Text, descricao = tbDescricao.Text;
            int quantidade = Int32.Parse(tbQuantidade.Text);

            Classes.Produto produto = new Classes.Produto(nome, valor, descricao, quantidade);
            produto.cadastrarProduto();
            listagem();

        }

        //Botão Editar
        private void btEditar_MouseClick(object sender, MouseEventArgs e)
        {
            string nome = tbNome.Text, valor = tbValor.Text, descricao = tbDescricao.Text;
            int quantidade = Int32.Parse(tbQuantidade.Text);

            Classes.Produto produto = new Classes.Produto(nome, valor, descricao, quantidade, idProduto);
            produto.editarProduto();

            listagem();
        }

        //Formulario Carregado
        private void frmProduto_Load(object sender, EventArgs e)
        {

        }



        #endregion
        // Botão Excluir
        private void btExcluir_MouseClick(object sender, MouseEventArgs e)
        {

            string nome = tbNome.Text, valor = tbValor.Text, descricao = tbDescricao.Text;
            int quantidade = Int32.Parse(tbQuantidade.Text);

            Classes.Produto produto = new Classes.Produto(nome, valor, descricao, quantidade, idProduto);
            produto.excluirProduto();

            listagem();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tbValor_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {

        }
    }
}
