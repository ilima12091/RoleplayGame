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

        public Elf(string name, int life, string story)
        {
            this.Name=name;
            this.Life=life;
            this.Magic=10;
            this.Armor=20;
            this.Attack=10;
            this.Story=story;
        }

    }
}

