using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoomNet60
{
    public class Studerende
    {

        //Instansfelter
        private string _navn;
        private int _fødselsmåned;
        private int _fødselsdag;

        



        //properties

        public string Navn
        {
            get { return _navn; }
            set { _navn = value; }
        }
        public int Fødselsmåned
        {
            get { return _fødselsmåned; }
            set { _fødselsmåned = value; }
        }

        public int Fødselsdag
        {
            get { return _fødselsdag; }
            set { _fødselsdag= value; }
        }

        //konstruktør
        public Studerende(string navn, int fødselsmåned, int fødselsdag)
        {
            Navn = navn;
            Fødselsmåned = fødselsmåned;
            Fødselsdag = fødselsdag;
        }

        //Funktioner
        public string UdskrivÅrstid()
        {
            if (Fødselsmåned == 12 || Fødselsmåned == 1 || Fødselsmåned == 2)
            {
                return "Vinter";
            }
            else if (Fødselsmåned == 3 || Fødselsmåned == 4 || Fødselsmåned == 5)
            {
                return "Forår";
            }
            else if (Fødselsmåned == 6 || Fødselsmåned == 7 || Fødselsmåned == 8)
            {
                return "Sommer";
            }
            else if (Fødselsmåned == 9 || Fødselsmåned == 10 || Fødselsmåned == 11)
            {
                return "Efterår";
            }
            else { return "Ukendt"; }

        }

        public override string ToString()
        {
            return $"{{{nameof(Navn)}={Navn}, {nameof(Fødselsmåned)}={Fødselsmåned.ToString()}, {nameof(Fødselsdag)}={Fødselsdag.ToString()}}}";
        }
    }
}
