using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Mage : GameCharacter
{
    public int SpellPower { get; set; } = 10;

    public Mage(string name, int level, int health, int mana, int intelligence)
        : base(name, level, health, mana, 0, intelligence)
    {
    }

    public override void Attack()
    {
        int magicDamage = (Intelligence * 3) + SpellPower;
        Random random = new Random();
        bool burningEffect = random.Next(100) < 25;

        Console.WriteLine($"{Name} casts a spell and deals {magicDamage} damage{(burningEffect ? ", applying a burning effect!" : ".")}");
    }

    public override void Defend()
    {
        int damageReduction = Mana / 4;
        Random random = new Random();
        bool evade = random.Next(100) < 20;

        if (evade)
        {
            Console.WriteLine($"{Name} evades the attack completely!");
        }
        else
        {
            Console.WriteLine($"{Name} reduces the damage by {damageReduction}.");
        }
    }

    public override void LevelUp()
    {
        Level++;
        Intelligence += 5;
        Mana += 15;
        SpellPower += 3;

        Console.WriteLine($"{Name} leveled up! Level: {Level}, Intelligence: {Intelligence}, Mana: {Mana}, SpellPower: {SpellPower}");
    }
    public override string ToString()
    {
        return base.ToString() + $", Mana: {Mana}, Intelligence: {Intelligence}, SpellPower: {SpellPower}";
    }

}