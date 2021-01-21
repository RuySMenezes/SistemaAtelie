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
    public partial class frmTelaPrincipal : Form
    {
        Thread venda, produto, cliente, pesquisa;
        public frmTelaPrincipal()
        {
            InitializeComponent();
        }

        private void lbVenda_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
            venda = new Thread(novoform);
            venda.SetApartmentState(ApartmentState.STA);
            venda.Start();
        }
        private void novoform()
        {
            Application.Run(new frmVenda());
        }
        private void lbRelatorio_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
            pesquisa = new Thread(novoform3);
            pesquisa.SetApartmentState(ApartmentState.STA);
            pesquisa.Start();
        }
        private void novoform3()
        {
            Application.Run(new frmPesquisa());
        }

        private void lbCliente_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
            cliente = new Thread(novoform4);
            cliente.SetApartmentState(ApartmentState.STA);
            cliente.Start();
        }
        private void novoform4()
        {
            Application.Run(new frmCliente());
        }





        private void lbEstoque_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
            produto = new Thread(novoform2);
            produto.SetApartmentState(ApartmentState.STA);
            produto.Start();
        }
        private void novoform2()
        {
            Application.Run(new frmProduto());
        }
    }
    }

