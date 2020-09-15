namespace RoleplayGame
{
    public class Ancestral_Armor
    {
        private string name;
        private int armor;
        private string description;

        public string Name{get;private set;}
        public string Description{get;private set;}        
        public int Armor{get;private set;}

        public Ancestral_Armor()
        {
            this.Name = "Ancestral Armor";
            this.Description = "May it keep you well! said Theoden. It was made for me in Thengel's day, while still I was a boy. - The Two Towers";
            this.Armor = 75;
        }


    }
}