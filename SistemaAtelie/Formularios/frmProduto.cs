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

        Banco_de_Dados.Conexao conexao = new Banco_de_Dados.Conexao();
        SqlCommand cmd = new SqlCommand();

        public frmProduto()
        {
            InitializeComponent();
            listagem();

        }

              private void btVoltar_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
            voltar = new Thread(novoform);
            voltar.SetApartmentState(ApartmentState.STA);
            voltar.Start();
        }
        private void novoform()
        {
            Application.Run(new frmTelaPrincipal());
        }

        private void btCadastrar_MouseClick(object sender, MouseEventArgs e)
        {
            string nome= tbNome.Text, valor = tbValor.Text, descricao = tbDescricao.Text;
            int quantidade = Int32.Parse(tbQuantidade.Text);

            Classes.Produto produto = new Classes.Produto(nome, valor, descricao, quantidade);
            produto.cdProduto();


        }

        public void listagem()
        {
            //Comando Sql -- insert, update, delete
            cmd.CommandText = "Select * from Produto ";

            try
            {
                //conectar com banco
                cmd.Connection = conexao.conectar();
                //executar comando
                             
                
                SqlDataAdapter adaptador = new SqlDataAdapter();
                adaptador.SelectCommand = cmd;
                DataTable mamaco = new DataTable();
                adaptador.Fill(mamaco);
                dgProduto.DataSource = mamaco;
                conexao.desconectar();
            }
            catch (SqlException e)
            {
                
                //desconectar
                conexao.desconectar();
            }
            
        }
    }
}
