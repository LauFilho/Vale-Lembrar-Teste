using System;
using System.Windows.Forms;
using Vale_Lembrar_Teste.BO;
using Vale_Lembrar_Teste.MODEL;

namespace Vale_Lembrar_Teste.Cadastrar
{
    public partial class add_user : Form
    {
        public add_user()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_cancel_add_user_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_add_user_Click(object sender, EventArgs e)
        {
            try
            {
                UsuarioModel User_Model = new UsuarioModel();
                UsuarioBO User_BO = new UsuarioBO();
                User_Model.Nome_user = txt_add_user.Text;
                User_Model.Senha_user = txt_add_senha.Text;
                if (user_comum.Checked)
                {
                    User_Model.Funcao_user = user_comum.Text;
                }
                if (user_admin.Checked)
                {
                    User_Model.Funcao_user = user_admin.Text;
                }
                User_BO.Add_User(User_Model);
                MessageBox.Show("Adicionado com Sucesso o Usuário  =  " + User_Model.Nome_user);
            }
            catch (Exception)
            {
                MessageBox.Show("Não foi possível adicionar o Usuário!");
            }
        }

        private void txt_user_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
