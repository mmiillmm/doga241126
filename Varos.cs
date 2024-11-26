using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace varosok
{
    internal class Varos
    {

        public string VarosNev { get; set; }
        public string Orszag { get; set; }
        public float Lakossag { get; set; }

        public override string ToString()
        {
            return $"\t Város neve: {VarosNev}\n" +
                    $"\t Ország: {Orszag}\n" +
                     $"\t Lakosság: {Lakossag}\n";
        }

        public Varos(string sor)
        {
            string[] adatok = sor.Split(';');

            VarosNev = adatok[0];
            Orszag = adatok[1];
            Lakossag = float.Parse(adatok[2]);
        }
    }
    

}
