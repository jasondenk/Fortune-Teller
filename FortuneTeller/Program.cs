using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FortuneTeller
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare Variables
            string firstName;
            string lastName;
            int age;
            int birthMonth;
            string color;
            string colorLower;
            char colorChar;
            int siblings;
            int retirement;
            string vacationLocation;
            string transportation = "walk";
            int bankMoney;

            //PART I
            Console.WriteLine("Type your first name, press enter: ");
            firstName = Console.ReadLine();
            Console.WriteLine("Type your last name, press enter: ");
            lastName = Console.ReadLine();
            Console.WriteLine("Type your age, press enter: ");
            age = int.Parse(Console.ReadLine());
            Console.WriteLine("Type your birth month (as a number), press enter: ");
            birthMonth = int.Parse(Console.ReadLine());
            Console.WriteLine("Type your favorite letter of the color spectrum ROYGBIV, or \nif you don't know what colors are in ROYGBIV, type help, then press enter:");
            color = Console.ReadLine();
            colorLower = color.ToLower();
            if (colorLower == "help")
            {
                Console.WriteLine(" R=red \n O=orange \n Y=yellow \n G=green \n B=blue \n I=indigo \n V=violet \n");
                Console.WriteLine("Enter your favorite letter of the color spectrum ROYGBIV, press enter: ");
                color = Console.ReadLine();
                colorLower = color.ToLower();
            }
            colorChar = Convert.ToChar(colorLower);
            
                              
            Console.WriteLine("Type your number of siblings, press enter: ");
            siblings = int.Parse(Console.ReadLine());

            //part2
            
            if (age%2==0)
            {
                retirement = 2;
            }
            else
            {
                retirement = 3;
            }

            
            if (siblings == 0)
            {
                vacationLocation = "Hawaii";
            }
            else if (siblings == 1)
            {
                vacationLocation = "Peru";
            }
            else if (siblings == 2)
            {
                vacationLocation = "New Zealand";
            }
            else if (siblings == 3)
            {
                vacationLocation = "California";
            }
            else if (siblings > 3)
            {
                vacationLocation = "Mexico";
            }
            else
            {
                vacationLocation = "Bonndock, South Dakota";
            }

            
            switch (colorChar)
            {
                case 'r':
                    transportation = "boat";
                    break;
                case 'o':
                    transportation = "jet";
                    break;
                case 'y':
                    transportation = "hot air balloon";
                    break;
                case 'g':
                    transportation = "sled dog team";
                    break;
                case 'b':
                    transportation = "jeep";
                    break;
                case 'i':
                    transportation = "submarine";
                    break;
                case 'v':
                    transportation = "helicopter";
                    break;                                                           
            }

            
            if (birthMonth >= 1 & birthMonth <= 12)
            {
                if (birthMonth <= 4)
                {
                    bankMoney = 10000000;
                }
                else if (birthMonth <= 8)
                {
                    bankMoney = 20000000;
                }
                else
                {
                    bankMoney = 30000000;
                }
            }
            else
            {
                bankMoney = 0;
            }

            //PART 3

            Console.WriteLine(firstName + " " + lastName + " will retire in " + retirement + " years with $" + bankMoney + " in the bank, a vacation home in " + vacationLocation + " and a " + transportation + ".");
            
                
              
        

        }
    }
}
