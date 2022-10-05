using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

    class Program
    {
        static void Main(string[] args)
        {
            Converter converter = new Converter();
            converter.Usd = 0.027;
            converter.Eur = 0.028;
            converter.Pln = 0.13;

            converter.UsdToUah = 36.61;
            converter.UsdToEur = 1.01;
            converter.UsdToPln = 4.84;

            converter.EurToUah = 36.41;
            converter.EurToUsd = 0.99;
            converter.EurToPln = 4.82;

            converter.PlnToUah = 7.56;
            converter.PlnToUsd = 0.21;
            converter.PlnToEur = 0.21;

            converter.Exchange();
        }
    }
    class Converter
    {
        private double uah;
        private double usd;
        private double eur;
        private double pln;
        private double usdToUah;
        private double usdToEur;
        private double usdToPln;
        private double eurToUah;
        private double eurToUsd;
        private double eurToPln;
        private double plnToUah;
        private double plnToUsd;
        private double plnToEur;
        public double Uah
        {
            set
            {
                uah = value;
            }
            get
            {
                return uah;
            }
        }
        public double Usd
        {
            set
            {
                usd = value;
            }
            get
            {
                return usd;
            }
        }
        public double Eur
        {
            set
            {
                eur = value;
            }
            get
            {
                return eur;
            }
        }
        public double Pln
        {
            set
            {
                pln = value;
            }
            get
            {
                return pln;
            }
        }
        public double UsdToUah
        {
            set
            {
                usdToUah = value;
            }
            get
            {
                return usdToUah;
            }
        }
        public double UsdToEur
        {
            set
            {
                usdToEur = value;
            }
            get
            {
                return usdToEur;
            }
        }
        public double UsdToPln
        {
            set
            {
                usdToPln = value;
            }
            get
            {
                return usdToPln;
            }
        }
        public double EurToUah
        {
            set
            {
                eurToUah = value;
            }
            get
            {
                return eurToUah;
            }
        }
        public double EurToUsd
        {
            set
            {
                eurToUsd = value;
            }
            get
            {
                return eurToUsd;
            }
        }
        public double EurToPln
        {
            set
            {
                eurToPln = value;
            }
            get
            {
                return eurToPln;
            }
        }
        public double PlnToUah
        {
            set
            {
                plnToUah = value;
            }
            get
            {
                return plnToUah;
            }
        }
        public double PlnToUsd
        {
            set
            {
                plnToUsd = value;
            }
            get
            {
                return plnToUsd;
            }
        }
        public double PlnToEur
        {
            set
            {
                plnToEur = value;
            }
            get
            {
                return plnToEur;
            }
        }
       public void Exchange()
        {
            Console.WriteLine("Виберiть валюту (uah, usd, eur, pln)");
            string userInput = Console.ReadLine();
            if (userInput == "uah")
            {
                Console.WriteLine("Введiть валюту у UAH");
                uah = double.Parse(Console.ReadLine());
                Console.WriteLine(uah + " UAH - " + uah * usd + " USD");
                Console.WriteLine(uah + " UAH - " + uah * eur + " EUR");
                Console.WriteLine(uah + " UAH - " + uah * pln + " PLN");
            }
            else if (userInput == "usd")
            {
                Console.WriteLine("Введiть валюту у USD");
                usd = double.Parse(Console.ReadLine());
                Console.WriteLine(usd + " USD - " + usd * usdToUah + " UAH");
                Console.WriteLine(usd + " USD - " + usd * usdToEur + " EUR");
                Console.WriteLine(usd + " USD - " + usd * usdToPln + " PLN");
            }
            else if (userInput == "eur")
            {
                Console.WriteLine("Введiть валюту у EUR");
                eur = double.Parse(Console.ReadLine());
                Console.WriteLine(eur + " EUR - " + eur * eurToUah + " UAH");
                Console.WriteLine(eur + " EUR - " + eur * eurToUsd + " USD");
                Console.WriteLine(eur + " EUR - " + eur * eurToPln + " PLN");
            }
            else if (userInput == "pln")
            {
                Console.WriteLine("Введiть валюту у PLN");
                pln = double.Parse(Console.ReadLine());
                Console.WriteLine(pln + " PLN - " + pln * plnToUah + " UAH");
                Console.WriteLine(pln + " PLN - " + pln * plnToUsd + " USD");
                Console.WriteLine(pln + " PLN - " + pln * plnToEur + " EUR");
            }
        }
    }
