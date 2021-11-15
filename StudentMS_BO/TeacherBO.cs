using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentMS_BO
{
    public class TeacherBO : Base
    {
        public int TeacherID { get; set; }
        public byte[] Foto { get; set; }
        public string Emri { get; set; }
        public string Mbiemri { get; set; }
        public string Gjinia { get; set; }
        public string Email { get; set; }
        public string NrTel { get; set; }
        public string Vendbanimi { get; set; }
        public string Specializimi { get; set; }
        public int WeeklyWorkingHr { get; set; }
        public DateTime Birthdate { get; set; }

        public TeacherBO()
        {

        }
        public TeacherBO(byte[] foto, string emri, string mbiemri, string gjinia, string email, string nrTel,
            string vendbanimi, string specializimi, int orePune, DateTime birthdate)
        {
            Foto = foto;
            Emri = emri;
            Mbiemri = mbiemri;
            Gjinia = gjinia;
            Email = email;
            NrTel = nrTel;
            Vendbanimi = vendbanimi;
            Specializimi = specializimi;
            WeeklyWorkingHr = orePune;
            Birthdate = birthdate;


        }
        public TeacherBO( string emri, string mbiemri, string gjinia, string email, string nrTel,
           string vendbanimi, string specializimi, int orePune, DateTime birthdate)
        {
    
            Emri = emri;
            Mbiemri = mbiemri;
            Gjinia = gjinia;
            Email = email;
            NrTel = nrTel;
            Vendbanimi = vendbanimi;
            Specializimi = specializimi;
            WeeklyWorkingHr = orePune;
            Birthdate = birthdate;
        }
    }
}
