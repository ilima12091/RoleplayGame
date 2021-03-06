namespace RoleplayGame
{
    public class Elf
    {
        private string name;

        private int life;

        private int magic;

        private int armor;

        private int attack;

        private string story;

        private int currentLife;

        public Bow Bow{get; private set;}

        public Shuanggou Shuanggou{get; private set;}

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (value != "" && value != null)
                {
                    this.name=value;
                }
            }
        }
        public int Life
        {
            get
            {
                return this.life;
            }
            set
            {
                if(value>0)
                {
                    this.life=value;
                }
            }
        }
        public int Magic
        {
            get
            {
                return this.magic;
            }
            set
            {
                if (value>0)
                {
                    this.magic=value;
                }
            }
        }
        public int Armor
        {
            get
            {
                return this.armor;
            }
            set
            {
                if (value>0)
                {
                    this.armor=value;
                }
            }
        }
        public int Attack
        {
            get
            {
                return this.attack;
            }
            set
            {
                if (value>0)
                {
                    this.attack=value;
                }
            }
        }
        public string Story
        {
            get
            {
                return this.story;
            }
            set
            {
                if (value != "" && value != null)
                {
                    this.story=value;
                }
            }
        }
        public int CurrentLife
        {
            get
            {
                return this.currentLife;
            }
            set
            {
                if(value>0)
                {
                    this.currentLife=value;
                }
            }
        }
        public Elf(string name, int life, int magic, int armor, int attack, string story)
        {
            this.Name = name;
            this.Life = life;
            this.CurrentLife = life;
            this.Magic = magic;
            this.Armor = armor;
            this.Attack = attack;
            this.Story = story;
            this.Bow = new Bow();
            this.Shuanggou = new Shuanggou();
        }

        public int GetTotalAttack()
        {
            int totalAttack = this.Magic+this.Attack+Shuanggou.Attack+Bow.Attack;
            return totalAttack;
        }

        public int GetTotalDefense()
        {
            int totalDefense = this.Armor;
            return totalDefense;
        }

        public void Recover()
        {
            this.CurrentLife=this.Life;
        }

        public void AttackElf(Elf e)
        {   if (e.GetTotalDefense()<this.GetTotalAttack())
            {
                e.CurrentLife -= (this.GetTotalAttack()-e.GetTotalDefense());
            }
        }
        public void AttackWizard(Wizard w)
        {   if (w.GetTotalDefense()<this.GetTotalAttack())
            {
                w.CurrentLife -= (this.GetTotalAttack()-w.GetTotalDefense());
            }
        }
        public void AttackDwarf(Dwarf d)
        {   if (d.GetTotalDefense()<this.GetTotalAttack())
            {
                d.CurrentLife -= (this.GetTotalAttack()-d.GetTotalDefense());
            }
        }
    }

}

