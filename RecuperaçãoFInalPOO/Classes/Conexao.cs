using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace RecuperaçãoFInalPOO.Classes
{
    class Conexao
    {
        public MySqlConnection con = new MySqlConnection();
        public Conexao()
        {
            con.ConnectionString = @"Server=localhost;Database=supermercadosuper;Uid=Gerencia;Pwd=gerenciaSuper;";
        }
        //Método Conectar
        public MySqlConnection Conectar()
        {
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
            return con;
        }
        //Método Desconectar
        public void Desconectar()
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
        }
    }
}
