using Vale_Lembrar_Teste.MODEL;
using Vale_Lembrar_Teste.DAO;
using System.Data;

namespace Vale_Lembrar_Teste.BO
{
    public class Ped_CmpBO
    {
        public void BO_Add_PC (Ped_CmpModel PC)
        {
            if (PC != null)
            {
                Ped_CmpDAO PCDAO = new Ped_CmpDAO();
                if (PC.ID != 0)
                {
                    PCDAO.Insert_PC(PC);
                }
            }
        }

        public void BO_Update_PC(Ped_CmpModel PC,int Pc_Id)
        {
            if (PC != null)
            {
                Ped_CmpDAO PCDAO = new Ped_CmpDAO();
                if (PC.ID != 0)
                {
                    PCDAO.Update_PC(PC, Pc_Id);
                }
            }

        }

        public void BO_Delete_PC(Ped_CmpModel PC)
        {
            if (PC != null)
            {
                Ped_CmpDAO PCDAO = new Ped_CmpDAO();
                PCDAO.Delete_PC(PC);
            }
        }

        public int BO_Lembrar_PC()
        {
            Ped_CmpDAO PCDAO = new Ped_CmpDAO();
            int i = PCDAO.Lembrar_PC();
            return i;
        }

        public DataTable BO_PC_List_OM(string pesquisa)
        {
            Ped_CmpDAO PC_DAO = new Ped_CmpDAO();
            DataTable dtLista = new DataTable();
            dtLista = PC_DAO.PC_List(pesquisa);
            return dtLista;
        }
    }
}
