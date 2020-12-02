namespace Elves.Models
{
    public class Weapon
    {
        public string Name;
        public int Damage;

        public Weapon(string name, int dmg)
        {
            Name = name;
            Damage = dmg;
        }
    }
}