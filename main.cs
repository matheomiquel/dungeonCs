using System;
using System.Windows;
namespace Dungeon
{
    public delegate void fn(string phrase);
    class Program
    {
        static protected uint[,] statistics = new uint[,] {
            { 40, 18, 12, 25 }, //speed
            { 45, 25, 12, 18 }, //attack
            { 70, 15, 30, 10 }  //defense
        };
        static void Main()
        {
            string name = getName();
            uint statistical = getStats(name);
            Weapon weapon = new Weapon();
            Head head = new Head();
            Torso torso = new Torso();
            Legs legs = new Legs();
            MainCharacter player = new MainCharacter(hp: statistics[statistical, 0], level: 1, attack: statistics[statistical, 1],
            defense: statistics[statistical, 2], speed: statistics[statistical, 3], name: name, weapon: weapon,
            head: head, torso: torso, legs: legs);
            Console.WriteLine(player.head.name);
        }

        static private void wesh(string phrase)
        {
            Console.WriteLine(phrase);
        }
        static private uint getStats(string name)
        {
            Console.Clear();
            Console.WriteLine($"Bien maintenant {name} te considère tu comme quelqu'un de\n1: rapide\n2: fort\n3: résitant?");
            char value = '\0';
            while (value < 49 || value > 51)
            {
                value = Console.ReadKey().KeyChar;
                if (value < 1 || value > 3)
                {
                    Console.Clear();
                    Console.WriteLine("tu dois appuyer sur 1,2 ou 3!\n1: rapide\n2: fort\n3: résitant");
                }
            }
            return (uint)(value - 49);
        }
        static private string getName()
        {
            Console.Clear();
            string name = "";
            Console.WriteLine("Bonjour Aventurier comment t'appelle tu?");
            while (name == "")
            {
                name = Console.ReadLine();
                if (name == "")
                {
                    Console.Clear();
                    Console.WriteLine("tu dois rentrer un pseudo avec au moins 1 caractère!");
                }
            }
            return name;
        }
    }
}