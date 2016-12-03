using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentRecords
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 - Add student records");
            Console.WriteLine("2 - Delete student records");
            Console.WriteLine("3 - Update student records");
            Console.WriteLine("4 - View all student records");
            Console.WriteLine("5 - Calculate an average of a selected student's scores");
            Console.WriteLine("6 - Show student who gets the max total score");
            Console.WriteLine("7 - Show student who gets the min total score");
            Console.WriteLine("8 - Find student by ID");
            Console.WriteLine("9 - Sort records by total scores");

            Console.WriteLine("\nEnter your choice: ");

            int userChoiceMenu1 = int.Parse(Console.ReadLine());

            switch (userChoiceMenu1)
            {
                case 1: //do stuff
                    break;
                case 2: //do stuff
                    break;
                case 3: //do stuff
                    break;
                case 4: //do stuff
                    break;
                case 5: //do stuff
                    break;
                case 6: //do stuff
                    break;
                case 7: //do stuff
                    break;
                case 8: //do stuff
                    break;
                case 9: //do stuff
                    break;
            }
        }
    }
}
