using System;

namespace ImportoScontato
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("imetti l'importo");
            double totale = double.Parse(Console.ReadLine());
            double sconto = totale * 100 / 20;
            if (totale > 100)
            {
                double importo = totale - sconto;
                Console.WriteLine($"l'importo scontato è{importo}");

            }
            else
                Console.WriteLine($"la spesa è di {totale}");
            Console.ReadLine();
        } 
    }
}
