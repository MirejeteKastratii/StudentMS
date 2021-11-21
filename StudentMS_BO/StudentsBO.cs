using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentMS_BO
{
    public class StudentsBO:Base
    {
        public int ID { get; set; }
        public string Emri { get; set; }
        public string Mbiemri { get; set; }
        public DateTime DataLindjes { get; set; }
        public string Gjinia { get; set; }
        public string Email { get; set; }
        public string NumriTel{ get; set; }
        
        public StudentsBO()
        {

        }
        public StudentsBO(string emri, string mbiemri, DateTime data, string gjinia, string email, string nrTel)
        {
            Emri = emri;
            Mbiemri = mbiemri;
            DataLindjes = data;
            Gjinia = gjinia;
            Email = email;
            NumriTel = nrTel;
        }
    }
}
