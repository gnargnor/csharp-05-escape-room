using System;
using System.Collections.Generic;

namespace csharp05escaperoom
{
    //Room Class
    public class Room {
        private string rName;
        private string rDescription;

        public int XCoordinate { get; set; }
        public int YCoordinate { get; set; }

        public static string Instructions = "Add an instance of the Room class to name and describe the room in which the player will be located";
        public static void PrintInstructions(){
            Console.WriteLine(Instructions);
        }

        public string RoomName {
            get {
                return rName;
            }
            set {
                rName = value;
            }
        }

        public string RoomDescription {
            get {
                return rDescription;
            }
            set {
                rDescription = value;
            }
        }

        public void PrintRoomName() {
            Console.WriteLine(rName);
            for (int i = 0; i < rName.Length; i++) {
                Console.Write("-");
            }
            Console.WriteLine();
        }

        public void PrintRoomDescription() {
            Console.WriteLine(rDescription);
        }

        public void DescribeRoom() {
            PrintRoomName();
            PrintRoomDescription();
        }

        public override string ToString() {
            return "Room Name: " + rName + ", Room Description " + rDescription;
        }

        public Room(string roomName, string roomDescription) {
            rName = roomName;
            rDescription = roomDescription;
        }
    }//End Room Class


    //Item Class
    public class Item {
        private string displayString = "You see a ";

        public string ItemName { get; set; }
        public string ItemDescription { get; set; }

        public static string Instructions = "Add an instance of the Item class to create an interactive object in the room.\n" +
            "Players can use the \"inspect <Item>\" command to return the item description,\n" +
            "the \"take <Item>\" command to add the Item to their Inventory,\n" +
            "or the \"use <Item>\" command to use the Item";
		public static void PrintInstructions(){
			Console.WriteLine(Instructions);
		}

        public string DisplayString {
            get
            {
                return displayString;
            }
            set
            {
                displayString = value;
            }
        }

        public void DisplayItem() {
            Console.WriteLine(DisplayString + ItemName);
        }

        public void InspectItem() {
            Console.WriteLine(ItemDescription);
        }

        public override string ToString() {
            return string.Format("[Item: ItemName={0}, ItemDescription={1}, DisplayString={2}]", ItemName, ItemDescription, DisplayString);
        }

        public Item(string itemName, string itemDescription){
            ItemName = itemName;
            ItemDescription = itemDescription;
        }
    }//End Item Class


    //Sight Class
    public class Sight {
        public string SightName { get; set; }
        public string SightDescription { get; set; }

        public static string Instructions = "Add an instance of the Sight class for things of interest in your room.\n" +
            "Players can use the look <Sight> command to return the Sight\'s description";
        public static void PrintInstructions(){
            Console.WriteLine(Instructions);
        }

        public void LookSight() {
            Console.WriteLine(SightDescription);
        }

        public override string ToString()
        {
            return string.Format("[Sight: SightName={0}, SightDescription={1}]", SightName, SightDescription);
        }

        public Sight(string sightName, string sightDescription){
            SightName = sightName;
            SightDescription = sightDescription;
        }

    }//End Sight Class


    //Sight List Class
    public class SightList {
        public List<object> sights = new List<object>();
        public void AddSight(object newSight){
            sights.Add(newSight);
        }
    } 


    //NPC Class
    public class Npc {
        public string CharacterName { get; set; }
        public string CharacterDescription { get; set; }

        public static string Instructions = "Add an instance of the Npc class to create non-player characters that the player can interact with.\n" +
            "Players can use the talk <Character> command to return one of the characters phrases.";
        public static void PrintInstructions(){
            Console.WriteLine(Instructions);
        }

        public void Speak(){
            Console.WriteLine(CharacterName + "says \"Hello there!\"");
        }

        public Npc(string characterName, string characterDescription){
            CharacterName = characterName;
            CharacterDescription = characterDescription;
        }

        public override string ToString()
        {
            return string.Format("[Npc: CharacterName={0}, CharacterDescription={1}]", CharacterName, CharacterDescription);
        }

    }


    //Commands Class
    public class CommandList {
        public List<object> Commands { get; private set; } = new List<object>();
        public void AddCommand(object newCommand){
            Commands.Add(newCommand);
        }

        public CommandList() {
            Console.WriteLine("Command List Created");
        }
    }//End Command


    //Look Command
    public class Look {
        public string CommandName { get; private set; } = "look";
        public string HelpCommand { get; private set; } = "\n" + 
            "- Returns the description of a target Sight\n" +
            "- Use: \"look <Sight>\"\n" +
            "- Example: \"look birds\"\n" +
            "- The birds are sitting in the tree peacefully, chirping away";

        public Boolean IsCommand { get; private set; } = true;

        public void FunctionCall(string lookTarget){
            Console.WriteLine("looking at " + lookTarget);
        }

        public override string ToString()
        {
            return string.Format("[Look: \nCommandName = {0}, \nHelpCommand = {1}, \nIsCommand = {2}]", CommandName, HelpCommand, IsCommand);
        }

	    public Look(){
	        Console.WriteLine("Look command created");
	    }
    }//End Look Command

    class MainClass {
        public static void Main(string[] args) {
            Room computerRoom = new Room("Computer Room", "You find yourself in the basement in the Computer Room.  It smells like sweat and frustration.  You see a Macbook on a plain white desk surrounded by b.. soda cans.  There are two monitors flanking the Macbook, predictably.  Logan is sleeping on the floor.");
            CommandList commandList = new CommandList();
            Look look = new Look();
            commandList.AddCommand(look);
            Console.WriteLine(commandList.Commands[0]);
            Console.WriteLine(look.HelpCommand);

        }
    }
}
