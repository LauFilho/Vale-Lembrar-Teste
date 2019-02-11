using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using Vale_Lembrar_Teste.MODEL;


namespace Vale_Lembrar_Teste.DAO
{
    public class Ord_ManDAO
    {
        public void Insert_OM(Ord_ManModel OM)
        {
            MySqlCommand comando = new MySqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "insert into ordem_de_manutencao (id_om, descricao_om, data_om, status_om) values (@id_om, @descricao_om, @data_om,@status_om)";
            comando.Parameters.AddWithValue("@id_om", OM.ID);
            comando.Parameters.AddWithValue("@descricao_om", OM.Descricao);
            comando.Parameters.AddWithValue("@data_om", OM.Data);
            comando.Parameters.AddWithValue("@status_om", OM.Status);
            ConnectBD.CRUD(comando);
        }

        public void Update_OM(Ord_ManModel OM, int Om_set)
        {
            MySqlCommand comando = new MySqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "update ordem_de_manutencao set id_om =" + Om_set + ", descricao_om = @descricao_om, data_om = @data_om, status_om = @status_om where id_om = @id_om";
            comando.Parameters.AddWithValue("@id_om", OM.ID);
            comando.Parameters.AddWithValue("@descricao_om", OM.Descricao);
            comando.Parameters.AddWithValue("@data_om", OM.Data);
            comando.Parameters.AddWithValue("@status_om", OM.Status);
            ConnectBD.CRUD(comando);
        }

        public void Delete_OM(Ord_ManModel OM)
        {
            MySqlCommand comando = new MySqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "delete from ordem_de_manutencao where id_om = @id_del_om";
            comando.Parameters.AddWithValue("@id_del_om", OM.ID);
            ConnectBD.CRUD(comando);
        }

        public Ord_ManModel BuscarID_OM(int id_om)
        {
            MySqlCommand comando = new MySqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "select * from ordem_de_manutencao where id_om = @id_om";
            comando.Parameters.AddWithValue("@id_om",id_om);
            MySqlDataReader dr = ConnectBD.Select(comando);
            Ord_ManModel OM = new Ord_ManModel();
            if (dr.HasRows)
            {
                dr.Read();
                OM.ID = (int) dr["id_om"];
                OM.Descricao = (string) dr["descricao_om"];
                OM.Data = (DateTime)dr["data_om"];
            }
            else
            {
                OM = null;
            }
            return OM;
        }
        public IList <Ord_ManModel> BuscaPorDescricao_Om (string Descricao)
        {
            MySqlCommand comando = new MySqlCommand();
            comando.CommandText = "select * from ordem_de_manutencao where descricao_om like @descricao";
            comando.Parameters.AddWithValue("@descricao","%"+ Descricao + "%");
            MySqlDataReader dr = ConnectBD.Select(comando);
            IList<Ord_ManModel> Lista_Oms = new List<Ord_ManModel>();
            if(dr.HasRows)
            {
                while(dr.Read())
                {
                    Ord_ManModel Ord_Om = new Ord_ManModel();
                    Ord_Om.ID = (int)dr["id_om"];
                    Ord_Om.Descricao = (string)dr["descricao_om"];
                    Ord_Om.Data = (DateTime) dr["data_om"];
                    Lista_Oms.Add(Ord_Om);
                }   
            }
            else
            {
                Lista_Oms = null;
            }
            return Lista_Oms;
        }
        public DataTable Om_List(string pesquisa)
        {
            MySqlCommand comando = new MySqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "select id_om as Numero,descricao_om as Descrição ,status_om As Status, data_om as Data , concat ('Faltam ',DATEDIFF(data_om,CURDATE()), ' dias. ') As 'Dias'  from ordem_de_manutencao where concat (id_om,descricao_om,data_om,status_om) like '%" + pesquisa +"%'";
            MySqlDataReader Data_Reader = ConnectBD.Select(comando);
            DataTable dtLista = new DataTable();
            if (Data_Reader.HasRows)
            {
                MySqlDataAdapter Data_Adapter = ConnectBD.Fill(comando);
                Data_Adapter.Fill(dtLista);
                return dtLista;
            }
            else
            {
                return null;
            }
        
        }

        public List <Ord_ManModel> Listagem_Om()
        {
            MySqlCommand comando = new MySqlCommand();
            comando.CommandText = "select id_om AS Número, descricao_om AS Descrição, data_om AS Data, CONCAT ('Faltam ', DATEDIFF(data_om, CURDATE()), ' dias. ') As 'Dias' from ordem_de_manutencao";
            MySqlDataReader dr = ConnectBD.Select(comando);
            List<Ord_ManModel> Lista_Oms = new List<Ord_ManModel>();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    Ord_ManModel Ord_Om = new Ord_ManModel();
                    Ord_Om.ID = (int)dr["id_om"];
                    Ord_Om.Descricao = (string)dr["descricao_om"];
                    Ord_Om.Data = (DateTime)dr["data_om"];
                    Lista_Oms.Add(Ord_Om);
                }
            }
            else
            {
                Lista_Oms = null;
            }
            return Lista_Oms;
        }


        public int Lembrar_Om()
        {
            MySqlCommand comando = new MySqlCommand();
            comando.CommandText = "select count(*) as 'Resultado' from ordem_de_manutencao where data_om = CURDATE()";
            MySqlDataReader Data_Reader = ConnectBD.Select(comando);
            if (Data_Reader.HasRows)
            {
                Data_Reader.Read();
                return (Data_Reader.GetInt32(0));
            }
            return 0;
        }
    }
}
