using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAtelie.Classes
{
    class Cadastro
    {
        Banco_de_Dados.Conexao conexao = new Banco_de_Dados.Conexao();
        SqlCommand cmd = new SqlCommand();
        public String mensagem;


        public Cadastro(String nome, String valor, String descricao, int quantidade)
        {
            //Comando Sql -- insert, update, delete
            cmd.CommandText = "insert into Produto (Nome, Valor, Quantidade, Descricao) values (@nome, @valor, @Quantidade, @descricao)";

            //paramentros
            cmd.Parameters.AddWithValue("@nome",nome);
            cmd.Parameters.AddWithValue("@valor",valor);
            cmd.Parameters.AddWithValue("quantidade",quantidade);
            cmd.Parameters.AddWithValue("descricao",descricao);

            try 
            {
                //conectar com banco
                cmd.Connection = conexao.conectar();
                //executar comando
                cmd.ExecuteNonQuery();
                //desconectar
                conexao.desconectar();
                //mostrar mensagem de erro ou sucesso
                this.mensagem = "Cadastrado com sucesso!!";
            }
            catch (SqlException e)
            {
                this.mensagem = e.ToString();
            }


        }
    }
}
