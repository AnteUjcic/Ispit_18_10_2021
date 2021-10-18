using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreciZadtak
{
    class Program
    {
        static void Main(string[] args)
        {
            Brod brod = new Brod();
            Zrakoplov zrakoplov = new Zrakoplov();
            brod.KudaVozi();
            zrakoplov.KudaVozi();
        }
    }
}
