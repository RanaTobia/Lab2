using System;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Welcome to Grand Circus’ Room Detail Generator! ");
            Console.WriteLine("We are Glad to Help you Today!! ");

            // Declare the variable 

            bool Valid = false;
            decimal number;

            // Start While-Do loop to continue measuring the room until the user respond with no

            while (Valid == false)
            {

                Console.WriteLine("Enter The Width of The Room : ");

                string width = Console.ReadLine();

                // check if the user input a right number for width

                if (decimal.TryParse(width, out number)) {
                    Valid = true;
                    Console.WriteLine("Enter The Lenght of The Room : ");
                    string length = Console.ReadLine();

                // check if the user input a right number for length

                    if (decimal.TryParse(length, out number))
                    {
                        Valid = true;
                        Console.WriteLine("Enter The Height of The Room : ");
                        string height = Console.ReadLine();

                // check if the user input a right number for height

                        if (decimal.TryParse(height, out number))
                        {
                            Valid = true;
                            decimal area = (decimal.Parse(width)) * (decimal.Parse(length));
                            decimal perimeter = 2*(decimal.Parse(width)+ decimal.Parse(length));
                            decimal volume = decimal.Parse(width) * decimal.Parse(length) * decimal.Parse(height);
                            Console.WriteLine("The Area is Equal to : {0}", area);
                            Console.WriteLine($"The Perimeter is Equal to: {perimeter}", perimeter);
                            Console.WriteLine($"The Volume is Equal to: {volume}", volume);

                 // check if the user want to continue measuring another room
       
                            Console.WriteLine("Do You Want to Continue Measuring Another Room? (y/n):");
                            string respond = Console.ReadLine();
                            if (respond == "y" || respond == "y")   // if Yes continue
                            {
                               Valid = false;
                            }
                            else     //exit the program 
                            {
                                Console.WriteLine("Good Bye");
                                break;      
                            }
                        }
                        else // when we input a wrong data type for the height
                        {
                            Console.WriteLine("Invalid Number For The Height");
                            Console.WriteLine("Please Try Again");
                            Valid = false;
                        }

                    }
                    else // when the user input a wrong data type for the lenght
                    {
                        Console.WriteLine("Invalid Number For The Lenght");
                        Console.WriteLine("Please Try Again");
                        Valid = false;
                    }
                }
                else  // when we input a wrong data type for the width
                {
                    Console.WriteLine("Invalid Number For The Width");
                    Console.WriteLine("Please Try Again");
                    Valid = false;
                }
            }
        }
    }
}
