using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objective
{
    //This class is basically an object that gives Pikachu the stats we set within the object.
    internal class Pikachu
    {
        public int Health = 50;
        public int Level = 5;


        //This one will show the different aspects of the object pikachu that we have listed below. 
        public void ShowPikachu ()
        {
            Console.WriteLine("\nPikachu:");
            Console.WriteLine($"\tHealth: {Health}");
            Console.WriteLine($"\tLevel: {Level}");
        }
        
        


    }

    internal class Pokemon
    {
        //this object holds these values, they aren't set to anything yet. as public the outside can reach the different parts of the object,
        //but private set means that the different parts can only be changed within the class and not by the program itself.
        public string Name { get; set; }
        public int Health { get; set; }
        public int Level { get; set; }


        //The constructor takes in the different values and set them as the value of the new pokemon created.
        public Pokemon(string name, int health, int level)
        {
            Name = name;
            Health = health;
            Level = level;
        }



        public void ShowPokemon()
        {
            Console.WriteLine();
            Console.WriteLine(Name);
            Console.WriteLine($"Health: {Health}");
            Console.WriteLine($"Level: {Level}");
        }




    }
}
