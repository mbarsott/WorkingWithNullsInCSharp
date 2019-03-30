using System;

namespace GameConsole
{
    internal class PlayerDisplayer
    {
        public static void Write(PlayerCharacter player)
        {
            if (string.IsNullOrWhiteSpace(player.Name))
            {
                Console.WriteLine("Player name is null or all whitespace");
            }
            else
            {
                Console.WriteLine(player.Name);
            }

//            int days = player.DaysSinceLastLogin.GetValueOrDefault(-1);
//            int days = player.DaysSinceLastLogin.HasValue ? player.DaysSinceLastLogin.Value : -1;
            int days = player.DaysSinceLastLogin ?? -1;
            Console.WriteLine($"{days} days since last login");

//            if (player.DaysSinceLastLogin == null)
//            if (player.DaysSinceLastLogin.HasValue)
//            {
////                Console.WriteLine(player.DaysSinceLastLogin);
//                Console.WriteLine(player.DaysSinceLastLogin.Value); // int, not a Nullable<int> as the comment above
//            }
//            else
//            {
////                Console.WriteLine(player.DaysSinceLastLogin.Value); // throws an exception
//                Console.WriteLine("No value for DaysSinceLastLogin");
//            }

            if (player.DateOfBirth == null)
            {
                Console.WriteLine("No date of birth specified");
            }
            else
            {
                Console.WriteLine(player.DateOfBirth);
            }

            if (player.IsNoob == null)
            {
                Console.WriteLine("Player newbie status is unknown");
            }
            else if (player.IsNoob == true)
            {
                Console.WriteLine("Player is newbie");
            }
            else
            {
                Console.WriteLine("Player is experienced.");
            }
        }
    }
}