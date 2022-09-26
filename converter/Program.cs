using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

class Program
{
    double uah;
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
    double usd;
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
    double eur;
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
    double rub;
    public double Rub
    {
        set
        {
            rub = value;
        }
        get
        {
            return rub;
        }
    }
    public static void Main()
    {
        Program program = new Program();
        double usd = 0.027;
        double eur = 0.028;
        double rub = 1.59;
        Console.WriteLine("Виберiть валюту(uah, usd, eur, rub)");
        string userInput = Console.ReadLine();
        if (userInput == "uah")
        {
            Console.WriteLine("Введiть суму в гривнях");
            program.uah = double.Parse(Console.ReadLine());
            Console.WriteLine(program.uah + " гривень - " + program.uah * usd + " доларiв");
            Console.WriteLine(program.uah + " гривень - " + program.uah * eur + " євро");
            Console.WriteLine(program.uah + " гривень - " + program.uah * rub + " рублiв");
        }
        else if (userInput == "usd")
        {
            Console.WriteLine("Введiть суму в доларах");
            program.usd = double.Parse(Console.ReadLine());
            Console.WriteLine(program.usd + " доларiв - " + program.usd / usd + " гривень");
            Console.WriteLine(program.usd + " доларiв - " + program.usd * 1.03 + " євро");
            Console.WriteLine(program.usd + " доларiв - " + program.usd * 57.96 + " рублiв");
        }
        else if (userInput == "eur")
        {
            Console.WriteLine("Введiть суму в євро");
            program.eur = double.Parse(Console.ReadLine());
            Console.WriteLine(program.eur + " євро - " + program.eur / eur + " гривень");
            Console.WriteLine(program.eur + " євро - " + program.eur * 0.97 + " доларiв");
            Console.WriteLine(program.eur + " євро - " + program.eur * 56.15 + " рублiв");
        }
        else if (userInput == "rub")
        {
            Console.WriteLine("Введiть суму в рублях");
            program.rub = double.Parse(Console.ReadLine());
            Console.WriteLine(program.rub + " рублiв - " + program.rub / rub + " гривень");
            Console.WriteLine(program.rub + " рублiв - " + program.rub * 0.017 + " доларiв");
            Console.WriteLine(program.rub + " рублiв - " + program.rub * 0.018 + " євро");
        }
    }
}