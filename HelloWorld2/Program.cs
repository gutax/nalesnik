using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Zawijasz naleśniki w rulon czy trójkąt?");
        string odpowiedz = Console.ReadLine();

        if (odpowiedz.ToLower() == "rulon")
        {
            Console.WriteLine("Debil.");
        }
        else if (odpowiedz.ToLower() == "trojkat")
        {
            Console.WriteLine("Gratulacje!");
        }
        else
        {
            Console.WriteLine("wpisz rulon albo trojkat(bez polskich znakow)");
        }

        Console.WriteLine("koniec");
        Console.ReadKey();
    }
}
