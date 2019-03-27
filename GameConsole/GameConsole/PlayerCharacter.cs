using System;

namespace GameConsole
{
    internal class PlayerCharacter
    {
        public string Name { get; set; }

//        public int DaysSinceLastLogin { get; set; }
//        public Nullable<int> DaysSinceLastLogin { get; set; }
        public int? DaysSinceLastLogin { get; set; }

//        public DateTime DateOfBirth { get; set; }
//        public Nullable<DateTime> DateOfBirth { get; set; }
        public DateTime? DateOfBirth { get; set; }

        public bool? IsNoob { get; set; }

        public PlayerCharacter()
        {
//            DateOfBirth = DateTime.MinValue; // magic number
            DateOfBirth = null;
//            DaysSinceLastLogin = -1; // magic number
            DaysSinceLastLogin = null;
        }
    }
}