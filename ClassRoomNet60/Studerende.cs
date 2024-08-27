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
    }
}
