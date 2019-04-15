using System;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            string answer;
            
            Console.WriteLine("Hey there. Want to know the perimeter of a room?");

            do
            {

                double length;
                Console.WriteLine("Enter the length.");
                length = int.Parse(Console.ReadLine());

                double width;
                Console.WriteLine("Now the width");
                width = int.Parse(Console.ReadLine());

                double height;
                Console.WriteLine("What is the height of the room?");
                height = int.Parse(Console.ReadLine());

                double peri;
                peri = (length * 2) + (width * 2);

                Console.WriteLine("The perimeter of the room is " + peri);
                Console.WriteLine("The volume of the room is " + (peri * height));

                Console.WriteLine("Would you like to go again? y/n");
                answer = Console.ReadLine();

            } while (answer == "y");
        }
    }
}