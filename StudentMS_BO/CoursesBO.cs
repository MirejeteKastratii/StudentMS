using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentMS_BO
{
    public class CoursesBO:Base
    {
        public int ID { get; set; }

        public string Titulli { get; set; }
        public string Pershkrimi { get; set; }
        public string Syllabusi { get; set; }
        public int Sesionet { get; set; }

        public CoursesBO()
        {

        }

        public CoursesBO(string titulli, string pershkrimi, string syllabusi, int sesionet)
        {
            Titulli = titulli;
            Pershkrimi = pershkrimi;
            Syllabusi = syllabusi;
            Sesionet = sesionet;

        }
        public CoursesBO(int id, string titulli, string pershkrimi, string syllabusi, int sesionet)
        {
            ID = id;
            Titulli = titulli;
            Pershkrimi = pershkrimi;
            Syllabusi = syllabusi;
            Sesionet = sesionet;

        }
    }

    

}
