using System;

namespace PersonalityTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutaja sisestada tema lemmikvärvi
            //kui kasutaja sisestab "punane", konsool kuvab "oled Romantiline";
            //kui kasutaja sisestab "roheline", konsool kuvab "oled looduse sõber";
            //kui kasutraja sisestab midai muud, konsool kuvab "oled ükssavrik";

            Console.WriteLine("Mis on su lemmikvärv");
            string UserColor = Console.ReadLine();

            if (UserColor == "punane")
            {
                Console.WriteLine("oled romanitilne");
            }
            else if(UserColor == "sisine")
            {
                Console,WriteLine("oled töökas");
            }
            else if(UserColor == "roheline")
            {
                    Console.WriteLine("oled loodus sõber")
            }
            else 
            {
                Console.WriteLine("oled ükssarvik");
            }  
        }   
        


    }
}
