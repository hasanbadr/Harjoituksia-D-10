using System;

class Program
{
    static void Main()
    {
        Console.Write("Syötä kokonaisluku väliltä 1 - 10: ");
        int luku = int.Parse(Console.ReadLine());

        if (luku >= 1 && luku <= 10)
        {
            for (int i = 1; i <= 10; i++)
            {
                int tulos = luku * i;
                Console.WriteLine($"{luku} x {i} = {tulos}");
            }
        }
        else
        {
            Console.WriteLine("Syötä luku väliltä 1 - 10.");
        }
    }
}