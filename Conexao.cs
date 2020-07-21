using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Auto_Atendimento
{
    class Conexao
    {
        private static string str = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename='E:\\Arquivos\\Projetos\\TCC\\TCC-master - Copia\\Estoque.mdf';Integrated Security=True;Connect Timeout=30";
        private static SqlConnection con = null;
         public static SqlConnection OC()
        {
            con = new SqlConnection(str);
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            try
            {
                con.Open();
            }
            catch (SqlException sqle)
            {
                con = null;
            }
            return con;
        }
        public static void FC()
        {
            if (con != null)
            {
                con.Close();
            }
        }
    }
}
