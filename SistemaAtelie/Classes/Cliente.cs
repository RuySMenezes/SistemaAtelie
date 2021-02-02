using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAtelie.Classes
{
    class Cliente
    {
        Banco_de_Dados.Conexao conexao = new Banco_de_Dados.Conexao();
        SqlCommand cmd = new SqlCommand();

        public String mensagem;
        string nome;
        int id, cpf, telefone;


        //Construtor com parametros opcionais
        public Cliente(string nome = null, int cpf = 0, int telefone = 0, int id = 0)
        {
            this.nome = nome;
            this.cpf = cpf;
            this.telefone = telefone;
            this.id = id;

        }


        public DataTable filtroCliente(string filtro)
        {
            cmd.CommandText = "SELECT * FROM Cliente WHERE idCliente LIKE '%" + filtro + "%' or Nome LIKE '%" + filtro + "%' or Cpf LIKE '%" + filtro + "%' or Telefone LIKE '%" + filtro + "%' ; ";


            Console.WriteLine(filtro);
            try
            {
                //conectar com banco
                cmd.Connection = conexao.conectar();
                //executar comando
                cmd.ExecuteNonQuery();
                //desconectar
                conexao.desconectar();
                //mostrar mensagem de erro ou sucesso
                this.mensagem = "Filtrado!!";
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
        //Cadastrar Produto
        public void cadastrarCliente()
        {
            //Comando Sql -- insert, update, delete
            cmd.CommandText = "insert into Cliente (Nome, cpf, telefone) values (@nome, @cpf, @telefone)";

            //paramentros
            cmd.Parameters.AddWithValue("@nome", nome);
            cmd.Parameters.AddWithValue("@cpf", cpf);
            cmd.Parameters.AddWithValue("@telefone", telefone);

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
        public void editarCliente()
        {
            //Comando Sql -- insert, update, delete
            cmd.CommandText = "UPDATE Cliente SET Nome = @nome, Cpf = @cpf, Telefone = @telefone WHERE idCliente = @id";

            //paramentros
            cmd.Parameters.AddWithValue("@nome", nome);
            cmd.Parameters.AddWithValue("@cpf", cpf);
            cmd.Parameters.AddWithValue("@telefone", telefone);
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
        public DataTable listarCliente()
        {
            //Comando Sql -- insert, update, delete
            cmd.CommandText = "Select * from Cliente ";

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

        public void excluirCliente()
        {
            //Comando Sql -- insert, update, delete
            cmd.CommandText = "DELETE  from Cliente  WHERE idCliente = @id";


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
                this.mensagem = "Deletado!!";



            }
            catch (SqlException e)
            {
                this.mensagem = e.ToString();

                //desconectar
                conexao.desconectar();
                Console.WriteLine(mensagem);


            }
        }

    }


}
