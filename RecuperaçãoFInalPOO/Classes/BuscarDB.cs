using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RecuperaçãoFInalPOO.Classes;
using MySql.Data.MySqlClient;
using System.Data;
using System.Diagnostics;

namespace RecuperaçãoFInalPOO.Classes
{
    class BuscarDB
    {
        Conexao con = new Conexao();
        MySqlCommand cmd;
        MySqlDataAdapter da;
        DataTable dt;
        public string ms = "";

        //funciona normalmente
        public string ProcurarCliente(string cpf)
        {
            cmd = new MySqlCommand();
            cmd.CommandText = @"select nome from clientes where cpf = @cpf";
            cmd.Parameters.AddWithValue("@cpf", cpf);
            try
            {
                cmd.Connection = con.Conectar();
                if(cmd.ExecuteScalar() != null)
                {
                    ms = cmd.ExecuteScalar().ToString();
                }
                else
                {
                    ms = "";
                }

            }
            catch (MySqlException e)
            {
                Debug.WriteLine(e.Message);
                ms = "Erro ao se conectar ao banco de dados";
            }
            finally
            {
                con.Desconectar();
            }
            return ms;
        }
        //Mesmo tendo produtos no banco e o comando funcionando normal no banco.
        //o dt continua vazio depois do da.Fill(dt);
        public DataTable ProcurarProduto(string codigo)
        {
            dt = new DataTable();
            cmd = new MySqlCommand();
            da = new MySqlDataAdapter(cmd);

            cmd.CommandText = @"select nome,preço,desconto from produtos where codigo = @codigo";
            cmd.Parameters.AddWithValue("@codigo", codigo);
            try
            {
                cmd.Connection = con.Conectar();
                da.Fill(dt);
                Debug.WriteLine(dt.Rows.Count);
            }
            catch (MySqlException e)
            {
                Debug.WriteLine(e.Message);
                ms = "Erro ao se conectar ao banco de dados";
            }
            finally
            {
                con.Desconectar();
            }
            return dt;
        }
    }
}
