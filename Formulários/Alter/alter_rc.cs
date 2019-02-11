using System;
using System.Windows.Forms;
using Vale_Lembrar_Teste.BO;
using Vale_Lembrar_Teste.MODEL;

namespace Vale_Lembrar_Teste.Alter
{
    public partial class alter_rc : Form
    {
        public alter_rc()
        {
            InitializeComponent();
        }

        private void alter_rc_Load(object sender, EventArgs e)
        {

        }

        private void btn_alter_rc_Click(object sender, EventArgs e)
        {
            try
            {
                Req_CmpModel Req_Model = new Req_CmpModel();
                Req_CmpBO RC_BO = new Req_CmpBO();
                Req_Model.ID = int.Parse(txt_id_rc.Text);
                Req_Model.Descricao = txt_descricao_rc.Text;
                Req_Model.Data = DateTime.Parse(txt_data_rc.Text);
                if (btn_statusnovo_rc.Checked)
                {
                    Req_Model.Status = btn_statusnovo_rc.Text;
                }
                if (btn_statusandamento_rc.Checked)
                {
                    Req_Model.Status = btn_statusandamento_rc.Text;
                }
                if (btn_statusatrasada_rc.Checked)
                {
                    Req_Model.Status = btn_statusatrasada_rc.Text;
                }
                if (btn_statusconcluida_rc.Checked)
                {
                    Req_Model.Status = btn_statusconcluida_rc.Text;
                }
                RC_BO.BO_Update_RC(Req_Model, int.Parse(txt_id2_rc.Text));
                MessageBox.Show("Alterada A RC de nº = " + Req_Model.ID);
            }
            catch (Exception)
            {
                MessageBox.Show("Número da RC Inválida ou Inexistente!! ");
            }
        }
    }
}
