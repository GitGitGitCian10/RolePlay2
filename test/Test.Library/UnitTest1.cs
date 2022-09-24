using NUnit.Framework;
using RoleplayGame;

namespace GameTest
{
    public class CharactersTests
    {
        [Test]
        public void AtaqueMayorDefensa()
        {
            Dwarf gimli = new Dwarf("Gimli"); // 32 armadura, 100 vida
            gimli.Helmet = new Helmet();
            gimli.Shield = new Shield();

            Archer legolas = new Archer("legolas"); // 35 daño
            legolas.Bow = new Bow(); 

            gimli.ReceiveAttack(legolas.AttackValue);
            gimli.ReceiveAttack(legolas.AttackValue);
            int vidaExpected = 94;
            Assert.AreEqual(gimli.Health, vidaExpected);
        }

        [Test]
        public void AtaqueMenorDefensa()
        {
            Dwarf gimli = new Dwarf("Gimli"); // 32 armadura, 100 vida
            gimli.Helmet = new Helmet();
            gimli.Shield = new Shield();

            Knight aragorn = new Knight ("Aragorn"); // 20 daño
            aragorn.Sword = new Sword(); 
            gimli.ReceiveAttack(aragorn.AttackValue);

            int vidaExpected = 100;
            Assert.AreEqual(gimli.Health, vidaExpected);
        }
        
        [Test]
        public void Curar()
        {
            Dwarf gimli = new Dwarf("Gimli"); // 32 armadura, 100 vida
            gimli.Helmet = new Helmet();
            gimli.Shield = new Shield();

            Archer legolas = new Archer("legolas"); // 35 daño
            legolas.Bow = new Bow(); 

            gimli.ReceiveAttack(legolas.AttackValue);
            gimli.ReceiveAttack(legolas.AttackValue); // Vida de 94
            gimli.Cure();
            int vidaExpected = 100;
            Assert.AreEqual(gimli.Health, vidaExpected);
        }

        [Test]
        public void AtaqueVidaMenorCero()
        {
            Dwarf gimli = new Dwarf("Gimli"); // 32 armadura, 100 vida
            gimli.Helmet = new Helmet();
            gimli.Shield = new Shield();

            Archer legolas = new Archer("legolas"); // 35 daño
            legolas.Bow = new Bow(); 

            for (int i=0;i<=40;i++)
            {
                gimli.ReceiveAttack(legolas.AttackValue);
            }
            int vidaExpected = 0;
            Assert.AreEqual(gimli.Health, vidaExpected);
        }
    }
}