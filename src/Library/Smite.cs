namespace RoleplayGame
{
    public class Smite
    {
        public string Name {get; private set;}
        public int Magic {get; private set;}
        public string Description {get; private set;}
        public Smite()
        {
            this.Name = "Smite";
            this.Magic = 90;
            this.Description = "Este hechizo quema al enemigo y tiene un total de 90 de magia";
        }
    }
}