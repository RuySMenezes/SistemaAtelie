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
    public partial class frmVenda : Form
    {
        Thread voltar;
        public frmVenda()
        {
            InitializeComponent();
        }

        private void button3_MouseClick(object sender, MouseEventArgs e)
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

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
