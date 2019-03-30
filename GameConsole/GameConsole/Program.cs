using System;

namespace GameConsole
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var player = new PlayerCharacter();
//            PlayerCharacter player = null;
//            player.Name = null;
            player.DaysSinceLastLogin = 42;
//            PlayerDisplayer.Write(player);
//            int days = player.DaysSinceLastLogin.Value; // throws an exception if DaysSinceLastLogin is null
//            int days = player.DaysSinceLastLogin ?? -1; // throws an exception if player is null
//            int days;
//            if (player != null)
//            {
//                days = player.DaysSinceLastLogin ?? -1;
//            }
//            else
//            {
//                days = -1;
//            }
            int days = player?.DaysSinceLastLogin ?? -1;
            Console.WriteLine(days);

//            PlayerCharacter[] players = new PlayerCharacter[3]
//            {
//                new PlayerCharacter()
//                {
//                    Name = "Sarah"
//                },
//                new PlayerCharacter(), // Name == null
//                null // PlayerCharacter[2] == null
//            };
            PlayerCharacter[] players = null;
            string p1 = players?[0]?.Name;
            string p2 = players?[1]?.Name;
            string p3 = players?[2]?.Name;
            Console.WriteLine("{0}, {1}, {2}", p1 ?? "null", p2 ?? "null", p3 ?? "null");
        }
    }
}