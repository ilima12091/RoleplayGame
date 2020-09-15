namespace RoleplayGame
{
    public class Sword_of_Morthrond
    {
        private string name;
        private int attack;
        private string description;

        public string Name{get;private set;}
        public string Description{get;private set;}        
        public int Attack{get;private set;}

        public Sword_of_Morthrond()
        {
            this.Name = "Sword of Morthrond";
            this.Description = "The Morthond Valye made a great bay that beat up against the sheer southern faces of the mountains.-The return of the King";
            this.Attack = 150;
        }


    }
}