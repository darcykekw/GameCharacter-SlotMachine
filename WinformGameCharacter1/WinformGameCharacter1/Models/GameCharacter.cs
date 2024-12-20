using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

abstract class GameCharacter
{
    public abstract void Attack();
    public abstract void Defend();
    public abstract void LevelUp();

    public override string ToString()
    {
        return $"Name: {Name}, Level: {Level}, Health: {Health}";
    }

    public string Name { get; }
    public int Level { get; set; }
    public int Health { get; set; }
    public int Mana { get; set; }
    public int Strength { get; set; }
    public int Intelligence { get; set; }

    protected GameCharacter(string name, int level, int health, int mana, int strength, int intelligence)
    {
        Name = name;
        Level = level;
        Health = health;
        Mana = mana;
        Strength = strength;
        Intelligence = intelligence;
    }
}
