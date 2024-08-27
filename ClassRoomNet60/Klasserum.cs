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

        public void UdskrivKlasseLokale()
        {
            Console.WriteLine($"Klasselokale :{this.KlasseNavn}");

            Console.WriteLine("Personer: ");
            foreach (var Studerende in this.Klasseliste)
            {
                Console.WriteLine($"Navn: {Studerende.Navn}, Fødselsmåned: {Studerende.Fødselsmåned}, Fødselsdag: {Studerende.Fødselsdag}, Årstid: {Studerende.UdskrivÅrstid()}");
            }
        }

        //ToString

        public override string ToString()
        {
            return $"{{{nameof(KlasseNavn)}={KlasseNavn}, {nameof(Klasseliste)}={Klasseliste}, {nameof(SemesterStart)}={SemesterStart.ToString()}}}";
        }

        

    }
}
