namespace RoleplayGame
{
    public class Wizard
    {
        private string name;
        private int life;
        private int currentLife;
        private int magic;
        private int armor;
        private int attack;
        private string story;
        public SpellBook SpellBook {get; private set;}
        public VoidStaff VoidStaff {get; private set;}
        public string Name
        {
            get {
                return this.name;
            }
            set {
                if(value != "" && value != null)
                {
                    this.name = value;
                }
            }
        }

        public int Life
        {
            get {
                return this.life;
            }
            set {
                if(value > 0)
                {
                    this.life = value;
                }
            }
        }

        public int CurrentLife
        {
            get {
                return this.currentLife;
            }
            set {
                if(value > 0)
                {
                    this.currentLife = value;
                }
            }
        }

        public int Magic
        {
            get {
                return this.magic;
            }
            set {
                if(value > 0)
                {
                    this.magic = value;
                }
            }
        }

        public int Armor
        {
            get {
                return this.armor;
            }
            set {
                if(value > 0)
                {
                    this.armor = value;
                }
            }
        }

        public int Attack
        {
            get {
                return this.attack;
            }
            set {
                if(value > 0)
                {
                    this.attack = value;
                }
            }
        }

        public string Story
        {
            get {
                return this.story;
            }
            set {
                if(value != "" && value != null)
                {
                    this.story = value;
                }
            }
        }
    
        public Wizard(string name, int life, int magic, int armor, int attack, string story)
        {
            this.Name = name;
            this.Life = life;
            this.CurrentLife = life;
            this.Magic = magic;
            this.Armor = armor;
            this.Attack = attack;
            this.Story = story;
            this.SpellBook = new SpellBook();
            this.VoidStaff = new VoidStaff();
        }

        public int GetTotalAttack() 
        {
            int totalAttack = this.Attack + this.Magic + this.SpellBook.GetTotalMagic() + this.VoidStaff.Magic;
            return totalAttack;
        }

        public int GetTotalDefense()
        {
            return this.Armor;
        }

        public void Recover()
        {
            this.CurrentLife = this.Life;
        }

        public void AttackWizard(Wizard w)
        {
            if(w.GetTotalDefense() < this.GetTotalAttack())
            {
                w.CurrentLife -= (this.GetTotalAttack() - w.GetTotalDefense());
            }
        }

        public void AttackDwarf(Dwarf d)
        {
            if(d.Armor < this.GetTotalAttack())
            {
                d.CurrentLife -= (this.GetTotalAttack() - d.GetTotalDefense());
            }
        }

        public void AttackElf(Elf e)
        {
            if(e.Armor < this.GetTotalAttack())
            {
                e.CurrentLife -= (this.GetTotalAttack() - e.GetTotalDefense());
            }
        }
    }
}
