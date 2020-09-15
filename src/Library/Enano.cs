namespace Enano
{
    public class Enano
    {
        private string name;
        private int attack;
        private int armor;
        private int life;
        private string story;

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
                    this.life = value;
                }
            }    
        }
        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if(value!=""&& value!=null)
                {
                    this.name = value;
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
                if(value!=""&& value!=null)
                {
                    this.story = value;
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
                if(value>0)
                {
                    this.attack = value;
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
                if(value>0)
                {
                    this.armor = value;
                }
            }    
        }

        public Enano(string name, int attack, int armor, int life, string story)
        {
            this.Name = name;
            this.Attack = attack;
            this.Armor = armor;
            this.Life = life;
            this.Story = story;
        }


    }
}