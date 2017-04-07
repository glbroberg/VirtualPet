using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet_Template
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hello!  Welcome to VirtuaPet! \n\n Would you like to name your pet?(y/n): ");
            string nameQuest = Console.ReadLine().ToLower();


            Console.WriteLine();
            VirtualPet myPet = new VirtualPet();


            //TODO add a greeting for the user. you can also let the user name the pet if you like

            int selectedOption;

            do
            {
                //TODO fill this out with more options to interact with the pet
                Console.WriteLine();
                Console.WriteLine("Please select an option");
                Console.WriteLine("1. Feed the pet");
                Console.WriteLine("2. Put the pet to bed");
                Console.WriteLine("3. Play with the pet");
                Console.WriteLine("4. Give the pet a drink");
                Console.WriteLine("5. Discipline the pet");
                Console.WriteLine("6. Rename Pet");
                Console.WriteLine("10. Quit");


                selectedOption = int.Parse(Console.ReadLine());

                myPet.MyPetStatus();

                switch (selectedOption)
                {
                    //when the user selects option one we feed the pet
                    case 1:

                        myPet.HungerDecrease();
                        Console.WriteLine("Thank you for feeding the pet");
                        break;

                    case 2:

                        myPet.HungerDecrease();
                        Console.WriteLine("Thank you for feeding the pet");
                        break;

                    case 3:

                        myPet.HungerDecrease();
                        Console.WriteLine("Thank you for feeding the pet");
                        break;

                    case 4:

                        myPet.HungerDecrease();
                        Console.WriteLine("Thank you for feeding the pet");
                        break;

                    case 5:

                        myPet.HungerDecrease();
                        Console.WriteLine("Thank you for feeding the pet");
                        break;

                    case 6:

                        myPet.HungerDecrease();
                        Console.WriteLine("Thank you for feeding the pet");
                        break;

                    case 10:

                        Console.WriteLine("Thank you for playing.");
                        break;

                    default:

                        Console.WriteLine("Invalid option selected.");
                        break;
                }

                //TODO We can put method calls here so the pet can have some values change automatically
                //Feel free to add, remove, or modify which methods are called here
                myPet.HungerIncrease();

            } while (selectedOption != 10);

        }
    }
}
