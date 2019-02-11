namespace Vale_Lembrar_Teste.MODEL
{
    public class UsuarioModel
    {
        private int id_user;
        public int Id_user
        {
            get{return id_user;}
            set{id_user = value;}
        }

        private string nome_user;
        public string Nome_user
        {
            get{return nome_user;}
            set{nome_user = value;}
        }

        private string senha_user;
        public string Senha_user
        {
            get{return senha_user;}
            set{senha_user = value;}
        }

        private string funcao_user;
        public string Funcao_user
        {
            get { return funcao_user; }
            set { funcao_user = value; }
        }

    }
}
