using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class Game
    { 
        
        public void Run()
        {

            //Initialize base stats.
            string name = "";
            float health = 100;
            bool playerIsAlive = health > 0;
            float damage = 10;
            float powerLevel = 0;

            //Assigns name variable based on user input.
            Console.WriteLine("Please input a name.");
            name = Console.ReadLine();
            Console.Clear();

            string choice = "";
            string job = "";
            bool validInputRecieved = false;

            //Class selection menu  
            while (!validInputRecieved)
            {
                //Display class options
                Console.WriteLine("Welcome " + name + "!!!");
                Console.WriteLine("Please select a class");
                Console.WriteLine("1.Wizard");
                Console.WriteLine("2.Dwarf");
                Console.WriteLine("3.Paladin");
                Console.WriteLine();
                Console.Write("> ");

                //Get class from player
                choice = Console.ReadLine();   
                
                validInputRecieved = true;

                //Assign stats based on choice
                //Assign Wizard stats
                if (choice == "1")
                {
                    job = "Wizard";
                    health = 5025;
                    damage = 4550;
                }
                //Assign Dwarf stats
                else if (choice == "2")
                {
                    job = "Dwarf";
                    health = 98;
                    damage = 98999;
                }
                //Assign Paladin stats
                else if (choice == "3")
                {
                    job = "Paladin";
                    health = 269;
                    damage = 420;
                }
                //Otherwise if a invalid input was read...
                else
                {
                    //...display error message and clear the screen
                    Console.WriteLine("Invalid Input");
                    Console.ReadKey();
                    Console.Clear();
                    validInputRecieved = false;   
                }
            }


            Console.WriteLine("Stats");

            Console.Write("Name: ");
            Console.WriteLine(name);

            Console.Write("Class:");
            Console.WriteLine(job);

            Console.Write("Health: ");
            Console.WriteLine(health);

            Console.Write("Damage: ");
            Console.WriteLine(damage);

            powerLevel = health * damage;
            Console.Write("Power Level:");
            Console.WriteLine(powerLevel);

            Console.ReadKey();
            Console.Clear();

            

            int numberOfTries = 3;

            for (int i = 0; i < numberOfTries; i++)
            {
                Console.WriteLine("You continue on your adventure and you discover a monkey." +
                "The monkey says she'll give you gold if you answer this riddle.");

                Console.WriteLine("What kind of room has no doors or windows?");

                Console.WriteLine("1.Backrooms");
                Console.WriteLine("2.Chatrooms");
                Console.WriteLine("3.Mushrooms");

                choice = Console.ReadLine();

                if (choice == "3")
                {
                    Console.WriteLine("AyYYYY you did it!" +
                        " The monkey does a little dance and runs away.");
                    break;
                }

                Console.WriteLine("You fool!!!!!!!");

                Console.ReadKey();
                Console.Clear();
            }


        }
    }
}
