using System;
using System.Windows.Forms;
using Vale_Lembrar_Teste.BO;
using Vale_Lembrar_Teste.MODEL;

namespace Vale_Lembrar_Teste.Add
{
    public partial class add_rc : Form
    {
        public add_rc()
        {
            InitializeComponent();
            txt_id_rc.Enabled = true;
            txt_descricao_rc.Enabled = true;
            txt_data_rc.Enabled = true;
        }

        private void btn_cancel_rc_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_add_rc_Click(object sender, EventArgs e)
        {
            try
            {
                Req_CmpModel RC_Model = new Req_CmpModel();
                Req_CmpBO RC_BO = new Req_CmpBO();
                RC_Model.ID = int.Parse(txt_id_rc.Text);
                RC_Model.Descricao = txt_descricao_rc.Text;
                RC_Model.Data = DateTime.Parse(txt_data_rc.Text);
                if (btn_statusnovo_rc.Checked)
                {
                    RC_Model.Status = btn_statusnovo_rc.Text;
                }
                if (btn_statusandamento_rc.Checked)
                {
                    RC_Model.Status = btn_statusandamento_rc.Text;
                }
                if (btn_statusatrasada_rc.Checked)
                {
                    RC_Model.Status = btn_statusatrasada_rc.Text;
                }
                if (btn_statusconcluida_rc.Checked)
                {
                    RC_Model.Status = btn_statusconcluida_rc.Text;
                }
                RC_BO.BO_Add_RC(RC_Model);
                MessageBox.Show("Adicionado com Sucesso A RC nº =  " + RC_Model.ID);
            }
            catch (Exception)
            {
                MessageBox.Show("Número da RC Inválido ou Já Cadastrada !! ");
            }
        }

        private void add_rc_Load(object sender, EventArgs e)
        {

        }
    }
}
