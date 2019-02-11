using System;
using System.Windows.Forms;
using Vale_Lembrar_Teste.MODEL;
using Vale_Lembrar_Teste.BO;

namespace Vale_Lembrar_Teste
{
    public partial class alter_om : Form
    {
        public alter_om()
        {
            InitializeComponent();
        }

        private void alter_om_Load(object sender, EventArgs e)
        {

        }

        private void btn_alter_om_Click(object sender, EventArgs e)
        {
                try    
                {
                    Ord_ManModel Om_Model = new Ord_ManModel();
                    Ord_ManBO Om_BO = new Ord_ManBO();
                    Om_Model.ID = int.Parse(txt_id_om.Text);
                    Om_Model.Descricao = txt_descricao_om.Text;
                    Om_Model.Data = DateTime.Parse(txt_data_om.Text);
                    if (btn_statusnovo_om.Checked)
                    {
                        Om_Model.Status = btn_statusnovo_om.Text;
                    }
                    if (btn_statusandamento_om.Checked)
                    {
                        Om_Model.Status = btn_statusandamento_om.Text;
                    }
                    if (btn_statusatrasada_om.Checked)
                    {
                        Om_Model.Status = btn_statusatrasada_om.Text;
                    }
                    if (btn_statusconcluida_om.Checked)
                    {
                        Om_Model.Status = btn_statusconcluida_om.Text;
                    }
                Om_BO.BO_Update_OM(Om_Model,int.Parse(txt_id2_om.Text));
                    MessageBox.Show("Alterada a OM de nº = " + Om_Model.ID);
                }
                catch (Exception)
                {
                    MessageBox.Show("Número da OM Inválida ou Inexistente!! ");
                }
        }

        private void btn_cancel_om_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txt_descricao_om_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txt_id2_om_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txt_data_om_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txt_id_om_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
