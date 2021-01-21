using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAtelie.Classes
{
    class Produto
    {
        Banco_de_Dados.Conexao conexao = new Banco_de_Dados.Conexao();
        SqlCommand cmd = new SqlCommand();
        public String mensagem;
        string nome, valor, descricao;
        int quantidade, id;

        public Produto(string nome, string valor, string descricao, int quantidade)
        {
            this.nome = nome;
            this.valor = valor;
            this.descricao = descricao;
            this.quantidade = quantidade;

        }

        public void cdProduto()
        {
            //Comando Sql -- insert, update, delete
            cmd.CommandText = "insert into Produto (Nome, Valor, Quantidade, Descricao) values (@nome, @valor, @quantidade, @descricao)";

            //paramentros
            cmd.Parameters.AddWithValue("@nome", nome);
            cmd.Parameters.AddWithValue("@valor", valor);
            cmd.Parameters.AddWithValue("@quantidade", quantidade);
            cmd.Parameters.AddWithValue("@descricao", descricao);

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
                //desconectar
                conexao.desconectar();
            }
            Console.WriteLine(mensagem);
        }

        public void edProduto ()
        {
            //Comando Sql -- insert, update, delete
            cmd.CommandText = "update Produto set (Nome = @nome, Valor = @valor, Quantidade = @quantidade, Descricao = @descricao) where (idProduto = @id)";

            //paramentros
            cmd.Parameters.AddWithValue("@nome", nome);
            cmd.Parameters.AddWithValue("@valor", valor);
            cmd.Parameters.AddWithValue("@quantidade", quantidade);
            cmd.Parameters.AddWithValue("@descricao", descricao);
            cmd.Parameters.AddWithValue("@id", id);

            try
            {
                //conectar com banco
                cmd.Connection = conexao.conectar();
                //executar comando
                cmd.ExecuteNonQuery();
                //desconectar
                conexao.desconectar();
                //mostrar mensagem de erro ou sucesso
                this.mensagem = "Atualizado!!";
            }
            catch (SqlException e)
            {
                this.mensagem = e.ToString();
                //desconectar
                conexao.desconectar();
            }
            Console.WriteLine(mensagem);
        }

        public void ltProduto()
        {
            //Comando Sql -- insert, update, delete
            cmd.CommandText = "Select * from Produto ";
                        
            try
            {
                //conectar com banco
                cmd.Connection = conexao.conectar();
                //executar comando
                cmd.ExecuteNonQuery();
                //desconectar
                conexao.desconectar();
                //mostrar mensagem de erro ou sucesso
                this.mensagem = "Pesquisado!!";
                SqlDataAdapter adaptador = new SqlDataAdapter();
                adaptador.SelectCommand = cmd;
                
            }
            catch (SqlException e)
            {
                this.mensagem = e.ToString();
                //desconectar
                conexao.desconectar();
            }
            Console.WriteLine(mensagem);
        }


    }
}

