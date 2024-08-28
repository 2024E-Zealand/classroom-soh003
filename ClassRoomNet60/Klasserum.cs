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

        //Funktioner
        //Udskriv info om klasselokale
        public void UdskrivKlasseLokale()
        {
            Console.WriteLine($"Klasselokale :{this.KlasseNavn}");

            Console.WriteLine("Personer: ");
            foreach (var Studerende in this.Klasseliste)
            {
                Console.WriteLine($"Navn: {Studerende.Navn}, Fødselsmåned: {Studerende.Fødselsmåned}, Fødselsdag: {Studerende.Fødselsdag}, Årstid: {Studerende.UdskrivÅrstid()}");
            }
        }

        //udskriv fødselsdage pr. årstid
        public void UdskrivFødselsdagePrÅrstid()
        {
            int vinterCount = Klasseliste.Count(s => s.UdskrivÅrstid() == "Vinter");
            int forårCount = Klasseliste.Count(s => s.UdskrivÅrstid() == "Forår");
            int sommerCount = Klasseliste.Count(s => s.UdskrivÅrstid() == "Sommer");
            int efterårCount = Klasseliste.Count(s => s.UdskrivÅrstid() == "Efterår");

            Console.WriteLine($"Antal studerende med fødselsdag om vinteren: {vinterCount}");
            Console.WriteLine($"Antal studerende med fødselsdag om foråret: {forårCount}");
            Console.WriteLine($"Antal studerende med fødselsdag om sommeren: {sommerCount}");
            Console.WriteLine($"Antal studerende med fødselsdag om efteråret: {efterårCount}");
        }

        //ToString

        public override string ToString()
        {
            return $"{{{nameof(KlasseNavn)}={KlasseNavn}, {nameof(Klasseliste)}={Klasseliste}, {nameof(SemesterStart)}={SemesterStart.ToString()}}}";
        }

        

    }
}
