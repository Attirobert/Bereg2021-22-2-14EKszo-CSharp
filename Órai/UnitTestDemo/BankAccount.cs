using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestDemo
{
    // Az osztály public legyen, hogy a teszt elérje
    public class BankAccount
    {
        // Properties
        string ugyfelNeve;
        double egyenleg;

        // Konstruktor
        public BankAccount( string UgyfelNeve, double Egyenleg)
        {
            ugyfelNeve = UgyfelNeve;
            egyenleg = Egyenleg;
        }

        // Egyenleg lekérdezés
        public double Egyenleg { get { return egyenleg; } }

        // Pénz kivétel
        public void Kivet(double osszeg)
        {
            if (egyenleg == 0) throw new Exception("Az egyenleg = 0");
            if (osszeg <= 0 || osszeg > egyenleg) throw new ArgumentOutOfRangeException("A kifizetésre nincs fedezet.");

            egyenleg -= osszeg;
        }

        // Pénz befizetés
        public void Betet(double osszeg)
        {
            if (osszeg <= 0) throw new ArgumentOutOfRangeException("Tartozás törlesztésre elszámoltuk.");

            egyenleg += osszeg;
        }
    }
}
