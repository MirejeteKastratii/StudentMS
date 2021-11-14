using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentMS_BO
{
    internal class StudentsBO:Base
    {
        public int ID { get; set; }
        public string Emri { get; set; }
        public string Mbiemri { get; set; }
        public int PrindiID { get; set; }
        public DateTime DataLindjes { get; set; }
        public string Gjinia { get; set; }
        public string Email { get; set; }
        public string NumriTel{ get; set; }
        public int CourseID { get; set; }
        
    }
}
