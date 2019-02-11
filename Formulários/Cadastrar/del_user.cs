using System;
using System.Windows.Forms;
using Vale_Lembrar_Teste.BO;
using Vale_Lembrar_Teste.MODEL;

namespace Vale_Lembrar_Teste.Cadastrar
{
    public partial class del_user : Form
    {
        public del_user()
        {
            InitializeComponent();
        }

        private void del_user_Load(object sender, EventArgs e)
        {

        }

        private void btn_del_user_Click(object sender, EventArgs e)
        {
            string message = "Tem certeza que deseja excluir o Usuário?";
            string caption = "Atenção para exclusão!";
            try
            {
                UsuarioModel UserModel = new UsuarioModel();
                UsuarioBO User_BO = new UsuarioBO();
                UserModel.Nome_user = txt_del_user.Text;
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;
                result = MessageBox.Show(message, caption, buttons);
                if (result == DialogResult.Yes)
                {
                    User_BO.Delete_User(UserModel);
                    MessageBox.Show("Excluído com Sucesso o Usuário =  " + UserModel.Nome_user);
                }

            }
            catch (Exception erro)
            {
                MessageBox.Show("Não foi possível excluir o Usuário!");
            }
        }
    }
}
