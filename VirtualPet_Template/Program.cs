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

            // Introduction and Pet Naming
            VirtualPet myPet = new VirtualPet();
            Console.Write("Hello!  Welcome to VirtuaPet! \n\nWould you like to name your pet?(y/n): ");
            string nameQuest = Console.ReadLine().ToLower();

            if (nameQuest == "y" || nameQuest=="yes")
            {
                myPet.PetName();
            }
            else if(nameQuest=="n" || nameQuest == "no")
            {
                
            }
            else
            {
                Console.WriteLine("Invalid answwer, would you like to name your pet (y/n)?: ");
                nameQuest = Console.ReadLine().ToLower();

            }


            // Main Menu
            int selectedOption;
            do
            {

                myPet.MyPetStatus();

                Console.WriteLine();
                Console.WriteLine("Please select an option");
                Console.WriteLine("1. Feed your pet");
                Console.WriteLine("2. Give your pet a drink");
                Console.WriteLine("3. Put your pet to bed");
                Console.WriteLine("4. Play with your pet");
                Console.WriteLine("5. Give your pet a bath");
                Console.WriteLine("6. Discipline your pet");
                Console.WriteLine("7. Rename Pet");
                Console.WriteLine("8. Have pet do a magic trick");
                //Console.WriteLine("9. Advanced Options");
                Console.WriteLine("10. Quit");


                selectedOption = int.Parse(Console.ReadLine());              

                switch (selectedOption)
                {
                    // Feed Pet
                    case 1:

                        myPet.StomachIncrease();
                        myPet.HitPointsIncrease();
                        myPet.ActivityDecrease();
                        Console.WriteLine("Yummy!! (Is what I am thinking because I can't speak!)");
                        break;

                    // Hydrate Pet
                    case 2:

                        myPet.HydrationIncrease();
                        myPet.ActivityDecrease();
                        Console.WriteLine("Ahhh");
                        break;

                    // Pet Sleep
                    case 3:

                        myPet.BehaviorIncrease();
                        myPet.HitPointsIncrease();                          
                        myPet.ManaIncrease();
                        myPet.ActivityDecrease();
                        Console.WriteLine("I feel much better after a nap, is what I would say if I could talk!");
                        break;

                    // Play with Pet
                    case 4:

                        myPet.ActivityIncrease();
                        myPet.ActivityIncrease();
                        myPet.StomachDecrease();
                        myPet.HitPointsDecrease();
                        myPet.HydrationDecrease();
                        Console.WriteLine("That was fun!! (If I could talk)");
                        break;

                    // Bath Pet
                    case 5:

                        myPet.StomachDecrease();
                        Console.WriteLine("I hate baths!");
                        break;

                    // Discipline Pet
                    case 6:

                        myPet.Punish();
                        Console.WriteLine("I learned my lesson");
                        break;
                    
                    // Rename Pet
                    case 7:

                        myPet.PetName();
                        break;

                    // Pet Magic Trick
                    //case 8:

                    //    myPet.ManaTrick();
                    //    break;

                    case 10:

                        Console.WriteLine("Thank you for playing.");
                        break;

                    default:

                        Console.WriteLine("Invalid option selected.");
                        break;
                }

                
                myPet.StomachIncrease();

            } while (selectedOption != 10);

        }
    }
}
