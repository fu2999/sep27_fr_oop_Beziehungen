using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sep27_fr_oop_Beziehungen
{
    internal class Person
    {
        private string _nachName;
        private string _vorName;
        private int _alter;

        private Adresse _adresse;
        private Hund _hund;

        // Konstruktor
        public Person(string nachName, string vorName, int alter, Adresse adresse = null, Hund hund = null)
        {
            _nachName = nachName;
            _vorName = vorName;
            _alter = alter;

            _adresse = adresse;
            _hund = hund;

        }

        // GET Methoden
        public string GetNachName() => _nachName;
        public string GetVorName() => _vorName;
        public int GetAlter() => _alter;
        public Hund GetHund() => _hund;


        // SET Methoden
        public void SetNachName(string neuerNachName) => _nachName = neuerNachName;
        public void SetAdresse(Adresse adresse) => _adresse = adresse;
        public void SetHund(Hund hund) => _hund = hund;


        public void ZeigePersonInfo()
        {
            Console.WriteLine($"{GetVorName()} {GetNachName()}, Alter: {GetAlter()}");

            if (_adresse != null) // Falls Adresse nicht null ist, also falls gesetzt wurde
            {
                _adresse.AusgabeAdresse(); // Methode aus der Klasse Adresse wird aufgerufen
            }
            else // falls Adrese nicht gesetzt wurde
            {
                Console.WriteLine("Keine Adresse gesetzt.");
            }

            if (_hund != null)
            {
                Console.WriteLine($"{GetVorName()} besitzt einen Hund: {_hund}.");
            } else
            {
                Console.WriteLine($"{GetVorName()} besitzt keinen Hund.");
            }
        }
    }
}>
