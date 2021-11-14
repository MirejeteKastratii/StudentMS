using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentMS_BO
{
    internal class ParentsBO:Base
    {
        public int ID { get; set; }
        public string EmriBabit { get; set; }
        public string EmriMamit { get; set; }
        public string Mbiemri { get; set; }
        public int NrTel { get; set; }
        public string Email { get; set; }
    }
}
