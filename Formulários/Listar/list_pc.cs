using System;
using System.Windows.Forms;
using Vale_Lembrar_Teste.BO;

namespace Vale_Lembrar_Teste.Listar
{
    public partial class list_pc : Form
    {        
        public list_pc()
        {
            InitializeComponent();
        }
        private void grid_pc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void list_pc_Load(object sender, EventArgs e)
        {
            Ped_CmpBO List_PC = new Ped_CmpBO();
            grid_pc.DataSource = List_PC.BO_PC_List_OM("");
         
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void search_om_TextChanged(object sender, EventArgs e)
        {
            Ped_CmpBO List_PC = new Ped_CmpBO();
           // grid_pc.DataSource = List_PC.BO_PC_List_OM(search_pc.Text);
        }
    }
}
