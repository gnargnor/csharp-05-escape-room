using System;

namespace csharp05escaperoom
{
    public class Room
    {
        private string rName;
        private string rDescription;

        public string RoomName
        {
            get
            {
                return rName;
            }
            set
            {
                rName = value;
            }
        }

        public string RoomDescription
        {
            get
            {
                return rDescription;
            }
            set
            {
                rDescription = value;
            }
        }

        public void PrintRoomName()
        {
            Console.WriteLine(rName);
            for (int i = 0; i < rName.Length; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine();
        }

        public void PrintRoomDescription()
        {
            Console.WriteLine(rDescription);
        }

        public override string ToString()
        {
            return "Room Name: " + rName + ", Room Description " + rDescription;
        }

        public Room(string roomName, string roomDescription)
        {
            rName = roomName;
            rDescription = roomDescription;
            PrintRoomName();
            PrintRoomDescription();
        }

    }

    class MainClass
    {
        public static void Main(string[] args)
        {
            Room computerRoom = new Room("Computer Room", "You find yourself in the basement in the Computer Room.  It smells like sweat and frustration.  You see a Macbook on a plain white desk surrounded by b.. soda cans.  There are two monitors flanking the Macbook, predictably.  Logan is sleeping on the floor.");
        }
    }
}
