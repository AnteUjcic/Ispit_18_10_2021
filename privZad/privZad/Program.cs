using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace privZad
{
    class Program
    {
        static void Main(string[] args)
        {

            Sport nogomet = new Sport("Nogomet", true, 11);
            Sport vaterpolo = new Sport("Vaterpolo", true, 7);
            Sport curling = new Sport("curling", false, 4);

         
        }
	
	}

    public class Sport
    {
        private string naziv;
        private bool IgraLiSeLoptom;
        private byte BrojIgraca;

        public Sport(string naziv, bool igraLiSeLoptom, byte brojIgraca)
        {
            this.naziv = naziv;
            IgraLiSeLoptom = igraLiSeLoptom;
            BrojIgraca = brojIgraca;
        }

        public string Naziv { get => naziv; set => naziv = value; }
        public bool IgraLiSeLoptom1 { get => IgraLiSeLoptom; set => IgraLiSeLoptom = value; }
        public byte BrojIgraca1 { get => BrojIgraca; set => BrojIgraca = value; }


    }
}

