using System;
using System.Windows.Forms;
using Vale_Lembrar_Teste.MODEL;
using Vale_Lembrar_Teste.BO;



namespace Vale_Lembrar_Teste
{
    public partial class add_om : Form
    {
        

        public add_om()
        {
            InitializeComponent();
            txt_id_om.Enabled = true;
            txt_descricao_om.Enabled = true;
            txt_data_om.Enabled = true;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Ord_ManModel Om_Model = new Ord_ManModel();
                Ord_ManBO Om_BO = new Ord_ManBO();
                Om_Model.ID = int.Parse(txt_id_om.Text);
                Om_Model.Descricao = txt_descricao_om.Text;
                Om_Model.Data = DateTime.Parse(txt_data_om.Text);
                if(btn_statusnovo_om.Checked)
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
                Om_BO.BO_Add_Om(Om_Model);
                MessageBox.Show("Adicionado com Sucesso a OM nº =  " + Om_Model.ID);
            }
            catch (Exception erro)
            {
                MessageBox.Show("Número da OM Inválida ou Já Cadastrada!! ", erro.Message);
            }
        }
            

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void descricao_om_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_id_om_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
