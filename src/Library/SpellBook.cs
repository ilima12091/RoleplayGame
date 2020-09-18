using System.Collections;

namespace RoleplayGame
{
    public class SpellBook
    {
        private ArrayList spellsList;
        public SpellBook()
        {
            this.spellsList = new ArrayList();
            Smite spell = new Smite();
            this.spellsList.Add(spell);
        }

        public int GetTotalMagic()
        {
            int totalMagic = 0;
            foreach(Smite smite in spellsList)
            {
                totalMagic += smite.Magic;
            }
            return totalMagic;
        }
    }
}