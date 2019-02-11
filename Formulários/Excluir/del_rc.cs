using System;
using System.Windows.Forms;
using Vale_Lembrar_Teste.BO;
using Vale_Lembrar_Teste.MODEL;

namespace Vale_Lembrar_Teste.Excluir
{
    public partial class del_rc : Form
    {
        public del_rc()
        {
            InitializeComponent();
        }

        private void btn_del_rc_Click(object sender, EventArgs e)
        {
            string message = "Tem certeza que deseja excluir a RC?";
            string caption = "Atenção para exclusão!";
            try
            {
                Req_CmpModel Req_Model = new Req_CmpModel();
                Req_CmpBO RC_BO = new Req_CmpBO();
                Req_Model.ID = int.Parse(txt_id_rc.Text);
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;
                result = MessageBox.Show(message, caption, buttons);
                if (result == DialogResult.Yes)
                {
                    RC_BO.BO_Delete_RC(Req_Model);
                    MessageBox.Show("Excluída com Sucesso a RC nº =  " + Req_Model.ID);
                }

            }
            catch (Exception erro)
            {
                MessageBox.Show("Verifique o número da RC!! ");
            }
        }

        private void btn_cancel_del_rc_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
