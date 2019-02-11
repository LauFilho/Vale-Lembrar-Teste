using System;
using System.Windows.Forms;
using Vale_Lembrar_Teste.BO;

namespace Vale_Lembrar_Teste.Listar
{
    public partial class list_om : Form
    {
        
        public list_om()
        {
            InitializeComponent();
        }

        
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void list_om_Load(object sender, EventArgs e)
        {
            Ord_ManBO List_OM = new Ord_ManBO();
            grid_om.DataSource = List_OM.BO_List_OM("");
        }
        private void txt_list_om_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txt_list_om_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void grid_om_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void list_cancel_om_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txt_search_om_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

       
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //Ord_ManBO List_OM = new Ord_ManBO();
            //grid_om.DataSource = List_OM.BO_List_OM(search_om.Text);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

    }
}
