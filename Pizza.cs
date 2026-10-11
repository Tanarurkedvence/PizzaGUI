using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaGUI
{
    internal class Pizza
    {
        public Pizza(string l)
        {
            var r = l.Split('\t');
            Id = int.Parse(r[0]);
            Nev = r[1];
            Feltetek = r[2];
            Ar = int.Parse(r[3]);
            Vega = r[4] == "Igen" ? true : false;
            Csipos = r[5] == "Igen" ? true : false;
        }

        public int Id { get; set; }
        public string Nev { get; set; }
        public string Feltetek { get; set; }
        public int Ar { get; set; }
        public bool Vega { get; set; }
        public bool Csipos { get; set; }

        public override string ToString()
        {
            return $"{Id} {Nev}\t{Feltetek} {Ar}";
        }
    }
}
