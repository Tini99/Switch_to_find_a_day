using System;

namespace Switch_to_find_a_day
{
    /*
         in this programe we will use the switch case statement to find the day of a week.
        User will enter a number between 1 to 7 and then we will display the day corresponding to the number.
        We will use " Day_number" as a user input and it will be a integer type.
        */
    class Program
    {
        static void Main(string[] args)
        {
            int Day_number;

            Console.WriteLine("Enter a number between 1 to 7, to check the day of the week ");
            Day_number = Convert.ToInt32(Console.ReadLine());

            switch(Day_number) //1
            {
                case 1: //1 == Day_number
                    Console.WriteLine("Sunday");
                    break;
                case 2: //2 == Day_number
                    Console.WriteLine(Day_number.ToString() + "the day of a week is Monday");
                    break;
                case 3: //3 == Day_number
                    Console.WriteLine("Tuesday");
                    break;
                case 4: //4 == Day_number
                    Console.WriteLine("Wednesday");
                    break;
                case 5: //5 == Day_number
                    Console.WriteLine("Thrusday");
                    break;
                case 6: //6 == Day_number
                    Console.WriteLine("Friday");
                    break;
                case 7: //7 == Day_number
                    Console.WriteLine("Sartuday");
                    break;
                default:
                    Console.WriteLine("You enter the wrong number");
                    break;

            }
            Console.WriteLine("Thank you");
        }
    }
}
