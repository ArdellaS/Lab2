using System;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            double length;
            double width;
            double height;
            double peri;
            string answer;
            
            

            do
            {

                Console.WriteLine("Hey there. Want to know the perimeter of a room?");
                Console.WriteLine("Enter the length.");
                length = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Now the width");
                width = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("What is the height of the room?");
                height = Convert.ToDouble(Console.ReadLine());

                peri = (length * 2) + (width * 2);

                Console.WriteLine("The perimeter of the room is " + peri);
                Console.WriteLine("The volume of the room is " + (peri * height));

                Console.WriteLine("Would you like to go again? y/n");
                answer = Console.ReadLine();

            } while (answer == "y");
        }
    }
}
