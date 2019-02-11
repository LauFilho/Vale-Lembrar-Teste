using System;
using System.Windows.Forms;
using Vale_Lembrar_Teste.BO;
using Vale_Lembrar_Teste.MODEL;
namespace Vale_Lembrar_Teste.Excluir
{
    public partial class del_om : Form
    {
        public del_om()
        {
            InitializeComponent();

        }

        private void txt_id_om_TextChanged(object sender, EventArgs e)
        {
             
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_del_om_Click(object sender, EventArgs e)
        {
            string message = "Tem certeza que deseja excluir a OM?";
            string caption = "Atenção para exclusão!";
            try
            {
                    Ord_ManModel Om_Model = new Ord_ManModel();
                    Ord_ManBO Om_BO = new Ord_ManBO();
                    Om_Model.ID = int.Parse(txt_id_cancel_om.Text);
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result;
                    result = MessageBox.Show(message, caption, buttons);
                    if (result == DialogResult.Yes)
                    {
                        Om_BO.BO_Del_Om(Om_Model);
                        MessageBox.Show("Excluída com Sucesso a OM nº =  " + Om_Model.ID);
                    }
                        
            }
            catch (Exception erro)
            {
                MessageBox.Show("Verifique o número da OM!! ", erro.Message);
            }
        }

        private void btn_cancel_om_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_cancel_del_om_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void del_om_Load(object sender, EventArgs e)
        {
            
        }
    }
}
