using System;
using System.Collections.Generic;
using System.Data;
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


        //Construtor com parametros opcionais
        public Produto(string nome = null, string valor = null, string descricao = null, int quantidade = 0, int id = 0)
        {
            this.nome = nome;
            this.valor = valor;
            this.descricao = descricao;
            this.quantidade = quantidade;
            this.id = id;

        }


        //Cadastrar Produto
        public void cadastrarProduto()
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


        //Editar Produto
        public void editarProduto ()
        {
            //Comando Sql -- insert, update, delete
            cmd.CommandText = "UPDATE Produto SET Nome = @nome, Valor = @valor, Quantidade = @quantidade, Descricao = @descricao WHERE idProduto = @id";

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


        //Listar Produtos (Sem Filtros)
        public DataTable listarProduto()
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
                DataTable mamaco = new DataTable();
                adaptador.Fill(mamaco);

                conexao.desconectar();
                Console.WriteLine(mensagem);

                return mamaco;
            }
            catch (SqlException e)
            {
                this.mensagem = e.ToString();

                //desconectar
                conexao.desconectar();
                Console.WriteLine(mensagem);

                return null;
            }
        }


    }
}

