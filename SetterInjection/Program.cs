using System;

namespace Samurais
{
    class Program
    {
        static void Main(string[] args)
        {
            IWeapon weapon = new Sword();
            Samurai warrior = new Samurai();
            warrior.Weapon = weapon;
            warrior.Attack("the long-nose");
            Console.Read();
        }
    }

    interface IWeapon
    {
        void Hit(string target);
    }

    class Sword : IWeapon
    {
        public void Hit(string target)
        {
            Console.WriteLine("Chopped {0} clean in half!", target);
        }
    }

    class Bow : IWeapon
    {
        public void Hit(string target)
        {
            Console.WriteLine("Shot {0} with an arrow to the head!", target);
        }
    }

    class Samurai
    {
        private IWeapon weapon;

        public IWeapon Weapon
        {
            get
            {
                return this.weapon;
            }
            set
            {
                this.weapon = value;
            }
        }

        public void Attack(string target)
        {
            this.weapon.Hit(target);
        }
    }
}
