using Gnarly.bl;
using System;

namespace Gnarly
{
    class Program
    {
        static void Main(string[] args)
        {
            //User inputs

            UserValidation user = new UserValidation();

            Console.WriteLine("LOG IN ONLINE SHOPPING");
            Console.WriteLine("(1)LOG IN ");
            Console.WriteLine("(2)Register");
            int userInput = int.Parse(Console.ReadLine());

            if (userInput.Equals(1))
            {
                user.LogIn();
            }
            else if (userInput.Equals(2))
            {
                user.Register();
            }
            else
            {
            }

            Console.ReadKey();


            Console.WriteLine("\n!Welcome to GNARLY!");
            Console.WriteLine("------------------");
            Console.WriteLine("Established in 2008, Gnarly! is a lifestyle brand dedicated to introducing and sustaining a \n streetwear culture fueled by comics, music, skateboarding, people, and most especially, \n extreme fun to individuals worldwide");
            Console.WriteLine("------------------");
            Console.WriteLine("T-SHIRT Available");
            Console.WriteLine("\n[1]BIOHAZARD $39.99 \n[2]CRAZY $40 \n[3]BANZAI $38.99 \n[4]BEESWAX $49.99 \n[5]FUDGE RAMEN $50 \n[6]BUMMER $56.99 \n[7]GREM'S VERTIGO $49.99 \n[8]PLANET G $40.99 \n[9]FISHING FOR PEACE $39.99 \n[10]HOLIDAY BREAK $49.99");

            Console.WriteLine("------------------");

            int tshirt;
            Console.WriteLine("Enter an item");
            Console.WriteLine("------------------");
            tshirt = Convert.ToInt32(Console.ReadLine());
            switch (tshirt)
            {
                case 1:
                    Console.WriteLine("\n[1] BIOHAZARD $39.99");
                    break;
                case 2:
                    Console.WriteLine("\n[2] CRAZY $40");
                    break;
                case 3:
                    Console.WriteLine("\n[3] BANZAI $38.99");
                    break;
                case 4:
                    Console.WriteLine("\n[4] BEESWAX $49.99");
                    break;
                case 5:
                    Console.WriteLine("\n[5] BEESWAX $49.99");
                    break;
                case 6:
                    Console.WriteLine("\n[6] BUMMER $56.99");
                    break;
                case 7:
                    Console.WriteLine("\n[7] GREM'S VERTIGO $49.99");
                    break;
                case 8:
                    Console.WriteLine("\n[8] PLANET G $40.99");
                    break;
                case 9:
                    Console.WriteLine("\n[9] FISHING FOR PEACE $39.99");
                    break;
                case 10:
                    Console.WriteLine("\n[10] HOLIDAY BREAK $49.99");
                    break;
            }
            Console.WriteLine("------------------");

            Console.WriteLine("Enter to Confirm your Order");
            Console.WriteLine("------------------");
            Console.ReadKey();
            Console.WriteLine("Thank You for Choosing Gnarly");


        }
    }
}