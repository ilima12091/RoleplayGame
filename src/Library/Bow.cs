namespace RoleplayGame
{
    public class Bow
    {
        public string Name {get; private set;}

        public string Description {get; private set;}

        public int Attack {get; private set;}

        public Bow()
        {
            this.Name = "arco ultrapotente";
            this.Description = "Este arco fue usado por el rey mutombo en la guerra de zimbabue";
            this.Attack= 100;
        }
    }
}