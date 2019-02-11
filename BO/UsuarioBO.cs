using Vale_Lembrar_Teste.MODEL;
using Vale_Lembrar_Teste.DAO;
using System.Data;

namespace Vale_Lembrar_Teste.BO
{
    class UsuarioBO
    {
        public void Add_User (UsuarioModel User)
        {
            UsuarioDAO userDAO = new UsuarioDAO();
            if (User.Nome_user != " ")
            {
                userDAO.Insert(User);
            }
        }

        public void Delete_User(UsuarioModel User)
        {
            UsuarioDAO userDAO = new UsuarioDAO();
            if (User.Nome_user != null)
            {
                userDAO.Delete(User);
            }
        }

        public UsuarioModel Select_User(UsuarioModel User)
        {
            UsuarioDAO userDAO = new UsuarioDAO();
            UsuarioModel Usuario_resultado = new UsuarioModel();
            Usuario_resultado = userDAO.Usuario_Login(User.Nome_user, User.Senha_user);

            return Usuario_resultado;
        }

        public DataTable User_List(string pesquisa)
        {
            UsuarioDAO User_DAO = new UsuarioDAO();
            DataTable dtLista = new DataTable();
            dtLista = User_DAO.UserList(pesquisa);
            return dtLista;
        }

        

    }
}
