using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DurgiZadatak
{
    class Zrakoplov
    {
        private string naziv;
        private double snagaMotora;
        private int doesgLeta;

        public Zrakoplov(string naziv, double snagaMotora, int doesgLeta)
        {
            this.naziv = naziv;
            this.snagaMotora = snagaMotora;
            this.doesgLeta = doesgLeta;
        }

        public string Naziv { get => naziv; set => naziv = value; }
        public double SnagaMotora { get => snagaMotora; set => snagaMotora = value; }
        public int DoesgLeta { get => doesgLeta; set => doesgLeta = value; }
    }
}
