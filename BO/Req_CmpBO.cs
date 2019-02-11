using Vale_Lembrar_Teste.MODEL;
using Vale_Lembrar_Teste.DAO;
using System.Data;

namespace Vale_Lembrar_Teste.BO
{
    public class Req_CmpBO
    {
        public void BO_Add_RC(Req_CmpModel RC)
        {
            if (RC != null)
            {
                Req_CmpDAO RCDAO = new Req_CmpDAO();
                if (RC.ID != 0)
                {

                    RCDAO.Insert_RC(RC);

                }
            }
        }

        public void BO_Update_RC(Req_CmpModel RC,int RC_ID2)
        {
            if (RC != null)
            {
                Req_CmpDAO RCDAO = new Req_CmpDAO();
                if (RC.ID != 0)
                {
                    RCDAO.Update_RC(RC, RC_ID2);
                }
            }
        }

        public void BO_Delete_RC(Req_CmpModel RC)
        {
            if (RC != null)
            {
                Req_CmpDAO RCDAO = new Req_CmpDAO();
                RCDAO.Delete_RC(RC);
            }
        }
        public int BO_Lembrar_RC()
        {
            Req_CmpDAO PCDAO = new Req_CmpDAO();
            int i = PCDAO.Lembrar_RC();
            return i;
        }

        public DataTable BO_RC_List_RC(string pesquisa)
        {
            Req_CmpDAO RC_DAO = new Req_CmpDAO();
            DataTable dtLista = new DataTable();
            dtLista = RC_DAO.RC_List(pesquisa);
            return dtLista;
        }
    }
}
