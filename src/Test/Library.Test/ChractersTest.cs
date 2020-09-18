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
        public void More_armor_than_attack()
        {
            dwarf.AttackElf(elf);
            Assert.True(elf.CurrentLife == elf.Life);
        }

    }

}