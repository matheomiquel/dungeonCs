using System;
namespace Dungeon
{
    public abstract class Character
    {
        public uint hp { get; set; }
        public uint attack { get; set; }
        public uint totalAttack { get; set; }
        public uint defense { get; set; }
        public uint totalDefense { get; set; }
        public uint speed { get; set; }
        public string name { get; set; }
        public uint level { get; set; }
        public Weapon weapon { get; set; }
        public Head head { get; set; }
        public Torso torso { get; set; }
        public Legs legs { get; set; }
    }
    public class MainCharacter : Character
    {
        public uint xp { get; set; }
        public MainCharacter(uint hp, uint level, uint attack, uint defense, uint speed, string name,
        Weapon weapon, Head head, Torso torso, Legs legs)
        {
            this.hp = hp;
            this.xp = 0;
            this.level = level;
            this.attack = attack;
            this.defense = defense;
            this.speed = speed;
            this.name = name;
            this.totalAttack = attack + weapon.attack;
            this.weapon = weapon;
            this.head = head;
            this.torso = torso;
            this.legs = legs;
            this.totalDefense = defense + head.defense + torso.defense + legs.defense;
        }
    }
}