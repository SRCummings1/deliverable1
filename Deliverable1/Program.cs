

using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;
namespace Deliverable1
{
    class Program
    {
        static void Main(string[] args)
        {
            int groupSize;
            String result;
            String vacationType;

            Console.WriteLine("What kind of trip would you like to go on, musical, tropical, or adventurous?");
            vacationType = Console.ReadLine();
            Console.WriteLine("How many are in your group");
            groupSize = Convert.ToInt32(Console.ReadLine());

            if (vacationType == "musical" && Convert.ToInt32(groupSize) <= 3)
            {
                result = ("Since you're a group of " + groupSize + " going on a musical vacation, you should fly first class to New Orleans.");
            }
            else
            if (vacationType == "musical" && Convert.ToInt32(groupSize) >= 4 && Convert.ToInt32(groupSize) <= 5)
            {
                result = ("Since you're a group of " + groupSize + " going on a musical vacation, you should take a helicopter to New Orleans.");
            }
            else
            if (vacationType == "musical" && Convert.ToInt32(groupSize) >= 6)
            {
                result = ("Since you're a group of " + groupSize + " going on a musical vacation, you should charter a flight to New Orleans.");
            }
            else
            if (vacationType == "tropical" && Convert.ToInt32(groupSize) <= 3)
            {
                result = ("Since you're a group of " + groupSize + " going on a tropical vacation, you should fly first class to Mexico.");
            }
            else
            if (vacationType == "tropical" && Convert.ToInt32(groupSize) >= 4 && Convert.ToInt32(groupSize) <= 5)
            {
                result = ("Since you're a group of " + groupSize + " going on a tropical vacation, you should take a helicopter to Mexico.");
            }
            else
            if (vacationType == "tropical" && Convert.ToInt32(groupSize) >= 6)
            {
                result = ("Since you're a group of " + groupSize + " going on a tropical vacation, you should charter a flight to Mexico.");
            }
            else
            if (vacationType == "adventurous" && Convert.ToInt32(groupSize) <= 3)
            {
                result = ("Since you're a group of " + groupSize + " going on an adventurous vacation, you should fly first class to Whitewater Rafting the Grand Canyon.");
            }
            else
            if (vacationType == "adventurous" && Convert.ToInt32(groupSize) >= 4 && Convert.ToInt32(groupSize) <= 5)
            {
                result = ("Since you're a group of " + groupSize + " going on an adventurous vacation, you should take a helicopter to Whitewater Rafting the Grand Canyon.");
            }
            else
            if (vacationType == "adventurous" && Convert.ToInt32(groupSize) >= 6)
            {
                result = ("Since you're a group of " + groupSize + " going on an adventurous vacation, you should charter a flight to Whitewater Rafting the Grand Canyon.");
            }
            else
            {
                result = ("Incorrect answer.");
            }
            Console.WriteLine(result);?
            Console.ReadKey();
        } } }