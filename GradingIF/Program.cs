using System;

namespace GradingIF
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib mis hinde kasutaja sai
            //kui kasutaja sai "A", konsool kuvab "Suurepärane!";
            //"B", konsool kuvab "Väga hea!";
            //"C", konsool kuvab "Hea!";
            //"D", konsool kuvab "Rahuldav!";
            //"E", konsool kuvab "Kasin!";
            //"F", konsool kuvab "Puudulik!";
            //kui kasutaja siestab midagi muud, siis konsool kuvab "vale väärtus"

            //kasutame IF


            Console.WriteLine("Sisesta oma tulemus:");
            //char - character
            char userResult = Convert.ToChar(Console.ReadLine().ToUpper());

            if (userResult == 'A')
            {
                Console.WriteLine("Suurepärane!");
            }
            if (userResult == 'B')
            {
                Console.WriteLine("Väga hea!");
            }
            if (userResult == 'C')
            {
                Console.WriteLine("Hea!");
            }
            if (userResult == 'D')
            {
                Console.WriteLine("Rahuldav!");
            }
            if (userResult == 'E')
            {
                Console.WriteLine("Kasin!");
            }
            if (userResult == 'F')
            {
                Console.WriteLine("Puudulik!");
            }
            else
            {
                Console.WriteLine("Vale väärtus!");
            }
        }
    }
}
