namespace sep27_fr_oop_Beziehungen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Adresse ersteAdresse = new Adresse("Musterstrasse", 123, 10301, "Berlin");
            Adresse zweiteAdresse = new Adresse("Laerholzstrasse", 11, 44801, "Bochum");

            Person erstePerson = new Person("Müldür", "Mert", 25);
            Person zweitePerson = new Person("Kaya", "Fuat", 31);
            Person drittePerson = new Person("Lee", "Leonie", 7);
            Person viertePerson = new Person("Can", "Ayla", 15);

            Hund ersterHund = new Hund("Bello");
            Hund zweiterHund = new Hund("Wauwau");
            Hund dritterHund = new Hund("Drecksköter");
            Hund vierterHund = new Hund("Magersuchthund");

            // erstePerson erhält die Adresse ersteAdresse
            erstePerson.SetAdresse(ersteAdresse);

            Console.WriteLine();

            // zweitePerson erhält die Adresse zweiteAdresse
            zweitePerson.SetAdresse(zweiteAdresse);

            // Hund erst Füttern, dann mit drittePerson Gassi führen
            drittePerson.SetHund(zweiterHund);
            zweiterHund.Fuettern();
            zweiterHund.Gassi(drittePerson);

            // Hund erst Füttern, dann mit zweiterPerson Gassi führen
            //ersterHund.Fuettern();
            zweitePerson.SetHund(ersterHund);
            ersterHund.Gassi(zweitePerson);
        }
    }
}
