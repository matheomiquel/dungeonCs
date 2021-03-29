using System;
namespace Dungeon
{
    public class Weapon
    {
        public uint attack;
        public string name;
        public Weapon(uint attack = 0, string name = "Sword")
        {
            this.attack = attack;
            this.name = name;
        }
    }
    public interface DefensiveItem
    {
        uint defense { get; set; }
        string name { get; set; }
    }
    public class Head : DefensiveItem
    {
        public uint defense { get; set; }
        public string name { get; set; }
        public Head(uint defense = 0, string name = "Helmet")
        {
            this.defense = defense;
            this.name = name;
        }
    }

    public class Torso : DefensiveItem
    {
        public uint defense { get; set; }
        public string name { get; set; }
        public Torso(uint defense = 0, string name = "Chestplate")
        {
            this.defense = defense;
            this.name = name;
        }
    }


    public class Legs : DefensiveItem
    {
        public uint defense { get; set; }
        public string name { get; set; }
        public Legs(uint defense = 0, string name = "Legs armor")
        {
            this.defense = defense;
            this.name = name;
        }
    }
}