using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet_Template
{

    class VirtualPet
    {
        // Initiat Fields
        private string name;
        private int stomach;
        private int hydration;
        private int behavior;
        private int hitPoints;
        private int activity;
        private int mana;
        private int bigMacCount = 0;
         
        // Default Constructor
        public VirtualPet()
        {
            this.name = "Nameless Loser";
            this.stomach = 20;
            this.hydration = 50;
            this.behavior = 50;
            this.hitPoints = 50;
            this.activity = 50;
            this.mana = 20;
        }


        // Assigns Pet Name
        public void PetName(string nameAns)
        {
            if (nameAns == "y" || nameAns == "yes")
            {
                Console.Write("Please type your pet's name: ");
                name = Console.ReadLine();
                return;
            }
            else if (nameAns == "n" || nameAns == "no")
            {
                return;
            }
            else
            {
                Console.WriteLine("Invalid answwer, would you like to name your Gryphon (y/n)?: ");
                string nameRecheck = Console.ReadLine().ToLower();
                PetName(nameRecheck);
            }
        }


        //************* Attribute Modifying Methods **********************************  

        //Stomach Block
        public void StomachIncrease()
        {
            this.stomach = stomach + 5;
        }
        public void StomachDecrease()
        {
            this.stomach = stomach - 5;
        }

        // Feeding choice
        public void FeedPet()
        {
            Console.WriteLine("What would you like to feed "+name+"?\n1. Birdseed"
                                +"\n2. Raw Meat\n3. Big Mac");
            string feedChoice = Console.ReadLine();
            int a;
            bool valid = int.TryParse(feedChoice, out a);
            
            switch (a)
            {
                case 1:
                    Console.WriteLine("Ohh, birdseed, I love birdseed");
                    StomachIncrease();
                    break;

                case 2:
                    StomachIncrease();
                    StomachIncrease();
                    HitPointsIncrease();
                    Console.WriteLine("MEAT! MEAT! MEAT!");
                    break;

                case 3:
                    StomachIncrease();
                    ManaDecrease();
                    ActivityDecrease();
                    HitPointsDecrease();
                    Console.WriteLine("WTF is this?!?!  I Like it, but I feel like I might die later..."+bigMacCount);
                    bigMacCount++;
                    break;

                default:
                    Console.WriteLine("Pick a valid option");
                    break;
            }
        }

        // Hydration Block
        public void HydrationIncrease()
        {
            this.hydration = hydration + 5;
        }
        public void HydrationDecrease()
        {
            this.hydration = hydration - 5;

        }

        // Behavior Block
        public void BehaviorIncrease()
        {
            this.behavior = behavior + 5;
        }
        public void behaviorDecrease()
        {
            this.behavior = behavior - 5;
        }

        // Punishment Block
        public void Punish()
        {
            Console.WriteLine("Choose how to discipline your Gryphon: \n.1 Stern talking-to \n2. Spanking");
            string punishInput = Console.ReadLine();
            int a;
            bool valid = int.TryParse(punishInput, out a);
            switch (a)
            {
                case 1:
                    BehaviorIncrease();
                    ActivityDecrease();
                    Console.WriteLine("I learned my lesson");
                    break;

                case 2:
                    BehaviorIncrease();
                    BehaviorIncrease();
                    HitPointsDecrease();
                    ManaDecrease();
                    Console.WriteLine("Ouch, my butt hurts!!");
                    break;

                default:
                    Console.Write("Enter valid option number:");
                    Punish();
                    break;
            }    
        }

        // Hit Points Block
        public void HitPointsIncrease()
        {
            this.hitPoints = hitPoints + 5;
        }
        public void HitPointsDecrease()
        {
            this.hitPoints = hitPoints - 5;
        }

        // Bordem Block
        public void ActivityIncrease()
        {
            this.activity = activity + 5;
        }
        public void ActivityDecrease()
        {
            this.activity = activity - 5;
        }

        // Mana Block
        public void ManaIncrease()
        {
            this.mana = mana + 5;
        }
        public void ManaDecrease()
        {
            this.mana = mana - 5;
        }

        //****************** End of Attribute Modifying Methods *****************************


        public bool DeathCheck()
        {
            bool death = false;

            if( bigMacCount == 3)
            {
                Console.WriteLine("Your Gryphon has passes due to heart disease, most likely \n"+
                                   "caused by too much fast food");
                death = true;
            }
            if (stomach == 0)
            {
                Console.WriteLine("Your Gryphon has died of hunger!!");
                death = true;
            }

            if (hydration == 0)
            {
                Console.WriteLine("Your Gryphon has died of thurst!!");
                death = true;
            }

            if (activity == 0)
            {
                Console.WriteLine("Your Gryphon has died from being too lazy!!");
                death = true;
            }

            if (hitPoints == 0)
            {
                Console.WriteLine("Your Gryphon has been beaten to death!!");
                death = true;
            }

            if (behavior == 0)
            {
                Console.WriteLine("Your Gryphon has been eaten for being a jerk!!");
                death = true;
            }

            if (stomach == 100)
            {
                Console.WriteLine("Your Gryphon was stuffed to death!");
                death = true;
            }

            if (hydration == 100)
            {
                Console.WriteLine("Your Gryphon has internally drowned!!");
                death = true;
            }

            if (activity == 100)
            {
                Console.WriteLine("Your Gryphon's heart exploded!!");
                death = true;
            }

            return death;
        }


        // Full check
        public bool FullCheck()
        {
            bool full = false;
            if (hitPoints == 100)
            {
                Console.WriteLine("Your pet has full health!!");
                full = true;
            }
            if (behavior == 100)
            {
                Console.WriteLine("Your pet is well behaved");
                full = true;
            }

            return full;
        }

        // Status Meter Conversion
        public string StatusMeter(int a)
        {
            char[] level = { '_', '_', '_', '_', '_', '_', '_', '_', '_', '_' };
            int count = 0;
            int b = 9;
            while (b<a)
            {
                level[count] = '+';
                count++;
                b = b + 10; 
            }
            string reading = new string(level);
            return reading;
        }
   

        // Method for stats of virtual pet
        public void MyPetStatus()
        {
            Console.WriteLine(name);
            Console.WriteLine("Stomach:     " + StatusMeter(stomach)+ " "+stomach+"%");
            Console.WriteLine("Hydration:   " + StatusMeter(hydration)+ " " + hydration + "%");
            Console.WriteLine("Behavior:    " + StatusMeter(behavior) +" " + behavior + "%");
            Console.WriteLine("Hit Points:  " + StatusMeter(hitPoints)+ " " + hitPoints + "%");
            Console.WriteLine("Activity:    " + StatusMeter(activity) +" " + activity + "%");
            Console.WriteLine("Mana:        " + StatusMeter(mana) + " " + mana + "%");
        }
    }
}
