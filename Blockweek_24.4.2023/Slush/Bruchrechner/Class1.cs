using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bruchrechner
{
    public class Rechner
    {
        public double Zaehler { get; set; }
        public double Nenner { get; set; }


        public Rechner(double zaehler, double nenner)
        {
            double ggt = GGT(zaehler, nenner);
            Zaehler = zaehler / ggt;
            Nenner = nenner / ggt;
        }

        public static Rechner Addition(Rechner f1, Rechner f2)
        {
            double zaehler = f1.Zaehler * f2.Zaehler;
            double nenner = f1.Nenner * f2.Nenner;
            return new Rechner(zaehler, nenner);
        }
        public static Rechner Subtraktion(Rechner f1, Rechner f2)
        {
            double zaehler = f1.Zaehler* f2.Nenner - f2.Zaehler * f1.Nenner;
            double nenner = f1.Nenner * f2.Nenner;
            return new Rechner(zaehler, nenner);
        }

        public static Rechner Multiplikation(Rechner f1, Rechner f2)
        {
            double zaehler = f1.Zaehler * f2.Zaehler;
            double nenner = f1.Nenner * f2.Nenner;
            return new Rechner(zaehler, nenner);
        }

        public static Rechner Division(Rechner f1, Rechner f2)
        {
            double zaehler= f1.Zaehler * f2.Nenner;
            double nenner = f1.Nenner * f2.Zaehler;
            return new Rechner(zaehler, nenner);
        }

        public static Rechner Potenzieren(Rechner f, int n)
        {
            double zaehler = Math.Pow(f.Zaehler, n);
            double nenner = Math.Pow(f.Nenner, n);
            return new Rechner(zaehler, nenner);
        }

        //Rechenlogik Wurzel
        public static Rechner Wurzel(Rechner f)
        {
            double zaehler = (double)Math.Sqrt(f.Zaehler);
            double nenner = (double)Math.Sqrt(f.Nenner);
            return new Rechner(zaehler, nenner);
        }

        //Überladung der ToString Methode. Notwendig, um richtigen Output zu bekommen
        public override string ToString()
        {
            if (Nenner == 1)
                return Zaehler.ToString();
            else
                return "Zähler: " + Zaehler + " | Nenner: " + Nenner;
        }

        double GGT(double a, double b)
        {
            if (b == 0)
            {
                return a;
            }
            else
            {
                return GGT(b, a % b);
            }
        }
    }
}
