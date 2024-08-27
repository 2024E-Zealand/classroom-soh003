using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoomNet60
{
    public class Klasserum
    {
        public string KlasseNavn {  get; set; }
        public List<Studerende> Klasseliste {  get; set; }
        public DateTime SemesterStart { get; set; }
       
        //Konstruktør default
        public Klasserum()
        {
            
        }



        //konstruktør

        public Klasserum(string klasseNavn, List<Studerende> klasseliste, DateTime semesterStart)
        {
            KlasseNavn = klasseNavn;
            Klasseliste = klasseliste;
            SemesterStart = semesterStart;
        }
    }
}
