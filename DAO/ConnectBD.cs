using System.Data;
using MySql.Data.MySqlClient;

namespace Vale_Lembrar_Teste.DAO
{
    public class ConnectBD
    {
        private static string servidor = "localhost";
        private static string banco = "bd_valelembrar";
        private static string userid = "Vale";
        private static string senha = "12345" ;

      
        public static MySqlConnection Conectar()
        {

            string stringConexao = "server =" + servidor + " ; database = " + banco + "; uid = " + userid + " ; Password = " + senha + ";Max Pool Size = 1024";
            MySqlConnection conexao = new MySqlConnection(stringConexao);
            conexao.Open();
            return conexao;            
       }
        
        public static void CRUD (MySqlCommand comando)
        {
            MySqlConnection con = Conectar();
            comando.Connection = con;
            comando.ExecuteNonQuery();
            con.Close();
        }

        public static MySqlDataReader Select (MySqlCommand comando)
        {
            MySqlConnection con = Conectar();
            comando.Connection = con;
            MySqlDataReader dr = comando.ExecuteReader(CommandBehavior.CloseConnection);
            return dr;
        }

        public static MySqlDataAdapter Fill (MySqlCommand comando)
        {
            MySqlConnection con = Conectar();
            comando.Connection = con;
            MySqlDataAdapter Data_Adap = new MySqlDataAdapter(comando);
            //con.Close();
            return Data_Adap;
            
        }
        
    }
}
