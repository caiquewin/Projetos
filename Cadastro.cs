using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroDePessoas
{
    public class Cadastro
    {
        // metodo construtor
        Conexao conexao = new Conexao();
        SqlCommand cmd = new SqlCommand();
        public string mensagem="";//mesagem de erro ou sucesso

        public Cadastro(string nome,string telefone)
        {
            
            //1°vamos fazer o comando sql que acessa o banco de dados
            //o insert pra inserir 
            //o update para atualizar
            // o delete para deletar
            cmd.CommandText = "insert into tbTelefone (Name, NumeroTelefone) values (@nome, @telefone)";

            // iremos colocar os parametros
            cmd.Parameters.AddWithValue("@nome",nome);
            cmd.Parameters.AddWithValue("@telefone", telefone);
            
            try
            {
                
                cmd.Connection = conexao.conectar();// vamos conectar ao bd

                cmd.ExecuteNonQuery();// execultar os comandos

                conexao.desconectar(); // depois desconectar do bd

                this.mensagem = "Cadastrado com sucesso";
            }
            catch (SqlException e)
            {
                this.mensagem = "Erro ao tentar se conectar com bando de DB";
            }
            // depois mostrar mensagem de erro ou de sucesso


        }
    }
}
