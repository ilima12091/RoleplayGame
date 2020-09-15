namespace RoleplayGame
{
    public class Shuanggou
    {
        public string Name {get; private set;}

        public string Description {get; private set;}

        public int Attack {get; private set;}

        public Shuanggou()
        {
            this.Name = "Espada de gancho del maestro elfo tio segundo de Legolas";
            this.Description = "Este espada fue usada para entrenar a Legolas para usar su arco, cada vez que Legolas erraba una flecha el tio le aplicaba un correctivo en los dedos con esta espada";
            this.Attack= 80;
        }
    }
}