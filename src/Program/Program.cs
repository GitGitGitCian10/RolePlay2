using System;
using RoleplayGame;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            SpellsBook book = new SpellsBook();
            book.Spells = new Spell[]{ new Spell() };

            Wizard gandalf = new Wizard("Gandalf");
            gandalf.Staff = new Staff();
            gandalf.SpellsBook = book;

            Dwarf gimli = new Dwarf("Gimli");
            gimli.Axe = new Axe();
            gimli.Helmet = new Helmet();
            gimli.Shield = new Shield();

            Console.WriteLine($"Gimli has {gimli.Health}");
            Console.WriteLine($"Gandalf attacks Gimli with ⚔️ {gandalf.AttackValue}");

            gimli.ReceiveAttack(gandalf.AttackValue);

            Console.WriteLine($"Gimli has {gimli.Health}");

            gimli.Cure();

            Console.WriteLine($"Gimli has {gimli.Health}");

// Si o si tiene que tener toda la equipacion, sino no se puede atacar, por ejemplo el enano debe tener casco y armadura.
// Saltan exepciones si no se se le ponen las armas al personaje y se llaman a metodos

            Dwarf gimli2 = new Dwarf("Gimli");
            gimli2.Axe = new Axe();
            gimli2.Helmet = new Helmet();
            gimli2.Shield = new Shield();
            Console.WriteLine(gimli2.AttackValue);
            Console.WriteLine(gimli2.DefenseValue);

            Dwarf gimli3 = new Dwarf("Gimli");
            Console.WriteLine(gimli3.AttackValue);
            Console.WriteLine(gimli3.DefenseValue);
        }
    }
}
