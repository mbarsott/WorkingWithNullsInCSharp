using System;

namespace GameConsole
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var player = new PlayerCharacter();
//            player.Name = "Sarah";
            player.Name = null;
//            player.DaysSinceLastLogin = 42;
            PlayerDisplayer.Write(player);
        }
    }
}