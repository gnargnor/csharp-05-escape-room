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

    }

    class MainClass
    {
        public static void Main(string[] args)
        {
            
        }
    }
}
