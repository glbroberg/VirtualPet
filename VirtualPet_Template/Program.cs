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
            Console.Write("Hello!  Welcome to VirtuaPet! \n\n" +
              "           _          (`-." + "\n" +
              "           \\`----.    ) ^_`)" + "\n" +
              "     ,__    \\__  `\\_ /  (  `" + "\n" +
              "      \\_\\     \\__  `|   }" + "\n" +
              "        \\\\  .-' \\__/    }" + "\n" +
              "         ))/   \\__,<  /_/" + "\n" +
              "         ((|  _/_/ `\\ \\_\\_" + "\n" +
              "           '\\____\\\\  )__\\_\\" + "\n");

            Console.Write("\n\nWould you like to name your Gryphon?(y/n): ");
            string nameQuest = Console.ReadLine().ToLower();
            myPet.PetName(nameQuest);
            //if (nameQuest == "y" || nameQuest=="yes")
            //{
            //    myPet.PetName();
            //}
            //else if(nameQuest=="n" || nameQuest == "no")
            //{
                
            //}
            //else
            //{
            //    Console.WriteLine("Invalid answwer, would you like to name your Gryphon (y/n)?: ");
            //    nameQuest = Console.ReadLine().ToLower();
                
            //        myPet.PetName();
                
            //}


            // Main Menu
            int selectedOption;
            do
            {
                myPet.MyPetStatus();

                Console.WriteLine();
                Console.WriteLine("Please select an option");
                Console.WriteLine("1. Feed your Gryphon");
                Console.WriteLine("2. Give your Gryphon a drink");
                Console.WriteLine("3. Put your Gryphon to bed");
                Console.WriteLine("4. Play with your Gryphon");              
                Console.WriteLine("5. Discipline your Gryphon");
                Console.WriteLine("6. Rename Gryphon");
                //Console.WriteLine("7. Have your pet do a trick");
                //Console.WriteLine("8. Advanced Options");                                
                Console.WriteLine("7. Quit");

                int quitOption = 7;
                selectedOption = int.Parse(Console.ReadLine());              

                switch (selectedOption)
                {
                                   
                    // Feed Pet
                    case 1:
                        myPet.FeedPet();
                        if (myPet.DeathCheck())
                        {
                            Console.WriteLine("\nGAME OVER!!");
                            selectedOption = quitOption;
                            break;
                        }                        
                        break;


                    // Hydrate Pet
                    case 2:
                        myPet.HydrationIncrease();
                        myPet.ActivityDecrease();
                        if (myPet.DeathCheck())
                        {
                            Console.WriteLine("\nGAME OVER!!");
                            selectedOption = quitOption;
                            break;
                        }
                        Console.WriteLine("Ahhh");
                        break;

                    
                    // Pet Sleep
                    case 3:
                        myPet.BehaviorIncrease();
                        myPet.HitPointsIncrease();                          
                        myPet.ManaIncrease();
                        myPet.ActivityDecrease();
                        if (myPet.DeathCheck())
                        {
                            Console.WriteLine("\nGAME OVER!!");
                            selectedOption = quitOption;
                            break;
                        }
                        Console.WriteLine("I feel much better after a nap, is what I would say if I could talk!");
                        break;

                    
                    // Play with Pet
                    case 4:
                        myPet.ActivityIncrease();
                        myPet.ActivityIncrease();
                        myPet.StomachDecrease();
                        myPet.HitPointsDecrease();
                        myPet.HydrationDecrease();
                        if (myPet.DeathCheck())
                        {
                            Console.WriteLine("\nGAME OVER!!");
                            selectedOption = quitOption;
                            break;
                        }
                        Console.WriteLine("That was fun!!");
                        break;

                    
                    // Discipline Pet
                    case 5:
                        myPet.Punish();
                        if (myPet.DeathCheck())
                        {
                            Console.WriteLine("\nGAME OVER!!");
                            selectedOption = quitOption;
                            break;
                        }                        
                        break;
                    
                    
                    // Rename Pet
                    case 6:
                        myPet.PetName("y");
                        break;
                    
                        
                    // Quit Option
                    case 7:
                        Console.WriteLine("Thank you for playing.");
                        break;

                    default:
                        Console.WriteLine("Invalid option selected.");
                        break;
                }

            } while (selectedOption != 7);

        }
    }
}
