using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class Game
    { 
        string name = "";
        float health = 100;
        bool playerIsAlive = true;
        float damage = 10;
        float powerLevel = 0;
        string job = "";
        bool gameOver = false;
        string choice = "";
        int currentScene = 0;

        float Add(float lhs, float rhs)
        {
            float result = lhs + rhs;
            return result;
        }

        string CombineStrings(string lhs, string rhs)
        {
            string result = lhs + rhs;
            return result;
        }

        bool CheckIsEven(float value)
        {
            if (value % 2 == 0)
            {
                return true;
            }
            else if (value % 2 != 0)
            {
                return false;
            }

            return false;
        }

        void DisplayStats()
        {
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
        }

        string GetInput(string prompt, string option1, string option2, string option3)
        {

            bool validInputReceived = false;

            while (!validInputReceived)
            {
                Console.Clear();

                Console.WriteLine(prompt);
                Console.WriteLine("1." + option1);
                Console.WriteLine("2." + option2);
                Console.WriteLine("3." + option3);
                Console.Write("> ");

                choice = Console.ReadLine();

                validInputReceived = true;

                if (choice != "1" && choice != "2" && choice != "3")
                {
                    validInputReceived = false;
                    Console.WriteLine("Invalid Input");
                    Console.ReadKey();
                }
            }

            return choice;
        }

        void DisplayStatMenu()
        {
            //Initialize base stats.

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

            //Display class options
            Console.WriteLine("Welcome " + name + "!!!");
            Console.ReadKey();

            string choice = GetInput("Please select a class.", "Wizard", "Dwarf", "Paladin");

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

            DisplayStats();

            Console.ReadKey();
            Console.Clear();
        }

        void DisplayRoom1()
        {
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

            DisplayStats();
            currentScene = 0;
        }

        void DisplayCurrentScene()
        {
            if (currentScene == 0)
            {
                DisplayStatMenu();
            }
            else if (currentScene == 1)
            {
                DisplayRoom1();
            }
            else if (currentScene == 2)
            {
                //DisplayRoom2();
            }
        }

        public void Run()
        {
            while (!gameOver)
            {
                DisplayCurrentScene();
            }
        }
    }
}
