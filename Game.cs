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

            Console.WriteLine("Hello Dungeon Quest 2: Reloaded Electric Boogaloo & Knuckles");

            /// Makes the console pause and wait for a key to be pressed.
            /// Can be used to allow the player to move to the next screen
            /// when they are ready to do so.
            Console.ReadKey();
            Console.Clear();

            //Assigns name variable based on user input.
            Console.WriteLine("Please input a name.");
            name = Console.ReadLine();

            Console.Clear();

            //Class selection menu
            Console.WriteLine("Welcome " + name + "!!!");
            Console.WriteLine("Please select a class");
            Console.WriteLine("1.Thief");
            Console.WriteLine("2.Warrior");
            Console.WriteLine("3.Mage");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                health = 50;
                damage = 15;
            }
            else if (choice == "2")
            {
                health = 150;
                damage = 4550;
            }
            else if (choice == "3")
            {
                health = 2;
                damage = 2;
            }
            else
            {
                Console.WriteLine("Invalid Input");
            }

            Console.WriteLine("Stats");

            Console.Write("Name: ");
            Console.WriteLine(name);

            Console.Write("Class:");
            Console.WriteLine(choice);

            Console.Write("Health: ");
            Console.WriteLine(health);

            Console.Write("Damage: ");
            Console.WriteLine(damage);

            powerLevel = health * damage;
            Console.Write("Power Level:");
            Console.WriteLine(powerLevel);

            Console.Clear();

            Console.WriteLine("You've encountered a traveler and" +
                " they offer you a drink. Do you accept?");
            Console.WriteLine("1.Yes");
            Console.WriteLine("2.No");

            choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.WriteLine("You fool!!!! It was poison. You died." +
                    " You're a loser. :(");
            }
            else if (choice == "2")
            {
                Console.WriteLine("You decline. The traveler says they were just" +
                    "testing you. You leave.");
            }
        }
    }
}
