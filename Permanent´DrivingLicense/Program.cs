using System;

namespace Permanent_DrivingLicense
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutaja sünniaastat
            //programm kontrollib kasutaja vanust
            //programm teatab kaustajat, kas ta on piisavalt vana
            //et juhiluba saada

            Console.WriteLine("Mis aastal sa oled sündinud?")
            int Age = Int32.Parse(Console.ReadLine());
            int YearOfBirth = 2021 - Age;

            if (Age > YearOfBirth)
            {
                Console.WriteLine("Oled piisavalt vana et saada juhiluba");
            }
            else if (Age < )
            {
                Console.WriteLine("Oled liiga noor");
            }


        }

    }
}
