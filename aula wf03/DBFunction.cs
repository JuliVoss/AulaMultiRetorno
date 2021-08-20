using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula_wf03
{
    public static class DBFunction
    {
        public static SqlConnection Connection { get; set; } = new SqlConnection("Data Source=BUE205D70;Initial Catalog=BDJULIA;Persist Security Info=True;User ID=guest01;Password=@Senac2021");

        public static void Executa(string comando)
        {
            SqlCommand cmd = new SqlCommand(comando, Connection);
            Connection.Open();
            cmd.ExecuteNonQuery();
            Connection.Close();
        }
    }
}
