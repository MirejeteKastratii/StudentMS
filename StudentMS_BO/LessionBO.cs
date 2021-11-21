using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentMS_BO
{
   public class LessionBO : Base
    {
        public int OraID { get; set; }
        public DateTime Data { get; set; }
        public int NrOres { get; set; }
        public int LendaID { get; set; }
        public int MesuesiID { get; set; }
        public string TemaMesimore { get; set; }

        public LessionBO()
        {

        }
        public LessionBO( DateTime data, int nrOres, int lenda, int mesuesi, string tema)
        {
          
            Data = data;
            NrOres = nrOres;
            LendaID = lenda;
            MesuesiID = mesuesi;
            TemaMesimore = tema;
        }
        public LessionBO(int id,DateTime data, int nrOres, int lenda, int mesuesi, string tema)
        {
            OraID = id;
            Data = data;
            NrOres = nrOres;
            LendaID = lenda;
            MesuesiID = mesuesi;
            TemaMesimore = tema;
        }
    }
}
