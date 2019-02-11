using System;
using System.Windows.Forms;
using Vale_Lembrar_Teste.BO;

namespace Vale_Lembrar_Teste.Listar
{
    public partial class list_rc : Form
    {
        public list_rc()
        {
            InitializeComponent();
        }
        private void grid_rc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void list_rc_Load(object sender, EventArgs e)
        {
            Req_CmpBO List_RC = new Req_CmpBO();
            grid_rc.DataSource = List_RC.BO_RC_List_RC("");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void search_om_TextChanged(object sender, EventArgs e)
        {
            Req_CmpBO List_PC = new Req_CmpBO();
           // grid_rc.DataSource = List_PC.BO_RC_List_RC(search_rc.Text);
        }
    }
}
