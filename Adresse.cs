using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sep27_fr_oop_Beziehungen
{
    internal class Adresse
    {
        private string _strasse;
        private int _hausnummer;
        private int _plz;
        private string _ort;

        public Adresse(string strasse, int hausnummer, int plz, string ort)
        {
            _strasse = strasse;
            _hausnummer = hausnummer;
            _plz = plz;
            _ort = ort;
        }

        // GET Methoden
        public string GetStrasse()
        {
            return _strasse;
        }
        public int GetHausnummer()
        {
            return _hausnummer;
        }
        public int GetPlz()
        {
            return _plz;
        }
        public string GetOrt()
        {
            return _ort;
        }

        // Ausgabe Adresse
        public void AusgabeAdresse()
        {
            Console.WriteLine($"{GetStrasse()} {GetHausnummer()}, {GetPlz()} {GetOrt()}");
        }
    }
}
