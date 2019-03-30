using System;

namespace GameConsole
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            PlayerCharacter sarah = new PlayerCharacter(new DiamondSkinDefence()) {Name = "Sarah"};
            PlayerCharacter amrit = new PlayerCharacter(new IronBonesDefence()) {Name = "Amrit"};
            PlayerCharacter gentry = new PlayerCharacter(new NullDefence()) {Name = "Gentry"};

            sarah.Hit(10);
            amrit.Hit(10);
            gentry.Hit(10);
        }
    }
}