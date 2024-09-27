using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sep27_fr_oop_Beziehungen
{
    internal class Hund
    {
        private string _name;
        private bool _gefuettert;

        //// Bezug auf Klasse Person
        //private Person _person;

        // Konstruktor Hund

        public Hund(string name)
        {
            _name = name;
            _gefuettert = false;
        }

        // Gassi gehen, falls Person über 16 mitgeht und, falls Hund gefüttert worden ist

        public void Gassi(Person person)
        {
            if (person != null)
            {
                AbfrageAlter(person);

                if (person.GetAlter() >= 16)
                {
                    AbfrageGefuettert();

                    if (_name != null && _gefuettert == true)
                        Console.WriteLine($"{person.GetVorName()} geht Gassi mit Hund {_name}.");
                }

            } else
            {
                Console.WriteLine("Keine Person vorhanden. Kein Gassi gehen.");
            }
            Console.WriteLine();
        }

        public void AbfrageAlter(Person person)
        {
            if (person != null)
            {
                if (person.GetAlter() >= 16)
                {
                    Console.WriteLine($"{person.GetVorName()} ist {person.GetAlter()}. {person.GetVorName()} kann {_name} Gassi führen! :-)");
                }
                else
                {
                    Console.WriteLine($"{person.GetVorName()} ist {person.GetAlter()} und daher nicht alt genug, um den {_name} Gassi zu führen...");
                }
            } else
            {
                Console.WriteLine("Keine Person ausgewählt.");
            }
            Console.WriteLine();
        }

        public void AbfrageGefuettert()
        {
            if (_gefuettert == true)
            {
                Console.WriteLine($"{_name} ist satt.");
            }
            else
            {
                Console.WriteLine($"{_name} wurde noch nicht gefüttert. Gassi gehen nicht möglich... Sorry! Wuff");
            }
        }

        public void Fuettern()
        {
            Console.WriteLine($"Der Hund {_name} wird gefüttert...");
            _gefuettert = true;
        }

        public void ZeigeHundInfo()
        {
            Console.WriteLine("Hundename: " + _name);
            if (_gefuettert == true) {
                Console.WriteLine($"Der {_name} wurde bereits gefüttert.");
            } else
            {
                Console.WriteLine($"{_name} knurrt der Magen. Bitte füttern :-(");
            } 
        }
    }
}
