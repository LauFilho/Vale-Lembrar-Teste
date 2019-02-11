using System;
using System.Windows.Forms;
using Vale_Lembrar_Teste.MODEL;
using Vale_Lembrar_Teste.BO;
namespace Vale_Lembrar_Teste.Alter
{
    public partial class alter_pc : Form
    {
        public alter_pc()
        {
            InitializeComponent();
        }

        private void btn_alter_pc_Click(object sender, EventArgs e)
        {
            try
            {
                Ped_CmpModel Ped_Model = new Ped_CmpModel();
                Ped_CmpBO PC_BO = new Ped_CmpBO();
                Ped_Model.ID = int.Parse(txt_id_pc.Text);
                Ped_Model.Descricao = txt_descricao_pc.Text;
                Ped_Model.Data = DateTime.Parse(txt_data_pc.Text);
                if (btn_statusnovo_pc.Checked)
                {
                    Ped_Model.Status = btn_statusnovo_pc.Text;
                }
                if (btn_statusandamento_pc.Checked)
                {
                    Ped_Model.Status = btn_statusandamento_pc.Text;
                }
                if (btn_statusatrasada_pc.Checked)
                {
                    Ped_Model.Status = btn_statusatrasada_pc.Text;
                }
                if (btn_statusconcluida_pc.Checked)
                {
                    Ped_Model.Status = btn_statusconcluida_pc.Text;
                }
                PC_BO.BO_Update_PC(Ped_Model, int.Parse(txt_id2_pc.Text));
                MessageBox.Show("Alterada o PC de nº = " + Ped_Model.ID);
            }
            catch (Exception)
            {
                MessageBox.Show("Número do PC Inválido ou Inexistente!! ");
            }
        }

        private void btn_cancel_pc_Click(object sender, EventArgs e)
        {

        }
    }
}
