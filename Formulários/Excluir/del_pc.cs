using System;
using System.Windows.Forms;
using Vale_Lembrar_Teste.BO;
using Vale_Lembrar_Teste.MODEL;

namespace Vale_Lembrar_Teste.Excluir
{
    public partial class del_pc : Form
    {
        public del_pc()
        {
            InitializeComponent();
        }

        private void btn_del_pc_Click(object sender, EventArgs e)
        {
            string message = "Tem certeza que deseja excluir o PC?";
            string caption = "Atenção para exclusão!";
            try
            {
                Ped_CmpModel Ped_Model = new Ped_CmpModel();
                Ped_CmpBO PC_BO = new Ped_CmpBO();
                Ped_Model.ID = int.Parse(txt_id_cancel_pc.Text);
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;
                result = MessageBox.Show(message, caption, buttons);
                if (result == DialogResult.Yes)
                {
                    PC_BO.BO_Delete_PC(Ped_Model);
                    MessageBox.Show("Excluído com Sucesso o PC nº =  " + Ped_Model.ID);
                }

            }
            catch (Exception erro)
            {
                MessageBox.Show("Verifique o número do PC!! ", erro.Message);
            }
        }

        private void btn_cancel_del_pc_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
