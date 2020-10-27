// Copyright © 2019-2020 Dmitriy Lukovenko. All rights reserved.
// Contacts: <mludima23@gmail.com>
// License: https://opensource.org/licenses/GPL-3.0

using System.Collections.Generic;

namespace ProfileEditor
{
    public class PetDB
    {
        public static void Load(ref Dictionary<int, ItemInfo> db)
        {
            db.Add(0, new ItemInfo("None", "None.jpg"));
            db.Add(1, new ItemInfo("Brainslug", "Pets/Pet_001.jpg"));
            db.Add(2, new ItemInfo("Mini Crewmate", "Pets/Pet_002.jpg"));
            db.Add(3, new ItemInfo("Dog", "Pets/Pet_003.jpg"));
            db.Add(4, new ItemInfo("Henry", "Pets/Pet_004.jpg"));
            db.Add(5, new ItemInfo("Hamster", "Pets/Pet_005.jpg"));
            db.Add(6, new ItemInfo("Robot", "Pets/Pet_006.jpg"));
            db.Add(7, new ItemInfo("UFO", "Pets/Pet_007.jpg"));
            db.Add(8, new ItemInfo("Ellie", "Pets/Pet_008.jpg"));
            db.Add(9, new ItemInfo("Squig", "Pets/Pet_009.jpg"));
            db.Add(10, new ItemInfo("Bedcrab", "Pets/Pet_010.jpg"));
        }
    }
    public class HeadsDB
    {
        public static void Load(ref Dictionary<int, ItemInfo> db)
        {
            db.Add(0, new ItemInfo("None", "None.jpg"));
            db.Add(1, new ItemInfo("Astronaut Helmet", "Heads/Head_001.jpg"));
            db.Add(2, new ItemInfo("Backwards cap", "Heads/Head_002.jpg"));
            db.Add(3, new ItemInfo("Brain Slug", "Heads/Head_003.jpg"));
            db.Add(4, new ItemInfo("Bush Hat", "Heads/Head_004.jpg"));
            db.Add(5, new ItemInfo("Captain Hat", "Heads/Head_005.jpg"));
            db.Add(6, new ItemInfo("Double Top Hat", "Heads/Head_006.jpg"));
            db.Add(7, new ItemInfo("Flowerpot Hat", "Heads/Head_007.jpg"));
            db.Add(8, new ItemInfo("Goggles", "Heads/Head_008.jpg"));
            db.Add(9, new ItemInfo("Hard Hat", "Heads/Head_009.jpg"));
            db.Add(10, new ItemInfo("Military Hat", "Heads/Head_010.jpg"));
            db.Add(11, new ItemInfo("Paper Hat", "Heads/Head_011.jpg"));
            db.Add(12, new ItemInfo("Party Hat", "Heads/Head_012.jpg"));
            db.Add(13, new ItemInfo("Police Hat", "Heads/Head_013.jpg"));
            db.Add(14, new ItemInfo("Stethoscope", "Heads/Head_014.jpg"));
            db.Add(15, new ItemInfo("Top Hat", "Heads/Head_015.jpg"));
            db.Add(16, new ItemInfo("Towel Wizard", "Heads/Head_016.jpg"));
            db.Add(17, new ItemInfo("Ushanka", "Heads/Head_017.jpg"));
            db.Add(18, new ItemInfo("Viking", "Heads/Head_018.jpg"));
            db.Add(19, new ItemInfo("Wall Guard Cap", "Heads/Head_019.jpg"));
            db.Add(20, new ItemInfo("Snowman", "Heads/Head_020.jpg"));
        }
    }
    public class BodyDB
    {
        public static void Load(ref Dictionary<int, ItemInfo> db)
        {
            db.Add(0, new ItemInfo("None", "None.jpg"));
            db.Add(1, new ItemInfo("Astronaut", "Body/Body_001.jpg"));
            db.Add(2, new ItemInfo("Captain", "Body/Body_002.jpg"));
            db.Add(3, new ItemInfo("Mechanic", "Body/Body_003.jpg"));
            db.Add(4, new ItemInfo("Military", "Body/Body_004.jpg"));
            db.Add(5, new ItemInfo("Police", "Body/Body_005.jpg"));
            db.Add(6, new ItemInfo("Doctor", "Body/Body_006.jpg"));
            db.Add(7, new ItemInfo("Black Suit", "Body/Body_007.jpg"));
            db.Add(8, new ItemInfo("Whtie Suit", "Body/Body_008.jpg"));
            db.Add(9, new ItemInfo("Wall Guard Suit", "Body/Body_009.jpg"));
            db.Add(10, new ItemInfo("MIRA Hazmat", "Body/Body_010.jpg"));
            db.Add(11, new ItemInfo("MIRA Security Guard", "Body/Body_011.jpg"));
            db.Add(12, new ItemInfo("MIRA Landing", "Body/Body_012.jpg"));
            db.Add(13, new ItemInfo("Miner Gear", "Body/Body_013.jpg"));
            db.Add(14, new ItemInfo("Winter Gear", "Body/Body_014.jpg"));
            db.Add(15, new ItemInfo("Archaelogist", "Body/Body_015.jpg"));
        }
    }
    public class ColorDB
    {
        public static void Load(ref Dictionary<int, string> db)
        {
            db.Add(0, "Red");
            db.Add(1, "Blue");
            db.Add(2, "Green");
            db.Add(3, "Pink");
            db.Add(4, "Orange");
            db.Add(5, "Yellow");
            db.Add(6, "Black");
            db.Add(7, "White");
            db.Add(8, "Violet");
            db.Add(9, "Brown");
            db.Add(10, "Light Blue");
            db.Add(11, "Light Green");
        }
    }
}
