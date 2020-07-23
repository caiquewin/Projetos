using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroDePessoas
{
    
    public class Conexao
    {

        //instânciar a conexão sqlconnection

        SqlConnection con = new SqlConnection();
        //1° construtor
        public Conexao()
        {
            con.ConnectionString =@"Data Source=DESKTOP-PRPUO5C\;Initial Catalog=teste;Integrated Security=True";

        }
        // Metodo conectar 
        public SqlConnection conectar()
        {
            if(con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
            return con;
        }
        // Metodo desconectar
        public void desconectar()
        {
            if (con.State== System.Data.ConnectionState.Open)
            {
                con.Close();
            }
            
        }
    }
}
