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

namespace SistemaAtelie.Formularios
{
    public partial class frmCliente : Form
    {
        Thread voltar;
        int idCliente;
        public frmCliente()
        {
            InitializeComponent();
            listagem();
        }

        //Listagem de Produtos
        private void listagem()
        {
            Classes.Cliente list = new Classes.Cliente();
            try
            {
                dgCliente.DataSource = list.listarCliente();
            }
            catch (Exception)
            {
                Console.WriteLine("Listagem Falhou! Verifique a conexão com o banco");
            }

        }
        private void dgCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dgCliente.SelectedRows[0];

            idCliente = Int32.Parse(row.Cells["idCliente"].Value.ToString());
            tbNome.Text = row.Cells["Nome"].Value.ToString();
            tbCpf.Text = row.Cells["Cpf"].Value.ToString();
            tbTelefone.Text = row.Cells["Telefone"].Value.ToString();

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

            string nome = tbNome.Text;
            int cpf= Int32.Parse(tbCpf.Text);
            int telefone = Int32.Parse(tbTelefone.Text);

            Classes.Cliente cliente = new Classes.Cliente(nome, cpf, telefone);
            cliente.cadastrarCliente();
            listagem();
        }

        private void btEditar_MouseClick(object sender, MouseEventArgs e)
        {

            string nome = tbNome.Text;
            int cpf = Int32.Parse(tbCpf.Text);
            int telefone = Int32.Parse(tbTelefone.Text);

            Classes.Cliente cliente = new Classes.Cliente(nome, cpf, telefone, idCliente);
            cliente.editarCliente();

            listagem();
        }

        
    }
}
