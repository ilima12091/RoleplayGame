using System;

namespace RoleplayGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Dwarf dwarf = new Dwarf("Rodri", 10, 10, 10, "El enano Rodri");
            Elf elf = new Elf("Jero", 10, 10, 30, 10, "El elfo Jero");
            Wizard wizard = new Wizard("Nacho", 250, 10, 10, 10, "El mago Nacho");
            Console.WriteLine("Rodri: " + dwarf.CurrentLife + "\n" + "Jero: " + elf.CurrentLife + "\n" + "Nacho: " + wizard.CurrentLife);
            elf.AttackWizard(wizard);
            Console.WriteLine("\n" + "Rodri: " + dwarf.CurrentLife + "\n" + "Jero: " + elf.CurrentLife + "\n" + "Nacho: " + wizard.CurrentLife);
        }
    }
}
