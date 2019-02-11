using System;
using System.Collections.Generic;
using System.Data;
using MySql.Data.MySqlClient;
using Vale_Lembrar_Teste.MODEL;
namespace Vale_Lembrar_Teste.DAO
{
    public class Ped_CmpDAO
    {
        public void Insert_PC(Ped_CmpModel PC)
        {
            MySqlCommand comando = new MySqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "insert into pedido_de_compra (id_pc, descricao_pc, data_pc,status_pc) values (@id_pc, @descricao_pc, @data_pc,@status_pc)";
            comando.Parameters.AddWithValue("@id_pc", PC.ID);
            comando.Parameters.AddWithValue("@descricao_pc", PC.Descricao);
            comando.Parameters.AddWithValue("@data_pc", PC.Data);
            comando.Parameters.AddWithValue("@status_pc", PC.Status);
            ConnectBD.CRUD(comando);
        }

        public void Update_PC(Ped_CmpModel PC,int Pc_Id2)
        {
            MySqlCommand comando = new MySqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "update pedido_de_compra set id_pc = "+ Pc_Id2 + ", descricao_pc = @descricao_pc, data_pc = @data_pc, status_pc = @status_pc where id_pc = @id_pc";
            comando.Parameters.AddWithValue("@id_pc", PC.ID);
            comando.Parameters.AddWithValue("@descricao_pc", PC.Descricao);
            comando.Parameters.AddWithValue("@data_pc", PC.Data);
            comando.Parameters.AddWithValue("@status_pc", PC.Status);
            ConnectBD.CRUD(comando);
        }

        public void Delete_PC(Ped_CmpModel PC)
        {
            MySqlCommand comando = new MySqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "delete from bd_valelembrar.pedido_de_compra where id_pc = @id_del_pc";
            comando.Parameters.AddWithValue("@id_del_pc", PC.ID);
            ConnectBD.CRUD(comando);
        }

        public Ped_CmpModel BuscarID_PC(int id_pc)
        {
            MySqlCommand comando = new MySqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "select * from pedido_de_compra where id_pc = @id_pc";
            comando.Parameters.AddWithValue("@id_pc", id_pc);

            MySqlDataReader dr = ConnectBD.Select(comando);
            Ped_CmpModel PC = new Ped_CmpModel();
            if (dr.HasRows)
            {
                dr.Read();
                PC.ID = (int)dr["id_pc"];
                PC.Descricao = (string)dr["descricao_pc"];
                PC.Data = (DateTime)dr["data_pc"];
            }
            else
            {
                PC = null;
            }

            return PC;
        }

        public IList<Ped_CmpModel> BuscaPorDescricao_Pc(string Descricao)
        {
            MySqlCommand comando = new MySqlCommand();
            comando.CommandText = "select * from pedido_de_compra where descricao_pc like @descricao";
            comando.Parameters.AddWithValue("@descricao", "%" + Descricao + "%");
            MySqlDataReader dr = ConnectBD.Select(comando);
            IList<Ped_CmpModel> Lista_PCs = new List<Ped_CmpModel>();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    Ped_CmpModel Ped_CP = new Ped_CmpModel();
                    Ped_CP.ID = (int)dr["id_pc"];
                    Ped_CP.Descricao = (string)dr["descricao_pc"];
                    Ped_CP.Data = (DateTime)dr["data_pc"];
                    Lista_PCs.Add(Ped_CP);
                }
            }
            else
            {
                Lista_PCs = null;
            }
            return Lista_PCs;
        }

        public int Lembrar_PC()
        {
            MySqlCommand comando = new MySqlCommand();
            comando.CommandText = "select count(*) as 'Resultado' from pedido_de_compra where data_pc = CURDATE()";
            MySqlDataReader Data_Reader = ConnectBD.Select(comando);
            if (Data_Reader.HasRows)
            {
                Data_Reader.Read();
                return int.Parse(Data_Reader.GetString(0));
            }
            return 0;
        }

        public DataTable PC_List(string pesquisa)
        {
            MySqlCommand comando = new MySqlCommand();
            comando.CommandType = CommandType.Text; 
            comando.CommandText = "select id_pc as Numero,descricao_pc as Descrição ,status_pc as Status,data_pc as Data ,CONCAT ('Faltam ',DATEDIFF(data_pc,CURDATE()), ' dias. ') As 'Dias'  from pedido_de_compra where concat(id_pc,descricao_pc,data_pc,status_pc) like '%" + pesquisa + "%'";
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

