using System;
using System.Windows.Forms;
using Vale_Lembrar_Teste.BO;
using Vale_Lembrar_Teste.MODEL;

namespace Vale_Lembrar_Teste.Add
{
    public partial class add_pc : Form
    {
        public add_pc()
        {
            InitializeComponent();
        }

        private void add_pc_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_cancel_pc_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_add_pc_Click(object sender, EventArgs e)
        {
            try
            {
                Ped_CmpModel PC_Model = new Ped_CmpModel();
                Ped_CmpBO PC_BO = new Ped_CmpBO();
                PC_Model.ID = int.Parse(txt_id_pc.Text);
                PC_Model.Descricao = txt_descricao_pc.Text;
                PC_Model.Data = DateTime.Parse(txt_data_pc.Text);
                if (btn_statusnovo_pc.Checked)
                {
                    PC_Model.Status = btn_statusnovo_pc.Text;
                }
                if (btn_statusandamento_pc.Checked)
                {
                    PC_Model.Status = btn_statusandamento_pc.Text;
                }
                if (btn_statusatrasada_pc.Checked)
                {
                    PC_Model.Status = btn_statusatrasada_pc.Text;
                }
                if (btn_statusconcluida_pc.Checked)
                {
                    PC_Model.Status = btn_statusconcluida_pc.Text;
                }
                PC_BO.BO_Add_PC(PC_Model);
                MessageBox.Show("Adicionado com Sucesso O PC nº =  " + PC_Model.ID);
            }
            catch (Exception)
            {
                MessageBox.Show("Número do PC Inválido ou Já Cadastrado !! ");
            }
        }
    }
}
