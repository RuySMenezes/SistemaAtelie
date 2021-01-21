using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SistemaAtelie.Banco_de_Dados
{
    class Conexao
    {

        SqlConnection con = new SqlConnection();

        //Construtor
        public Conexao()
        {
            con.ConnectionString = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=MimosAtelie;Integrated Security=True";
                                    
            //Codigo para conexão do banco do Ruy caso necessario
            //Data Source=DESKTOP-JKDMOTU\SQLEXPRESS;Initial Catalog=MimosAtelie;Integrated Security=True
        }

        //Metodo Conectar
        public SqlConnection conectar()
        {
            if(con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }

            return con;
        }
        
        //Metodo Desconectar

        public  void desconectar()
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
        }
    }
}
