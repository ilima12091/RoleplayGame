using NUnit.Framework;
using RoleplayGame;

namespace Test.Library
{
    public class CharactersTest
    {

        private Dwarf dwarf;
        private Elf elf;

        [SetUp]
        public void Setup()
        {
            dwarf = new Dwarf("Nacho", 10, 10, 10, "El enano nacho");
            elf = new Elf("Jero", 10, 10, 30, 10, "El elfo Jero");
        }

        [Test]
        /*Este test prueba que si se realiza un ataque y 
        el atacado tiene más defensa que el ataque del atacante la vida se mantiene*/
        public void More_armor_than_attack()        
        {
            dwarf.AttackElf(elf);
            Assert.True(elf.CurrentLife == elf.Life);
        }
        [Test]
        /*Este test prueba que si un personaje es atacado y se le usa medotodo Revive 
        la salud del personaje se recupera a la inicial*/
        public void Revive()
        {
            elf.AttackDwarf(dwarf);
            dwarf.Recover();
            Assert.True(dwarf.CurrentLife == dwarf.Life);
        }

    }

}