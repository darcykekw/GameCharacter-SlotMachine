using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Warrior : GameCharacter
{
    public int Armor { get; set; } = 10;

    public Warrior(string name, int level, int health, int strength)
        : base(name, level, health, 0, strength, 0)
    {
    }

    public override void Attack()
    {
        int baseDamage = Strength * 2;
        Random rnd = new Random();
        bool criticalHit = rnd.Next(100) < 20;
        int finalDamage = criticalHit ? baseDamage * 2 : baseDamage;

        Console.WriteLine($"{Name} attacks and deals {finalDamage} damage{(criticalHit ? " with a critical hit!" : ".")}");
    }

    public override void Defend()
    {
        int damageReduction = Armor / 2;
        Random rnd = new Random();
        bool block = rnd.Next(100) < 15;

        if (block)
        {
            Console.WriteLine($"{Name} blocks the attack completely!");
        }
        else
        {
            Console.WriteLine($"{Name} reduces the damage by {damageReduction}.");
        }
    }

    public override void LevelUp()
    {
        Level++;
        Strength += 5;
        Health += 20;
        Armor += 2;

        Console.WriteLine($"{Name} leveled up! Level: {Level}, Strength: {Strength}, Health: {Health}, Armor: {Armor}");
    }
    public override string ToString()
    {
        return base.ToString() + $", Strength: {Strength}, Armor: {Armor}";
    }

}