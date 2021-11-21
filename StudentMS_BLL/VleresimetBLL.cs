using StudentMS_BO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentMS_DAL;
using System.Data;

namespace StudentMS_BLL
{
    public class VleresimetBLL
    {
        VleresimiDAL vleresimiDAL = new VleresimiDAL();
        public void InsertoVleresime(VleresimetBO vleresimet)
        {
            vleresimiDAL.InsertVlersimet(vleresimet);
        }
        public DataTable GetVleresimet()
        {
            return vleresimiDAL.GetVleresimet();
        }
        public bool DeleteVleresimin(int ID)
        {
            return vleresimiDAL.DeleteVleresimi(ID);
        }
    public VleresimetBO GetVleresimetByID(int ID)
        {
            return vleresimiDAL.GetVleresimetByID(ID);

        }
        public void EditoVleresimet(VleresimetBO model)
        {
            vleresimiDAL.EditoVleresimet(model);
        }
    }
}
