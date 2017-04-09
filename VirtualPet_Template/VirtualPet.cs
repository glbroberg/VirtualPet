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

        // Default Constructor
        public VirtualPet()
        {
            this.name = "Nameless Loser";
            this.stomach = 90;
            this.hydration = 20;
            this.behavior = 20;
            this.hitPoints = 20;
            this.activity = 20;
            this.mana = 20;
        }


        //// Name Choice Constructor
        //public VirtualPet(string name)
        //{
        //    this.name = name;
        //    this.stomach = 90;
        //    this.hydration = 50;
        //    this.behavior = 50;
        //    this.hitPoints = 50;
        //    this.activity = 50;  
        //}


        // Assigns Pet Name
        public void PetName()
        {

            Console.Write("Please type your pet's name: ");
            name = Console.ReadLine();
            
        }


        //************* Attribute Modifying Methods **********************************  

        string stomachHi = "No thanks, I'm already full!";
        string stomachLo = "Your pet has died from hunger";
        //Stomach Block
        public void StomachIncrease()
        {
            attribChecker(stomach,stomachHi, stomachLo);
            this.stomach = stomach + 5;
        }
        public void StomachDecrease()
        {
            attribChecker(stomach, stomachHi, stomachLo);
            this.stomach = stomach - 5;
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
            Console.WriteLine("Choose how to discipline your pet: \n\t1. Stern talking-to \n\t2. Spanking");
            string punishInput = Console.ReadLine();
            int a;
            bool valid = int.TryParse(punishInput, out a);
            switch (a)
            {
                case 1:
                    BehaviorIncrease();
                    ActivityDecrease(); 
                    break;

                case 2:
                    BehaviorIncrease();
                    BehaviorIncrease();
                    HitPointsDecrease();
                    ManaDecrease();
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

        
        // Status Meter Conversion
        public string StatusMeter(int a)
        {
            char[] level = { '_', '_', '_', '_', '_', '_', '_', '_', '_', '_' };
            int count = 0;
            while (a > 0)
            {
                level[count] = '+';
                count++;
                a = a - 10; 
            }
            string reading = new string(level);
            return reading;
        }

        
        // Amount Check
        public void attribChecker(int a, string hi, string lo)
        {
            if (a >= 100)
            {
                Console.WriteLine(hi);
                return;
            }
            if (a <= 0)
            {
                Console.WriteLine(lo);
                return;
            }
         
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
