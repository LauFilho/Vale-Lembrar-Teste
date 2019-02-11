using System;

namespace Vale_Lembrar_Teste.MODEL
{
    public abstract class Serviço
    {
        private int id;
        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        private string descricao;
        public string Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }

        private DateTime data;
        public DateTime Data
        {
            get { return data; }
            set { data = value; }
        }

        private string status;
        public string Status
        {
            get { return status; }
            set { status = value; }
        }
    }
}
