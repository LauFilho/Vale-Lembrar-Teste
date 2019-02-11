using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.Data;
using Vale_Lembrar_Teste.MODEL;

namespace Vale_Lembrar_Teste.DAO
{
    class UsuarioDAO
    {
        public void Insert(UsuarioModel User)
        {
            MySqlCommand comando = new MySqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "insert into usuarios (nome_user,senha_user,funcao_user) values (@add_user,@add_senha,@funcao_user)";
            comando.Parameters.AddWithValue("@add_user", User.Nome_user);
            comando.Parameters.AddWithValue("@add_senha", User.Senha_user);
            comando.Parameters.AddWithValue("@funcao_user", User.Funcao_user);
            ConnectBD.CRUD(comando);
        }

        public void Delete(UsuarioModel User)
        {
            MySqlCommand comando = new MySqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "delete from bd_valelembrar.usuarios where nome_user = @nome_del_user";
            comando.Parameters.AddWithValue("@nome_del_user", User.Nome_user);
            ConnectBD.CRUD(comando);
        }

        public UsuarioModel FindUser(string nome)
        {
            MySqlCommand comando = new MySqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "select nome_user as Nome, funcao_user as 'Tipo de Usuário' from bd_valelembrar.usuarios where nome_user = @nome_user";
            comando.Parameters.AddWithValue("@nome_user", nome);
            MySqlDataReader dr = ConnectBD.Select(comando);
            UsuarioModel User = new UsuarioModel();
            if (dr.HasRows)
            {
                dr.Read();
                User.Id_user = (int)dr["id_user"];
                User.Nome_user = (string)dr["nome_user"];
                User.Funcao_user = (string)dr["funcao_user"];
            }
            else
            {
                User = null;
            }

            return User;
        }

        public UsuarioModel Usuario_Login(string nome, string senha)
        {
            MySqlCommand comando = new MySqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "select id_user, nome_user, funcao_user from usuarios where nome_user = @nome_user and senha_user = @senha_user";
            comando.Parameters.AddWithValue("@nome_user", nome);
            comando.Parameters.AddWithValue("@senha_user", senha);
            MySqlDataReader dr = ConnectBD.Select(comando);
            UsuarioModel User = new UsuarioModel();
            if (dr.HasRows)
            {
                dr.Read();
                User.Id_user = (int)dr["id_user"];
                User.Nome_user = (string)dr["nome_user"];
                User.Funcao_user = (string)dr["funcao_user"];

                return User;
            }
            else
            {
                return null;

            }
            
        }
        public DataTable UserList(string pesquisa)
        {
            MySqlCommand comando = new MySqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "select nome_user as Nome, funcao_user as Função from usuarios WHERE CONCAT(nome_user,funcao_user) like '%" + pesquisa + "%'";
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


