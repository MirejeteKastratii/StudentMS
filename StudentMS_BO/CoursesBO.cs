using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentMS_BO
{
    internal class CoursesBO:Base
    {
        public int ID { get; set; }
        public string Titulli { get; set; }
        public string Pershkrimi { get; set; }
        public string Syllabusi { get; set; }
        public int Sesionet { get; set; }
    }
}
