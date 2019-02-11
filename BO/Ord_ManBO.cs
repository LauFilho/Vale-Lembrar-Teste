using Vale_Lembrar_Teste.MODEL;
using Vale_Lembrar_Teste.DAO;
using System.Data;
using System.Collections.Generic;

namespace Vale_Lembrar_Teste.BO
{
    public class Ord_ManBO
    {
        public void BO_Add_Om(Ord_ManModel OM)
        {
            if (OM != null)
            {
                Ord_ManDAO OMDAO = new Ord_ManDAO();
                if (OM.ID != 0)
                {
                    //altera
                    OMDAO.Insert_OM(OM);
                }
            }
        }
        public void BO_Update_OM(Ord_ManModel OM, int OM_set)
        {
            if (OM != null)
            {
                Ord_ManDAO OMDAO = new Ord_ManDAO();
                if (OM.ID != 0)
                {
                    //altera
                    OMDAO.Update_OM(OM, OM_set);
                }
            }

        }

        public void BO_Del_Om(Ord_ManModel OM)
        {
            if (OM != null)
            {
                Ord_ManDAO OMDAO = new Ord_ManDAO();
                OMDAO.Delete_OM(OM);
            }
        }

        public DataTable BO_List_OM(string pesquisa)
        {
            Ord_ManDAO OM_DAO = new Ord_ManDAO();
            DataTable dtLista = new DataTable();
            dtLista = OM_DAO.Om_List(pesquisa);
            return dtLista;
        }

        public int BO_Lembrar_OM()
        {
            Ord_ManDAO OMDAO = new Ord_ManDAO();
            int i = OMDAO.Lembrar_Om();
            return i;
        }
        public List<Ord_ManModel> BO_Listagem_Om()
        {
            Ord_ManDAO OM_DAO = new Ord_ManDAO();
            List<Ord_ManModel> Lista_aux = new List<Ord_ManModel>();
            Lista_aux = OM_DAO.Listagem_Om();
            return Lista_aux;

        }
    }
    
}

