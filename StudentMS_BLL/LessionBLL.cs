using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentMS_BO;
using StudentMS_DAL;

namespace StudentMS_BLL
{
   public class LessionBLL
    {
        LessionDAL lessionDAL = new LessionDAL();
       public DataTable LessionLista()
        {
            return lessionDAL.GetLessionList();
        }
        public void InsertLessions(LessionBO model) {
            lessionDAL.InsertLessions(model);
        }
        public bool DeleteLession (int ID) {
            return lessionDAL.DeleteLession(ID);
        }
        public bool UpdateLession(LessionBO model) {
            return lessionDAL.UpdateLession(model);
        }
        public LessionBO GetLessionByID(int ID)
        {
            return lessionDAL.GetOrenByID(ID);
        }
    }
}
