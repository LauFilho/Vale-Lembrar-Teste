using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.Data;
using Vale_Lembrar_Teste.MODEL;

namespace Vale_Lembrar_Teste.DAO
{
    public class Req_CmpDAO
    {
        public void Insert_RC(Req_CmpModel RC)
        {
            MySqlCommand comando = new MySqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "insert into requisicao_de_compra (id_rc, descricao_rc, data_rc,status_rc) values (@id_rc, @descricao_rc, @data_rc,@status_rc)";
            comando.Parameters.AddWithValue("@id_rc", RC.ID);
            comando.Parameters.AddWithValue("@descricao_rc", RC.Descricao);
            comando.Parameters.AddWithValue("@data_rc", RC.Data);
            comando.Parameters.AddWithValue("@status_rc", RC.Status);
            ConnectBD.CRUD(comando);
        }

        public void Update_RC(Req_CmpModel RC, int RC_ID2)
        {
            MySqlCommand comando = new MySqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "update requisicao_de_compra set id_rc  = " + RC_ID2 + ", descricao_rc = @descricao_rc, data_rc = @data_rc, status_rc = @status_rc where id_rc = @id_rc";
            comando.Parameters.AddWithValue("@id_rc", RC.ID);
            comando.Parameters.AddWithValue("@descricao_rc", RC.Descricao);
            comando.Parameters.AddWithValue("@data_rc", RC.Data);
            comando.Parameters.AddWithValue("@status_rc", RC.Status);
            ConnectBD.CRUD(comando);
        }

        public void Delete_RC(Req_CmpModel RC)
        {
            MySqlCommand comando = new MySqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "delete from bd_valelembrar.requisicao_de_compra where id_rc = @id_del_rc";
            comando.Parameters.AddWithValue("@id_del_rc", RC.ID);
            ConnectBD.CRUD(comando);
        }

        public Req_CmpModel BuscarID_RC(int id_rc)
        {
            MySqlCommand comando = new MySqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "select * from requisicao_de_compra where id_rc = @id_rc";
            comando.Parameters.AddWithValue("@id_rc", id_rc);

            MySqlDataReader dr = ConnectBD.Select(comando);
            Req_CmpModel RC = new Req_CmpModel();
            if (dr.HasRows)
            {
                dr.Read();
                RC.ID = (int)dr["id_rc"];
                RC.Descricao = (string)dr["descricao_rc"];
                RC.Data = (DateTime)dr["data_rc"];
            }
            else
            {
                RC = null;
            }

            return RC;
        }
        public IList<Req_CmpModel> BuscaPorDescricao_Rc(string Descricao)
        {
            MySqlCommand comando = new MySqlCommand();
            comando.CommandText = "select * from requisicao_de_compra where descricao_rc like @descricao";
            comando.Parameters.AddWithValue("@descricao", "%" + Descricao + "%");
            MySqlDataReader dr = ConnectBD.Select(comando);
            IList<Req_CmpModel> Lista_RCs = new List<Req_CmpModel>();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    Req_CmpModel Req_CP = new Req_CmpModel();
                    Req_CP.ID = (int)dr["id_rc"];
                    Req_CP.Descricao = (string)dr["descricao_rc"];
                    Req_CP.Data = (DateTime)dr["data_rc"];
                    Lista_RCs.Add(Req_CP);
                }
            }
            else
            {
                Lista_RCs = null;
            }
            return Lista_RCs;
        }

        public int Lembrar_RC()
        {
            MySqlCommand comando = new MySqlCommand();
            comando.CommandText = "select count(*) as 'Resultado' from requisicao_de_compra where data_rc = CURDATE()";
            MySqlDataReader Data_Reader = ConnectBD.Select(comando);
            if (Data_Reader.HasRows)
            {
                Data_Reader.Read();
                return int.Parse(Data_Reader.GetString(0));
            }
            return 0;
        }

        public DataTable RC_List(string pesquisa)
        {
            MySqlCommand comando = new MySqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "select id_rc as Numero,descricao_rc as Descrição ,status_rc as Status,data_rc as Data ,CONCAT ('Faltam ',DATEDIFF(data_rc,CURDATE()), ' dias. ') As 'Dias'  from requisicao_de_compra where concat(id_rc,descricao_rc,data_rc,status_rc) like '%" + pesquisa + "%'";
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
    }
}

