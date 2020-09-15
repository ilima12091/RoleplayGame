using System.Collections;

namespace RoleplayGame
{
    public class VoidStaff
    {
        public string Name {get; private set;}
        public int Magic {get; private set;}
        public string Description {get; private set;}
        public VoidStaff()
        {
            this.Name = "Bastón del vacío";
            this.Magic = 70;
            this.Description = "Este poderoso bastón fue utilizado en la batalla del ragnarok.";
        }
    }
}