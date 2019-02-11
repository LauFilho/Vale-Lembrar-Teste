using System;
using System.ComponentModel;
using System.Threading;
using System.Windows.Forms;
using Vale_Lembrar_Teste.BO;
using Vale_Lembrar_Teste.MODEL;

namespace Vale_Lembrar_Teste
{

    public partial class MenuPrinc : Form
    {
        public MenuPrinc()
        {
            InitializeComponent();
            menu_add.Enabled = false;
            menu_edit.Enabled = false;
            menu_list.Enabled = false;
            menu_del.Enabled = false;
            menu_logout.Enabled = false;
            menu_user.Enabled = false;
            //timer1.Enabled = true;
        }
        
   
        private void adicionarToolStripMenuItem_Click(object sender, EventArgs e)
        {
                
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void oMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            add_om add = new add_om();
            add.ShowDialog();
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void oMToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            alter_om add = new alter_om();
            add.ShowDialog();
        }

        private void rQToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add.add_rc add = new Add.add_rc();
            add.ShowDialog();
        }

        private void rQToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Add.add_pc add = new Add.add_pc();
            add.ShowDialog();

        }

        private void oMToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Excluir.del_om add = new Excluir.del_om();
            add.ShowDialog();
        }

        private void rQToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Excluir.del_rc add = new Excluir.del_rc();
            add.ShowDialog();
        }

        private void pDToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Excluir.del_pc add = new Excluir.del_pc();
            add.ShowDialog();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            try
            {
                UsuarioModel UserModel = new UsuarioModel();
                UsuarioModel Usuario_Encontrado = new UsuarioModel();
                UserModel.Nome_user = txt_user.Text;
                UserModel.Senha_user = txt_senha.Text;
                UsuarioBO UserBO = new UsuarioBO();
                Usuario_Encontrado = UserBO.Select_User(UserModel);
                if (Usuario_Encontrado != null)
                {
                    MessageBox.Show("Bem vindo ao Vale Lembrar Sr(a)!\n" + txt_user.Text);
                    Lembrador.RunWorkerAsync();
                    menu_logout.Enabled = true;
                    menu_add.Enabled = true;
                    menu_edit.Enabled = true;
                    menu_list.Enabled = true;
                    menu_del.Enabled = true;
                    txt_user.Visible = false;
                    txt_senha.Visible = false;
                    img_cadeado.Visible = false;
                    lbl_autenicacao.Visible = false;
                    lbl_senha.Visible = false;
                    lbl_user.Visible = false;
                    btn_login.Visible = false;
                    menu_logout.Visible = true;
                    if (Usuario_Encontrado.Funcao_user == "Admin")
                    {
                        menu_user.Enabled = true;
                    }
                }

                else
                {
                    MessageBox.Show("Login ou Senha Incorretos!");
                    txt_user.Text = ("");
                    txt_senha.Text = ("");
                }
            }
            catch (Exception EX)
            {
                MessageBox.Show("Não foi possível conectar ao banco de dados!", EX.Message);
            }

        }
        private void menu_logout_Click(object sender, EventArgs e)
        {
            string message = "Deseja mesmo sair?";
            string caption = "Atenção!";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;
            
            result = MessageBox.Show(message, caption, buttons);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                MessageBox.Show("Logout realizado com sucesso!");
                txt_user.Text = ("");
                txt_senha.Text = ("");
                menu_user.Enabled = false;
                menu_logout.Enabled = false;
                menu_add.Enabled = false;
                menu_edit.Enabled = false;
                menu_list.Enabled = false;
                menu_del.Enabled = false;
                txt_user.Visible = true;
                txt_senha.Visible = true;
                img_cadeado.Visible = true;
                lbl_autenicacao.Visible = true;
                lbl_senha.Visible = true;
                lbl_user.Visible = true;
                btn_login.Visible = true;
                menu_logout.Visible = true;
            }
        }

        private void menu_list_om_Click(object sender, EventArgs e)
        {
            Listar.list_om add = new Listar.list_om();
            add.ShowDialog();
        }

        private void menu_list_rc_Click(object sender, EventArgs e)
        {
            Listar.list_rc add = new Listar.list_rc();
            add.ShowDialog();
        }

        private void menu_list_pc_Click(object sender, EventArgs e)
        {
            Listar.list_pc add = new Listar.list_pc();
            add.ShowDialog();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void adicionarToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Cadastrar.add_user add = new Cadastrar.add_user();
            add.ShowDialog();
        }

        private void usuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menu_user_del_Click(object sender, EventArgs e)
        {
            Cadastrar.del_user add = new Cadastrar.del_user();
            add.ShowDialog();
        }

        private void menu_user_list_Click(object sender, EventArgs e)
        {
            Cadastrar.list_user add = new Cadastrar.list_user();
            add.ShowDialog();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void menu_edit_rc_Click(object sender, EventArgs e)
        {
            Alter.alter_rc add = new Alter.alter_rc();
            add.ShowDialog();
        }

        private void menu_edit_pc_Click(object sender, EventArgs e)
        {
            Alter.alter_pc add = new Alter.alter_pc();
            add.ShowDialog();
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            

        }

        private void Lembrador_DoWork(object sender, DoWorkEventArgs e)
        {
            Ord_ManBO Lembrar_OM = new Ord_ManBO();
            Ped_CmpBO Lembrar_PC = new Ped_CmpBO();
            Req_CmpBO Lembrar_RC = new Req_CmpBO();
            int Num_Dia_Om = Lembrar_OM.BO_Lembrar_OM();
            int Num_Dia_Pc = Lembrar_PC.BO_Lembrar_PC();
            int Num_Dia_Rc = Lembrar_RC.BO_Lembrar_RC();
            Thread.Sleep(1000);
            MessageBox.Show(Num_Dia_Om + " Lembretes de OM!!!!\n" + 
                            Num_Dia_Pc + " Lembretes de PC!!!!\n" +
                            Num_Dia_Rc + " Lembretes de RC!!!!\n","\t Lembretes do Dia!!",
                            MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            
        }

        private void Lembrador_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {

        }

        private void Lembrador_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

        }
    }
}
