using System;

namespace positiveNegative
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm palub sisestada numbrit
            //programm kontrollib numbrit
            //kui number on positiivne, konsool kuvab "number on positiivne"
            //kui number on negatiivne, konsool kuvab "number on negatiivne"
            //kui sisestatud number on 0m siis konsool kuvab "null";
            //NB! Int32.Parse asemel kasutame  Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Palun Sisesta Numbrit");
            int Positiivne = Convert.ToInt32(Console.ReadLine());
            int Negatiivne = - + Positiivne;

            if (Positiivne > Negatiivne)
            {
                Console.WriteLine("Number on positiivne");

            }
            else if (Positiivne < Negatiivne)
            {
                Console.WriteLine("Number on Negatiivne");
            }
            else
            {
                Console.WriteLine
            }
            
        }
    }
}
