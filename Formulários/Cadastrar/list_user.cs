using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;
using Vale_Lembrar_Teste.BO;

namespace Vale_Lembrar_Teste.Cadastrar
{
    public partial class list_user : Form
    {
        
        public list_user()
        {
            InitializeComponent();
        }


       
        private void list_user_Load(object sender, EventArgs e)
        {
            UsuarioBO Usuario_list = new UsuarioBO();
            grid_user.DataSource = Usuario_list.User_List("");
        }


    }
}
