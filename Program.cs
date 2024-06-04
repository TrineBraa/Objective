
using System.Runtime.InteropServices;
using Microsoft.VisualBasic;
using Objective;

Main();
void Main()
{
    //this makes a new object of the object we have in the pikachu class
    Pikachu pikachu = new Pikachu();


    Console.WriteLine();
    Console.WriteLine("A look into the more Objective related coding in C#");
    Console.WriteLine("Working on objective oriented coding and learn that in a more proper way.");


    //var pikachu = new
    //{
    //    Health = 50,
    //    Level = 5, 
    //};

    //Console.WriteLine($"" + $"Pikachu has \n{pikachu.Health} hp and \nis level {pikachu.Level}");

    //This will call on the object and the show pikachu will show the stats of pikachu object.
    pikachu.ShowPikachu();

    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine("This are created by the use of the new constructor that was made!");
    var Arcanine = new Pokemon("Arcanine", 55, 12);
    var Zapdos = new Pokemon("Zapdos", 100, 50);

    Arcanine.ShowPokemon();
    Zapdos.ShowPokemon();
}





