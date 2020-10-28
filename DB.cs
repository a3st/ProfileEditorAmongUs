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

            db.Add(21, new ItemInfo("Antlers", "Heads/Head_021.jpg"));
            db.Add(22, new ItemInfo("Christmas Lights Hat", "Heads/Head_022.jpg"));
            db.Add(23, new ItemInfo("Santa Hat", "Heads/Head_023.jpg"));
            db.Add(24, new ItemInfo("Christmas Tree Hat", "Heads/Head_024.jpg"));
            db.Add(25, new ItemInfo("Present Hat", "Heads/Head_025.jpg"));
            db.Add(26, new ItemInfo("Candy Canes Hat", "Heads/Head_026.jpg"));
            db.Add(27, new ItemInfo("Elf Hat", "Heads/Head_027.jpg"));
            db.Add(28, new ItemInfo("2019 Yellow Party Hat", "Heads/Head_028.jpg"));
            db.Add(29, new ItemInfo("White Hat", "Heads/Head_029.jpg"));
            db.Add(30, new ItemInfo("Crown", "Heads/Head_030.jpg"));

            db.Add(31, new ItemInfo("Eyebrows", "Heads/Head_031.jpg"));
            db.Add(32, new ItemInfo("Angel Halo", "Heads/Head_032.jpg"));
            db.Add(33, new ItemInfo("Elf Cap", "Heads/Head_033.jpg"));
            db.Add(34, new ItemInfo("Flat Cap", "Heads/Head_034.jpg"));
            db.Add(35, new ItemInfo("Plunger", "Heads/Head_035.jpg"));
            db.Add(36, new ItemInfo("Snorkel", "Heads/Head_036.jpg"));
            db.Add(37, new ItemInfo("Stickmin Figure", "Heads/Head_037.jpg"));
            db.Add(38, new ItemInfo("Straw Hat", "Heads/Head_038.jpg"));
            db.Add(39, new ItemInfo("Sheriff Hat", "Heads/Head_039.jpg"));
            db.Add(40, new ItemInfo("Eyeball Lamp", "Heads/Head_040.jpg"));

            db.Add(41, new ItemInfo("Toilet Paper Hat", "Heads/Head_041.jpg"));
            db.Add(42, new ItemInfo("Toppat Clan Leader Hat", "Heads/Head_042.jpg"));
            db.Add(43, new ItemInfo("Black Fedora", "Heads/Head_043.jpg"));
            db.Add(44, new ItemInfo("Ski Goggles", "Heads/Head_044.jpg"));
            db.Add(45, new ItemInfo("Landing Headset", "Heads/Head_045.jpg"));
            db.Add(46, new ItemInfo("MIRA Hazmat Mask", "Heads/Head_046.jpg"));
            db.Add(47, new ItemInfo("Medical Mask", "Heads/Head_047.jpg"));
            db.Add(48, new ItemInfo("MIRA Security Cap", "Heads/Head_048.jpg"));
            db.Add(49, new ItemInfo("Safari Hat", "Heads/Head_049.jpg"));

            db.Add(50, new ItemInfo("Banana Hat", "Heads/Head_050.jpg"));
            db.Add(51, new ItemInfo("Beanie", "Heads/Head_051.jpg"));
            db.Add(52, new ItemInfo("Bear Ears", "Heads/Head_052.jpg"));
            db.Add(53, new ItemInfo("Cheese Hat", "Heads/Head_053.jpg"));
            db.Add(54, new ItemInfo("Cherry Hat", "Heads/Head_054.jpg"));
            db.Add(55, new ItemInfo("Egg Hat", "Heads/Head_055.jpg"));
            db.Add(56, new ItemInfo("Green Fedora", "Heads/Head_056.jpg"));
            db.Add(57, new ItemInfo("Flamingo Hat", "Heads/Head_057.jpg"));
            db.Add(58, new ItemInfo("Flower Hat", "Heads/Head_058.jpg"));
            db.Add(59, new ItemInfo("Knight Helmet", "Heads/Head_059.jpg"));

            db.Add(60, new ItemInfo("Plant Hat", "Heads/Head_060.jpg"));
            db.Add(61, new ItemInfo("Cat Head Hat", "Heads/Head_061.jpg"));
            db.Add(62, new ItemInfo("Bat Wings", "Heads/Head_062.jpg"));
            db.Add(63, new ItemInfo("Devil Horns", "Heads/Head_063.jpg"));
            db.Add(64, new ItemInfo("Mohawk", "Heads/Head_064.jpg"));
            db.Add(65, new ItemInfo("Pumpkin Hat", "Heads/Head_065.jpg"));
            db.Add(66, new ItemInfo("Spooky Paper Bag Hat", "Heads/Head_066.jpg"));
            db.Add(67, new ItemInfo("Witch Hat", "Heads/Head_067.jpg"));
            db.Add(68, new ItemInfo("Wolf Ears", "Heads/Head_068.jpg"));
            db.Add(69, new ItemInfo("Pirate Hat", "Heads/Head_069.jpg"));

            db.Add(70, new ItemInfo("Plague Doctor Mask", "Heads/Head_070.jpg"));
            db.Add(71, new ItemInfo("Knife Hat", "Heads/Head_071.jpg"));
            db.Add(72, new ItemInfo("Hockey Mask", "Heads/Head_072.jpg"));
            db.Add(73, new ItemInfo("Miner Gear Hat", "Heads/Head_073.jpg"));
            db.Add(74, new ItemInfo("Winter Gear Hat", "Heads/Head_074.jpg"));
            db.Add(75, new ItemInfo("Archaeologist Hat", "Heads/Head_075.jpg"));
            db.Add(76, new ItemInfo("Antenna", "Heads/Head_076.jpg"));
            db.Add(77, new ItemInfo("Balloon", "Heads/Head_077.jpg"));
            db.Add(78, new ItemInfo("Bird Nest", "Heads/Head_078.jpg"));
            db.Add(79, new ItemInfo("Black Bandanna", "Heads/Head_079.jpg"));

            db.Add(80, new ItemInfo("Caution Sign Hat", "Heads/Head_080.jpg"));
            db.Add(81, new ItemInfo("Chef Hat", "Heads/Head_081.jpg"));
            db.Add(82, new ItemInfo("Blue Cap", "Heads/Head_082.jpg"));
            db.Add(83, new ItemInfo("Do-rag", "Heads/Head_083.jpg"));
            db.Add(84, new ItemInfo("Dum Sticky Note", "Heads/Head_084.jpg"));
            db.Add(85, new ItemInfo("Fez", "Heads/Head_085.jpg"));
            db.Add(86, new ItemInfo("General Hat", "Heads/Head_086.jpg"));
            db.Add(87, new ItemInfo("Pompadour", "Heads/Head_087.jpg"));
            db.Add(88, new ItemInfo("Hunter Hat", "Heads/Head_088.jpg"));
            db.Add(89, new ItemInfo("Military Helmet", "Heads/Head_089.jpg"));

            db.Add(90, new ItemInfo("Mini Crewmate", "Heads/Head_090.jpg"));
            db.Add(91, new ItemInfo("Ninja Mask", "Heads/Head_091.jpg"));
            db.Add(92, new ItemInfo("Ram Horns", "Heads/Head_092.jpg"));
            db.Add(93, new ItemInfo("Snow Crewmate", "Heads/Head_093.jpg"));
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
