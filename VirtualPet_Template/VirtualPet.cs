using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet_Template
{

    class VirtualPet
    {
        //Initiat Fields
        private string name;
        private int hunger;
        private int behavior;
        private int hitPoints;
        private int boredem;

        //this defaut constructor is sets options without giving us any options
        public VirtualPet()
        {
            this.name = "Nameless Loser";
            this.hunger = 20;
            this.behavior = 20;
            this.hitPoints = 20;
            this.boredem = 20;

            //TODO account for more fields
        }

        //TODO how can we set things with our construtor
        public VirtualPet(string name)
        {
            this.name = name;
            this.hunger = 10;
            this.behavior = 10;
            this.hitPoints = 10;
            this.boredem = 10;
            
        }

        
        //this method can be called to increase the hunger
        public void HungerIncrease()
        {
            //TODO modify these values to anything you see fit
            this.hunger = hunger + 3;
        }

        //this method can be called to decrease the hunger
        public void HungerDecrease()
        {   
            //TODO modify these values to anything you see fit
            this.hunger = hunger - 5;
        }

        //TODO we need to add more methods to modify the other fields


        //method for stats of virtual pet
        public void MyPetStatus()
        {
            Console.WriteLine(name);
            Console.WriteLine("Hunger: " + hunger);
            //TODO account for more fields
        }
    }
}
