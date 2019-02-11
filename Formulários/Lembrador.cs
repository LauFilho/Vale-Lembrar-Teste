using System;
using System.ComponentModel;
using System.Threading;
using System.Windows.Forms;

namespace Vale_Lembrar_Teste.Formulários
{
    public partial class lembrador_om : Form
    {
        public lembrador_om()
        {
            InitializeComponent();
        }

        private void BW_1_DoWork(object sender, DoWorkEventArgs e)
        {
            MessageBox.Show("Mensagem 1");
            Thread.Sleep(2000);
            MessageBox.Show("Mensagem 2");
        }

        private void BW_1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {

        }

        private void BW_1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

        }

        private void lembrador_om_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            BW_1.RunWorkerAsync();
        }
    }
}
