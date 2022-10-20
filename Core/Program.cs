﻿// See https://aka.ms/new-console-template for more information
using Microsoft.Win32.SafeHandles;
using System.Reflection.Metadata;
using System.Diagnostics;
using System.IO;
using static System.Net.WebRequestMethods;
using System;
using System.Reflection;
using System.Security.AccessControl;

Console.WriteLine("Initialization...");

Console.SetWindowSize(121, 31);
//System.Threading.Thread.Sleep(1000);
//Console.WriteLine("U have been hacked");
//System.Diagnostics.Process.Start("explorer.exe", "https://youtu.be/dQw4w9WgXcQ");

// variables
bool prepprep = true;
bool mainmenuloop = true;
bool genloop = false;
bool firstgen = false;
bool genreset = false;
bool gensettings = false;
bool gameloop = false;
bool rendermap = true;
bool inventory = false;
bool load = false;
bool prepload = false;
bool uniload = false;
bool savemain = false;
bool mainmenu = false;
bool logo = true;
bool save = false;
bool startcell = true;
bool cellgen = true;
bool population = false;
bool population1 = true;
bool player = true;
bool battle = false;
bool enemygen = false;
bool turn = false;
bool _event = false;
bool shop = false;
bool boss = false;
int eventid = 0;
int cellmin = 9;
int cellmax = 30;
int eventstate = 0;
int ranout4 = 0;
int bosscell = 0;
int ranoutstr = 0;
int cellcount = 0;
int generror = 0;
int pos = 1;
int saveloaded = 0; // active save file
int savestate = 0; //savestate
int chosg = 0; //secondary controls
int chosg1 = 10; //main controls
int chosg2 = 0; //player controls
int set1 = 0; //health
int set2 = 0; // gold
int set3 = 0; // exp
int set4 = 0; //kills
int set5 = 0; //floor
int set6 = 0; //stage
int set7 = 0;
int set8 = 0;
int set9 = 0;
int slot1 = 0;
int slot2 = 0;
int slot3 = 0;
//enemy index
//-1 error 
//0 empty
//1 slime
//2 skeleton
//3 spawner (if not insta kill spawns random mobs)
//4 troll
//5 tree? ent?
//6 golem
//7 
//8 cat? (why?)
//9 
//10 
// special mobs?
//11 chest (mimic)(chance from event(only?))
//12 (floor 5) finall boss
//13
//14
//15
// id = array index, { health, strg, crit chance, gold, exp}
int[,] enemystats = new int[10, 5] { { 10, 5, 10, 5, 1 }, { 50, 10, 15, 25, 5 }, { 100, 0, 0, 500, 100 }, { 75, 30, 5, 50, 10 }, { 150, 2, 0, 10, 2 }, { 300, 25, 20, 200, 50 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 } };
// id = array index, { health, strg, crit chance, gold, exp}
int[,] spenemystats = new int[5, 5] { { 150, 30, 5, 250, 20 }, { 500, 25, 30, 750, 150 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 } };
// current battle state or for save
// id ,health, strg, crit chance, gold, exp, applied special effect(poison, etc)
int[,] battlelog = new int[4, 7];

//1, id, dmg, crit chance, special effect id
int[] weaponpreset = new int[] { 1, 1, 1, 1, 1 };
//2, id, defence, durability, empty
int[] armorpreset = new int[] { 1, 1, 1, 1, 1 };
//3, id, defence, durability, effect id
int[] shieldpreset = new int[] { 1, 1, 1, 1, 1 };
//4, id,( effect id, effect id2) empty, empty, empty
int[] itempreset = new int[] { 1, 1, 1, 1, 1 };
//type, id, index1, index2, index3, index4
int[] inventorylog = new int[] { 0, 0 };

float fset1 = 0;
string eventrender = "\r\n                                                                                                                        " +
                          "\r\n                                                                                                                        " +
                          "\r\n                                                                                                                        " +
                          "\r\n                                                                                                                        " +
                          "\r\n                                                                                                                        " +
                          "\r\n                                                                                                                        " +
                          "\r\n                                                                                                                        " +
                          "\r\n                                                                                                                        " +
                          "\r\n                                                                                                                        " +
                          "\r\n                                                                                                                        " +
                          "\r\n                                                                                                                        " +
                          "\r\n                                                                                                                        " +
                          "\r\n                                                                                                                        " +
                          "\r\n                                                                                                                        " +
                          "\r\n                                                                                                                        " +
                          "\r\n                                                                                                                        " +
                          "\r\n                                                                                                                        " +
                          "\r\n                                                                                                                        " +
                          "\r\n                                                                                                                        " +
                          "\r\n                                                                                                                        " +
                          "\r\n                                                                                                                        " +
                          "\r\n                                                                                                                        " +
                          "\r\n                                                                                                                        ";
string tempfilepath = "";
// coord for map
int _1x1 = 0;
int _1x2 = 0;
int _1x3 = 0;
int _1x4 = 0;
int _1x5 = 0;
int _1x6 = 0;
int _1x7 = 0;
int _1x8 = 0;
int _1x9 = 0;
int _1x10 = 0;
int _1x11 = 0;
int _1x12 = 0;
int _1x13 = 0;
int _1x14 = 0;
int _1x15 = 0;
int _1x16 = 0;
int _1x17 = 0;
int _2x1 = 0;
int _2x2 = 0;
int _2x3 = 0;
int _2x4 = 0;
int _2x5 = 0;
int _2x6 = 0;
int _2x7 = 0;
int _2x8 = 0;
int _2x9 = 0;
int _3x1 = 0;
int _3x2 = 0;
int _3x3 = 0;
int _3x4 = 0;
int _3x5 = 0;
int _3x6 = 0;
int _3x7 = 0;
int _3x8 = 0;
int _3x9 = 0;
int _3x10 = 0;
int _3x11 = 0;
int _3x12 = 0;
int _3x13 = 0;
int _3x14 = 0;
int _3x15 = 0;
int _3x16 = 0;
int _3x17 = 0;
int _4x1 = 0;
int _4x2 = 0;
int _4x3 = 0;
int _4x4 = 0;
int _4x5 = 0;
int _4x6 = 0;
int _4x7 = 0;
int _4x8 = 0;
int _4x9 = 0;
int _5x1 = 0;
int _5x2 = 0;
int _5x3 = 0;
int _5x4 = 0;
int _5x5 = 0;
int _5x6 = 0;
int _5x7 = 0;
int _5x8 = 0;
int _5x9 = 0;
int _5x10 = 0;
int _5x11 = 0;
int _5x12 = 0;
int _5x13 = 0;
int _5x14 = 0;
int _5x15 = 0;
int _5x16 = 0;
int _5x17 = 0;
int _6x1 = 0;
int _6x2 = 0;
int _6x3 = 0;
int _6x4 = 0;
int _6x5 = 0;
int _6x6 = 0;
int _6x7 = 0;
int _6x8 = 0;
int _6x9 = 0;
int _7x1 = 0;
int _7x3 = 0; //cell
int _7x5 = 0; //cell
int _7x7 = 0; //cell
int _7x9 = 0; //cell
int _7x11 = 0; //cell
int _7x13 = 0; //cell
int _7x15 = 0; //cell
int _7x17 = 0; //cell
int _7x2 = 0; //coridor
int _7x4 = 0;
int _7x6 = 0;
int _7x8 = 0;
int _7x10 = 0;
int _7x12 = 0;
int _7x14 = 0;
int _7x16 = 0;

//testing variables
int f = 1;

//Creating save directory with txt file
string fileName = "Save1.txt";
string fileName1 = "Save2.txt";
string fileName2 = "Save3.txt";
var path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Written Dungeon");
string filepath = System.IO.Path.Combine(path, fileName);
string filepath1 = System.IO.Path.Combine(path, fileName1);
string filepath2 = System.IO.Path.Combine(path, fileName2);
while (prepprep)
{
    if (!Directory.Exists(path))
    {
        Directory.CreateDirectory(path);
    }
    else if (!System.IO.File.Exists(filepath))
    {
        using (StreamWriter sw = System.IO.File.CreateText(filepath))
        {
            sw.WriteLine("none");
        }
    }
    else if (!System.IO.File.Exists(filepath1))
    {
        using (StreamWriter sw = System.IO.File.CreateText(filepath1))
        {
            sw.WriteLine("none");
        }
    }
    else if (!System.IO.File.Exists(filepath2))
    {
        using (StreamWriter sw = System.IO.File.CreateText(filepath2))
        {
            sw.WriteLine("none");
        }
    }
    else
    {
        prepprep = false;
    }
}
Console.WriteLine("Done");
System.Threading.Thread.Sleep(200);
Console.Clear();

while (true)
{
    while (mainmenuloop) // main menu loop
    {


        //main logo st 1
        while (logo)
        {
            Console.Clear();
            Console.WriteLine("              ___       __   ________  ___  _________  _________  _______   ________         \r\n             |\\  \\     |\\  \\|\\   __  \\|\\  \\|\\___   ___\\\\___   ___\\\\  ___ \\ |\\   ___  \\       \r\n             \\ \\  \\    \\ \\  \\ \\  \\|\\  \\ \\  \\|___ \\  \\_\\|___ \\  \\_\\ \\   __/|\\ \\  \\\\ \\  \\      \r\n              \\ \\  \\  __\\ \\  \\ \\   _  _\\ \\  \\   \\ \\  \\     \\ \\  \\ \\ \\  \\_|/_\\ \\  \\\\ \\  \\     \r\n               \\ \\  \\|\\__\\_\\  \\ \\  \\\\  \\\\ \\  \\   \\ \\  \\     \\ \\  \\ \\ \\  \\_|\\ \\ \\  \\\\ \\  \\    \r\n                \\ \\____________\\ \\__\\\\ _\\\\ \\__\\   \\ \\__\\     \\ \\__\\ \\ \\_______\\ \\__\\\\ \\__\\   \r\n                 \\|____________|\\|__|\\|__|\\|__|    \\|__|      \\|__|  \\|_______|\\|__| \\|__|   \r\n                                                                                             \r\n                                                                                             \r\n                                                                                             \r\n              ________  ___  ___  ________   ________  _______   ________  ________          \r\n             |\\   ___ \\|\\  \\|\\  \\|\\   ___  \\|\\   ____\\|\\  ___ \\ |\\   __  \\|\\   ___  \\        \r\n             \\ \\  \\_|\\ \\ \\  \\\\\\  \\ \\  \\\\ \\  \\ \\  \\___|\\ \\   __/|\\ \\  \\|\\  \\ \\  \\\\ \\  \\       \r\n              \\ \\  \\ \\\\ \\ \\  \\\\\\  \\ \\  \\\\ \\  \\ \\  \\  __\\ \\  \\_|/_\\ \\  \\\\\\  \\ \\  \\\\ \\  \\      \r\n               \\ \\  \\_\\\\ \\ \\  \\\\\\  \\ \\  \\\\ \\  \\ \\  \\|\\  \\ \\  \\_|\\ \\ \\  \\\\\\  \\ \\  \\\\ \\  \\     \r\n                \\ \\_______\\ \\_______\\ \\__\\\\ \\__\\ \\_______\\ \\_______\\ \\_______\\ \\__\\\\ \\__\\    \r\n                 \\|_______|\\|_______|\\|__| \\|__|\\|_______|\\|_______|\\|_______|\\|__| \\|__|    \r\n                                                                                             \r\n                                                                                             ");
            Console.WriteLine("                                        ------------------------" +
                          "\r\n                                        | Press Enter to start |" +
                          "\r\n                                        ------------------------");

            if (Console.ReadLine() == "")
            {
                mainmenu = true;
                logo = false;
            }
            else
            {
                Console.WriteLine("Error 2");
            }
        }

        //Main menu st 2
        while (mainmenu)
        {
            Console.Clear();
            Console.WriteLine("\n\r\n\r\n\r\n\r\n\r\n\r                                                    ===========" +
                                                "\n\r                                                    |Main Menu|" +
                                                "\n\r                                                    ===========" +
                                                "\n\r" +
                                                "\n\r                                                     [1] Start " +
                                                "\n\r" +
                                                "\n\r                                                     [2] Quit");
            Console.WriteLine("\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r------------------------------------------------------------------------------------------------------------------------\n\r" +
                "   [1] Numpad 1  |  [2] Numpad 2  |  [Back] Backspace\n\r" +
                "------------------------------------------------------------------------------------------------------------------------");

            switch (Console.ReadKey().Key)
            {
                case ConsoleKey.Escape:
                    Console.Clear();
                    logo = false;
                    mainmenu = false;
                    savemain = false;
                    break;
                case ConsoleKey.Backspace:
                    Console.Clear();
                    logo = true;
                    mainmenu = false;
                    break;
                case ConsoleKey.NumPad1:
                    Console.Clear();
                    mainmenu = false;
                    savemain = true;
                    chosg1 = 0;
                    break;
                case ConsoleKey.NumPad2:
                    Console.Clear();
                    Environment.Exit(0);
                    break;
                case ConsoleKey.Enter:
                    break;

            }


        }

        //choose save slots st 3
        while (savemain)
        {
            while (chosg1 == 0)
            {
                Console.Clear();
                Console.WriteLine("\n\r\n\r\n\r\n\r\n\r\n\r                                                    ===========" +
                                                    "\n\r                                                    |  Saves  |" +
                                                    "\n\r                                                    ===========" +
                                                    "\n\r" +
                                                    "\n\r                                                    [1] Slot 1 " +
                                                    "\n\r" +
                                                    "\n\r                                                    [2] Slot 2" +
                                                    "\n\r" +
                                                    "\n\r                                                    [3] Slot 3");
                Console.WriteLine("\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r------------------------------------------------------------------------------------------------------------------------\n\r" +
                    "   [1] Numpad 1  |  [2] Numpad 2  |  [3] Numpad 3  |  [Back] Backspace\n\r" +
                    "------------------------------------------------------------------------------------------------------------------------");
                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.Escape:
                        Console.Clear();
                        logo = false;
                        mainmenu = true;
                        savemain = false;
                        break;
                    case ConsoleKey.Backspace:
                        Console.Clear();
                        mainmenu = true;
                        savemain = false;
                        chosg1 = 10;
                        break;
                    case ConsoleKey.NumPad1:
                        Console.Clear();
                        chosg1 = 1;
                        break;
                    case ConsoleKey.NumPad2:
                        Console.Clear();
                        //load = true;
                        chosg1 = 2;
                        break;
                    case ConsoleKey.NumPad3:
                        Console.Clear();
                        //load = true;
                        chosg1 = 3;
                        break;
                    case ConsoleKey.Enter:
                        break;
                }
            }

            if (chosg1 == 1) //choose save slot 1
            {

                Console.Clear();
                Console.WriteLine("\n\r\n\r\n\r\n\r\n\r\n\r                                                    ------------" +
                                                    "\n\r                                                   =========== |" +
                                                    "\n\r                                                   |  Slot 1 | |" +
                                                    "\n\r                                                   =========== |" +
                                                    "\n\r                                                               |" +
                                                    "\n\r                                                    [1] Load   |" +
                                                    "\n\r                                                               |" +
                                                    "\n\r                                                    [2] Delete |" +
                                                    "\n\r                                                               |" +
                                                    "\n\r                                                        --------");
                Console.WriteLine("\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r------------------------------------------------------------------------------------------------------------------------\n\r" +
                    "   [1] Numpad 1  |  [2] Numpad 2  |  [Back] Backspace\n\r" +
                    "------------------------------------------------------------------------------------------------------------------------");


                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.Escape:
                        //Console.WriteLine("escape");
                        //Console.Clear();
                        break;
                    case ConsoleKey.Backspace:
                        Console.Clear();
                        chosg1 = 0;
                        chosg = 0;
                        save = false;
                        break;
                    case ConsoleKey.NumPad1:
                        Console.Clear();
                        chosg = 1;
                        chosg1 = 10;
                        savemain = false;
                        mainmenuloop = false;
                        //Console.WriteLine("num 1");
                        break;
                    case ConsoleKey.NumPad2:
                        Console.Clear();
                        //load = true;
                        chosg = 2;
                        break;
                }

                if (chosg == 1) // save selected 1 (loading)
                {
                    saveloaded = 1;
                    prepload = true;
                }
                else if (chosg == 2)
                {
                    tempfilepath = filepath;
                    using (StreamWriter writetext = new StreamWriter(filepath))
                    {
                        writetext.Write("none");
                    }
                    Console.WriteLine("Save Cleared");
                    System.Threading.Thread.Sleep(100);
                }

            }
            if (chosg1 == 2) //save slot 2
            {
                Console.Clear();
                Console.WriteLine("\n\r\n\r\n\r\n\r\n\r\n\r                                                    ------------" +
                                                    "\n\r                                                   =========== |" +
                                                    "\n\r                                                   |  Slot 2 | |" +
                                                    "\n\r                                                   =========== |" +
                                                    "\n\r                                                               |" +
                                                    "\n\r                                                    [1] Load   |" +
                                                    "\n\r                                                               |" +
                                                    "\n\r                                                    [2] Delete |" +
                                                    "\n\r                                                               |" +
                                                    "\n\r                                                        --------");
                Console.WriteLine("\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r------------------------------------------------------------------------------------------------------------------------\n\r" +
                    "   [1] Numpad 1  |  [2] Numpad 2  |  [Back] Backspace\n\r" +
                    "------------------------------------------------------------------------------------------------------------------------");

                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.Escape:
                        //Console.WriteLine("escape");
                        //Console.Clear();
                        break;
                    case ConsoleKey.Backspace:
                        Console.Clear();
                        chosg1 = 0;
                        chosg = 0;
                        save = false;
                        break;
                    case ConsoleKey.NumPad1:
                        Console.Clear();
                        chosg = 1;
                        chosg1 = 10;
                        savemain = false;
                        mainmenuloop = false;
                        //Console.WriteLine("num 1");
                        break;
                    case ConsoleKey.NumPad2:
                        Console.Clear();
                        //load = true;
                        chosg = 2;
                        break;
                }

                if (chosg == 1) // save selected 2 (loading)
                {
                    saveloaded = 2;
                    prepload = true;
                }
                else if (chosg == 2)
                {
                    tempfilepath = filepath1;
                    using (StreamWriter writetext = new StreamWriter(tempfilepath))
                    {
                        writetext.Write("none");
                    }
                    Console.WriteLine("Save Cleared");
                    System.Threading.Thread.Sleep(100);
                }
            }
            if (chosg1 == 3) //save slot 3
            {
                Console.Clear();
                Console.WriteLine("\n\r\n\r\n\r\n\r\n\r\n\r                                                    ------------" +
                                                    "\n\r                                                   =========== |" +
                                                    "\n\r                                                   |  Slot 3 | |" +
                                                    "\n\r                                                   =========== |" +
                                                    "\n\r                                                               |" +
                                                    "\n\r                                                    [1] Load   |" +
                                                    "\n\r                                                               |" +
                                                    "\n\r                                                    [2] Delete |" +
                                                    "\n\r                                                               |" +
                                                    "\n\r                                                        --------");
                Console.WriteLine("\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r------------------------------------------------------------------------------------------------------------------------\n\r" +
                    "   [1] Numpad 1  |  [2] Numpad 2  |  [Back] Backspace\n\r" +
                    "------------------------------------------------------------------------------------------------------------------------");
                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.Escape:
                        //Console.WriteLine("escape");
                        //Console.Clear();
                        break;
                    case ConsoleKey.Backspace:
                        Console.Clear();
                        chosg1 = 0;
                        chosg = 0;
                        save = false;
                        break;
                    case ConsoleKey.NumPad1:
                        Console.Clear();
                        chosg = 1;
                        chosg1 = 10;
                        savemain = false;
                        mainmenuloop = false;
                        //Console.WriteLine("num 1");
                        break;
                    case ConsoleKey.NumPad2:
                        Console.Clear();
                        //load = true;
                        chosg = 2;
                        break;
                }

                if (chosg == 1) // save selected 3 (loading)
                {
                    saveloaded = 3;
                    prepload = true;
                }
                else if (chosg == 2)
                {
                    tempfilepath = filepath2;
                    using (StreamWriter writetext = new StreamWriter(tempfilepath))
                    {
                        writetext.Write("none");
                    }
                    Console.WriteLine("Save Cleared");
                    System.Threading.Thread.Sleep(100);
                }
            }
        }
    }
    // selecting save file
    while (prepload)
    {
        if (saveloaded == 1)
        {
            tempfilepath = filepath;
            load = true;
            prepload = false;
        }
        else if (saveloaded == 2)
        {
            tempfilepath = filepath1;
            load = true;
            prepload = false;
        }
        else if (saveloaded == 3)
        {
            tempfilepath = filepath2;
            load = true;
            prepload = false;
        }
    }
    // actual loading a save
    while (load)
    {
        Console.Clear();
        Console.WriteLine("\n\r                                                    Save Slot " + saveloaded + "\n\r ");

        var filestream = new System.IO.FileStream(tempfilepath,
                                                  System.IO.FileMode.Open,
                                                  System.IO.FileAccess.Read,
                                                  System.IO.FileShare.ReadWrite);
        var file = new System.IO.StreamReader(filestream, System.Text.Encoding.UTF8, true, 128);
        string temp;
        while ((temp = file.ReadLine()) != null)
        {
            //Do something with the lineOfText
            string substring;
            //int useless = 0;
            int startIndex = 0;
            int length = 6;
            while (true)
            {

                if (temp == "none")
                {
                    Console.WriteLine("                                                This file is empty\n\r                                            [3] Change Generation settings");
                    //\n\r Generating...
                    genloop = true;
                    firstgen = true;
                    genreset = true;
                    //System.Threading.Thread.Sleep(500);
                    break;
                }
                substring = temp.Substring(startIndex, length);
                if (substring == "health")
                {
                    startIndex = temp.IndexOf(":");
                    int.TryParse(temp.Substring(startIndex + 1), out set1);
                    Console.WriteLine("                                               Health:" + set1);
                    break;
                }
                else if (substring == "gold__")
                {
                    startIndex = temp.IndexOf(":");
                    int.TryParse(temp.Substring(startIndex + 1), out set2);
                    Console.WriteLine("                                               Gold:" + set2);
                    break;
                }
                else if (substring == "exp___")
                {
                    startIndex = temp.IndexOf(":");
                    int.TryParse(temp.Substring(startIndex + 1), out set3);
                    Console.WriteLine("                                               Exp:" + set3);
                    break;
                }
                else if (substring == "kills_")
                {
                    startIndex = temp.IndexOf(":");
                    int.TryParse(temp.Substring(startIndex + 1), out set4);
                    Console.WriteLine("                                               Kills:" + set4);
                    break;
                }
                else if (substring == "floor_")
                {
                    startIndex = temp.IndexOf(":");
                    int.TryParse(temp.Substring(startIndex + 1), out set5);
                    Console.WriteLine("                                               Floor:" + set5);
                    break;
                }
                //else if (substring == "stage_")
                //{
                //    startIndex = temp.IndexOf(":");
                //    int.TryParse(temp.Substring(startIndex + 1), out set6);
                //    Console.WriteLine("                                               Stage:" + set6);
                //    break;
                //}
                else if (substring == "stagen")
                {
                    //Console.WriteLine(temp);
                    startIndex = temp.IndexOf(":");
                    if (pos == 1)
                    {
                        int.TryParse(temp.Substring(startIndex + 1), out _1x1);
                        pos++;
                    }
                    else if (pos == 2)
                    {
                        int.TryParse(temp.Substring(startIndex + 1), out _1x2);
                        pos++;
                    }
                    else if (pos == 3)
                    {
                        int.TryParse(temp.Substring(startIndex + 1), out _1x3);
                        pos++;
                    }
                    else if (pos == 4)
                    {
                        int.TryParse(temp.Substring(startIndex + 1), out _1x4);
                        pos++;
                    }
                    else if (pos == 5)
                    {
                        int.TryParse(temp.Substring(startIndex + 1), out _1x5);
                        pos++;
                    }
                    else if (pos == 6)
                    {
                        int.TryParse(temp.Substring(startIndex + 1), out _1x6);
                        pos++;
                    }
                    else if (pos == 7)
                    {
                        int.TryParse(temp.Substring(startIndex + 1), out _1x7);
                        pos++;
                    }
                    else if (pos == 8)
                    {
                        int.TryParse(temp.Substring(startIndex + 1), out _1x8);
                        pos++;
                    }
                    else if (pos == 9)
                    {
                        int.TryParse(temp.Substring(startIndex + 1), out _1x9);
                        pos++;
                    }
                    else if (pos == 10)
                    {
                        int.TryParse(temp.Substring(startIndex + 1), out _1x10);
                        pos++;
                    }
                    else if (pos == 11)
                    {
                        int.TryParse(temp.Substring(startIndex + 1), out _1x11);
                        pos++;
                    }
                    else if (pos == 12)
                    {
                        int.TryParse(temp.Substring(startIndex + 1), out _1x12);
                        pos++;
                    }
                    else if (pos == 13)
                    {
                        int.TryParse(temp.Substring(startIndex + 1), out _1x13);
                        pos++;
                    }
                    else if (pos == 14)
                    {
                        int.TryParse(temp.Substring(startIndex + 1), out _1x14);
                        pos++;
                    }
                    else if (pos == 15)
                    {
                        int.TryParse(temp.Substring(startIndex + 1), out _1x15);
                        pos++;
                    }
                    else if (pos == 16)
                    {
                        int.TryParse(temp.Substring(startIndex + 1), out _1x16);
                        pos++;
                    }
                    else if (pos == 17)
                    {
                        int.TryParse(temp.Substring(startIndex + 1), out _1x17);
                        pos++;
                    }
                    else if (pos == 18)
                    {
                        int.TryParse(temp.Substring(startIndex + 1), out _2x1);
                        pos++;
                    }
                    else if (pos == 19)
                    {
                        int.TryParse(temp.Substring(startIndex + 1), out _2x2);
                        pos++;
                    }
                    else if (pos == 20)
                    {
                        int.TryParse(temp.Substring(startIndex + 1), out _2x3);
                        pos++;
                    }
                    else if (pos == 21)
                    {
                        int.TryParse(temp.Substring(startIndex + 1), out _2x4);
                        pos++;
                    }
                    else if (pos == 22)
                    {
                        int.TryParse(temp.Substring(startIndex + 1), out _2x5);
                        pos++;
                    }
                    else if (pos == 23)
                    {
                        int.TryParse(temp.Substring(startIndex + 1), out _2x6);
                        pos++;
                    }
                    else if (pos == 24)
                    {
                        int.TryParse(temp.Substring(startIndex + 1), out _2x7);
                        pos++;
                    }
                    else if (pos == 25)
                    {
                        int.TryParse(temp.Substring(startIndex + 1), out _2x8);
                        pos++;
                    }
                    else if (pos == 26)
                    {
                        int.TryParse(temp.Substring(startIndex + 1), out _2x9);
                        pos++;
                    }
                    else if (pos == 27)
                    {
                        int.TryParse(temp.Substring(startIndex + 1), out _3x1);
                        pos++;
                    }
                    else if (pos == 28)
                    {
                        int.TryParse(temp.Substring(startIndex + 1), out _3x2);
                        pos++;
                    }
                    else if (pos == 29)
                    {
                        int.TryParse(temp.Substring(startIndex + 1), out _3x3);
                        pos++;
                    }
                    else if (pos == 30)
                    {
                        int.TryParse(temp.Substring(startIndex + 1), out _3x4);
                        pos++;
                    }
                    else if (pos == 31)
                    {
                        int.TryParse(temp.Substring(startIndex + 1), out _3x5);
                        pos++;
                    }
                    else if (pos == 32)
                    {
                        int.TryParse(temp.Substring(startIndex + 1), out _3x6);
                        pos++;
                    }
                    else if (pos == 33)
                    {
                        int.TryParse(temp.Substring(startIndex + 1), out _3x7);
                        pos++;
                    }
                    else if (pos == 34)
                    {
                        int.TryParse(temp.Substring(startIndex + 1), out _3x8);
                        pos++;
                    }
                    else if (pos == 35)
                    {
                        int.TryParse(temp.Substring(startIndex + 1), out _3x9);
                        pos++;
                    }
                    else if (pos == 36)
                    {
                        int.TryParse(temp.Substring(startIndex + 1), out _3x10);
                        pos++;
                    }
                    else if (pos == 37)
                    {
                        int.TryParse(temp.Substring(startIndex + 1), out _3x11);
                        pos++;
                    }
                    else if (pos == 38)
                    {
                        int.TryParse(temp.Substring(startIndex + 1), out _3x12);
                        pos++;
                    }
                    else if (pos == 39)
                    {
                        int.TryParse(temp.Substring(startIndex + 1), out _3x13);
                        pos++;
                    }
                    else if (pos == 40)
                    {
                        int.TryParse(temp.Substring(startIndex + 1), out _3x14);
                        pos++;
                    }
                    else if (pos == 41)
                    {
                        int.TryParse(temp.Substring(startIndex + 1), out _3x15);
                        pos++;
                    }
                    else if (pos == 42)
                    {
                        int.TryParse(temp.Substring(startIndex + 1), out _3x16);
                        pos++;
                    }
                    else if (pos == 43)
                    {
                        int.TryParse(temp.Substring(startIndex + 1), out _3x17);
                        pos++;
                    }
                    else if (pos == 44)
                    {
                        int.TryParse(temp.Substring(startIndex + 1), out _4x1);
                        pos++;
                    }
                    else if (pos == 45)
                    {
                        int.TryParse(temp.Substring(startIndex + 1), out _4x2);
                        pos++;
                    }
                    else if (pos == 46)
                    {
                        int.TryParse(temp.Substring(startIndex + 1), out _4x3);
                        pos++;
                    }
                    else if (pos == 47)
                    {
                        int.TryParse(temp.Substring(startIndex + 1), out _4x4);
                        pos++;
                    }
                    else if (pos == 48)
                    {
                        int.TryParse(temp.Substring(startIndex + 1), out _4x5);
                        pos++;
                    }
                    else if (pos == 49)
                    {
                        int.TryParse(temp.Substring(startIndex + 1), out _4x6);
                        pos++;
                    }
                    else if (pos == 50)
                    {
                        int.TryParse(temp.Substring(startIndex + 1), out _4x7);
                        pos++;
                    }
                    else if (pos == 51)
                    {
                        int.TryParse(temp.Substring(startIndex + 1), out _4x8);
                        pos++;
                    }
                    else if (pos == 52)
                    {
                        int.TryParse(temp.Substring(startIndex + 1), out _4x9);
                        pos++;
                    }
                    else if (pos == 53)
                    {
                        int.TryParse(temp.Substring(startIndex + 1), out _5x1);
                        pos++;
                    }
                    else if (pos == 54)
                    {
                        int.TryParse(temp.Substring(startIndex + 1), out _5x2);
                        pos++;
                    }
                    else if (pos == 55)
                    {
                        int.TryParse(temp.Substring(startIndex + 1), out _5x3);
                        pos++;
                    }
                    else if (pos == 56)
                    {
                        int.TryParse(temp.Substring(startIndex + 1), out _5x4);
                        pos++;
                    }
                    else if (pos == 57)
                    {
                        int.TryParse(temp.Substring(startIndex + 1), out _5x5);
                        pos++;
                    }
                    else if (pos == 58)
                    {
                        int.TryParse(temp.Substring(startIndex + 1), out _5x6);
                        pos++;
                    }
                    else if (pos == 59)
                    {
                        int.TryParse(temp.Substring(startIndex + 1), out _5x7);
                        pos++;
                    }
                    else if (pos == 60)
                    {
                        int.TryParse(temp.Substring(startIndex + 1), out _5x8);
                        pos++;
                    }
                    else if (pos == 61)
                    {
                        int.TryParse(temp.Substring(startIndex + 1), out _5x9);
                        pos++;
                    }
                    else if (pos == 62)
                    {
                        int.TryParse(temp.Substring(startIndex + 1), out _5x10);
                        pos++;
                    }
                    else if (pos == 63)
                    {
                        int.TryParse(temp.Substring(startIndex + 1), out _5x11);
                        pos++;
                    }
                    else if (pos == 64)
                    {
                        int.TryParse(temp.Substring(startIndex + 1), out _5x12);
                        pos++;
                    }
                    else if (pos == 65)
                    {
                        int.TryParse(temp.Substring(startIndex + 1), out _5x13);
                        pos++;
                    }
                    else if (pos == 66)
                    {
                        int.TryParse(temp.Substring(startIndex + 1), out _5x14);
                        pos++;
                    }
                    else if (pos == 67)
                    {
                        int.TryParse(temp.Substring(startIndex + 1), out _5x15);
                        pos++;
                    }
                    else if (pos == 68)
                    {
                        int.TryParse(temp.Substring(startIndex + 1), out _5x16);
                        pos++;
                    }
                    else if (pos == 69)
                    {
                        int.TryParse(temp.Substring(startIndex + 1), out _5x17);
                        pos++;
                    }
                    else if (pos == 70)
                    {
                        int.TryParse(temp.Substring(startIndex + 1), out _6x1);
                        pos++;
                    }
                    else if (pos == 71)
                    {
                        int.TryParse(temp.Substring(startIndex + 1), out _6x2);
                        pos++;
                    }
                    else if (pos == 72)
                    {
                        int.TryParse(temp.Substring(startIndex + 1), out _6x3);
                        pos++;
                    }
                    else if (pos == 73)
                    {
                        int.TryParse(temp.Substring(startIndex + 1), out _6x4);
                        pos++;
                    }
                    else if (pos == 74)
                    {
                        int.TryParse(temp.Substring(startIndex + 1), out _6x5);
                        pos++;
                    }
                    else if (pos == 75)
                    {
                        int.TryParse(temp.Substring(startIndex + 1), out _6x6);
                        pos++;
                    }
                    else if (pos == 76)
                    {
                        int.TryParse(temp.Substring(startIndex + 1), out _6x7);
                        pos++;
                    }
                    else if (pos == 77)
                    {
                        int.TryParse(temp.Substring(startIndex + 1), out _6x8);
                        pos++;
                    }
                    else if (pos == 78)
                    {
                        int.TryParse(temp.Substring(startIndex + 1), out _6x9);
                        pos++;
                    }
                    else if (pos == 79)
                    {
                        int.TryParse(temp.Substring(startIndex + 1), out _7x1);
                        pos++;
                    }
                    else if (pos == 80)
                    {
                        int.TryParse(temp.Substring(startIndex + 1), out _7x2);
                        pos++;
                    }
                    else if (pos == 81)
                    {
                        int.TryParse(temp.Substring(startIndex + 1), out _7x3);
                        pos++;
                    }
                    else if (pos == 82)
                    {
                        int.TryParse(temp.Substring(startIndex + 1), out _7x4);
                        pos++;
                    }
                    else if (pos == 83)
                    {
                        int.TryParse(temp.Substring(startIndex + 1), out _7x5);
                        pos++;
                    }
                    else if (pos == 84)
                    {
                        int.TryParse(temp.Substring(startIndex + 1), out _7x6);
                        pos++;
                    }
                    else if (pos == 85)
                    {
                        int.TryParse(temp.Substring(startIndex + 1), out _7x7);
                        pos++;
                    }
                    else if (pos == 86)
                    {
                        int.TryParse(temp.Substring(startIndex + 1), out _7x8);
                        pos++;
                    }
                    else if (pos == 87)
                    {
                        int.TryParse(temp.Substring(startIndex + 1), out _7x9);
                        pos++;
                    }
                    else if (pos == 88)
                    {
                        int.TryParse(temp.Substring(startIndex + 1), out _7x10);
                        pos++;
                    }
                    else if (pos == 89)
                    {
                        int.TryParse(temp.Substring(startIndex + 1), out _7x11);
                        pos++;
                    }
                    else if (pos == 90)
                    {
                        int.TryParse(temp.Substring(startIndex + 1), out _7x12);
                        pos++;
                    }
                    else if (pos == 91)
                    {
                        int.TryParse(temp.Substring(startIndex + 1), out _7x13);
                        pos++;
                    }
                    else if (pos == 92)
                    {
                        int.TryParse(temp.Substring(startIndex + 1), out _7x14);
                        pos++;
                    }
                    else if (pos == 93)
                    {
                        int.TryParse(temp.Substring(startIndex + 1), out _7x15);
                        pos++;
                    }
                    else if (pos == 94)
                    {
                        int.TryParse(temp.Substring(startIndex + 1), out _7x16);
                        pos++;
                    }
                    else if (pos == 95)
                    {
                        int.TryParse(temp.Substring(startIndex + 1), out _7x17);
                        pos++;
                    }
                    //int.TryParse(temp.Substring(startIndex + 1), out gene);
                    //Console.WriteLine("stagen:" + slot1);
                    break;
                }
                else if (substring == "Empty_")
                {
                    startIndex = temp.IndexOf(":");
                    int.TryParse(temp.Substring(startIndex + 1), out set8);
                    //Console.WriteLine("Not assigned:" + set7);
                    break;
                }
                else if (substring == "slot1_")
                {
                    startIndex = temp.IndexOf(":");
                    int.TryParse(temp.Substring(startIndex + 1), out slot1);
                    //Console.WriteLine("slot 1:" + slot1);
                    break;
                }
                else if (true)
                {
                    Console.WriteLine("Error 1");
                }
                //break;
            }
        }
        Console.WriteLine("\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n                                                      Load?\n\r                                                     [1] Yes\n\r                                                     [2] No");
        Console.WriteLine("\n\r\n\r\n\r\n\r\n\r\n------------------------------------------------------------------------------------------------------------------------\n\r" +
                    "   [1] Numpad 1  |  [2] Numpad 2  |  [2] Numpad 2  |  [Back] Backspace\n\r" +
                    "------------------------------------------------------------------------------------------------------------------------");
        //gameloop = true;
        switch (Console.ReadKey().Key)
        {
            case ConsoleKey.NumPad1:
                uniload = true;
                load = false;
                gameloop = true;
                break;
            case ConsoleKey.NumPad2:
                load = false;
                mainmenuloop = true;
                savemain = true;
                chosg1 = 0;
                genloop = false;
                break;
            case ConsoleKey.NumPad3:
                gensettings = true;
                load = false;
                gameloop = true;
                uniload = true;
                break;
            case ConsoleKey.Backspace:
                load = false;
                mainmenuloop = true;
                savemain = true;
                chosg1 = 0;
                genloop = false;
                break;
        }
    }

    while (gensettings)
    {
        Console.Clear();
        for (int i = 1; i == 1; f++)
        {
            Console.WriteLine("Write minimum cells to generate. Default is 9");
            string consoletext = Console.ReadLine();
            if (int.TryParse(consoletext, out cellmin))
            {
                i++;
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Write number dumbass...");
            }
        }
        //int.TryParse(Console.ReadLine(), out cellmin);
        for (int i = 1; i == 1; f++)
        {
            Console.WriteLine("Write maximum cells to generate. Default is 30");
            string consoletext = Console.ReadLine();
            if (int.TryParse(consoletext, out cellmax))
            {
                i++;
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Write number dumbass...");
            }
        }
        gensettings = false;
    }

    // uni load
    int count = 1;
    int percentage = 0;
    while (uniload)
    {
        string bar = "..........";

        while (true)
        {
            int counter = 0;
            while (counter <= 8)
            {
                counter++;
                percentage++;
            }
            break;
        }
        if (count == 2)
        {
            bar = "0.........";
        }
        else if (count == 3)
        {
            bar = "00........";
        }
        else if (count == 4)
        {
            bar = "000.......";
        }
        else if (count == 5)
        {
            bar = "0000......";
        }
        else if (count == 6)
        {
            bar = "00000.....";
        }
        else if (count == 7)
        {
            bar = "000000....";
        }
        else if (count == 8)
        {
            bar = "0000000...";
        }
        else if (count == 9)
        {
            bar = "00000000..";
        }
        else if (count == 10)
        {
            bar = "000000000.";
        }
        else if (count == 11)
        {
            bar = "0000000000";
            uniload = false;
            savemain = false;
            mainmenuloop = false;
        }
        else
        {
            Console.WriteLine("Error 0");
        }
        Console.Clear();
        Console.WriteLine("\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r                                                 ------------");
        Console.WriteLine("                                                 |" + bar + "|  " + percentage + "%");
        Console.WriteLine("                                                 ------------");
        //bar + ".";
        count++;
        System.Threading.Thread.Sleep(50);
    }

    while (genloop) //generation loop st 4
    {
        Console.Clear();
        Console.WriteLine("Gen Loop");
        while (genreset)
        {
            ranout4 = 0;
            savestate = 5;
            cellcount = 0;
            _1x1 = 0;
            _1x2 = 0;
            _1x3 = 0;
            _1x4 = 0;
            _1x5 = 0;
            _1x6 = 0;
            _1x7 = 0;
            _1x8 = 0;
            _1x9 = 0;
            _1x10 = 0;
            _1x11 = 0;
            _1x12 = 0;
            _1x13 = 0;
            _1x14 = 0;
            _1x15 = 0;
            _1x16 = 0;
            _1x17 = 0;
            _2x1 = 0;
            _2x2 = 0;
            _2x3 = 0;
            _2x4 = 0;
            _2x5 = 0;
            _2x6 = 0;
            _2x7 = 0;
            _2x8 = 0;
            _2x9 = 0;
            _3x1 = 0;
            _3x2 = 0;
            _3x3 = 0;
            _3x4 = 0;
            _3x5 = 0;
            _3x6 = 0;
            _3x7 = 0;
            _3x8 = 0;
            _3x9 = 0;
            _3x10 = 0;
            _3x11 = 0;
            _3x12 = 0;
            _3x13 = 0;
            _3x14 = 0;
            _3x15 = 0;
            _3x16 = 0;
            _3x17 = 0;
            _4x1 = 0;
            _4x2 = 0;
            _4x3 = 0;
            _4x4 = 0;
            _4x5 = 0;
            _4x6 = 0;
            _4x7 = 0;
            _4x8 = 0;
            _4x9 = 0;
            _5x1 = 0;
            _5x2 = 0;
            _5x3 = 0;
            _5x4 = 0;
            _5x5 = 0;
            _5x6 = 0;
            _5x7 = 0;
            _5x8 = 0;
            _5x9 = 0;
            _5x10 = 0;
            _5x11 = 0;
            _5x12 = 0;
            _5x13 = 0;
            _5x14 = 0;
            _5x15 = 0;
            _5x16 = 0;
            _5x17 = 0;
            _6x1 = 0;
            _6x2 = 0;
            _6x3 = 0;
            _6x4 = 0;
            _6x5 = 0;
            _6x6 = 0;
            _6x7 = 0;
            _6x8 = 0;
            _6x9 = 0;
            _7x1 = 0;
            _7x3 = 0;
            _7x5 = 0;
            _7x7 = 0;
            _7x9 = 0;
            _7x11 = 0;
            _7x13 = 0;
            _7x15 = 0;
            _7x17 = 0;
            _7x2 = 0;
            _7x4 = 0;
            _7x6 = 0;
            _7x8 = 0;
            _7x10 = 0;
            _7x12 = 0;
            _7x14 = 0;
            _7x16 = 0;
            genreset = false;
        }

        while (firstgen)
        {
            set1 = 100; //health
            set2 = 0; // gold
            set3 = 0; //exp
            set4 = 0; //kills
            set5 = 1; //floor
            //set6 = 1; //stage
            savestate = 5;
            firstgen = false;
        }

        while (startcell)
        {
            Random random = new Random();
            ranoutstr = random.Next(1, 36);
            Console.WriteLine(ranoutstr);
            if (ranoutstr == 1)
            {
                _1x1 = 10;
            }
            else if (ranoutstr == 2)
            {
                _1x3 = 10;
            }
            else if (ranoutstr == 3)
            {
                _1x5 = 10;
            }
            else if (ranoutstr == 4)
            {
                _1x7 = 10;
            }
            else if (ranoutstr == 5)
            {
                _1x9 = 10;
            }
            else if (ranoutstr == 6)
            {
                _1x11 = 10;
            }
            else if (ranoutstr == 7)
            {
                _1x13 = 10;
            }
            else if (ranoutstr == 8)
            {
                _1x15 = 10;
            }
            else if (ranoutstr == 9)
            {
                _1x17 = 10;
            }
            else if (ranoutstr == 10)
            {
                _3x1 = 10;
            }
            else if (ranoutstr == 11)
            {
                _3x3 = 10;
            }
            else if (ranoutstr == 12)
            {
                _3x5 = 10;
            }
            else if (ranoutstr == 13)
            {
                _3x7 = 10;
            }
            else if (ranoutstr == 14)
            {
                _3x9 = 10;
            }
            else if (ranoutstr == 15)
            {
                _3x11 = 10;
            }
            else if (ranoutstr == 16)
            {
                _3x13 = 10;
            }
            else if (ranoutstr == 17)
            {
                _3x15 = 10;
            }
            else if (ranoutstr == 18)
            {
                _3x17 = 10;
            }
            else if (ranoutstr == 19)
            {
                _5x1 = 10;
            }
            else if (ranoutstr == 20)
            {
                _5x3 = 10;
            }
            else if (ranoutstr == 21)
            {
                _5x5 = 10;
            }
            else if (ranoutstr == 22)
            {
                _5x7 = 10;
            }
            else if (ranoutstr == 23)
            {
                _5x9 = 10;
            }
            else if (ranoutstr == 24)
            {
                _5x11 = 10;
            }
            else if (ranoutstr == 25)
            {
                _5x13 = 10;
            }
            else if (ranoutstr == 26)
            {
                _5x15 = 10;
            }
            else if (ranoutstr == 27)
            {
                _5x17 = 10;
            }
            else if (ranoutstr == 28)
            {
                _7x1 = 10;
            }
            else if (ranoutstr == 29)
            {
                _7x3 = 10;
            }
            else if (ranoutstr == 30)
            {
                _7x5 = 10;
            }
            else if (ranoutstr == 31)
            {
                _7x7 = 10;
            }
            else if (ranoutstr == 32)
            {
                _7x9 = 10;
            }
            else if (ranoutstr == 33)
            {
                _7x11 = 10;
            }
            else if (ranoutstr == 34)
            {
                _7x13 = 10;
            }
            else if (ranoutstr == 35)
            {
                _7x15 = 10;
            }
            else if (ranoutstr == 36)
            {
                _7x17 = 10;
            }
            startcell = false;
        }

        while (ranout4 == 0)
        {
            Random random4 = new Random();
            ranout4 = random4.Next(cellmin, cellmax);
        }

        if (ranout4 <= cellcount)
        {
            if (_1x1 == 1)
            {
                _1x1 = 11;
            }
            if (_1x3 == 1)
            {
                _1x3 = 11;
            }
            if (_1x5 == 1)
            {
                _1x5 = 11;
            }
            if (_1x7 == 1)
            {
                _1x7 = 11;
            }
            if (_1x9 == 1)
            {
                _1x9 = 11;
            }
            if (_1x11 == 1)
            {
                _1x11 = 11;
            }
            if (_1x13 == 1)
            {
                _1x13 = 11;
            }
            if (_1x15 == 1)
            {
                _1x15 = 11;
            }
            if (_1x17 == 1)
            {
                _1x17 = 11;
            }
            if (_3x1 == 1)
            {
                _3x1 = 11;
            }
            if (_3x3 == 1)
            {
                _3x3 = 11;
            }
            if (_3x5 == 1)
            {
                _3x5 = 11;
            }
            if (_3x7 == 1)
            {
                _3x7 = 11;
            }
            if (_3x9 == 1)
            {
                _3x9 = 11;
            }
            if (_3x11 == 1)
            {
                _3x11 = 11;
            }
            if (_3x13 == 1)
            {
                _3x13 = 11;
            }
            if (_3x15 == 1)
            {
                _3x15 = 11;
            }
            if (_3x17 == 1)
            {
                _3x17 = 11;
            }
            if (_5x1 == 1)
            {
                _5x1 = 11;
            }
            if (_5x3 == 1)
            {
                _5x3 = 11;
            }
            if (_5x5 == 1)
            {
                _5x5 = 11;
            }
            if (_5x7 == 1)
            {
                _5x7 = 11;
            }
            if (_5x9 == 1)
            {
                _5x9 = 11;
            }
            if (_5x11 == 1)
            {
                _5x11 = 11;
            }
            if (_5x13 == 1)
            {
                _5x13 = 11;
            }
            if (_5x15 == 1)
            {
                _5x15 = 11;
            }
            if (_5x17 == 1)
            {
                _5x17 = 11;
            }
            if (_7x1 == 1)
            {
                _7x1 = 11;
            }
            if (_7x3 == 1)
            {
                _7x3 = 11;
            }
            if (_7x5 == 1)
            {
                _7x5 = 11;
            }
            if (_7x7 == 1)
            {
                _7x7 = 11;
            }
            if (_7x9 == 1)
            {
                _7x9 = 11;
            }
            if (_7x11 == 1)
            {
                _7x11 = 11;
            }
            if (_7x13 == 1)
            {
                _7x13 = 11;
            }
            if (_7x15 == 1)
            {
                _7x15 = 11;
            }
            if (_7x17 == 1)
            {
                _7x17 = 11;
            }
            cellgen = false;
            population = true;
        }

        while (cellgen)
        {
            if (_1x1 == 10 || _1x1 == 1)
            {
                if (ranout4 <= cellcount)
                {
                    bosscell = 1;
                    break;
                }
                Random random = new Random();
                int ranout = random.Next(1, 100);
                int ranout2 = random.Next(1, 100);
                if (ranout >= 50)
                {
                    if (ranout2 >= 50 && _3x1 == 0)
                    {
                        _2x1 = 1;
                        _3x1 = 11;
                    }
                    if (ranout2 <= 50 && _3x1 == 0)
                        _1x2 = 1;
                    _1x3 = 1;
                }
                if (ranout <= 50)
                {
                    if (ranout2 >= 50 && _1x3 == 0)
                    {
                        _1x2 = 1;
                        _1x3 = 11;
                    }
                    _2x1 = 1;
                    _3x1 = 1;
                }
                if (_1x1 == 1)
                {
                    _1x1 = 11;
                }
                cellcount++;
            }

            if (_1x3 == 10 || _1x3 == 1)
            {
                if (ranout4 <= cellcount)
                {
                    bosscell = 2;
                    break;
                }
                Random random = new Random();
                int ranout = random.Next(1, 100);
                int ranout2 = random.Next(1, 100);
                if (ranout <= 34)
                {
                    if (ranout2 <= 34 && ranout2 >= 66 && _3x3 == 0)
                    {
                        _2x2 = 1;
                        _3x3 = 11;
                    }
                    if (ranout2 <= 66 && ranout2 >= 100 && _1x5 == 0)
                    {
                        _1x4 = 1;
                        _1x5 = 11;
                    }
                    if (ranout2 <= 34 && ranout2 >= 66 && _3x3 == 0)
                    {
                        _2x2 = 1;
                        _3x3 = 11;
                    }
                    if (ranout2 <= 66 && ranout2 >= 100 && _1x5 == 0)
                    {
                        _1x4 = 1;
                        _1x5 = 11;
                    }
                    _1x2 = 1;
                    _1x1 = 1;
                }
                if (ranout >= 34 && ranout <= 66)
                {
                    if (ranout2 <= 50 && _1x1 == 0)
                    {
                        _1x2 = 1;
                        _1x1 = 11;
                    }
                    if (ranout2 >= 50 && _3x3 == 0)
                    {
                        _2x2 = 1;
                        _3x3 = 11;
                    }
                    ranout2 = random.Next(1, 100);
                    if (ranout2 <= 50 && _1x1 == 0)
                    {
                        _1x2 = 1;
                        _1x1 = 11;
                    }
                    if (ranout2 >= 50 && _3x3 == 0)
                    {
                        _2x2 = 1;
                        _3x3 = 11;
                    }
                    _1x4 = 1;
                    _1x5 = 1;
                }
                if (ranout >= 75)
                {
                    if (ranout2 <= 50 && _1x1 == 0)
                    {
                        _1x2 = 1;
                        _1x1 = 11;
                    }
                    if (ranout2 >= 50 && _1x5 == 0)
                    {
                        _1x4 = 1;
                        _1x5 = 11;
                    }
                    ranout2 = random.Next(1, 100);
                    if (ranout2 <= 50 && _1x1 == 0)
                    {
                        _1x2 = 1;
                        _1x1 = 11;
                    }
                    if (ranout2 >= 50 && _1x5 == 0)
                    {
                        _1x4 = 1;
                        _1x5 = 11;
                    }
                    _2x2 = 1;
                    _3x3 = 1;
                }
                if (_1x3 == 1)
                {
                    _1x3 = 11;
                }
                cellcount++;
            }

            if (_1x5 == 10 || _1x5 == 1)
            {
                if (ranout4 <= cellcount)
                {
                    bosscell = 3;
                    break;
                }
                Random random = new Random();
                int ranout = random.Next(1, 100);
                int ranout2 = random.Next(1, 100);
                if (ranout <= 34)
                {
                    if (ranout2 <= 50 && _3x5 == 0)
                    {
                        _2x3 = 1;
                        _3x5 = 11;
                    }
                    if (ranout2 >= 50 && _1x7 == 0)
                    {
                        _1x6 = 1;
                        _1x7 = 11;
                    }
                    ranout2 = random.Next(1, 100);
                    if (ranout2 <= 50 && _3x5 == 0)
                    {
                        _2x3 = 1;
                        _3x5 = 11;
                    }
                    if (ranout2 >= 50 && _1x7 == 0)
                    {
                        _1x6 = 1;
                        _1x7 = 11;
                    }
                    _1x4 = 1;
                    _1x3 = 1;
                }
                if (ranout >= 34 && ranout <= 66)
                {
                    if (ranout2 <= 50 && _1x3 == 0)
                    {
                        _1x4 = 1;
                        _1x3 = 11;
                    }
                    if (ranout2 >= 50 && _3x5 == 0)
                    {
                        _2x3 = 1;
                        _3x5 = 11;
                    }
                    ranout2 = random.Next(1, 100);
                    if (ranout2 <= 50 && _1x3 == 0)
                    {
                        _1x4 = 1;
                        _1x3 = 11;
                    }
                    if (ranout2 >= 50 && _3x5 == 0)
                    {
                        _2x3 = 1;
                        _3x5 = 11;
                    }
                    _1x6 = 1;
                    _1x7 = 1;
                }
                if (ranout >= 66)
                {
                    if (ranout2 <= 50 && _1x3 == 0)
                    {
                        _1x4 = 1;
                        _1x3 = 11;
                    }
                    if (ranout2 >= 50 && _1x7 == 0)
                    {
                        _1x6 = 1;
                        _1x7 = 11;
                    }
                    ranout2 = random.Next(1, 100);
                    if (ranout2 <= 50 && _1x3 == 0)
                    {
                        _1x4 = 1;
                        _1x3 = 11;
                    }
                    if (ranout2 >= 50 && _1x7 == 0)
                    {
                        _1x6 = 1;
                        _1x7 = 11;
                    }
                    _2x3 = 1;
                    _3x5 = 1;
                }
                if (_1x5 == 1)
                {
                    _1x5 = 11;
                }
                cellcount++;
            }

            if (_1x7 == 10 || _1x7 == 1)
            {
                if (ranout4 <= cellcount)
                {
                    bosscell = 4;
                    break;
                }
                Random random = new Random();
                int ranout = random.Next(1, 100);
                int ranout2 = random.Next(1, 100);
                if (ranout <= 34)
                {
                    if (ranout2 <= 34 && _1x7 == 0)
                    {
                        _2x4 = 1;
                        _1x7 = 11;
                    }
                    if (ranout2 <= 34 && ranout2 >= 66 && _3x7 == 0)
                    {
                        _2x4 = 1;
                        _3x7 = 11;
                    }
                    if (ranout2 <= 66 && ranout2 >= 100 && _1x9 == 0)
                    {
                        _1x8 = 1;
                        _1x9 = 11;
                    }
                    ranout2 = random.Next(1, 100);
                    if (ranout2 <= 34 && _1x7 == 0)
                    {
                        _2x4 = 1;
                        _1x7 = 11;
                    }
                    if (ranout2 <= 34 && ranout2 >= 66 && _3x7 == 0)
                    {
                        _2x4 = 1;
                        _3x7 = 11;
                    }
                    if (ranout2 <= 66 && ranout2 >= 100 && _1x9 == 0)
                    {
                        _1x8 = 1;
                        _1x9 = 11;
                    }
                    _1x6 = 1;
                    _1x5 = 1;
                }
                if (ranout >= 34 && ranout <= 66)
                {
                    if (ranout2 <= 34 && _1x7 == 0)
                    {
                        _2x4 = 1;
                        _1x7 = 11;
                    }
                    if (ranout2 <= 34 && ranout2 >= 66 && _1x5 == 0)
                    {
                        _1x6 = 1;
                        _1x5 = 11;
                    }
                    if (ranout2 <= 66 && ranout2 >= 100 && _3x7 == 0)
                    {
                        _2x4 = 1;
                        _3x7 = 11;
                    }
                    ranout2 = random.Next(1, 100);
                    if (ranout2 <= 34 && _1x7 == 0)
                    {
                        _2x4 = 1;
                        _1x7 = 11;
                    }
                    if (ranout2 <= 34 && ranout2 >= 66 && _1x5 == 0)
                    {
                        _1x6 = 1;
                        _1x5 = 11;
                    }
                    if (ranout2 <= 66 && ranout2 >= 100 && _3x7 == 0)
                    {
                        _2x4 = 1;
                        _3x7 = 11;
                    }
                    _1x8 = 1;
                    _1x9 = 1;
                }
                if (ranout >= 66)
                {
                    if (ranout2 <= 34 && _1x7 == 0)
                    {
                        _2x4 = 1;
                        _1x7 = 11;
                    }
                    if (ranout2 <= 34 && ranout2 >= 66 && _1x5 == 0)
                    {
                        _1x6 = 1;
                        _1x5 = 11;
                    }
                    if (ranout2 <= 66 && ranout2 >= 100 && _1x9 == 0)
                    {
                        _1x8 = 1;
                        _1x9 = 11;
                    }
                    ranout2 = random.Next(1, 100);
                    if (ranout2 <= 34 && _1x7 == 0)
                    {
                        _2x4 = 1;
                        _1x7 = 11;
                    }
                    if (ranout2 <= 34 && ranout2 >= 66 && _1x5 == 0)
                    {
                        _1x6 = 1;
                        _1x5 = 11;
                    }
                    if (ranout2 <= 66 && ranout2 >= 100 && _1x9 == 0)
                    {
                        _1x8 = 1;
                        _1x9 = 11;
                    }
                    _2x4 = 1;
                    _3x7 = 1;
                }
                if (_1x7 == 1)
                {
                    _1x7 = 11;
                }
                cellcount++;
            }

            if (_1x9 == 10 || _1x9 == 1)
            {
                if (ranout4 <= cellcount)
                {
                    bosscell = 5;
                    break;
                }
                Random random = new Random();
                int ranout = random.Next(1, 100);
                int ranout2 = random.Next(1, 100);
                if (ranout <= 34)
                {
                    if (ranout2 <= 34 && _1x9 == 0)
                    {
                        _2x5 = 1;
                        _1x9 = 11;
                    }
                    if (ranout2 <= 34 && ranout2 >= 66 && _3x9 == 0)
                    {
                        _2x5 = 1;
                        _3x9 = 11;
                    }
                    if (ranout2 <= 66 && ranout2 >= 100 && _1x11 == 0)
                    {
                        _1x10 = 1;
                        _1x11 = 11;
                    }
                    ranout2 = random.Next(1, 100);
                    if (ranout2 <= 34 && _1x9 == 0)
                    {
                        _2x5 = 1;
                        _1x9 = 11;
                    }
                    if (ranout2 <= 34 && ranout2 >= 66 && _3x9 == 0)
                    {
                        _2x5 = 1;
                        _3x9 = 11;
                    }
                    if (ranout2 <= 66 && ranout2 >= 100 && _1x11 == 0)
                    {
                        _1x10 = 1;
                        _1x11 = 11;
                    }
                    _1x8 = 1;
                    _1x7 = 1;
                }
                if (ranout >= 34 && ranout <= 66)
                {
                    if (ranout2 <= 34 && _1x9 == 0)
                    {
                        _2x5 = 1;
                        _1x9 = 11;
                    }
                    if (ranout2 <= 34 && ranout2 >= 66 && _1x7 == 0)
                    {
                        _1x8 = 1;
                        _1x7 = 11;
                    }
                    if (ranout2 <= 66 && ranout2 >= 100 && _3x9 == 0)
                    {
                        _2x5 = 1;
                        _3x9 = 11;
                    }
                    ranout2 = random.Next(1, 100);
                    if (ranout2 <= 34 && _1x9 == 0)
                    {
                        _2x5 = 1;
                        _1x9 = 11;
                    }
                    if (ranout2 <= 34 && ranout2 >= 66 && _1x7 == 0)
                    {
                        _1x8 = 1;
                        _1x7 = 11;
                    }
                    if (ranout2 <= 66 && ranout2 >= 100 && _3x9 == 0)
                    {
                        _2x5 = 1;
                        _3x9 = 11;
                    }
                    _1x10 = 1;
                    _1x11 = 1;
                }
                if (ranout >= 66)
                {
                    if (ranout2 <= 34 && _1x9 == 0)
                    {
                        _2x5 = 1;
                        _1x9 = 11;
                    }
                    if (ranout2 <= 34 && ranout2 >= 66 && _1x7 == 0)
                    {
                        _1x8 = 1;
                        _1x7 = 11;
                    }
                    if (ranout2 <= 66 && ranout2 >= 100 && _1x11 == 0)
                    {
                        _1x10 = 1;
                        _1x11 = 11;
                    }
                    ranout2 = random.Next(1, 100);
                    if (ranout2 <= 34 && _1x9 == 0)
                    {
                        _2x5 = 1;
                        _1x9 = 11;
                    }
                    if (ranout2 <= 34 && ranout2 >= 66 && _1x7 == 0)
                    {
                        _1x8 = 1;
                        _1x7 = 11;
                    }
                    if (ranout2 <= 66 && ranout2 >= 100 && _1x11 == 0)
                    {
                        _1x10 = 1;
                        _1x11 = 11;
                    }
                    _2x5 = 1;
                    _3x9 = 1;
                }
                if (_1x9 == 1)
                {
                    _1x9 = 11;
                }
                cellcount++;
            }

            if (_1x11 == 10 || _1x11 == 1)
            {
                if (ranout4 <= cellcount)
                {
                    bosscell = 6;
                    break;
                }
                Random random = new Random();
                int ranout = random.Next(1, 100);
                int ranout2 = random.Next(1, 100);
                if (ranout <= 34)
                {
                    if (ranout2 <= 34 && _1x11 == 0)
                    {
                        _2x6 = 1;
                        _1x11 = 11;
                    }
                    if (ranout2 <= 34 && ranout2 >= 66 && _3x11 == 0)
                    {
                        _2x6 = 1;
                        _3x11 = 11;
                    }
                    if (ranout2 <= 66 && ranout2 >= 100 && _1x13 == 0)
                    {
                        _1x12 = 1;
                        _1x13 = 11;
                    }
                    ranout2 = random.Next(1, 100);
                    if (ranout2 <= 34 && _1x11 == 0)
                    {
                        _2x6 = 1;
                        _1x11 = 11;
                    }
                    if (ranout2 <= 34 && ranout2 >= 66 && _3x11 == 0)
                    {
                        _2x6 = 1;
                        _3x11 = 11;
                    }
                    if (ranout2 <= 66 && ranout2 >= 100 && _1x13 == 0)
                    {
                        _1x12 = 1;
                        _1x13 = 11;
                    }
                    _1x10 = 1;
                    _1x9 = 1;
                }
                if (ranout >= 34 && ranout <= 66)
                {
                    if (ranout2 <= 34 && _1x11 == 0)
                    {
                        _2x6 = 1;
                        _1x11 = 11;
                    }
                    if (ranout2 <= 34 && ranout2 >= 66 && _1x9 == 0)
                    {
                        _1x10 = 1;
                        _1x9 = 11;
                    }
                    if (ranout2 <= 66 && ranout2 >= 100 && _3x11 == 0)
                    {
                        _2x6 = 1;
                        _3x11 = 11;
                    }
                    ranout2 = random.Next(1, 100);
                    if (ranout2 <= 34 && _1x11 == 0)
                    {
                        _2x6 = 1;
                        _1x11 = 11;
                    }
                    if (ranout2 <= 34 && ranout2 >= 66 && _1x9 == 0)
                    {
                        _1x10 = 1;
                        _1x9 = 11;
                    }
                    if (ranout2 <= 66 && ranout2 >= 100 && _3x11 == 0)
                    {
                        _2x6 = 1;
                        _3x11 = 11;
                    }
                    _1x12 = 1;
                    _1x13 = 1;
                }
                if (ranout >= 66)
                {
                    if (ranout2 <= 34 && _1x11 == 0)
                    {
                        _2x6 = 1;
                        _1x11 = 11;
                    }
                    if (ranout2 <= 34 && ranout2 >= 66 && _1x9 == 0)
                    {
                        _1x10 = 1;
                        _1x9 = 11;
                    }
                    if (ranout2 <= 66 && ranout2 >= 100 && _1x13 == 0)
                    {
                        _1x12 = 1;
                        _1x13 = 11;
                    }
                    ranout2 = random.Next(1, 100);
                    if (ranout2 <= 34 && _1x11 == 0)
                    {
                        _2x6 = 1;
                        _1x11 = 11;
                    }
                    if (ranout2 <= 34 && ranout2 >= 66 && _1x9 == 0)
                    {
                        _1x10 = 1;
                        _1x9 = 11;
                    }
                    if (ranout2 <= 66 && ranout2 >= 100 && _1x13 == 0)
                    {
                        _1x12 = 1;
                        _1x13 = 11;
                    }
                    _2x6 = 1;
                    _3x11 = 1;
                }
                if (_1x11 == 1)
                {
                    _1x11 = 11;
                }
                cellcount++;
            }

            if (_1x13 == 10 || _1x13 == 1)
            {
                if (ranout4 <= cellcount)
                {
                    bosscell = 7;
                    break;
                }
                Random random = new Random();
                int ranout = random.Next(1, 100);
                int ranout2 = random.Next(1, 100);
                if (ranout <= 34)
                {
                    if (ranout2 <= 34 && _1x13 == 0)
                    {
                        _2x7 = 1;
                        _1x13 = 11;
                    }
                    if (ranout2 <= 34 && ranout2 >= 66 && _3x13 == 0)
                    {
                        _2x7 = 1;
                        _3x13 = 11;
                    }
                    if (ranout2 <= 66 && ranout2 >= 100 && _1x15 == 0)
                    {
                        _1x14 = 1;
                        _1x15 = 11;
                    }
                    ranout2 = random.Next(1, 100);
                    if (ranout2 <= 34 && _1x13 == 0)
                    {
                        _2x7 = 1;
                        _1x13 = 11;
                    }
                    if (ranout2 <= 34 && ranout2 >= 66 && _3x13 == 0)
                    {
                        _2x7 = 1;
                        _3x13 = 11;
                    }
                    if (ranout2 <= 66 && ranout2 >= 100 && _1x15 == 0)
                    {
                        _1x14 = 1;
                        _1x15 = 11;
                    }
                    _1x12 = 1;
                    _1x11 = 1;
                }
                if (ranout >= 34 && ranout <= 66)
                {
                    if (ranout2 <= 34 && _1x13 == 0)
                    {
                        _2x7 = 1;
                        _1x13 = 11;
                    }
                    if (ranout2 <= 34 && ranout2 >= 66 && _1x11 == 0)
                    {
                        _1x12 = 1;
                        _1x11 = 11;
                    }
                    if (ranout2 <= 66 && ranout2 >= 100 && _3x13 == 0)
                    {
                        _2x7 = 1;
                        _3x13 = 11;
                    }
                    ranout2 = random.Next(1, 100);
                    if (ranout2 <= 34 && _1x13 == 0)
                    {
                        _2x7 = 1;
                        _1x13 = 11;
                    }
                    if (ranout2 <= 34 && ranout2 >= 66 && _1x11 == 0)
                    {
                        _1x12 = 1;
                        _1x11 = 11;
                    }
                    if (ranout2 <= 66 && ranout2 >= 100 && _3x13 == 0)
                    {
                        _2x7 = 1;
                        _3x13 = 11;
                    }
                    _1x14 = 1;
                    _1x15 = 1;
                }
                if (ranout >= 66)
                {
                    if (ranout2 <= 34 && _1x13 == 0)
                    {
                        _2x7 = 1;
                        _1x13 = 11;
                    }
                    if (ranout2 <= 34 && ranout2 >= 66 && _1x11 == 0)
                    {
                        _1x12 = 1;
                        _1x11 = 11;
                    }
                    if (ranout2 <= 66 && ranout2 >= 100 && _1x15 == 0)
                    {
                        _1x14 = 1;
                        _1x15 = 11;
                    }
                    ranout2 = random.Next(1, 100);
                    if (ranout2 <= 34 && _1x13 == 0)
                    {
                        _2x7 = 1;
                        _1x13 = 11;
                    }
                    if (ranout2 <= 34 && ranout2 >= 66 && _1x11 == 0)
                    {
                        _1x12 = 1;
                        _1x11 = 11;
                    }
                    if (ranout2 <= 66 && ranout2 >= 100 && _1x15 == 0)
                    {
                        _1x14 = 1;
                        _1x15 = 11;
                    }
                    _2x7 = 1;
                    _3x13 = 1;
                }
                if (_1x13 == 1)
                {
                    _1x13 = 11;
                }
                cellcount++;
            }

            if (_1x15 == 10 || _1x15 == 1)
            {
                if (ranout4 <= cellcount)
                {
                    bosscell = 8;
                    break;
                }
                Random random = new Random();
                int ranout = random.Next(1, 100);
                int ranout2 = random.Next(1, 100);
                if (ranout <= 34)
                {
                    if (ranout2 <= 34 && _1x15 == 0)
                    {
                        _2x8 = 1;
                        _1x15 = 11;
                    }
                    if (ranout2 <= 34 && ranout2 >= 66 && _3x15 == 0)
                    {
                        _2x8 = 1;
                        _3x15 = 11;
                    }
                    if (ranout2 <= 66 && ranout2 >= 100 && _1x17 == 0)
                    {
                        _1x16 = 1;
                        _1x17 = 11;
                    }
                    ranout2 = random.Next(1, 100);
                    if (ranout2 <= 34 && _1x15 == 0)
                    {
                        _2x8 = 1;
                        _1x15 = 11;
                    }
                    if (ranout2 <= 34 && ranout2 >= 66 && _3x15 == 0)
                    {
                        _2x8 = 1;
                        _3x15 = 11;
                    }
                    if (ranout2 <= 66 && ranout2 >= 100 && _1x17 == 0)
                    {
                        _1x16 = 1;
                        _1x17 = 11;
                    }
                    _1x14 = 1;
                    _1x13 = 1;
                }
                if (ranout >= 34 && ranout <= 66)
                {
                    if (ranout2 <= 34 && _1x15 == 0)
                    {
                        _2x8 = 1;
                        _1x15 = 11;
                    }
                    if (ranout2 <= 34 && ranout2 >= 66 && _1x13 == 0)
                    {
                        _1x14 = 1;
                        _1x13 = 11;
                    }
                    if (ranout2 <= 66 && ranout2 >= 100 && _3x15 == 0)
                    {
                        _2x8 = 1;
                        _3x15 = 11;
                    }
                    ranout2 = random.Next(1, 100);
                    if (ranout2 <= 34 && _1x15 == 0)
                    {
                        _2x8 = 1;
                        _1x15 = 11;
                    }
                    if (ranout2 <= 34 && ranout2 >= 66 && _1x13 == 0)
                    {
                        _1x14 = 1;
                        _1x13 = 11;
                    }
                    if (ranout2 <= 66 && ranout2 >= 100 && _3x15 == 0)
                    {
                        _2x8 = 1;
                        _3x15 = 11;
                    }
                    _1x16 = 1;
                    _1x17 = 1;
                }
                if (ranout >= 66)
                {
                    if (ranout2 <= 34 && _1x15 == 0)
                    {
                        _2x8 = 1;
                        _1x15 = 11;
                    }
                    if (ranout2 <= 34 && ranout2 >= 66 && _1x13 == 0)
                    {
                        _1x14 = 1;
                        _1x13 = 11;
                    }
                    if (ranout2 <= 66 && ranout2 >= 100 && _1x17 == 0)
                    {
                        _1x16 = 1;
                        _1x17 = 11;
                    }
                    ranout2 = random.Next(1, 100);
                    if (ranout2 <= 34 && _1x15 == 0)
                    {
                        _2x8 = 1;
                        _1x15 = 11;
                    }
                    if (ranout2 <= 34 && ranout2 >= 66 && _1x13 == 0)
                    {
                        _1x14 = 1;
                        _1x13 = 11;
                    }
                    if (ranout2 <= 66 && ranout2 >= 100 && _1x17 == 0)
                    {
                        _1x16 = 1;
                        _1x17 = 11;
                    }
                    _2x8 = 1;
                    _3x15 = 1;
                }
                if (_1x15 == 1)
                {
                    _1x15 = 11;
                }
                cellcount++;
            }

            if (_1x17 == 10 || _1x17 == 1)
            {
                if (ranout4 <= cellcount)
                {
                    bosscell = 9;
                    break;
                }
                Random random = new Random();
                int ranout = random.Next(1, 100);
                int ranout2 = random.Next(1, 100);
                if (ranout <= 50)
                {
                    if (ranout2 >= 50 && _3x17 == 0)
                    {
                        _2x9 = 1;
                        _3x17 = 11;
                    }
                    _1x16 = 1;
                    _1x15 = 1;
                }
                if (ranout >= 50)
                {
                    if (ranout2 >= 50 && _1x15 == 0)
                    {
                        _1x16 = 1;
                        _1x15 = 11;
                    }
                    _2x9 = 1;
                    _3x17 = 1;
                }
                if (_1x17 == 1)
                {
                    _1x17 = 11;
                }
                cellcount++;
            }
            // coridors done from here                                                                            //////////////////////
            if (_3x1 == 10 || _3x1 == 1)
            {
                if (ranout4 <= cellcount)
                {
                    bosscell = 10;
                    break;
                }
                Random random = new Random();
                int ranout = random.Next(1, 100);
                int ranout2 = random.Next(1, 100);
                if (ranout <= 34)
                {
                    if (ranout2 <= 50 && _5x1 == 0)
                    {
                        _4x1 = 1;
                        _5x1 = 11;
                    }
                    if (ranout2 >= 50 && _3x3 == 0)
                    {
                        _3x2 = 1;
                        _3x3 = 11;
                    }
                    ranout2 = random.Next(1, 100);
                    if (ranout2 <= 50 && _5x1 == 0)
                    {
                        _4x1 = 1;
                        _5x1 = 11;
                    }
                    if (ranout2 >= 50 && _3x3 == 0)
                    {
                        _3x2 = 1;
                        _3x3 = 11;
                    }
                    _2x1 = 1;
                    _1x1 = 1;
                }
                if (ranout >= 34 && ranout <= 66)
                {
                    if (ranout2 <= 50 && _1x1 == 0)
                    {
                        _2x1 = 1;
                        _1x1 = 11;
                    }
                    if (ranout2 >= 50 && _5x1 == 0)
                    {
                        _4x1 = 1;
                        _5x1 = 11;
                    }
                    ranout2 = random.Next(1, 100);
                    if (ranout2 <= 50 && _1x1 == 0)
                    {
                        _2x1 = 1;
                        _1x1 = 11;
                    }
                    if (ranout2 >= 50 && _5x1 == 0)
                    {
                        _4x1 = 1;
                        _5x1 = 11;
                    }
                    _3x2 = 1;
                    _3x3 = 1;
                }
                if (ranout >= 66)
                {
                    if (ranout2 <= 50 && _1x1 == 0)
                    {
                        _2x1 = 1;
                        _1x1 = 11;
                    }
                    if (ranout2 >= 50 && _3x3 == 0)
                    {
                        _3x2 = 1;
                        _3x3 = 11;
                    }
                    ranout2 = random.Next(1, 100);
                    if (ranout2 <= 50 && _1x1 == 0)
                    {
                        _2x1 = 1;
                        _1x1 = 11;
                    }
                    if (ranout2 >= 50 && _3x3 == 0)
                    {
                        _3x2 = 1;
                        _3x3 = 11;
                    }
                    _4x1 = 1;
                    _5x1 = 1;
                }
                if (_3x1 == 1)
                {
                    _3x1 = 11;
                }
                cellcount++;
            }

            if (_3x3 == 10 || _3x3 == 1)
            {
                if (ranout4 <= cellcount)
                {
                    bosscell = 11;
                    break;
                }
                Random random = new Random();
                int ranout = random.Next(1, 100);
                int ranout2 = random.Next(1, 100);
                if (ranout <= 25)
                {
                    if (ranout2 <= 34 && _5x3 == 0)
                    {
                        _4x2 = 1;
                        _5x3 = 11;
                    }
                    if (ranout2 <= 34 && ranout2 >= 66 && _3x1 == 0)
                    {
                        _3x2 = 1;
                        _3x1 = 11;
                    }
                    if (ranout2 <= 66 && ranout2 >= 100 && _3x5 == 0)
                    {
                        _3x4 = 1;
                        _3x5 = 11;
                    }
                    ranout2 = random.Next(1, 100);
                    if (ranout2 <= 34 && _5x3 == 0)
                    {
                        _4x2 = 1;
                        _5x3 = 11;
                    }
                    if (ranout2 <= 34 && ranout2 >= 66 && _3x1 == 0)
                    {
                        _3x2 = 1;
                        _3x1 = 11;
                    }
                    if (ranout2 <= 66 && ranout2 >= 100 && _3x5 == 0)
                    {
                        _3x4 = 1;
                        _3x5 = 11;
                    }
                    _2x2 = 1;
                    _1x3 = 1;
                }
                if (ranout >= 25 && ranout <= 50)
                {
                    if (ranout2 <= 34 && _1x3 == 0)
                    {
                        _2x2 = 1;
                        _1x3 = 11;
                    }
                    if (ranout2 <= 34 && ranout2 >= 66 && _5x3 == 0)
                    {
                        _4x2 = 1;
                        _5x3 = 11;
                    }
                    if (ranout2 <= 66 && ranout2 >= 100 && _3x5 == 0)
                    {
                        _3x4 = 1;
                        _3x5 = 11;
                    }
                    ranout2 = random.Next(1, 100);
                    if (ranout2 <= 34 && _1x3 == 0)
                    {
                        _2x2 = 1;
                        _1x3 = 11;
                    }
                    if (ranout2 <= 34 && ranout2 >= 66 && _5x3 == 0)
                    {
                        _4x2 = 1;
                        _5x3 = 11;
                    }
                    if (ranout2 <= 66 && ranout2 >= 100 && _3x5 == 0)
                    {
                        _3x4 = 1;
                        _3x5 = 11;
                    }
                    _3x2 = 1;
                    _3x1 = 1;
                }
                if (ranout >= 50 && ranout <= 75)
                {
                    if (ranout2 <= 34 && _1x3 == 0)
                    {
                        _2x2 = 1;
                        _1x3 = 11;
                    }
                    if (ranout2 <= 34 && ranout2 >= 66 && _3x1 == 0)
                    {
                        _3x2 = 1;
                        _3x1 = 11;
                    }
                    if (ranout2 <= 66 && ranout2 >= 100 && _5x3 == 0)
                    {
                        _4x2 = 1;
                        _5x3 = 11;
                    }
                    ranout2 = random.Next(1, 100);
                    if (ranout2 <= 34 && _1x3 == 0)
                    {
                        _2x2 = 1;
                        _1x3 = 11;
                    }
                    if (ranout2 <= 34 && ranout2 >= 66 && _3x1 == 0)
                    {
                        _3x2 = 1;
                        _3x1 = 11;
                    }
                    if (ranout2 <= 66 && ranout2 >= 100 && _5x3 == 0)
                    {
                        _4x2 = 1;
                        _5x3 = 11;
                    }
                    _3x4 = 1;
                    _3x5 = 1;
                }
                if (ranout >= 75)
                {
                    if (ranout2 <= 34 && _1x3 == 0)
                    {
                        _2x2 = 1;
                        _1x3 = 11;
                    }
                    if (ranout2 <= 34 && ranout2 >= 66 && _3x1 == 0)
                    {
                        _3x2 = 1;
                        _3x1 = 11;
                    }
                    if (ranout2 <= 66 && ranout2 >= 100 && _3x5 == 0)
                    {
                        _3x4 = 1;
                        _3x5 = 11;
                    }
                    ranout2 = random.Next(1, 100);
                    if (ranout2 <= 34 && _1x3 == 0)
                    {
                        _2x2 = 1;
                        _1x3 = 11;
                    }
                    if (ranout2 <= 34 && ranout2 >= 66 && _3x1 == 0)
                    {
                        _3x2 = 1;
                        _3x1 = 11;
                    }
                    if (ranout2 <= 66 && ranout2 >= 100 && _3x5 == 0)
                    {
                        _3x4 = 1;
                        _3x5 = 11;
                    }
                    _4x2 = 1;
                    _5x3 = 1;
                }
                if (_3x3 == 1)
                {
                    _3x3 = 11;
                }
                cellcount++;
            }

            if (_3x5 == 10 || _3x5 == 1)
            {
                if (ranout4 <= cellcount)
                {
                    bosscell = 11;
                    break;
                }
                Random random = new Random();
                int ranout = random.Next(1, 100);
                int ranout2 = random.Next(1, 100);
                if (ranout <= 25)
                {
                    if (ranout2 <= 34 && _5x5 == 0)
                    {
                        _4x3 = 1;
                        _5x5 = 11;
                    }
                    if (ranout2 <= 34 && ranout2 >= 66 && _3x3 == 0)
                    {
                        _3x4 = 1;
                        _3x3 = 11;
                    }
                    if (ranout2 <= 66 && ranout2 >= 100 && _3x7 == 0)
                    {
                        _3x6 = 1;
                        _3x7 = 11;
                    }
                    ranout2 = random.Next(1, 100);
                    if (ranout2 <= 34 && _5x5 == 0)
                    {
                        _4x3 = 1;
                        _5x5 = 11;
                    }
                    if (ranout2 <= 34 && ranout2 >= 66 && _3x3 == 0)
                    {
                        _3x4 = 1;
                        _3x3 = 11;
                    }
                    if (ranout2 <= 66 && ranout2 >= 100 && _3x7 == 0)
                    {
                        _3x6 = 1;
                        _3x7 = 11;
                    }
                    _2x3 = 1;
                    _1x5 = 1;
                }
                if (ranout >= 25 && ranout <= 50)
                {
                    if (ranout2 <= 34 && _1x5 == 0)
                    {
                        _2x3 = 1;
                        _1x5 = 11;
                    }
                    if (ranout2 <= 34 && ranout2 >= 66 && _5x5 == 0)
                    {
                        _4x3 = 1;
                        _5x5 = 11;
                    }
                    if (ranout2 <= 66 && ranout2 >= 100 && _3x7 == 0)
                    {
                        _3x6 = 1;
                        _3x7 = 11;
                    }
                    ranout2 = random.Next(1, 100);
                    if (ranout2 <= 34 && _1x5 == 0)
                    {
                        _2x3 = 1;
                        _1x5 = 11;
                    }
                    if (ranout2 <= 34 && ranout2 >= 66 && _5x5 == 0)
                    {
                        _4x3 = 1;
                        _5x5 = 11;
                    }
                    if (ranout2 <= 66 && ranout2 >= 100 && _3x7 == 0)
                    {
                        _3x6 = 1;
                        _3x7 = 11;
                    }
                    _3x4 = 1;
                    _3x3 = 1;
                }
                if (ranout >= 50 && ranout <= 75)
                {
                    if (ranout2 <= 34 && _1x5 == 0)
                    {
                        _2x3 = 1;
                        _1x5 = 11;
                    }
                    if (ranout2 <= 34 && ranout2 >= 66 && _3x3 == 0)
                    {
                        _3x4 = 1;
                        _3x3 = 11;
                    }
                    if (ranout2 <= 66 && ranout2 >= 100 && _5x5 == 0)
                    {
                        _4x3 = 1;
                        _5x5 = 11;
                    }
                    ranout2 = random.Next(1, 100);
                    if (ranout2 <= 34 && _1x5 == 0)
                    {
                        _2x3 = 1;
                        _1x5 = 11;
                    }
                    if (ranout2 <= 34 && ranout2 >= 66 && _3x3 == 0)
                    {
                        _3x4 = 1;
                        _3x3 = 11;
                    }
                    if (ranout2 <= 66 && ranout2 >= 100 && _5x5 == 0)
                    {
                        _4x3 = 1;
                        _5x5 = 11;
                    }
                    _3x6 = 1;
                    _3x7 = 1;
                }
                if (ranout >= 75)
                {
                    if (ranout2 <= 34 && _1x5 == 0)
                    {
                        _2x3 = 1;
                        _1x5 = 11;
                    }
                    if (ranout2 <= 34 && ranout2 >= 66 && _3x3 == 0)
                    {
                        _3x4 = 1;
                        _3x3 = 11;
                    }
                    if (ranout2 <= 66 && ranout2 >= 100 && _3x7 == 0)
                    {
                        _3x6 = 1;
                        _3x7 = 11;
                    }
                    ranout2 = random.Next(1, 100);
                    if (ranout2 <= 34 && _1x5 == 0)
                    {
                        _2x3 = 1;
                        _1x5 = 11;
                    }
                    if (ranout2 <= 34 && ranout2 >= 66 && _3x3 == 0)
                    {
                        _3x4 = 1;
                        _3x3 = 11;
                    }
                    if (ranout2 <= 66 && ranout2 >= 100 && _3x7 == 0)
                    {
                        _3x6 = 1;
                        _3x7 = 11;
                    }
                    _4x3 = 1;
                    _5x5 = 1;
                }
                if (_3x5 == 1)
                {
                    _3x5 = 11;
                }
                cellcount++;
            }

            if (_3x7 == 10 || _3x7 == 1)
            {
                if (ranout4 <= cellcount)
                {
                    bosscell = 13;
                    break;
                }
                Random random = new Random();
                int ranout = random.Next(1, 100);
                int ranout2 = random.Next(1, 100);
                if (ranout <= 25)
                {
                    if (ranout2 <= 34 && _5x7 == 0)
                    {
                        _4x4 = 1;
                        _5x7 = 11;
                    }
                    if (ranout2 <= 34 && ranout2 >= 66 && _3x5 == 0)
                    {
                        _3x6 = 1;
                        _3x5 = 11;
                    }
                    if (ranout2 <= 66 && ranout2 >= 100 && _3x9 == 0)
                    {
                        _3x8 = 1;
                        _3x9 = 11;
                    }
                    ranout2 = random.Next(1, 100);
                    if (ranout2 <= 34 && _5x7 == 0)
                    {
                        _4x4 = 1;
                        _5x7 = 11;
                    }
                    if (ranout2 <= 34 && ranout2 >= 66 && _3x5 == 0)
                    {
                        _3x6 = 1;
                        _3x5 = 11;
                    }
                    if (ranout2 <= 66 && ranout2 >= 100 && _3x9 == 0)
                    {
                        _3x8 = 1;
                        _3x9 = 11;
                    }
                    _2x4 = 1;
                    _1x7 = 1;
                }
                if (ranout >= 25 && ranout <= 50)
                {
                    if (ranout2 <= 34 && _1x7 == 0)
                    {
                        _2x4 = 1;
                        _1x7 = 11;
                    }
                    if (ranout2 <= 34 && ranout2 >= 66 && _5x7 == 0)
                    {
                        _4x4 = 1;
                        _5x7 = 11;
                    }
                    if (ranout2 <= 66 && ranout2 >= 100 && _3x9 == 0)
                    {
                        _3x8 = 1;
                        _3x9 = 11;
                    }
                    ranout2 = random.Next(1, 100);
                    if (ranout2 <= 34 && _1x7 == 0)
                    {
                        _2x4 = 1;
                        _1x7 = 11;
                    }
                    if (ranout2 <= 34 && ranout2 >= 66 && _5x7 == 0)
                    {
                        _4x4 = 1;
                        _5x7 = 11;
                    }
                    if (ranout2 <= 66 && ranout2 >= 100 && _3x9 == 0)
                    {
                        _3x8 = 1;
                        _3x9 = 11;
                    }
                    _3x6 = 1;
                    _3x5 = 1;
                }
                if (ranout >= 50 && ranout <= 75)
                {
                    if (ranout2 <= 34 && _1x7 == 0)
                    {
                        _2x4 = 1;
                        _1x7 = 11;
                    }
                    if (ranout2 <= 34 && ranout2 >= 66 && _3x5 == 0)
                    {
                        _3x6 = 1;
                        _3x5 = 11;
                    }
                    if (ranout2 <= 66 && ranout2 >= 100 && _5x7 == 0)
                    {
                        _4x4 = 1;
                        _5x7 = 11;
                    }
                    ranout2 = random.Next(1, 100);
                    if (ranout2 <= 34 && _1x7 == 0)
                    {
                        _2x4 = 1;
                        _1x7 = 11;
                    }
                    if (ranout2 <= 34 && ranout2 >= 66 && _3x5 == 0)
                    {
                        _3x6 = 1;
                        _3x5 = 11;
                    }
                    if (ranout2 <= 66 && ranout2 >= 100 && _5x7 == 0)
                    {
                        _4x4 = 1;
                        _5x7 = 11;
                    }
                    _3x8 = 1;
                    _3x9 = 1;
                }
                if (ranout >= 75)
                {
                    if (ranout2 <= 34 && _1x7 == 0)
                    {
                        _2x4 = 1;
                        _1x7 = 11;
                    }
                    if (ranout2 <= 34 && ranout2 >= 66 && _3x5 == 0)
                    {
                        _3x6 = 1;
                        _3x5 = 11;
                    }
                    if (ranout2 <= 66 && ranout2 >= 100 && _3x9 == 0)
                    {
                        _3x8 = 1;
                        _3x9 = 11;
                    }
                    ranout2 = random.Next(1, 100);
                    if (ranout2 <= 34 && _1x7 == 0)
                    {
                        _2x4 = 1;
                        _1x7 = 11;
                    }
                    if (ranout2 <= 34 && ranout2 >= 66 && _3x5 == 0)
                    {
                        _3x6 = 1;
                        _3x5 = 11;
                    }
                    if (ranout2 <= 66 && ranout2 >= 100 && _3x9 == 0)
                    {
                        _3x8 = 1;
                        _3x9 = 11;
                    }
                    _4x4 = 1;
                    _5x7 = 1;
                }
                if (_3x7 == 1)
                {
                    _3x7 = 11;
                }
                cellcount++;
            }

            if (_3x9 == 10 || _3x9 == 1)
            {
                if (ranout4 <= cellcount)
                {
                    bosscell = 14;
                    break;
                }
                Random random = new Random();
                int ranout = random.Next(1, 100);
                int ranout2 = random.Next(1, 100);
                if (ranout <= 25)
                {
                    if (ranout2 <= 34 && _5x9 == 0)
                    {
                        _4x5 = 1;
                        _5x9 = 11;
                    }
                    if (ranout2 <= 34 && ranout2 >= 66 && _3x7 == 0)
                    {
                        _3x8 = 1;
                        _3x7 = 11;
                    }
                    if (ranout2 <= 66 && ranout2 >= 100 && _3x11 == 0)
                    {
                        _3x10 = 1;
                        _3x11 = 11;
                    }
                    ranout2 = random.Next(1, 100);
                    if (ranout2 <= 34 && _5x9 == 0)
                    {
                        _4x5 = 1;
                        _5x9 = 11;
                    }
                    if (ranout2 <= 34 && ranout2 >= 66 && _3x7 == 0)
                    {
                        _3x8 = 1;
                        _3x7 = 11;
                    }
                    if (ranout2 <= 66 && ranout2 >= 100 && _3x11 == 0)
                    {
                        _3x10 = 1;
                        _3x11 = 11;
                    }
                    _2x5 = 1;
                    _1x9 = 1;
                }
                if (ranout >= 25 && ranout <= 50)
                {
                    if (ranout2 <= 34 && _1x9 == 0)
                    {
                        _2x5 = 1;
                        _1x9 = 11;
                    }
                    if (ranout2 <= 34 && ranout2 >= 66 && _5x9 == 0)
                    {
                        _4x5 = 1;
                        _5x9 = 11;
                    }
                    if (ranout2 <= 66 && ranout2 >= 100 && _3x11 == 0)
                    {
                        _3x10 = 1;
                        _3x11 = 11;
                    }
                    ranout2 = random.Next(1, 100);
                    if (ranout2 <= 34 && _1x9 == 0)
                    {
                        _2x5 = 1;
                        _1x9 = 11;
                    }
                    if (ranout2 <= 34 && ranout2 >= 66 && _5x9 == 0)
                    {
                        _4x5 = 1;
                        _5x9 = 11;
                    }
                    if (ranout2 <= 66 && ranout2 >= 100 && _3x11 == 0)
                    {
                        _3x10 = 1;
                        _3x11 = 11;
                    }
                    _3x8 = 1;
                    _3x7 = 1;
                }
                if (ranout >= 50 && ranout <= 75)
                {
                    if (ranout2 <= 34 && _1x9 == 0)
                    {
                        _2x5 = 1;
                        _1x9 = 11;
                    }
                    if (ranout2 <= 34 && ranout2 >= 66 && _3x7 == 0)
                    {
                        _3x8 = 1;
                        _3x7 = 11;
                    }
                    if (ranout2 <= 66 && ranout2 >= 100 && _5x9 == 0)
                    {
                        _4x5 = 1;
                        _5x9 = 11;
                    }
                    ranout2 = random.Next(1, 100);
                    if (ranout2 <= 34 && _1x9 == 0)
                    {
                        _2x5 = 1;
                        _1x9 = 11;
                    }
                    if (ranout2 <= 34 && ranout2 >= 66 && _3x7 == 0)
                    {
                        _3x8 = 1;
                        _3x7 = 11;
                    }
                    if (ranout2 <= 66 && ranout2 >= 100 && _5x9 == 0)
                    {
                        _4x5 = 1;
                        _5x9 = 11;
                    }
                    _3x10 = 1;
                    _3x11 = 1;
                }
                if (ranout >= 75)
                {
                    if (ranout2 <= 34 && _1x9 == 0)
                    {
                        _2x5 = 1;
                        _1x9 = 11;
                    }
                    if (ranout2 <= 34 && ranout2 >= 66 && _3x7 == 0)
                    {
                        _3x8 = 1;
                        _3x7 = 11;
                    }
                    if (ranout2 <= 66 && ranout2 >= 100 && _3x11 == 0)
                    {
                        _3x10 = 1;
                        _3x11 = 11;
                    }
                    ranout2 = random.Next(1, 100);
                    if (ranout2 <= 34 && _1x9 == 0)
                    {
                        _2x5 = 1;
                        _1x9 = 11;
                    }
                    if (ranout2 <= 34 && ranout2 >= 66 && _3x7 == 0)
                    {
                        _3x8 = 1;
                        _3x7 = 11;
                    }
                    if (ranout2 <= 66 && ranout2 >= 100 && _3x11 == 0)
                    {
                        _3x10 = 1;
                        _3x11 = 11;
                    }
                    _4x5 = 1;
                    _5x9 = 1;
                }
                if (_3x9 == 1)
                {
                    _3x9 = 11;
                }
                cellcount++;
            }

            if (_3x11 == 10 || _3x11 == 1)
            {
                if (ranout4 <= cellcount)
                {
                    bosscell = 15;
                    break;
                }
                Random random = new Random();
                int ranout = random.Next(1, 100);
                int ranout2 = random.Next(1, 100);
                if (ranout <= 25)
                {
                    if (ranout2 <= 34 && _5x11 == 0)
                    {
                        _4x6 = 1;
                        _5x11 = 11;
                    }
                    if (ranout2 <= 34 && ranout2 >= 66 && _3x9 == 0)
                    {
                        _3x10 = 1;
                        _3x9 = 11;
                    }
                    if (ranout2 <= 66 && ranout2 >= 100 && _3x13 == 0)
                    {
                        _3x12 = 1;
                        _3x13 = 11;
                    }
                    ranout2 = random.Next(1, 100);
                    if (ranout2 <= 34 && _5x11 == 0)
                    {
                        _4x6 = 1;
                        _5x11 = 11;
                    }
                    if (ranout2 <= 34 && ranout2 >= 66 && _3x9 == 0)
                    {
                        _3x10 = 1;
                        _3x9 = 11;
                    }
                    if (ranout2 <= 66 && ranout2 >= 100 && _3x13 == 0)
                    {
                        _3x12 = 1;
                        _3x13 = 11;
                    }
                    _2x6 = 1;
                    _1x11 = 1;
                }
                if (ranout >= 25 && ranout <= 50)
                {
                    if (ranout2 <= 34 && _1x11 == 0)
                    {
                        _2x6 = 1;
                        _1x11 = 11;
                    }
                    if (ranout2 <= 34 && ranout2 >= 66 && _5x11 == 0)
                    {
                        _4x6 = 1;
                        _5x11 = 11;
                    }
                    if (ranout2 <= 66 && ranout2 >= 100 && _3x13 == 0)
                    {
                        _3x12 = 1;
                        _3x13 = 11;
                    }
                    ranout2 = random.Next(1, 100);
                    if (ranout2 <= 34 && _1x11 == 0)
                    {
                        _2x6 = 1;
                        _1x11 = 11;
                    }
                    if (ranout2 <= 34 && ranout2 >= 66 && _5x11 == 0)
                    {
                        _4x6 = 1;
                        _5x11 = 11;
                    }
                    if (ranout2 <= 66 && ranout2 >= 100 && _3x13 == 0)
                    {
                        _3x12 = 1;
                        _3x13 = 11;
                    }
                    _3x10 = 1;
                    _3x9 = 1;
                }
                if (ranout >= 50 && ranout <= 75)
                {
                    if (ranout2 <= 34 && _1x11 == 0)
                    {
                        _2x6 = 1;
                        _1x11 = 11;
                    }
                    if (ranout2 <= 34 && ranout2 >= 66 && _3x9 == 0)
                    {
                        _3x10 = 1;
                        _3x9 = 11;
                    }
                    if (ranout2 <= 66 && ranout2 >= 100 && _5x11 == 0)
                    {
                        _4x6 = 1;
                        _5x11 = 11;
                    }
                    ranout2 = random.Next(1, 100);
                    if (ranout2 <= 34 && _1x11 == 0)
                    {
                        _2x6 = 1;
                        _1x11 = 11;
                    }
                    if (ranout2 <= 34 && ranout2 >= 66 && _3x9 == 0)
                    {
                        _3x10 = 1;
                        _3x9 = 11;
                    }
                    if (ranout2 <= 66 && ranout2 >= 100 && _5x11 == 0)
                    {
                        _4x6 = 1;
                        _5x11 = 11;
                    }
                    _3x12 = 1;
                    _3x13 = 1;
                }
                if (ranout >= 75)
                {
                    if (ranout2 <= 34 && _1x11 == 0)
                    {
                        _2x6 = 1;
                        _1x11 = 11;
                    }
                    if (ranout2 <= 34 && ranout2 >= 66 && _3x9 == 0)
                    {
                        _3x10 = 1;
                        _3x9 = 11;
                    }
                    if (ranout2 <= 66 && ranout2 >= 100 && _3x13 == 0)
                    {
                        _3x12 = 1;
                        _3x13 = 11;
                    }
                    ranout2 = random.Next(1, 100);
                    if (ranout2 <= 34 && _1x11 == 0)
                    {
                        _2x6 = 1;
                        _1x11 = 11;
                    }
                    if (ranout2 <= 34 && ranout2 >= 66 && _3x9 == 0)
                    {
                        _3x10 = 1;
                        _3x9 = 11;
                    }
                    if (ranout2 <= 66 && ranout2 >= 100 && _3x13 == 0)
                    {
                        _3x12 = 1;
                        _3x13 = 11;
                    }
                    _4x6 = 1;
                    _5x11 = 1;
                }
                if (_3x11 == 1)
                {
                    _3x11 = 11;
                }
                cellcount++;
            }

            if (_3x13 == 10 || _3x13 == 1)
            {
                if (ranout4 <= cellcount)
                {
                    bosscell = 16;
                    break;
                }
                Random random = new Random();
                int ranout = random.Next(1, 100);
                int ranout2 = random.Next(1, 100);
                if (ranout <= 25)
                {
                    if (ranout2 <= 34 && _5x13 == 0)
                    {
                        _4x7 = 1;
                        _5x13 = 11;
                    }
                    if (ranout2 <= 34 && ranout2 >= 66 && _3x11 == 0)
                    {
                        _3x12 = 1;
                        _3x11 = 11;
                    }
                    if (ranout2 <= 66 && ranout2 >= 100 && _3x15 == 0)
                    {
                        _3x14 = 1;
                        _3x15 = 11;
                    }
                    ranout2 = random.Next(1, 100);
                    if (ranout2 <= 34 && _5x13 == 0)
                    {
                        _4x7 = 1;
                        _5x13 = 11;
                    }
                    if (ranout2 <= 34 && ranout2 >= 66 && _3x11 == 0)
                    {
                        _3x12 = 1;
                        _3x11 = 11;
                    }
                    if (ranout2 <= 66 && ranout2 >= 100 && _3x15 == 0)
                    {
                        _3x14 = 1;
                        _3x15 = 11;
                    }
                    _2x7 = 1;
                    _1x13 = 1;
                }
                if (ranout >= 25 && ranout <= 50)
                {
                    if (ranout2 <= 34 && _1x13 == 0)
                    {
                        _2x7 = 1;
                        _1x13 = 11;
                    }
                    if (ranout2 <= 34 && ranout2 >= 66 && _5x13 == 0)
                    {
                        _4x7 = 1;
                        _5x13 = 11;
                    }
                    if (ranout2 <= 66 && ranout2 >= 100 && _3x15 == 0)
                    {
                        _3x14 = 1;
                        _3x15 = 11;
                    }
                    ranout2 = random.Next(1, 100);
                    if (ranout2 <= 34 && _1x13 == 0)
                    {
                        _2x7 = 1;
                        _1x13 = 11;
                    }
                    if (ranout2 <= 34 && ranout2 >= 66 && _5x13 == 0)
                    {
                        _4x7 = 1;
                        _5x13 = 11;
                    }
                    if (ranout2 <= 66 && ranout2 >= 100 && _3x15 == 0)
                    {
                        _3x14 = 1;
                        _3x15 = 11;
                    }
                    _3x12 = 1;
                    _3x11 = 1;
                }
                if (ranout >= 50 && ranout <= 75)
                {
                    if (ranout2 <= 34 && _1x13 == 0)
                    {
                        _2x7 = 1;
                        _1x13 = 11;
                    }
                    if (ranout2 <= 34 && ranout2 >= 66 && _3x11 == 0)
                    {
                        _3x12 = 1;
                        _3x11 = 11;
                    }
                    if (ranout2 <= 66 && ranout2 >= 100 && _5x13 == 0)
                    {
                        _4x7 = 1;
                        _5x13 = 11;
                    }
                    ranout2 = random.Next(1, 100);
                    if (ranout2 <= 34 && _1x13 == 0)
                    {
                        _2x7 = 1;
                        _1x13 = 11;
                    }
                    if (ranout2 <= 34 && ranout2 >= 66 && _3x11 == 0)
                    {
                        _3x12 = 1;
                        _3x11 = 11;
                    }
                    if (ranout2 <= 66 && ranout2 >= 100 && _5x13 == 0)
                    {
                        _4x7 = 1;
                        _5x13 = 11;
                    }
                    _3x14 = 1;
                    _3x15 = 1;
                }
                if (ranout >= 75)
                {
                    if (ranout2 <= 34 && _1x13 == 0)
                    {
                        _2x7 = 1;
                        _1x13 = 11;
                    }
                    if (ranout2 <= 34 && ranout2 >= 66 && _3x11 == 0)
                    {
                        _3x12 = 1;
                        _3x11 = 11;
                    }
                    if (ranout2 <= 66 && ranout2 >= 100 && _3x15 == 0)
                    {
                        _3x14 = 1;
                        _3x15 = 11;
                    }
                    ranout2 = random.Next(1, 100);
                    if (ranout2 <= 34 && _1x13 == 0)
                    {
                        _2x7 = 1;
                        _1x13 = 11;
                    }
                    if (ranout2 <= 34 && ranout2 >= 66 && _3x11 == 0)
                    {
                        _3x12 = 1;
                        _3x11 = 11;
                    }
                    if (ranout2 <= 66 && ranout2 >= 100 && _3x15 == 0)
                    {
                        _3x14 = 1;
                        _3x15 = 11;
                    }
                    _4x7 = 1;
                    _5x13 = 1;
                }
                if (_3x13 == 1)
                {
                    _3x13 = 11;
                }
                cellcount++;
            }

            if (_3x15 == 10 || _3x15 == 1)
            {
                if (ranout4 <= cellcount)
                {
                    bosscell = 17;
                    break;
                }
                Random random = new Random();
                int ranout = random.Next(1, 100);
                int ranout2 = random.Next(1, 100);
                if (ranout <= 25)
                {
                    if (ranout2 <= 34 && _5x15 == 0)
                    {
                        _4x8 = 1;
                        _5x15 = 11;
                    }
                    if (ranout2 <= 34 && ranout2 >= 66 && _3x13 == 0)
                    {
                        _3x14 = 1;
                        _3x13 = 11;
                    }
                    if (ranout2 <= 66 && ranout2 >= 100 && _3x17 == 0)
                    {
                        _3x16 = 1;
                        _3x17 = 11;
                    }
                    ranout2 = random.Next(1, 100);
                    if (ranout2 <= 34 && _5x15 == 0)
                    {
                        _4x8 = 1;
                        _5x15 = 11;
                    }
                    if (ranout2 <= 34 && ranout2 >= 66 && _3x13 == 0)
                    {
                        _3x14 = 1;
                        _3x13 = 11;
                    }
                    if (ranout2 <= 66 && ranout2 >= 100 && _3x17 == 0)
                    {
                        _3x16 = 1;
                        _3x17 = 11;
                    }
                    _2x8 = 1;
                    _1x15 = 1;
                }
                if (ranout >= 25 && ranout <= 50)
                {
                    if (ranout2 <= 34 && _1x15 == 0)
                    {
                        _2x8 = 1;
                        _1x15 = 11;
                    }
                    if (ranout2 <= 34 && ranout2 >= 66 && _5x15 == 0)
                    {
                        _4x8 = 1;
                        _5x15 = 11;
                    }
                    if (ranout2 <= 66 && ranout2 >= 100 && _3x17 == 0)
                    {
                        _3x16 = 1;
                        _3x17 = 11;
                    }
                    ranout2 = random.Next(1, 100);
                    if (ranout2 <= 34 && _1x15 == 0)
                    {
                        _2x8 = 1;
                        _1x15 = 11;
                    }
                    if (ranout2 <= 34 && ranout2 >= 66 && _5x15 == 0)
                    {
                        _4x8 = 1;
                        _5x15 = 11;
                    }
                    if (ranout2 <= 66 && ranout2 >= 100 && _3x17 == 0)
                    {
                        _3x16 = 1;
                        _3x17 = 11;
                    }
                    _3x14 = 1;
                    _3x13 = 1;
                }
                if (ranout >= 50 && ranout <= 75)
                {
                    if (ranout2 <= 34 && _1x15 == 0)
                    {
                        _2x8 = 1;
                        _1x15 = 11;
                    }
                    if (ranout2 <= 34 && ranout2 >= 66 && _3x13 == 0)
                    {
                        _3x14 = 1;
                        _3x13 = 11;
                    }
                    if (ranout2 <= 66 && ranout2 >= 100 && _5x15 == 0)
                    {
                        _4x8 = 1;
                        _5x15 = 11;
                    }
                    ranout2 = random.Next(1, 100);
                    if (ranout2 <= 34 && _1x15 == 0)
                    {
                        _2x8 = 1;
                        _1x15 = 11;
                    }
                    if (ranout2 <= 34 && ranout2 >= 66 && _3x13 == 0)
                    {
                        _3x14 = 1;
                        _3x13 = 11;
                    }
                    if (ranout2 <= 66 && ranout2 >= 100 && _5x15 == 0)
                    {
                        _4x8 = 1;
                        _5x15 = 11;
                    }
                    _3x16 = 1;
                    _3x17 = 1;
                }
                if (ranout >= 75)
                {
                    if (ranout2 <= 34 && _1x15 == 0)
                    {
                        _2x8 = 1;
                        _1x15 = 11;
                    }
                    if (ranout2 <= 34 && ranout2 >= 66 && _3x13 == 0)
                    {
                        _3x14 = 1;
                        _3x13 = 11;
                    }
                    if (ranout2 <= 66 && ranout2 >= 100 && _3x17 == 0)
                    {
                        _3x16 = 1;
                        _3x17 = 11;
                    }
                    ranout2 = random.Next(1, 100);
                    if (ranout2 <= 34 && _1x15 == 0)
                    {
                        _2x8 = 1;
                        _1x15 = 11;
                    }
                    if (ranout2 <= 34 && ranout2 >= 66 && _3x13 == 0)
                    {
                        _3x14 = 1;
                        _3x13 = 11;
                    }
                    if (ranout2 <= 66 && ranout2 >= 100 && _3x17 == 0)
                    {
                        _3x16 = 1;
                        _3x17 = 11;
                    }
                    _4x8 = 1;
                    _5x15 = 1;
                }
                if (_3x15 == 1)
                {
                    _3x15 = 11;
                }
                cellcount++;
            }

            if (_3x17 == 10 || _3x17 == 1)
            {
                if (ranout4 <= cellcount)
                {
                    bosscell = 18;
                    break;
                }
                Random random = new Random();
                int ranout = random.Next(1, 100);
                int ranout2 = random.Next(1, 100);
                if (ranout <= 34)
                {
                    if (ranout2 <= 50 && _5x17 == 0)
                    {
                        _4x9 = 1;
                        _5x17 = 11;
                    }
                    if (ranout2 >= 50 && _3x15 == 0)
                    {
                        _3x16 = 1;
                        _3x15 = 11;
                    }
                    ranout2 = random.Next(1, 100);
                    if (ranout2 <= 50 && _5x17 == 0)
                    {
                        _4x9 = 1;
                        _5x17 = 11;
                    }
                    if (ranout2 >= 50 && _3x15 == 0)
                    {
                        _3x16 = 1;
                        _3x15 = 11;
                    }
                    _2x9 = 1;
                    _1x17 = 1;
                }
                if (ranout >= 34 && ranout <= 66)
                {
                    if (ranout2 <= 34 && _1x17 == 0)
                    {
                        _2x9 = 1;
                        _1x17 = 11;
                    }
                    if (ranout2 <= 34 && ranout2 >= 66 && _5x17 == 0)
                    {
                        _4x9 = 1;
                        _5x17 = 11;
                    }
                    ranout2 = random.Next(1, 100);
                    if (ranout2 <= 50 && _1x17 == 0)
                    {
                        _2x9 = 1;
                        _1x17 = 11;
                    }
                    if (ranout2 >= 50 && _5x17 == 0)
                    {
                        _4x9 = 1;
                        _5x17 = 11;
                    }
                    _3x16 = 1;
                    _3x15 = 1;
                }
                if (ranout >= 66)
                {
                    if (ranout2 <= 50 && _1x17 == 0)
                    {
                        _2x9 = 1;
                        _1x17 = 11;
                    }
                    if (ranout2 >= 50 && _3x15 == 0)
                    {
                        _3x16 = 1;
                        _3x15 = 11;
                    }
                    ranout2 = random.Next(1, 100);
                    if (ranout2 <= 50 && _1x17 == 0)
                    {
                        _2x9 = 1;
                        _1x17 = 11;
                    }
                    if (ranout2 >= 650 && _3x15 == 0)
                    {
                        _3x16 = 1;
                        _3x15 = 11;
                    }
                    _4x9 = 1;
                    _5x17 = 1;
                }
                if (_3x17 == 1)
                {
                    _3x17 = 11;
                }
                cellcount++;
            }

            if (_5x1 == 10 || _5x1 == 1)
            {
                if (ranout4 <= cellcount)
                {
                    bosscell = 19;
                    break;
                }
                Random random = new Random();
                int ranout = random.Next(1, 100);
                int ranout2 = random.Next(1, 100);
                if (ranout <= 34)
                {
                    if (ranout2 <= 50 && _7x1 == 0)
                    {
                        _6x1 = 1;
                        _7x1 = 11;
                    }
                    if (ranout2 >= 50 && _5x3 == 0)
                    {
                        _5x2 = 1;
                        _5x3 = 11;
                    }
                    ranout2 = random.Next(1, 100);
                    if (ranout2 <= 50 && _7x1 == 0)
                    {
                        _6x1 = 1;
                        _7x1 = 11;
                    }
                    if (ranout2 >= 50 && _5x3 == 0)
                    {
                        _5x2 = 1;
                        _5x3 = 11;
                    }
                    _4x1 = 1;
                    _3x1 = 1;
                }
                if (ranout >= 34 && ranout <= 66)
                {
                    if (ranout2 <= 50 && _3x1 == 0)
                    {
                        _4x1 = 1;
                        _3x1 = 11;
                    }
                    if (ranout2 >= 50 && _7x1 == 0)
                    {
                        _6x1 = 1;
                        _7x1 = 11;
                    }
                    ranout2 = random.Next(1, 100);
                    if (ranout2 <= 50 && _3x1 == 0)
                    {
                        _4x1 = 1;
                        _3x1 = 11;
                    }
                    if (ranout2 >= 50 && _7x1 == 0)
                    {
                        _6x1 = 1;
                        _7x1 = 11;
                    }
                    _5x2 = 1;
                    _5x3 = 1;
                }
                if (ranout >= 66)
                {
                    if (ranout2 <= 50 && _3x1 == 0)
                    {
                        _4x1 = 1;
                        _3x1 = 11;
                    }
                    if (ranout2 >= 50 && _5x3 == 0)
                    {
                        _5x2 = 1;
                        _5x3 = 11;
                    }
                    ranout2 = random.Next(1, 100);
                    if (ranout2 <= 50 && _3x1 == 0)
                    {
                        _4x1 = 1;
                        _3x1 = 11;
                    }
                    if (ranout2 >= 50 && _5x3 == 0)
                    {
                        _5x2 = 1;
                        _5x3 = 11;
                    }
                    _6x1 = 1;
                    _7x1 = 1;
                }
                if (_5x1 == 1)
                {
                    _5x1 = 11;
                }
                cellcount++;
            }

            if (_5x3 == 10 || _5x3 == 1)
            {
                if (ranout4 <= cellcount)
                {
                    bosscell = 20;
                    break;
                }
                Random random = new Random();
                int ranout = random.Next(1, 100);
                int ranout2 = random.Next(1, 100);
                if (ranout <= 25)
                {
                    if (ranout2 <= 34 && _7x3 == 0)
                    {
                        _6x2 = 1;
                        _7x3 = 11;
                    }
                    if (ranout2 <= 34 && ranout2 >= 66 && _5x1 == 0)
                    {
                        _5x2 = 1;
                        _5x1 = 11;
                    }
                    if (ranout2 <= 66 && ranout2 >= 100 && _5x5 == 0)
                    {
                        _5x4 = 1;
                        _5x5 = 11;
                    }
                    ranout2 = random.Next(1, 100);
                    if (ranout2 <= 34 && _7x3 == 0)
                    {
                        _6x2 = 1;
                        _7x3 = 11;
                    }
                    if (ranout2 <= 34 && ranout2 >= 66 && _5x1 == 0)
                    {
                        _5x2 = 1;
                        _5x1 = 11;
                    }
                    if (ranout2 <= 66 && ranout2 >= 100 && _5x5 == 0)
                    {
                        _5x4 = 1;
                        _5x5 = 11;
                    }
                    _4x2 = 1;
                    _3x3 = 1;
                }
                if (ranout >= 25 && ranout <= 50)
                {
                    if (ranout2 <= 34 && _3x3 == 0)
                    {
                        _4x2 = 1;
                        _3x3 = 11;
                    }
                    if (ranout2 <= 34 && ranout2 >= 66 && _7x3 == 0)
                    {
                        _6x2 = 1;
                        _7x3 = 11;
                    }
                    if (ranout2 <= 66 && ranout2 >= 100 && _5x5 == 0)
                    {
                        _5x4 = 1;
                        _5x5 = 11;
                    }
                    ranout2 = random.Next(1, 100);
                    if (ranout2 <= 34 && _3x3 == 0)
                    {
                        _4x2 = 1;
                        _3x3 = 11;
                    }
                    if (ranout2 <= 34 && ranout2 >= 66 && _7x3 == 0)
                    {
                        _6x2 = 1;
                        _7x3 = 11;
                    }
                    if (ranout2 <= 66 && ranout2 >= 100 && _5x5 == 0)
                    {
                        _5x4 = 1;
                        _5x5 = 11;
                    }
                    _5x2 = 1;
                    _5x1 = 1;
                }
                if (ranout >= 50 && ranout <= 75)
                {
                    if (ranout2 <= 34 && _3x3 == 0)
                    {
                        _4x2 = 1;
                        _3x3 = 11;
                    }
                    if (ranout2 <= 34 && ranout2 >= 66 && _5x1 == 0)
                    {
                        _5x2 = 1;
                        _5x1 = 11;
                    }
                    if (ranout2 <= 66 && ranout2 >= 100 && _7x3 == 0)
                    {
                        _6x2 = 1;
                        _7x3 = 11;
                    }
                    ranout2 = random.Next(1, 100);
                    if (ranout2 <= 34 && _3x3 == 0)
                    {
                        _4x2 = 1;
                        _3x3 = 11;
                    }
                    if (ranout2 <= 34 && ranout2 >= 66 && _5x1 == 0)
                    {
                        _5x2 = 1;
                        _5x1 = 11;
                    }
                    if (ranout2 <= 66 && ranout2 >= 100 && _7x3 == 0)
                    {
                        _6x2 = 1;
                        _7x3 = 11;
                    }
                    _5x4 = 1;
                    _5x5 = 1;
                }
                if (ranout >= 75)
                {
                    if (ranout2 <= 34 && _3x3 == 0)
                    {
                        _4x2 = 1;
                        _3x3 = 11;
                    }
                    if (ranout2 <= 34 && ranout2 >= 66 && _5x1 == 0)
                    {
                        _5x2 = 1;
                        _5x1 = 11;
                    }
                    if (ranout2 <= 66 && ranout2 >= 100 && _5x5 == 0)
                    {
                        _5x4 = 1;
                        _5x5 = 11;
                    }
                    ranout2 = random.Next(1, 100);
                    if (ranout2 <= 34 && _3x3 == 0)
                    {
                        _4x2 = 1;
                        _3x3 = 11;
                    }
                    if (ranout2 <= 34 && ranout2 >= 66 && _5x1 == 0)
                    {
                        _5x2 = 1;
                        _5x1 = 11;
                    }
                    if (ranout2 <= 66 && ranout2 >= 100 && _5x5 == 0)
                    {
                        _5x4 = 1;
                        _5x5 = 11;
                    }
                    _6x2 = 1;
                    _7x3 = 1;
                }
                if (_5x3 == 1)
                {
                    _5x3 = 11;
                }
                cellcount++;
            }

            if (_5x5 == 10 || _5x5 == 1)
            {
                if (ranout4 <= cellcount)
                {
                    bosscell = 21;
                    break;
                }
                Random random = new Random();
                int ranout = random.Next(1, 100);
                int ranout2 = random.Next(1, 100);
                if (ranout <= 25)
                {
                    if (ranout2 <= 34 && _7x5 == 0)
                    {
                        _6x3 = 1;
                        _7x5 = 11;
                    }
                    if (ranout2 <= 34 && ranout2 >= 66 && _5x3 == 0)
                    {
                        _5x4 = 1;
                        _5x3 = 11;
                    }
                    if (ranout2 <= 66 && ranout2 >= 100 && _5x7 == 0)
                    {
                        _5x6 = 1;
                        _5x7 = 11;
                    }
                    ranout2 = random.Next(1, 100);
                    if (ranout2 <= 34 && _7x5 == 0)
                    {
                        _6x3 = 1;
                        _7x5 = 11;
                    }
                    if (ranout2 <= 34 && ranout2 >= 66 && _5x3 == 0)
                    {
                        _5x4 = 1;
                        _5x3 = 11;
                    }
                    if (ranout2 <= 66 && ranout2 >= 100 && _5x7 == 0)
                    {
                        _5x6 = 1;
                        _5x7 = 11;
                    }
                    _4x3 = 1;
                    _3x5 = 1;
                }
                if (ranout >= 25 && ranout <= 50)
                {
                    if (ranout2 <= 34 && _3x5 == 0)
                    {
                        _4x3 = 1;
                        _3x5 = 11;
                    }
                    if (ranout2 <= 34 && ranout2 >= 66 && _7x5 == 0)
                    {
                        _6x3 = 1;
                        _7x5 = 11;
                    }
                    if (ranout2 <= 66 && ranout2 >= 100 && _5x7 == 0)
                    {
                        _5x6 = 1;
                        _5x7 = 11;
                    }
                    ranout2 = random.Next(1, 100);
                    if (ranout2 <= 34 && _3x5 == 0)
                    {
                        _4x3 = 1;
                        _3x5 = 11;
                    }
                    if (ranout2 <= 34 && ranout2 >= 66 && _7x5 == 0)
                    {
                        _6x3 = 1;
                        _7x5 = 11;
                    }
                    if (ranout2 <= 66 && ranout2 >= 100 && _5x7 == 0)
                    {
                        _5x6 = 1;
                        _5x7 = 11;
                    }
                    _5x4 = 1;
                    _5x3 = 1;
                }
                if (ranout >= 50 && ranout <= 75)
                {
                    if (ranout2 <= 34 && _3x5 == 0)
                    {
                        _4x3 = 1;
                        _3x5 = 11;
                    }
                    if (ranout2 <= 34 && ranout2 >= 66 && _5x3 == 0)
                    {
                        _5x4 = 1;
                        _5x3 = 11;
                    }
                    if (ranout2 <= 66 && ranout2 >= 100 && _7x5 == 0)
                    {
                        _6x3 = 1;
                        _7x5 = 11;
                    }
                    ranout2 = random.Next(1, 100);
                    if (ranout2 <= 34 && _3x5 == 0)
                    {
                        _4x3 = 1;
                        _3x5 = 11;
                    }
                    if (ranout2 <= 34 && ranout2 >= 66 && _5x3 == 0)
                    {
                        _5x4 = 1;
                        _5x3 = 11;
                    }
                    if (ranout2 <= 66 && ranout2 >= 100 && _7x5 == 0)
                    {
                        _6x3 = 1;
                        _7x5 = 11;
                    }
                    _5x6 = 1;
                    _5x7 = 1;
                }
                if (ranout >= 75)
                {
                    if (ranout2 <= 34 && _3x5 == 0)
                    {
                        _4x3 = 1;
                        _3x5 = 11;
                    }
                    if (ranout2 <= 34 && ranout2 >= 66 && _5x3 == 0)
                    {
                        _5x4 = 1;
                        _5x3 = 11;
                    }
                    if (ranout2 <= 66 && ranout2 >= 100 && _5x7 == 0)
                    {
                        _5x6 = 1;
                        _5x7 = 11;
                    }
                    ranout2 = random.Next(1, 100);
                    if (ranout2 <= 34 && _3x5 == 0)
                    {
                        _4x3 = 1;
                        _3x5 = 11;
                    }
                    if (ranout2 <= 34 && ranout2 >= 66 && _5x3 == 0)
                    {
                        _5x4 = 1;
                        _5x3 = 11;
                    }
                    if (ranout2 <= 66 && ranout2 >= 100 && _5x7 == 0)
                    {
                        _5x6 = 1;
                        _5x7 = 11;
                    }
                    _6x3 = 1;
                    _7x5 = 1;
                }
                if (_5x5 == 1)
                {
                    _5x5 = 11;
                }
                cellcount++;
            }

            if (_5x7 == 10 || _5x7 == 1)
            {
                if (ranout4 <= cellcount)
                {
                    bosscell = 22;
                    break;
                }
                Random random = new Random();
                int ranout = random.Next(1, 100);
                int ranout2 = random.Next(1, 100);
                if (ranout <= 25)
                {
                    if (ranout2 <= 34 && _7x7 == 0)
                    {
                        _6x4 = 1;
                        _7x7 = 11;
                    }
                    if (ranout2 <= 34 && ranout2 >= 66 && _5x5 == 0)
                    {
                        _5x6 = 1;
                        _5x5 = 11;
                    }
                    if (ranout2 <= 66 && ranout2 >= 100 && _5x9 == 0)
                    {
                        _5x8 = 1;
                        _5x9 = 11;
                    }
                    ranout2 = random.Next(1, 100);
                    if (ranout2 <= 34 && _7x7 == 0)
                    {
                        _6x4 = 1;
                        _7x7 = 11;
                    }
                    if (ranout2 <= 34 && ranout2 >= 66 && _5x5 == 0)
                    {
                        _5x6 = 1;
                        _5x5 = 11;
                    }
                    if (ranout2 <= 66 && ranout2 >= 100 && _5x9 == 0)
                    {
                        _5x8 = 1;
                        _5x9 = 11;
                    }
                    _4x4 = 1;
                    _3x7 = 1;
                }
                if (ranout >= 25 && ranout <= 50)
                {
                    if (ranout2 <= 34 && _3x7 == 0)
                    {
                        _4x4 = 1;
                        _3x7 = 11;
                    }
                    if (ranout2 <= 34 && ranout2 >= 66 && _7x7 == 0)
                    {
                        _6x4 = 1;
                        _7x7 = 11;
                    }
                    if (ranout2 <= 66 && ranout2 >= 100 && _5x9 == 0)
                    {
                        _5x8 = 1;
                        _5x9 = 11;
                    }
                    ranout2 = random.Next(1, 100);
                    if (ranout2 <= 34 && _3x7 == 0)
                    {
                        _4x4 = 1;
                        _3x7 = 11;
                    }
                    if (ranout2 <= 34 && ranout2 >= 66 && _7x7 == 0)
                    {
                        _6x4 = 1;
                        _7x7 = 11;
                    }
                    if (ranout2 <= 66 && ranout2 >= 100 && _5x9 == 0)
                    {
                        _5x8 = 1;
                        _5x9 = 11;
                    }
                    _5x6 = 1;
                    _5x5 = 1;
                }
                if (ranout >= 50 && ranout <= 75)
                {
                    if (ranout2 <= 34 && _3x7 == 0)
                    {
                        _4x4 = 1;
                        _3x7 = 11;
                    }
                    if (ranout2 <= 34 && ranout2 >= 66 && _5x5 == 0)
                    {
                        _5x6 = 1;
                        _5x5 = 11;
                    }
                    if (ranout2 <= 66 && ranout2 >= 100 && _7x7 == 0)
                    {
                        _6x4 = 1;
                        _7x7 = 11;
                    }
                    ranout2 = random.Next(1, 100);
                    if (ranout2 <= 34 && _3x7 == 0)
                    {
                        _4x4 = 1;
                        _3x7 = 11;
                    }
                    if (ranout2 <= 34 && ranout2 >= 66 && _5x5 == 0)
                    {
                        _5x6 = 1;
                        _5x5 = 11;
                    }
                    if (ranout2 <= 66 && ranout2 >= 100 && _7x7 == 0)
                    {
                        _6x4 = 1;
                        _7x7 = 11;
                    }
                    _5x8 = 1;
                    _5x9 = 1;
                }
                if (ranout >= 75)
                {
                    if (ranout2 <= 34 && _3x7 == 0)
                    {
                        _4x4 = 1;
                        _3x7 = 11;
                    }
                    if (ranout2 <= 34 && ranout2 >= 66 && _5x5 == 0)
                    {
                        _5x6 = 1;
                        _5x5 = 11;
                    }
                    if (ranout2 <= 66 && ranout2 >= 100 && _5x9 == 0)
                    {
                        _5x8 = 1;
                        _5x9 = 11;
                    }
                    ranout2 = random.Next(1, 100);
                    if (ranout2 <= 34 && _3x7 == 0)
                    {
                        _4x4 = 1;
                        _3x7 = 11;
                    }
                    if (ranout2 <= 34 && ranout2 >= 66 && _5x5 == 0)
                    {
                        _5x6 = 1;
                        _5x5 = 11;
                    }
                    if (ranout2 <= 66 && ranout2 >= 100 && _5x9 == 0)
                    {
                        _5x8 = 1;
                        _5x9 = 11;
                    }
                    _6x4 = 1;
                    _7x7 = 1;
                }
                if (_5x7 == 1)
                {
                    _5x7 = 11;
                }
                cellcount++;
            }

            if (_5x9 == 10 || _5x9 == 1)
            {
                if (ranout4 <= cellcount)
                {
                    bosscell = 23;
                    break;
                }
                Random random = new Random();
                int ranout = random.Next(1, 100);
                int ranout2 = random.Next(1, 100);
                if (ranout <= 25)
                {
                    if (ranout2 <= 34 && _7x9 == 0)
                    {
                        _6x5 = 1;
                        _7x9 = 11;
                    }
                    if (ranout2 <= 34 && ranout2 >= 66 && _5x7 == 0)
                    {
                        _5x8 = 1;
                        _5x7 = 11;
                    }
                    if (ranout2 <= 66 && ranout2 >= 100 && _5x11 == 0)
                    {
                        _5x10 = 1;
                        _5x11 = 11;
                    }
                    ranout2 = random.Next(1, 100);
                    if (ranout2 <= 34 && _7x9 == 0)
                    {
                        _6x5 = 1;
                        _7x9 = 11;
                    }
                    if (ranout2 <= 34 && ranout2 >= 66 && _5x7 == 0)
                    {
                        _5x8 = 1;
                        _5x7 = 11;
                    }
                    if (ranout2 <= 66 && ranout2 >= 100 && _5x11 == 0)
                    {
                        _5x10 = 1;
                        _5x11 = 11;
                    }
                    _4x5 = 1;
                    _3x9 = 1;
                }
                if (ranout >= 25 && ranout <= 50)
                {
                    if (ranout2 <= 34 && _3x9 == 0)
                    {
                        _4x5 = 1;
                        _3x9 = 11;
                    }
                    if (ranout2 <= 34 && ranout2 >= 66 && _7x9 == 0)
                    {
                        _6x5 = 1;
                        _7x9 = 11;
                    }
                    if (ranout2 <= 66 && ranout2 >= 100 && _5x11 == 0)
                    {
                        _5x10 = 1;
                        _5x11 = 11;
                    }
                    ranout2 = random.Next(1, 100);
                    if (ranout2 <= 34 && _3x9 == 0)
                    {
                        _4x5 = 1;
                        _3x9 = 11;
                    }
                    if (ranout2 <= 34 && ranout2 >= 66 && _7x9 == 0)
                    {
                        _6x5 = 1;
                        _7x9 = 11;
                    }
                    if (ranout2 <= 66 && ranout2 >= 100 && _5x11 == 0)
                    {
                        _5x10 = 1;
                        _5x11 = 11;
                    }
                    _5x8 = 1;
                    _5x7 = 1;
                }
                if (ranout >= 50 && ranout <= 75)
                {
                    if (ranout2 <= 34 && _3x9 == 0)
                    {
                        _4x5 = 1;
                        _3x9 = 11;
                    }
                    if (ranout2 <= 34 && ranout2 >= 66 && _5x7 == 0)
                    {
                        _5x8 = 1;
                        _5x7 = 11;
                    }
                    if (ranout2 <= 66 && ranout2 >= 100 && _7x9 == 0)
                    {
                        _6x5 = 1;
                        _7x9 = 11;
                    }
                    ranout2 = random.Next(1, 100);
                    if (ranout2 <= 34 && _3x9 == 0)
                    {
                        _4x5 = 1;
                        _3x9 = 11;
                    }
                    if (ranout2 <= 34 && ranout2 >= 66 && _5x7 == 0)
                    {
                        _5x8 = 1;
                        _5x7 = 11;
                    }
                    if (ranout2 <= 66 && ranout2 >= 100 && _7x9 == 0)
                    {
                        _6x5 = 1;
                        _7x9 = 11;
                    }
                    _5x10 = 1;
                    _5x11 = 1;
                }
                if (ranout >= 75)
                {
                    if (ranout2 <= 34 && _3x9 == 0)
                    {
                        _4x5 = 1;
                        _3x9 = 11;
                    }
                    if (ranout2 <= 34 && ranout2 >= 66 && _5x7 == 0)
                    {
                        _5x8 = 1;
                        _5x7 = 11;
                    }
                    if (ranout2 <= 66 && ranout2 >= 100 && _5x11 == 0)
                    {
                        _5x10 = 1;
                        _5x11 = 11;
                    }
                    ranout2 = random.Next(1, 100);
                    if (ranout2 <= 34 && _3x9 == 0)
                    {
                        _4x5 = 1;
                        _3x9 = 11;
                    }
                    if (ranout2 <= 34 && ranout2 >= 66 && _5x7 == 0)
                    {
                        _5x8 = 1;
                        _5x7 = 11;
                    }
                    if (ranout2 <= 66 && ranout2 >= 100 && _5x11 == 0)
                    {
                        _5x10 = 1;
                        _5x11 = 11;
                    }
                    _6x5 = 1;
                    _7x9 = 1;
                }
                if (_5x9 == 1)
                {
                    _5x9 = 11;
                }
                cellcount++;
            }

            if (_5x11 == 10 || _5x11 == 1)
            {
                if (ranout4 <= cellcount)
                {
                    bosscell = 24;
                    break;
                }
                Random random = new Random();
                int ranout = random.Next(1, 100);
                int ranout2 = random.Next(1, 100);
                if (ranout <= 25)
                {
                    if (ranout2 <= 34 && _7x11 == 0)
                    {
                        _6x6 = 1;
                        _7x11 = 11;
                    }
                    if (ranout2 <= 34 && ranout2 >= 66 && _5x9 == 0)
                    {
                        _5x10 = 1;
                        _5x9 = 11;
                    }
                    if (ranout2 <= 66 && ranout2 >= 100 && _5x13 == 0)
                    {
                        _5x12 = 1;
                        _5x13 = 11;
                    }
                    ranout2 = random.Next(1, 100);
                    if (ranout2 <= 34 && _7x11 == 0)
                    {
                        _6x6 = 1;
                        _7x11 = 11;
                    }
                    if (ranout2 <= 34 && ranout2 >= 66 && _5x9 == 0)
                    {
                        _5x10 = 1;
                        _5x9 = 11;
                    }
                    if (ranout2 <= 66 && ranout2 >= 100 && _5x13 == 0)
                    {
                        _5x12 = 1;
                        _5x13 = 11;
                    }
                    _4x6 = 1;
                    _3x11 = 1;
                }
                if (ranout >= 25 && ranout <= 50)
                {
                    if (ranout2 <= 34 && _3x11 == 0)
                    {
                        _4x6 = 1;
                        _3x11 = 11;
                    }
                    if (ranout2 <= 34 && ranout2 >= 66 && _7x11 == 0)
                    {
                        _6x6 = 1;
                        _7x11 = 11;
                    }
                    if (ranout2 <= 66 && ranout2 >= 100 && _5x13 == 0)
                    {
                        _5x12 = 1;
                        _5x13 = 11;
                    }
                    ranout2 = random.Next(1, 100);
                    if (ranout2 <= 34 && _3x11 == 0)
                    {
                        _4x6 = 1;
                        _3x11 = 11;
                    }
                    if (ranout2 <= 34 && ranout2 >= 66 && _7x11 == 0)
                    {
                        _6x6 = 1;
                        _7x11 = 11;
                    }
                    if (ranout2 <= 66 && ranout2 >= 100 && _5x13 == 0)
                    {
                        _5x12 = 1;
                        _5x13 = 11;
                    }
                    _5x10 = 1;
                    _5x9 = 1;
                }
                if (ranout >= 50 && ranout <= 75)
                {
                    if (ranout2 <= 34 && _3x11 == 0)
                    {
                        _4x6 = 1;
                        _3x11 = 11;
                    }
                    if (ranout2 <= 34 && ranout2 >= 66 && _5x9 == 0)
                    {
                        _5x10 = 1;
                        _5x9 = 11;
                    }
                    if (ranout2 <= 66 && ranout2 >= 100 && _7x11 == 0)
                    {
                        _6x6 = 1;
                        _7x11 = 11;
                    }
                    ranout2 = random.Next(1, 100);
                    if (ranout2 <= 34 && _3x11 == 0)
                    {
                        _4x6 = 1;
                        _3x11 = 11;
                    }
                    if (ranout2 <= 34 && ranout2 >= 66 && _5x9 == 0)
                    {
                        _5x10 = 1;
                        _5x9 = 11;
                    }
                    if (ranout2 <= 66 && ranout2 >= 100 && _7x11 == 0)
                    {
                        _6x6 = 1;
                        _7x11 = 11;
                    }
                    _5x12 = 1;
                    _5x13 = 1;
                }
                if (ranout >= 75)
                {
                    if (ranout2 <= 34 && _3x11 == 0)
                    {
                        _4x6 = 1;
                        _3x11 = 11;
                    }
                    if (ranout2 <= 34 && ranout2 >= 66 && _5x9 == 0)
                    {
                        _5x10 = 1;
                        _5x9 = 11;
                    }
                    if (ranout2 <= 66 && ranout2 >= 100 && _5x13 == 0)
                    {
                        _5x12 = 1;
                        _5x13 = 11;
                    }
                    ranout2 = random.Next(1, 100);
                    if (ranout2 <= 34 && _3x11 == 0)
                    {
                        _4x6 = 1;
                        _3x11 = 11;
                    }
                    if (ranout2 <= 34 && ranout2 >= 66 && _5x9 == 0)
                    {
                        _5x10 = 1;
                        _5x9 = 11;
                    }
                    if (ranout2 <= 66 && ranout2 >= 100 && _5x13 == 0)
                    {
                        _5x12 = 1;
                        _5x13 = 11;
                    }
                    _6x6 = 1;
                    _7x11 = 1;
                }
                if (_5x11 == 1)
                {
                    _5x11 = 11;
                }
                cellcount++;
            }

            if (_5x13 == 10 || _5x13 == 1)
            {
                if (ranout4 <= cellcount)
                {
                    bosscell = 25;
                    break;
                }
                Random random = new Random();
                int ranout = random.Next(1, 100);
                int ranout2 = random.Next(1, 100);
                if (ranout <= 25)
                {
                    if (ranout2 <= 34 && _7x13 == 0)
                    {
                        _6x7 = 1;
                        _7x13 = 11;
                    }
                    if (ranout2 <= 34 && ranout2 >= 66 && _5x11 == 0)
                    {
                        _5x12 = 1;
                        _5x11 = 11;
                    }
                    if (ranout2 <= 66 && ranout2 >= 100 && _5x15 == 0)
                    {
                        _5x14 = 1;
                        _5x15 = 11;
                    }
                    ranout2 = random.Next(1, 100);
                    if (ranout2 <= 34 && _7x13 == 0)
                    {
                        _6x7 = 1;
                        _7x13 = 11;
                    }
                    if (ranout2 <= 34 && ranout2 >= 66 && _5x11 == 0)
                    {
                        _5x12 = 1;
                        _5x11 = 11;
                    }
                    if (ranout2 <= 66 && ranout2 >= 100 && _5x15 == 0)
                    {
                        _5x14 = 1;
                        _5x15 = 11;
                    }
                    _4x7 = 1;
                    _3x13 = 1;
                }
                if (ranout >= 25 && ranout <= 50)
                {
                    if (ranout2 <= 34 && _3x13 == 0)
                    {
                        _4x7 = 1;
                        _3x13 = 11;
                    }
                    if (ranout2 <= 34 && ranout2 >= 66 && _7x13 == 0)
                    {
                        _6x7 = 1;
                        _7x13 = 11;
                    }
                    if (ranout2 <= 66 && ranout2 >= 100 && _5x15 == 0)
                    {
                        _5x14 = 1;
                        _5x15 = 11;
                    }
                    ranout2 = random.Next(1, 100);
                    if (ranout2 <= 34 && _3x13 == 0)
                    {
                        _4x7 = 1;
                        _3x13 = 11;
                    }
                    if (ranout2 <= 34 && ranout2 >= 66 && _7x13 == 0)
                    {
                        _6x7 = 1;
                        _7x13 = 11;
                    }
                    if (ranout2 <= 66 && ranout2 >= 100 && _5x15 == 0)
                    {
                        _5x14 = 1;
                        _5x15 = 11;
                    }
                    _5x12 = 1;
                    _5x11 = 1;
                }
                if (ranout >= 50 && ranout <= 75)
                {
                    if (ranout2 <= 34 && _3x13 == 0)
                    {
                        _4x7 = 1;
                        _3x13 = 11;
                    }
                    if (ranout2 <= 34 && ranout2 >= 66 && _5x11 == 0)
                    {
                        _5x12 = 1;
                        _5x11 = 11;
                    }
                    if (ranout2 <= 66 && ranout2 >= 100 && _7x13 == 0)
                    {
                        _6x7 = 1;
                        _7x13 = 11;
                    }
                    ranout2 = random.Next(1, 100);
                    if (ranout2 <= 34 && _3x13 == 0)
                    {
                        _4x7 = 1;
                        _3x13 = 11;
                    }
                    if (ranout2 <= 34 && ranout2 >= 66 && _5x11 == 0)
                    {
                        _5x12 = 1;
                        _5x11 = 11;
                    }
                    if (ranout2 <= 66 && ranout2 >= 100 && _7x13 == 0)
                    {
                        _6x7 = 1;
                        _7x13 = 11;
                    }
                    _5x14 = 1;
                    _5x15 = 1;
                }
                if (ranout >= 75)
                {
                    if (ranout2 <= 34 && _3x13 == 0)
                    {
                        _4x7 = 1;
                        _3x13 = 11;
                    }
                    if (ranout2 <= 34 && ranout2 >= 66 && _5x11 == 0)
                    {
                        _5x12 = 1;
                        _5x11 = 11;
                    }
                    if (ranout2 <= 66 && ranout2 >= 100 && _5x15 == 0)
                    {
                        _5x14 = 1;
                        _5x15 = 11;
                    }
                    ranout2 = random.Next(1, 100);
                    if (ranout2 <= 34 && _3x13 == 0)
                    {
                        _4x7 = 1;
                        _3x13 = 11;
                    }
                    if (ranout2 <= 34 && ranout2 >= 66 && _5x11 == 0)
                    {
                        _5x12 = 1;
                        _5x11 = 11;
                    }
                    if (ranout2 <= 66 && ranout2 >= 100 && _5x15 == 0)
                    {
                        _5x14 = 1;
                        _5x15 = 11;
                    }
                    _6x7 = 1;
                    _7x13 = 1;
                }
                if (_5x13 == 1)
                {
                    _5x13 = 11;
                }
                cellcount++;
            }

            if (_5x15 == 10 || _5x15 == 1)
            {
                if (ranout4 <= cellcount)
                {
                    bosscell = 26;
                    break;
                }
                Random random = new Random();
                int ranout = random.Next(1, 100);
                int ranout2 = random.Next(1, 100);
                if (ranout <= 25)
                {
                    if (ranout2 <= 34 && _7x15 == 0)
                    {
                        _6x8 = 1;
                        _7x15 = 11;
                    }
                    if (ranout2 <= 34 && ranout2 >= 66 && _5x13 == 0)
                    {
                        _5x14 = 1;
                        _5x13 = 11;
                    }
                    if (ranout2 <= 66 && ranout2 >= 100 && _5x17 == 0)
                    {
                        _5x16 = 1;
                        _5x17 = 11;
                    }
                    ranout2 = random.Next(1, 100);
                    if (ranout2 <= 34 && _7x15 == 0)
                    {
                        _6x8 = 1;
                        _7x15 = 11;
                    }
                    if (ranout2 <= 34 && ranout2 >= 66 && _5x13 == 0)
                    {
                        _5x14 = 1;
                        _5x13 = 11;
                    }
                    if (ranout2 <= 66 && ranout2 >= 100 && _5x17 == 0)
                    {
                        _5x16 = 1;
                        _5x17 = 11;
                    }
                    _4x8 = 1;
                    _3x15 = 1;
                }
                if (ranout >= 25 && ranout <= 50)
                {
                    if (ranout2 <= 34 && _3x15 == 0)
                    {
                        _4x8 = 1;
                        _3x15 = 11;
                    }
                    if (ranout2 <= 34 && ranout2 >= 66 && _7x15 == 0)
                    {
                        _6x8 = 1;
                        _7x15 = 11;
                    }
                    if (ranout2 <= 66 && ranout2 >= 100 && _5x17 == 0)
                    {
                        _5x16 = 1;
                        _5x17 = 11;
                    }
                    ranout2 = random.Next(1, 100);
                    if (ranout2 <= 34 && _3x15 == 0)
                    {
                        _4x8 = 1;
                        _3x15 = 11;
                    }
                    if (ranout2 <= 34 && ranout2 >= 66 && _7x15 == 0)
                    {
                        _6x8 = 1;
                        _7x15 = 11;
                    }
                    if (ranout2 <= 66 && ranout2 >= 100 && _5x17 == 0)
                    {
                        _5x16 = 1;
                        _5x17 = 11;
                    }
                    _5x14 = 1;
                    _5x13 = 1;
                }
                if (ranout >= 50 && ranout <= 75)
                {
                    if (ranout2 <= 34 && _3x15 == 0)
                    {
                        _4x8 = 1;
                        _3x15 = 11;
                    }
                    if (ranout2 <= 34 && ranout2 >= 66 && _5x13 == 0)
                    {
                        _5x14 = 1;
                        _5x13 = 11;
                    }
                    if (ranout2 <= 66 && ranout2 >= 100 && _7x15 == 0)
                    {
                        _6x8 = 1;
                        _7x15 = 11;
                    }
                    ranout2 = random.Next(1, 100);
                    if (ranout2 <= 34 && _3x15 == 0)
                    {
                        _4x8 = 1;
                        _3x15 = 11;
                    }
                    if (ranout2 <= 34 && ranout2 >= 66 && _5x13 == 0)
                    {
                        _5x14 = 1;
                        _5x13 = 11;
                    }
                    if (ranout2 <= 66 && ranout2 >= 100 && _7x15 == 0)
                    {
                        _6x8 = 1;
                        _7x15 = 11;
                    }
                    _5x16 = 1;
                    _5x17 = 1;
                }
                if (ranout >= 75)
                {
                    if (ranout2 <= 34 && _3x15 == 0)
                    {
                        _4x8 = 1;
                        _3x15 = 11;
                    }
                    if (ranout2 <= 34 && ranout2 >= 66 && _5x13 == 0)
                    {
                        _5x14 = 1;
                        _5x13 = 11;
                    }
                    if (ranout2 <= 66 && ranout2 >= 100 && _5x17 == 0)
                    {
                        _5x16 = 1;
                        _5x17 = 11;
                    }
                    ranout2 = random.Next(1, 100);
                    if (ranout2 <= 34 && _3x15 == 0)
                    {
                        _4x8 = 1;
                        _3x15 = 11;
                    }
                    if (ranout2 <= 34 && ranout2 >= 66 && _5x13 == 0)
                    {
                        _5x14 = 1;
                        _5x13 = 11;
                    }
                    if (ranout2 <= 66 && ranout2 >= 100 && _5x17 == 0)
                    {
                        _5x16 = 1;
                        _5x17 = 11;
                    }
                    _6x8 = 1;
                    _7x15 = 1;
                }
                if (_5x15 == 1)
                {
                    _5x15 = 11;
                }
                cellcount++;
            }

            if (_5x17 == 10 || _5x17 == 1)
            {
                if (ranout4 <= cellcount)
                {
                    bosscell = 27;
                    break;
                }
                Random random = new Random();
                int ranout = random.Next(1, 100);
                int ranout2 = random.Next(1, 100);
                if (ranout <= 34)
                {
                    if (ranout2 <= 50 && _7x17 == 0)
                    {
                        _6x9 = 1;
                        _7x17 = 11;
                    }
                    if (ranout2 >= 50 && _5x15 == 0)
                    {
                        _5x16 = 1;
                        _5x15 = 11;
                    }
                    ranout2 = random.Next(1, 100);
                    if (ranout2 <= 50 && _7x17 == 0)
                    {
                        _6x9 = 1;
                        _7x17 = 11;
                    }
                    if (ranout2 >= 50 && _5x15 == 0)
                    {
                        _5x16 = 1;
                        _5x15 = 11;
                    }
                    _4x9 = 1;
                    _3x17 = 1;
                }
                if (ranout >= 34 && ranout <= 66)
                {
                    if (ranout2 <= 50 && _3x17 == 0)
                    {
                        _4x9 = 1;
                        _3x17 = 11;
                    }
                    if (ranout2 >= 50 && _7x17 == 0)
                    {
                        _6x9 = 1;
                        _7x17 = 11;
                    }
                    ranout2 = random.Next(1, 100);
                    if (ranout2 <= 50 && _3x17 == 0)
                    {
                        _4x9 = 1;
                        _3x17 = 11;
                    }
                    if (ranout2 >= 50 && _7x17 == 0)
                    {
                        _6x9 = 1;
                        _7x17 = 11;
                    }
                    _5x16 = 1;
                    _5x15 = 1;
                }
                if (ranout >= 66)
                {
                    if (ranout2 <= 50 && _3x17 == 0)
                    {
                        _4x9 = 1;
                        _3x17 = 11;
                    }
                    if (ranout2 >= 50 && _5x15 == 0)
                    {
                        _5x16 = 1;
                        _5x15 = 11;
                    }
                    ranout2 = random.Next(1, 100);
                    if (ranout2 <= 50 && _3x17 == 0)
                    {
                        _4x9 = 1;
                        _3x17 = 11;
                    }
                    if (ranout2 >= 50 && _5x15 == 0)
                    {
                        _5x16 = 1;
                        _5x15 = 11;
                    }
                    _6x9 = 1;
                    _7x17 = 1;
                }
                if (_5x17 == 1)
                {
                    _5x17 = 11;
                }
                cellcount++;
            }

            if (_7x1 == 10 || _7x1 == 1)
            {
                if (ranout4 <= cellcount)
                {
                    bosscell = 28;
                    break;
                }
                Random random = new Random();
                int ranout = random.Next(1, 100);
                int ranout2 = random.Next(1, 100);
                if (ranout <= 50)
                {
                    if (ranout2 >= 50 && _7x3 == 0)
                    {
                        _7x2 = 1;
                        _7x3 = 11;
                    }
                    if (ranout2 <= 50 && _7x3 == 0)
                    {
                        _7x2 = 1;
                        _7x3 = 11;
                    }
                    _6x1 = 1;
                    _5x1 = 1;
                }
                if (ranout >= 50)
                {
                    if (ranout2 <= 34 && _5x1 == 0)
                    {
                        _6x1 = 1;
                        _5x1 = 11;
                    }
                    if (ranout2 <= 34 && _5x1 == 0)
                    {
                        _6x1 = 1;
                        _5x1 = 11;
                    }
                    _7x2 = 1;
                    _7x3 = 1;
                }
                if (_7x1 == 1)
                {
                    _7x1 = 11;
                }
                cellcount++;
            }

            if (_7x3 == 10 || _7x3 == 1)
            {
                if (ranout4 <= cellcount)
                {
                    bosscell = 29;
                    break;
                }
                Random random = new Random();
                int ranout = random.Next(1, 100);
                int ranout2 = random.Next(1, 100);
                if (ranout <= 34)
                {
                    if (ranout2 >= 50 && _7x1 == 0)
                    {
                        _7x2 = 1;
                        _7x1 = 11;
                    }
                    if (ranout2 <= 50 && _7x5 == 0)
                    {
                        _7x4 = 1;
                        _7x5 = 11;
                    }
                    ranout2 = random.Next(1, 100);
                    if (ranout2 <= 50 && _7x1 == 0)
                    {
                        _7x2 = 1;
                        _7x1 = 11;
                    }
                    if (ranout2 >= 50 && _7x5 == 0)
                    {
                        _7x4 = 1;
                        _7x5 = 11;
                    }
                    _6x2 = 1;
                    _5x3 = 1;
                }
                if (ranout >= 34 && ranout <= 66)
                {
                    if (ranout2 <= 50 && _5x3 == 0)
                    {
                        _6x2 = 1;
                        _5x3 = 11;
                    }
                    if (ranout2 >= 50 && _7x5 == 0)
                    {
                        _7x4 = 1;
                        _7x5 = 11;
                    }
                    ranout2 = random.Next(1, 100);
                    if (ranout2 <= 50 && _5x3 == 0)
                    {
                        _6x2 = 1;
                        _5x3 = 11;
                    }
                    if (ranout2 >= 50 && _7x5 == 0)
                    {
                        _7x4 = 1;
                        _7x5 = 11;
                    }
                    _7x2 = 1;
                    _7x1 = 1;
                }
                if (ranout >= 66)
                {
                    if (ranout2 <= 50 && _5x3 == 0)
                    {
                        _6x2 = 1;
                        _5x3 = 11;
                    }
                    if (ranout2 >= 50 && _7x1 == 0)
                    {
                        _7x2 = 1;
                        _7x1 = 11;
                    }
                    ranout2 = random.Next(1, 100);
                    if (ranout2 <= 50 && _5x3 == 0)
                    {
                        _6x2 = 1;
                        _5x3 = 11;
                    }
                    if (ranout2 >= 50 && _7x1 == 0)
                    {
                        _7x2 = 1;
                        _7x1 = 11;
                    }
                    _7x4 = 1;
                    _7x5 = 1;
                }
                if (_7x3 == 1)
                {
                    _7x3 = 11;
                }
                cellcount++;
            }

            if (_7x5 == 10 || _7x5 == 1)
            {
                if (ranout4 <= cellcount)
                {
                    bosscell = 30;
                    break;
                }
                Random random = new Random();
                int ranout = random.Next(1, 100);
                int ranout2 = random.Next(1, 100);
                if (ranout <= 34)
                {
                    if (ranout2 <= 50 && _7x3 == 0)
                    {
                        _7x4 = 1;
                        _7x3 = 11;
                    }
                    if (ranout2 >= 50 && _7x7 == 0)
                    {
                        _7x6 = 1;
                        _7x7 = 11;
                    }
                    ranout2 = random.Next(1, 100);
                    if (ranout2 <= 50 && _7x3 == 0)
                    {
                        _7x4 = 1;
                        _7x3 = 11;
                    }
                    if (ranout2 >= 50 && _7x7 == 0)
                    {
                        _7x6 = 1;
                        _7x7 = 11;
                    }
                    _6x3 = 1;
                    _5x5 = 1;
                }
                if (ranout >= 34 && ranout <= 66)                           //////////////////////////////////////
                {
                    if (ranout2 <= 50 && _5x5 == 0)
                    {
                        _6x3 = 1;
                        _5x5 = 11;
                    }
                    if (ranout2 >= 50 && _7x7 == 0)
                    {
                        _7x6 = 1;
                        _7x7 = 11;
                    }
                    ranout2 = random.Next(1, 100);
                    if (ranout2 <= 50 && _5x5 == 0)
                    {
                        _6x3 = 1;
                        _5x5 = 11;
                    }
                    if (ranout2 >= 50 && _7x7 == 0)
                    {
                        _7x6 = 1;
                        _7x7 = 11;
                    }
                    _7x4 = 1;
                    _7x3 = 1;
                }
                if (ranout >= 66)
                {
                    if (ranout2 <= 50 && _5x5 == 0)
                    {
                        _6x3 = 1;
                        _5x5 = 11;
                    }
                    if (ranout2 >= 50 && _7x3 == 0)
                    {
                        _7x4 = 1;
                        _7x3 = 11;
                    }
                    ranout2 = random.Next(1, 100);
                    if (ranout2 <= 50 && _5x5 == 0)
                    {
                        _6x3 = 1;
                        _5x5 = 11;
                    }
                    if (ranout2 >= 50 && _7x3 == 0)
                    {
                        _7x4 = 1;
                        _7x3 = 11;
                    }
                    _7x6 = 1;
                    _7x7 = 1;
                }
                if (_7x5 == 1)
                {
                    _7x5 = 11;
                }
                cellcount++;
            }

            if (_7x7 == 10 || _7x7 == 1)
            {
                if (ranout4 <= cellcount)
                {
                    bosscell = 31;
                    break;
                }
                Random random = new Random();
                int ranout = random.Next(1, 100);
                int ranout2 = random.Next(1, 100);
                if (ranout <= 34)
                {
                    if (ranout2 >= 50 && _7x5 == 0)
                    {
                        _7x6 = 1;
                        _7x5 = 11;
                    }
                    if (ranout2 <= 50 && _7x9 == 0)
                    {
                        _7x8 = 1;
                        _7x9 = 11;
                    }
                    ranout2 = random.Next(1, 100);
                    if (ranout2 >= 50 && _7x5 == 0)
                    {
                        _7x6 = 1;
                        _7x5 = 11;
                    }
                    if (ranout2 <= 50 && _7x9 == 0)
                    {
                        _7x8 = 1;
                        _7x9 = 11;
                    }
                    _6x4 = 1;
                    _5x7 = 1;
                }
                if (ranout >= 34 && ranout <= 66)
                {
                    if (ranout2 <= 50 && _5x7 == 0)
                    {
                        _6x4 = 1;
                        _5x7 = 11;
                    }
                    if (ranout2 >= 50 && _7x9 == 0)
                    {
                        _7x8 = 1;
                        _7x9 = 11;
                    }
                    ranout2 = random.Next(1, 100);
                    if (ranout2 <= 50 && _5x7 == 0)
                    {
                        _6x4 = 1;
                        _5x7 = 11;
                    }
                    if (ranout2 >= 50 && _7x9 == 0)
                    {
                        _7x8 = 1;
                        _7x9 = 11;
                    }
                    _7x6 = 1;
                    _7x5 = 1;
                }
                if (ranout >= 66)
                {
                    if (ranout2 <= 50 && _5x7 == 0)
                    {
                        _6x4 = 1;
                        _5x7 = 11;
                    }
                    if (ranout2 >= 50 && _7x9 == 0)
                    {
                        _7x6 = 1;
                        _7x5 = 11;
                    }
                    ranout2 = random.Next(1, 100);
                    if (ranout2 <= 50 && _5x7 == 0)
                    {
                        _6x4 = 1;
                        _5x7 = 11;
                    }
                    if (ranout2 >= 50 && _7x9 == 0)
                    {
                        _7x6 = 1;
                        _7x5 = 11;
                    }
                    _7x8 = 1;
                    _7x9 = 1;
                }
                if (_7x7 == 1)
                {
                    _7x7 = 11;
                }
                cellcount++;
            }

            if (_7x9 == 10 || _7x9 == 1)
            {
                if (ranout4 <= cellcount)
                {
                    bosscell = 32;
                    break;
                }
                Random random = new Random();
                int ranout = random.Next(1, 100);
                int ranout2 = random.Next(1, 100);
                if (ranout <= 34)
                {
                    if (ranout2 <= 50 && _7x7 == 0)
                    {
                        _7x8 = 1;
                        _7x7 = 11;
                    }
                    if (ranout2 >= 50 && _7x11 == 0)
                    {
                        _7x10 = 1;
                        _7x11 = 11;
                    }
                    ranout2 = random.Next(1, 100);
                    if (ranout2 <= 50 && _7x7 == 0)
                    {
                        _7x8 = 1;
                        _7x7 = 11;
                    }
                    if (ranout2 >= 50 && _7x11 == 0)
                    {
                        _7x10 = 1;
                        _7x11 = 11;
                    }
                    _6x5 = 1;
                    _5x9 = 1;
                }
                if (ranout >= 34 && ranout <= 66)
                {
                    if (ranout2 <= 50 && _5x9 == 0)
                    {
                        _6x5 = 1;
                        _5x9 = 11;
                    }
                    if (ranout2 >= 50 && _7x11 == 0)
                    {
                        _7x10 = 1;
                        _7x11 = 11;
                    }
                    ranout2 = random.Next(1, 100);
                    if (ranout2 <= 50 && _5x9 == 0)
                    {
                        _6x5 = 1;
                        _5x9 = 11;
                    }
                    if (ranout2 >= 50 && _7x11 == 0)
                    {
                        _7x10 = 1;
                        _7x11 = 11;
                    }
                    _7x8 = 1;
                    _7x7 = 1;
                }
                if (ranout >= 66)
                {
                    if (ranout2 <= 50 && _5x9 == 0)
                    {
                        _6x5 = 1;
                        _5x9 = 11;
                    }
                    if (ranout2 >= 650 && _7x7 == 0)
                    {
                        _7x8 = 1;
                        _7x7 = 11;
                    }
                    ranout2 = random.Next(1, 100);
                    if (ranout2 <= 50 && _5x9 == 0)
                    {
                        _6x5 = 1;
                        _5x9 = 11;
                    }
                    if (ranout2 >= 50 && _7x7 == 0)
                    {
                        _7x8 = 1;
                        _7x7 = 11;
                    }
                    _7x10 = 1;
                    _7x11 = 1;
                }
                if (_7x9 == 1)
                {
                    _7x9 = 11;
                }
                cellcount++;
            }

            if (_7x11 == 10 || _7x11 == 1)
            {
                if (ranout4 <= cellcount)
                {
                    bosscell = 33;
                    break;
                }
                Random random = new Random();
                int ranout = random.Next(1, 100);
                int ranout2 = random.Next(1, 100);
                if (ranout <= 34)
                {
                    if (ranout2 <= 50 && _7x9 == 0)
                    {
                        _7x10 = 1;
                        _7x9 = 11;
                    }
                    if (ranout2 >= 50 && _7x13 == 0)
                    {
                        _7x12 = 1;
                        _7x13 = 11;
                    }
                    ranout2 = random.Next(1, 100);
                    if (ranout2 <= 34 && ranout2 >= 66 && _7x9 == 0)
                    {
                        _7x10 = 1;
                        _7x9 = 11;
                    }
                    if (ranout2 <= 66 && ranout2 >= 100 && _7x13 == 0)
                    {
                        _7x12 = 1;
                        _7x13 = 11;
                    }
                    _6x6 = 1;
                    _5x11 = 1;
                }
                if (ranout >= 34 && ranout <= 66)
                {
                    if (ranout2 <= 50 && _5x11 == 0)
                    {
                        _6x6 = 1;
                        _5x11 = 11;
                    }
                    if (ranout2 >= 50 && _7x13 == 0)
                    {
                        _7x12 = 1;
                        _7x13 = 11;
                    }
                    ranout2 = random.Next(1, 100);
                    if (ranout2 <= 50 && _5x11 == 0)
                    {
                        _6x6 = 1;
                        _5x11 = 11;
                    }
                    if (ranout2 >= 50 && _7x13 == 0)
                    {
                        _7x12 = 1;
                        _7x13 = 11;
                    }
                    _7x10 = 1;
                    _7x9 = 1;
                }
                if (ranout >= 66)
                {
                    if (ranout2 <= 50 && _5x11 == 0)
                    {
                        _6x6 = 1;
                        _5x11 = 11;
                    }
                    if (ranout2 >= 50 && _7x9 == 0)
                    {
                        _7x10 = 1;
                        _7x9 = 11;
                    }
                    ranout2 = random.Next(1, 100);
                    if (ranout2 <= 50 && _5x11 == 0)
                    {
                        _6x6 = 1;
                        _5x11 = 11;
                    }
                    if (ranout2 >= 50 && _7x9 == 0)
                    {
                        _7x10 = 1;
                        _7x9 = 11;
                    }
                    _7x12 = 1;
                    _7x13 = 1;
                }
                if (_7x11 == 1)
                {
                    _7x11 = 11;
                }
                cellcount++;
            }

            if (_7x13 == 10 || _7x13 == 1)
            {
                if (ranout4 <= cellcount)
                {
                    bosscell = 34;
                    break;
                }
                Random random = new Random();
                int ranout = random.Next(1, 100);
                int ranout2 = random.Next(1, 100);
                if (ranout <= 34)
                {
                    if (ranout2 <= 50 && _7x11 == 0)
                    {
                        _7x12 = 1;
                        _7x11 = 11;
                    }
                    if (ranout2 >= 50 && _7x15 == 0)
                    {
                        _7x14 = 1;
                        _7x15 = 11;
                    }
                    ranout2 = random.Next(1, 100);
                    if (ranout2 <= 50 && _7x11 == 0)
                    {
                        _7x12 = 1;
                        _7x11 = 11;
                    }
                    if (ranout2 >= 50 && _7x15 == 0)
                    {
                        _7x14 = 1;
                        _7x15 = 11;
                    }
                    _6x7 = 1;
                    _5x13 = 1;
                }
                if (ranout >= 34 && ranout <= 66)
                {
                    if (ranout2 <= 50 && _5x13 == 0)
                    {
                        _6x7 = 1;
                        _5x13 = 11;
                    }
                    if (ranout2 >= 50 && _7x15 == 0)
                    {
                        _7x14 = 1;
                        _7x15 = 11;
                    }
                    ranout2 = random.Next(1, 100);
                    if (ranout2 <= 50 && _5x13 == 0)
                    {
                        _6x7 = 1;
                        _5x13 = 11;
                    }
                    if (ranout2 >= 50 && _7x15 == 0)
                    {
                        _7x14 = 1;
                        _7x15 = 11;
                    }
                    _7x12 = 1;
                    _7x11 = 1;
                }
                if (ranout >= 66)
                {
                    if (ranout2 <= 50 && _5x13 == 0)
                    {
                        _6x7 = 1;
                        _5x13 = 11;
                    }
                    if (ranout2 >= 50 && _7x11 == 0)
                    {
                        _7x12 = 1;
                        _7x11 = 11;
                    }
                    ranout2 = random.Next(1, 100);
                    if (ranout2 <= 50 && _5x13 == 0)
                    {
                        _6x7 = 1;
                        _5x13 = 11;
                    }
                    if (ranout2 >= 50 && _7x11 == 0)
                    {
                        _7x12 = 1;
                        _7x11 = 11;
                    }
                    _7x14 = 1;
                    _7x15 = 1;
                }
                if (_7x13 == 1)
                {
                    _7x13 = 11;
                }
                cellcount++;
            }

            if (_7x15 == 10 || _7x15 == 1)
            {
                if (ranout4 <= cellcount)
                {
                    bosscell = 35;
                    break;
                }
                Random random = new Random();
                int ranout = random.Next(1, 100);
                int ranout2 = random.Next(1, 100);
                if (ranout <= 34)
                {
                    if (ranout2 <= 50 && _7x13 == 0)
                    {
                        _7x14 = 1;
                        _7x13 = 11;
                    }
                    if (ranout2 >= 50 && _7x17 == 0)
                    {
                        _7x16 = 1;
                        _7x17 = 11;
                    }
                    ranout2 = random.Next(1, 100);
                    if (ranout2 <= 50 && _7x13 == 0)
                    {
                        _7x14 = 1;
                        _7x13 = 11;
                    }
                    if (ranout2 >= 50 && _7x17 == 0)
                    {
                        _7x16 = 1;
                        _7x17 = 11;
                    }
                    _6x8 = 1;
                    _5x15 = 1;
                }
                if (ranout >= 34 && ranout <= 66)
                {
                    if (ranout2 <= 50 && _5x15 == 0)
                    {
                        _6x8 = 1;
                        _5x15 = 11;
                    }
                    if (ranout2 >= 50 && _7x17 == 0)
                    {
                        _7x16 = 1;
                        _7x17 = 11;
                    }
                    ranout2 = random.Next(1, 100);
                    if (ranout2 <= 50 && _5x15 == 0)
                    {
                        _6x8 = 1;
                        _5x15 = 11;
                    }
                    if (ranout2 >= 50 && _7x17 == 0)
                    {
                        _7x16 = 1;
                        _7x17 = 11;
                    }
                    _7x14 = 1;
                    _7x13 = 1;
                }
                if (ranout >= 66)
                {
                    if (ranout2 <= 50 && _5x15 == 0)
                    {
                        _6x8 = 1;
                        _5x15 = 11;
                    }
                    if (ranout2 >= 50 && _7x13 == 0)
                    {
                        _7x14 = 1;
                        _7x13 = 11;
                    }
                    ranout2 = random.Next(1, 100);
                    if (ranout2 <= 50 && _5x15 == 0)
                    {
                        _6x8 = 1;
                        _5x15 = 11;
                    }
                    if (ranout2 >= 50 && _7x13 == 0)
                    {
                        _7x14 = 1;
                        _7x13 = 11;
                    }
                    _7x16 = 1;
                    _7x17 = 1;
                }
                if (_7x15 == 1)
                {
                    _7x15 = 11;
                }
                cellcount++;
            }

            if (_7x17 == 10 || _7x17 == 1)
            {
                if (ranout4 <= cellcount)
                {
                    bosscell = 36;
                    break;
                }
                Random random = new Random();
                int ranout = random.Next(1, 100);
                int ranout2 = random.Next(1, 100);
                if (ranout <= 50)
                {
                    if (ranout2 <= 50 && _7x15 == 0)
                    {
                        _7x16 = 1;
                        _7x15 = 11;
                    }
                    if (ranout2 >= 50 && _7x15 == 0)
                    {
                        _7x16 = 1;
                        _7x15 = 11;
                    }
                    _6x9 = 1;
                    _5x17 = 1;
                }
                if (ranout <= 50)
                {
                    if (ranout2 <= 50 && _5x17 == 0)
                    {
                        _6x9 = 1;
                        _5x17 = 11;
                    }
                    if (ranout2 >= 50 && _5x17 == 0)
                    {
                        _6x9 = 1;
                        _5x17 = 11;
                    }
                    _7x16 = 1;
                    _7x15 = 1;
                }
                if (_7x17 == 1)
                {
                    _7x17 = 11;
                }
                cellcount++;
            }

            if (_1x1 == 10)
            {
                _1x1 = 13;
            }
            else if (_1x3 == 10)
            {
                _1x3 = 13;
            }
            else if (_1x5 == 10)
            {
                _1x5 = 13;
            }
            else if (_1x7 == 10)
            {
                _1x7 = 13;
            }
            else if (_1x9 == 10)
            {
                _1x9 = 13;
            }
            else if (_1x11 == 10)
            {
                _1x11 = 13;
            }
            else if (_1x13 == 10)
            {
                _1x13 = 13;
            }
            else if (_1x15 == 10)
            {
                _1x15 = 13;
            }
            else if (_1x17 == 10)
            {
                _1x17 = 13;
            }
            else if (_3x1 == 10)
            {
                _3x1 = 13;
            }
            else if (_3x3 == 10)
            {
                _3x3 = 13;
            }
            else if (_3x5 == 10)
            {
                _3x5 = 13;
            }
            else if (_3x7 == 10)
            {
                _3x7 = 13;
            }
            else if (_3x9 == 10)
            {
                _3x9 = 13;
            }
            else if (_3x11 == 10)
            {
                _3x11 = 13;
            }
            else if (_3x13 == 10)
            {
                _3x13 = 13;
            }
            else if (_3x15 == 10)
            {
                _3x15 = 13;
            }
            else if (_3x17 == 10)
            {
                _3x17 = 13;
            }
            else if (_5x1 == 10)
            {
                _5x1 = 13;
            }
            else if (_5x3 == 10)
            {
                _5x3 = 13;
            }
            else if (_5x5 == 10)
            {
                _5x5 = 13;
            }
            else if (_5x7 == 10)
            {
                _5x7 = 13;
            }
            else if (_5x9 == 10)
            {
                _5x9 = 13;
            }
            else if (_5x11 == 10)
            {
                _5x11 = 13;
            }
            else if (_5x13 == 10)
            {
                _5x13 = 13;
            }
            else if (_5x15 == 10)
            {
                _5x15 = 13;
            }
            else if (_5x17 == 10)
            {
                _5x17 = 13;
            }
            else if (_7x1 == 10)
            {
                _7x1 = 13;
            }
            else if (_7x3 == 10)
            {
                _7x3 = 13;
            }
            else if (_7x5 == 10)
            {
                _7x5 = 13;
            }
            else if (_7x7 == 10)
            {
                _7x7 = 13;
            }
            else if (_7x9 == 10)
            {
                _7x9 = 13;
            }
            else if (_7x11 == 10)
            {
                _7x11 = 13;
            }
            else if (_7x13 == 10)
            {
                _7x13 = 13;
            }
            else if (_7x15 == 10)
            {
                _7x15 = 13;
            }
            else if (_7x17 == 10)
            {
                _7x17 = 13;
            }
            // error in cell gen (prob overridden)
            if (_1x1 != 1 && _1x3 != 1 && _1x5 != 1 && _1x7 != 1 && _1x9 != 1 && _1x11 != 1 && _1x13 != 1 && _1x15 != 1 && _1x17 != 1 && _3x1 != 1 && _3x3 != 1 && _3x5 != 1 && _3x7 != 1 && _3x9 != 1 && _3x11 != 1 && _3x13 != 1 && _3x15 != 1 && _3x17 != 1 && _5x1 != 1 && _5x3 != 1 && _5x5 != 1 && _5x7 != 1 && _5x9 != 1 && _5x11 != 1 && _5x13 != 1 && _5x15 != 1 && _5x17 != 1 && _7x1 != 1 && _7x3 != 1 && _7x5 != 1 && _7x7 != 1 && _7x9 != 1 && _7x11 != 1 && _7x13 != 1 && _7x15 != 1 && _7x17 != 1)
            {
                cellgen = false;
            }
        }

        while (population)
        {
            Random random = new Random();
            if (ranoutstr == 1)
            {
                _1x1 = 13;
            }
            else if (ranoutstr == 2)
            {
                _1x3 = 13;
            }
            else if (ranoutstr == 3)
            {
                _1x5 = 13;
            }
            else if (ranoutstr == 4)
            {
                _1x7 = 13;
            }
            else if (ranoutstr == 5)
            {
                _1x9 = 13;
            }
            else if (ranoutstr == 6)
            {
                _1x11 = 13;
            }
            else if (ranoutstr == 7)
            {
                _1x13 = 13;
            }
            else if (ranoutstr == 8)
            {
                _1x15 = 13;
            }
            else if (ranoutstr == 9)
            {
                _1x17 = 13;
            }
            else if (ranoutstr == 10)
            {
                _3x1 = 13;
            }
            else if (ranoutstr == 11)
            {
                _3x3 = 13;
            }
            else if (ranoutstr == 12)
            {
                _3x5 = 13;
            }
            else if (ranoutstr == 13)
            {
                _3x7 = 13;
            }
            else if (ranoutstr == 14)
            {
                _3x9 = 13;
            }
            else if (ranoutstr == 15)
            {
                _3x11 = 13;
            }
            else if (ranoutstr == 16)
            {
                _3x13 = 13;
            }
            else if (ranoutstr == 17)
            {
                _3x15 = 13;
            }
            else if (ranoutstr == 18)
            {
                _3x17 = 13;
            }
            else if (ranoutstr == 19)
            {
                _5x1 = 13;
            }
            else if (ranoutstr == 20)
            {
                _5x3 = 13;
            }
            else if (ranoutstr == 21)
            {
                _5x5 = 13;
            }
            else if (ranoutstr == 22)
            {
                _5x7 = 13;
            }
            else if (ranoutstr == 23)
            {
                _5x9 = 13;
            }
            else if (ranoutstr == 24)
            {
                _5x11 = 13;
            }
            else if (ranoutstr == 25)
            {
                _5x13 = 13;
            }
            else if (ranoutstr == 26)
            {
                _5x15 = 13;
            }
            else if (ranoutstr == 27)
            {
                _5x17 = 13;
            }
            else if (ranoutstr == 28)
            {
                _7x1 = 13;
            }
            else if (ranoutstr == 29)
            {
                _7x3 = 13;
            }
            else if (ranoutstr == 30)
            {
                _7x5 = 13;
            }
            else if (ranoutstr == 31)
            {
                _7x7 = 13;
            }
            else if (ranoutstr == 32)
            {
                _7x9 = 13;
            }
            else if (ranoutstr == 33)
            {
                _7x11 = 13;
            }
            else if (ranoutstr == 34)
            {
                _7x13 = 13;
            }
            else if (ranoutstr == 35)
            {
                _7x15 = 13;
            }
            else if (ranoutstr == 36)
            {
                _7x17 = 13;
            }

            if (bosscell == 1)
            {
                _1x1 = 5;
            }
            else if (bosscell == 2)
            {
                _1x3 = 5;
            }
            else if (bosscell == 3)
            {
                _1x5 = 5;
            }
            else if (bosscell == 4)
            {
                _1x7 = 5;
            }
            else if (bosscell == 5)
            {
                _1x9 = 5;
            }
            else if (bosscell == 6)
            {
                _1x11 = 5;
            }
            else if (bosscell == 7)
            {
                _1x13 = 5;
            }
            else if (bosscell == 8)
            {
                _1x15 = 5;
            }
            else if (bosscell == 9)
            {
                _1x17 = 5;
            }
            else if (bosscell == 10)
            {
                _3x1 = 5;
            }
            else if (bosscell == 11)
            {
                _3x3 = 5;
            }
            else if (bosscell == 12)
            {
                _3x5 = 5;
            }
            else if (bosscell == 13)
            {
                _3x7 = 5;
            }
            else if (bosscell == 14)
            {
                _3x9 = 5;
            }
            else if (bosscell == 15)
            {
                _3x11 = 5;
            }
            else if (bosscell == 16)
            {
                _3x13 = 5;
            }
            else if (bosscell == 17)
            {
                _3x15 = 5;
            }
            else if (bosscell == 18)
            {
                _3x17 = 5;
            }
            else if (bosscell == 19)
            {
                _5x1 = 5;
            }
            else if (bosscell == 20)
            {
                _5x3 = 5;
            }
            else if (bosscell == 21)
            {
                _5x5 = 5;
            }
            else if (bosscell == 22)
            {
                _5x7 = 5;
            }
            else if (bosscell == 23)
            {
                _5x9 = 5;
            }
            else if (bosscell == 24)
            {
                _5x11 = 5;
            }
            else if (bosscell == 25)
            {
                _5x13 = 5;
            }
            else if (bosscell == 26)
            {
                _5x15 = 5;
            }
            else if (bosscell == 27)
            {
                _5x17 = 5;
            }
            else if (bosscell == 28)
            {
                _7x1 = 5;
            }
            else if (bosscell == 29)
            {
                _7x3 = 5;
            }
            else if (bosscell == 30)
            {
                _7x5 = 5;
            }
            else if (bosscell == 31)
            {
                _7x7 = 5;
            }
            else if (bosscell == 32)
            {
                _7x9 = 5;
            }
            else if (bosscell == 33)
            {
                _7x11 = 5;
            }
            else if (bosscell == 34)
            {
                _7x13 = 5;
            }
            else if (bosscell == 35)
            {
                _7x15 = 5;
            }
            else if (bosscell == 36)
            {
                _7x17 = 5;
            }

            while (population1)
            {
                if (_1x1 != 5 && _1x3 != 5 && _1x5 != 5 && _1x7 != 5 && _1x9 != 5 && _1x11 != 5 && _1x13 != 5 && _1x15 != 5 && _1x17 != 5 && _3x1 != 5 && _3x3 != 5 && _3x5 != 5 && _3x7 != 5 && _3x9 != 5 && _3x11 != 5 && _3x13 != 5 && _3x15 != 5 && _3x17 != 5 && _5x1 != 5 && _5x3 != 5 && _5x5 != 5 && _5x7 != 5 && _5x9 != 5 && _5x11 != 5 && _5x13 != 5 && _5x15 != 5 && _5x17 != 5 && _7x1 != 5 && _7x3 != 5 && _7x5 != 5 && _7x7 != 5 && _7x9 != 5 && _7x11 != 5 && _7x13 != 5 && _7x15 != 5 && _7x17 != 5)
                {
                    bosscell = random.Next(1, 36);

                    if (bosscell == 1 && _1x1 == 11)
                    {
                        _1x1 = 5;
                    }
                    else if (bosscell == 2 && _1x3 == 11)
                    {
                        _1x3 = 5;
                    }
                    else if (bosscell == 3 && _1x5 == 11)
                    {
                        _1x5 = 5;
                    }
                    else if (bosscell == 4 && _1x7 == 11)
                    {
                        _1x7 = 5;
                    }
                    else if (bosscell == 5 && _1x9 == 11)
                    {
                        _1x9 = 5;
                    }
                    else if (bosscell == 6 && _1x11 == 11)
                    {
                        _1x11 = 5;
                    }
                    else if (bosscell == 7 && _1x13 == 11)
                    {
                        _1x13 = 5;
                    }
                    else if (bosscell == 8 && _1x15 == 11)
                    {
                        _1x15 = 5;
                    }
                    else if (bosscell == 9 && _1x17 == 11)
                    {
                        _1x17 = 5;
                    }
                    else if (bosscell == 10 && _3x1 == 11)
                    {
                        _3x1 = 5;
                    }
                    else if (bosscell == 11 && _3x3 == 11)
                    {
                        _3x3 = 5;
                    }
                    else if (bosscell == 12 && _3x5 == 11)
                    {
                        _3x5 = 5;
                    }
                    else if (bosscell == 13 && _3x7 == 11)
                    {
                        _3x7 = 5;
                    }
                    else if (bosscell == 14 && _3x9 == 11)
                    {
                        _3x9 = 5;
                    }
                    else if (bosscell == 15 && _3x11 == 11)
                    {
                        _3x11 = 5;
                    }
                    else if (bosscell == 16 && _3x13 == 11)
                    {
                        _3x13 = 5;
                    }
                    else if (bosscell == 17 && _3x15 == 11)
                    {
                        _3x15 = 5;
                    }
                    else if (bosscell == 18 && _3x17 == 11)
                    {
                        _3x17 = 5;
                    }
                    else if (bosscell == 19 && _5x1 == 11)
                    {
                        _5x1 = 5;
                    }
                    else if (bosscell == 20 && _5x3 == 11)
                    {
                        _5x3 = 5;
                    }
                    else if (bosscell == 21 && _5x5 == 11)
                    {
                        _5x5 = 5;
                    }
                    else if (bosscell == 22 && _5x7 == 11)
                    {
                        _5x7 = 5;
                    }
                    else if (bosscell == 23 && _5x9 == 11)
                    {
                        _5x9 = 5;
                    }
                    else if (bosscell == 24 && _5x11 == 11)
                    {
                        _5x11 = 5;
                    }
                    else if (bosscell == 25 && _5x13 == 11)
                    {
                        _5x13 = 5;
                    }
                    else if (bosscell == 26 && _5x15 == 11)
                    {
                        _5x15 = 5;
                    }
                    else if (bosscell == 27 && _5x17 == 11)
                    {
                        _5x17 = 5;
                    }
                    else if (bosscell == 28 && _7x1 == 11)
                    {
                        _7x1 = 5;
                    }
                    else if (bosscell == 29 && _7x3 == 11)
                    {
                        _7x3 = 5;
                    }
                    else if (bosscell == 30 && _7x5 == 11)
                    {
                        _7x5 = 5;
                    }
                    else if (bosscell == 31 && _7x7 == 11)
                    {
                        _7x7 = 5;
                    }
                    else if (bosscell == 32 && _7x9 == 11)
                    {
                        _7x9 = 5;
                    }
                    else if (bosscell == 33 && _7x11 == 11)
                    {
                        _7x11 = 5;
                    }
                    else if (bosscell == 34 && _7x13 == 11)
                    {
                        _7x13 = 5;
                    }
                    else if (bosscell == 35 && _7x15 == 11)
                    {
                        _7x15 = 5;
                    }
                    else if (bosscell == 36 && _7x17 == 11)
                    {
                        _7x17 = 5;
                    }
                }

                if (_1x1 != 13 && _1x3 != 13 && _1x5 != 13 && _1x7 != 13 && _1x9 != 13 && _1x11 != 13 && _1x13 != 13 && _1x15 != 13 && _1x17 != 13 && _3x1 != 13 && _3x3 != 13 && _3x5 != 13 && _3x7 != 13 && _3x9 != 13 && _3x11 != 13 && _3x13 != 13 && _3x15 != 13 && _3x17 != 13 && _5x1 != 13 && _5x3 != 13 && _5x5 != 13 && _5x7 != 13 && _5x9 != 13 && _5x11 != 13 && _5x13 != 13 && _5x15 != 13 && _5x17 != 13 && _7x1 != 13 && _7x3 != 13 && _7x5 != 13 && _7x7 != 13 && _7x9 != 13 && _7x11 != 13 && _7x13 != 13 && _7x15 != 13 && _7x17 != 13)
                {
                    ranoutstr = random.Next(1, 36);

                    if (ranoutstr == 1 && _1x1 == 11)
                    {
                        _1x1 = 13;
                        ranoutstr = 50;
                    }
                    if (ranoutstr == 2 && _1x3 == 11)
                    {
                        _1x3 = 13;
                        ranoutstr = 50;
                    }
                    if (ranoutstr == 3 && _1x5 == 11)
                    {
                        _1x5 = 13;
                        ranoutstr = 50;
                    }
                    if (ranoutstr == 4 && _1x7 == 11)
                    {
                        _1x7 = 13;
                        ranoutstr = 50;
                    }
                    if (ranoutstr == 5 && _1x9 == 11)
                    {
                        _1x9 = 13;
                        ranoutstr = 50;
                    }
                    if (ranoutstr == 6 && _1x11 == 11)
                    {
                        _1x11 = 13;
                        ranoutstr = 50;
                    }
                    if (ranoutstr == 7 && _1x13 == 11)
                    {
                        _1x13 = 13;
                        ranoutstr = 50;
                    }
                    if (ranoutstr == 8 && _1x15 == 11)
                    {
                        _1x15 = 13;
                        ranoutstr = 50;
                    }
                    if (ranoutstr == 9 && _1x17 == 11)
                    {
                        _1x17 = 13;
                        ranoutstr = 50;
                    }
                    if (ranoutstr == 10 && _3x1 == 11)
                    {
                        _3x1 = 13;
                        ranoutstr = 50;
                    }
                    if (ranoutstr == 11 && _3x3 == 11)
                    {
                        _3x3 = 13;
                        ranoutstr = 50;
                    }
                    if (ranoutstr == 12 && _3x5 == 11)
                    {
                        _3x5 = 13;
                        ranoutstr = 50;
                    }
                    if (ranoutstr == 13 && _3x7 == 11)
                    {
                        _3x7 = 13;
                        ranoutstr = 50;
                    }
                    if (ranoutstr == 14 && _3x9 == 11)
                    {
                        _3x9 = 13;
                        ranoutstr = 50;
                    }
                    if (ranoutstr == 15 && _3x11 == 11)
                    {
                        _3x11 = 13;
                        ranoutstr = 50;
                    }
                    if (ranoutstr == 16 && _3x13 == 11)
                    {
                        _3x13 = 13;
                        ranoutstr = 50;
                    }
                    if (ranoutstr == 17 && _3x15 == 11)
                    {
                        _3x15 = 13;
                        ranoutstr = 50;
                    }
                    if (ranoutstr == 18 && _3x17 == 11)
                    {
                        _3x17 = 13;
                        ranoutstr = 50;
                    }
                    if (ranoutstr == 19 && _5x1 == 11)
                    {
                        _5x1 = 13;
                        ranoutstr = 50;
                    }
                    if (ranoutstr == 20 && _5x3 == 11)
                    {
                        _5x3 = 13;
                        ranoutstr = 50;
                    }
                    if (ranoutstr == 21 && _5x5 == 11)
                    {
                        _5x5 = 13;
                        ranoutstr = 50;
                    }
                    if (ranoutstr == 22 && _5x7 == 11)
                    {
                        _5x7 = 13;
                        ranoutstr = 50;
                    }
                    if (ranoutstr == 23 && _5x9 == 11)
                    {
                        _5x9 = 13;
                        ranoutstr = 50;
                    }
                    if (ranoutstr == 24 && _5x11 == 11)
                    {
                        _5x11 = 13;
                        ranoutstr = 50;
                    }
                    if (ranoutstr == 25 && _5x13 == 11)
                    {
                        _5x13 = 13;
                        ranoutstr = 50;
                    }
                    if (ranoutstr == 26 && _5x15 == 11)
                    {
                        _5x15 = 13;
                        ranoutstr = 50;
                    }
                    if (ranoutstr == 27 && _5x17 == 11)
                    {
                        _5x17 = 13;
                        ranoutstr = 50;
                    }
                    if (ranoutstr == 28 && _7x1 == 11)
                    {
                        _7x1 = 13;
                        ranoutstr = 50;
                    }
                    if (ranoutstr == 29 && _7x3 == 11)
                    {
                        _7x3 = 13;
                        ranoutstr = 50;
                    }
                    if (ranoutstr == 30 && _7x5 == 11)
                    {
                        _7x5 = 13;
                        ranoutstr = 50;
                    }
                    if (ranoutstr == 31 && _7x7 == 11)
                    {
                        _7x7 = 13;
                        ranoutstr = 50;
                    }
                    if (ranoutstr == 32 && _7x9 == 11)
                    {
                        _7x9 = 13;
                        ranoutstr = 50;
                    }
                    if (ranoutstr == 33 && _7x11 == 11)
                    {
                        _7x11 = 13;
                        ranoutstr = 50;
                    }
                    if (ranoutstr == 34 && _7x13 == 11)
                    {
                        _7x13 = 13;
                        ranoutstr = 50;
                    }
                    if (ranoutstr == 35 && _7x15 == 11)
                    {
                        _7x15 = 13;
                        ranoutstr = 50;
                    }
                    if (ranoutstr == 36 && _7x17 == 11)
                    {
                        _7x17 = 13;
                        ranoutstr = 50;
                    }
                }
                if ((_1x1 == 5 || _1x3 == 5 || _1x5 == 5 || _1x7 == 5 || _1x9 == 5 || _1x11 == 5 || _1x13 == 5 || _1x15 == 5 || _1x17 == 5 || _3x1 == 5 || _3x3 == 5 || _3x5 == 5 || _3x7 == 5 || _3x9 == 5 || _3x11 == 5 || _3x13 == 5 || _3x15 == 5 || _3x17 == 5 || _5x1 == 5 || _5x3 == 5 || _5x5 == 5 || _5x7 == 5 || _5x9 == 5 || _5x11 == 5 || _5x13 == 5 || _5x15 == 5 || _5x17 == 5 || _7x1 == 5 || _7x3 == 5 || _7x5 == 5 || _7x7 == 5 || _7x9 == 5 || _7x11 == 5 || _7x13 == 5 || _7x15 == 5 || _7x17 == 5) && (_1x1 == 13 || _1x3 == 13 || _1x5 == 13 || _1x7 == 13 || _1x9 == 13 || _1x11 == 13 || _1x13 == 13 || _1x15 == 13 || _1x17 == 13 || _3x1 == 13 || _3x3 == 13 || _3x5 == 13 || _3x7 == 13 || _3x9 == 13 || _3x11 == 13 || _3x13 == 13 || _3x15 == 13 || _3x17 == 13 || _5x1 == 13 || _5x3 == 13 || _5x5 == 13 || _5x7 == 13 || _5x9 == 13 || _5x11 == 13 || _5x13 == 13 || _5x15 == 13 || _5x17 == 13 || _7x1 == 13 || _7x3 == 13 || _7x5 == 13 || _7x7 == 13 || _7x9 == 13 || _7x11 == 13 || _7x13 == 13 || _7x15 == 13 || _7x17 == 13))
                {
                    population1 = false;
                    //remove later
                    //population = false;
                    //save = true;
                    //genloop = false;
                }
            }

            if (_1x1 == 11)
            {
                int ranout = random.Next(1, 100);
                int ranout2 = random.Next(1, 99);
                if (ranout <= 45)
                {
                    _1x1 = 3;
                }
                if (ranout >= 46 && ranout <= 65)
                {
                    if (ranout2 <= 49)
                    {
                        _1x1 = 4;
                    }
                    if (ranout2 >= 50)
                    {
                        _1x1 = 6;
                    }
                }
                if (ranout >= 66)
                {
                    _1x1 = 11;
                }
            }
            if (_1x3 == 11)
            {
                int ranout = random.Next(1, 100);
                int ranout2 = random.Next(1, 99);
                if (ranout <= 45)
                {
                    _1x3 = 3;
                }
                if (ranout >= 46 && ranout <= 65)
                {
                    if (ranout2 <= 49)
                    {
                        _1x3 = 4;
                    }
                    if (ranout2 >= 50)
                    {
                        _1x3 = 6;
                    }
                }
                if (ranout >= 66)
                {
                    _1x3 = 11;
                }
            }
            if (_1x5 == 11)
            {
                int ranout = random.Next(1, 100);
                int ranout2 = random.Next(1, 99);
                if (ranout <= 45)
                {
                    _1x5 = 3;
                }
                if (ranout >= 46 && ranout <= 65)
                {
                    if (ranout2 <= 49)
                    {
                        _1x5 = 4;
                    }
                    if (ranout2 >= 50)
                    {
                        _1x5 = 6;
                    }
                }
                if (ranout >= 66)
                {
                    _1x5 = 11;
                }
            }
            if (_1x7 == 11)
            {
                int ranout = random.Next(1, 100);
                int ranout2 = random.Next(1, 99);
                if (ranout <= 45)
                {
                    _1x7 = 3;
                }
                if (ranout >= 46 && ranout <= 65)
                {
                    if (ranout2 <= 49)
                    {
                        _1x7 = 4;
                    }
                    if (ranout2 >= 50)
                    {
                        _1x7 = 6;
                    }
                }
                if (ranout >= 66)
                {
                    _1x7 = 11;
                }
            }
            if (_1x9 == 11)
            {
                int ranout = random.Next(1, 100);
                int ranout2 = random.Next(1, 99);
                if (ranout <= 45)
                {
                    _1x9 = 3;
                }
                if (ranout >= 46 && ranout <= 65)
                {
                    if (ranout2 <= 49)
                    {
                        _1x9 = 4;
                    }
                    if (ranout2 >= 50)
                    {
                        _1x9 = 6;
                    }
                }
                if (ranout >= 66)
                {
                    _1x9 = 11;
                }
            }
            if (_1x11 == 11)
            {
                int ranout = random.Next(1, 100);
                int ranout2 = random.Next(1, 99);
                if (ranout <= 45)
                {
                    _1x11 = 3;
                }
                if (ranout >= 46 && ranout <= 65)
                {
                    if (ranout2 <= 49)
                    {
                        _1x11 = 4;
                    }
                    if (ranout2 >= 50)
                    {
                        _1x11 = 6;
                    }
                }
                if (ranout >= 66)
                {
                    _1x11 = 11;
                }
            }
            if (_1x13 == 11)
            {
                int ranout = random.Next(1, 100);
                int ranout2 = random.Next(1, 99);
                if (ranout <= 45)
                {
                    _1x13 = 3;
                }
                if (ranout >= 46 && ranout <= 65)
                {
                    if (ranout2 <= 49)
                    {
                        _1x13 = 4;
                    }
                    if (ranout2 >= 50)
                    {
                        _1x13 = 6;
                    }
                }
                if (ranout >= 66)
                {
                    _1x13 = 11;
                }
            }
            if (_1x15 == 11)
            {
                int ranout = random.Next(1, 100);
                int ranout2 = random.Next(1, 99);
                if (ranout <= 45)
                {
                    _1x15 = 3;
                }
                if (ranout >= 46 && ranout <= 65)
                {
                    if (ranout2 <= 49)
                    {
                        _1x15 = 4;
                    }
                    if (ranout2 >= 50)
                    {
                        _1x15 = 6;
                    }
                }
                if (ranout >= 66)
                {
                    _1x15 = 11;
                }
            }
            if (_1x17 == 11)
            {
                int ranout = random.Next(1, 100);
                int ranout2 = random.Next(1, 99);
                if (ranout <= 45)
                {
                    _1x17 = 3;
                }
                if (ranout >= 46 && ranout <= 65)
                {
                    if (ranout2 <= 49)
                    {
                        _1x17 = 4;
                    }
                    if (ranout2 >= 50)
                    {
                        _1x17 = 6;
                    }
                }
                if (ranout >= 66)
                {
                    _1x17 = 11;
                }
            }
            if (_3x1 == 11)
            {
                int ranout = random.Next(1, 100);
                int ranout2 = random.Next(1, 99);
                if (ranout <= 45)
                {
                    _3x1 = 3;
                }
                if (ranout >= 46 && ranout <= 65)
                {
                    if (ranout2 <= 49)
                    {
                        _3x1 = 4;
                    }
                    if (ranout2 >= 50)
                    {
                        _3x1 = 6;
                    }
                }
                if (ranout >= 66)
                {
                    _3x1 = 11;
                }
            }
            if (_3x3 == 11)
            {
                int ranout = random.Next(1, 100);
                int ranout2 = random.Next(1, 99);
                if (ranout <= 45)
                {
                    _3x3 = 3;
                }
                if (ranout >= 46 && ranout <= 65)
                {
                    if (ranout2 <= 49)
                    {
                        _3x3 = 4;
                    }
                    if (ranout2 >= 50)
                    {
                        _3x3 = 6;
                    }
                }
                if (ranout >= 66)
                {
                    _3x3 = 11;
                }
            }
            if (_3x5 == 11)
            {
                int ranout = random.Next(1, 100);
                int ranout2 = random.Next(1, 99);
                if (ranout <= 45)
                {
                    _3x5 = 3;
                }
                if (ranout >= 46 && ranout <= 65)
                {
                    if (ranout2 <= 49)
                    {
                        _3x5 = 4;
                    }
                    if (ranout2 >= 50)
                    {
                        _3x5 = 6;
                    }
                }
                if (ranout >= 66)
                {
                    _3x5 = 11;
                }
            }
            if (_3x7 == 11)
            {
                int ranout = random.Next(1, 100);
                int ranout2 = random.Next(1, 99);
                if (ranout <= 45)
                {
                    _3x7 = 3;
                }
                if (ranout >= 46 && ranout <= 65)
                {
                    if (ranout2 <= 49)
                    {
                        _3x7 = 4;
                    }
                    if (ranout2 >= 50)
                    {
                        _3x7 = 6;
                    }
                }
                if (ranout >= 66)
                {
                    _3x7 = 11;
                }
            }
            if (_3x9 == 11)
            {
                int ranout = random.Next(1, 100);
                int ranout2 = random.Next(1, 99);
                if (ranout <= 45)
                {
                    _3x9 = 3;
                }
                if (ranout >= 46 && ranout <= 65)
                {
                    if (ranout2 <= 49)
                    {
                        _3x9 = 4;
                    }
                    if (ranout2 >= 50)
                    {
                        _3x9 = 6;
                    }
                }
                if (ranout >= 66)
                {
                    _3x9 = 11;
                }
            }
            if (_3x11 == 11)
            {
                int ranout = random.Next(1, 100);
                int ranout2 = random.Next(1, 99);
                if (ranout <= 45)
                {
                    _3x11 = 3;
                }
                if (ranout >= 46 && ranout <= 65)
                {
                    if (ranout2 <= 49)
                    {
                        _3x11 = 4;
                    }
                    if (ranout2 >= 50)
                    {
                        _3x11 = 6;
                    }
                }
                if (ranout >= 66)
                {
                    _3x11 = 11;
                }
            }
            if (_3x13 == 11)
            {
                int ranout = random.Next(1, 100);
                int ranout2 = random.Next(1, 99);
                if (ranout <= 45)
                {
                    _3x13 = 3;
                }
                if (ranout >= 46 && ranout <= 65)
                {
                    if (ranout2 <= 49)
                    {
                        _3x13 = 4;
                    }
                    if (ranout2 >= 50)
                    {
                        _3x13 = 6;
                    }
                }
                if (ranout >= 66)
                {
                    _3x13 = 11;
                }
            }
            if (_3x15 == 11)
            {
                int ranout = random.Next(1, 100);
                int ranout2 = random.Next(1, 99);
                if (ranout <= 45)
                {
                    _3x15 = 3;
                }
                if (ranout >= 46 && ranout <= 65)
                {
                    if (ranout2 <= 49)
                    {
                        _3x15 = 4;
                    }
                    if (ranout2 >= 50)
                    {
                        _3x15 = 6;
                    }
                }
                if (ranout >= 66)
                {
                    _3x15 = 11;
                }
            }
            if (_3x17 == 11)
            {
                int ranout = random.Next(1, 100);
                int ranout2 = random.Next(1, 99);
                if (ranout <= 45)
                {
                    _3x17 = 3;
                }
                if (ranout >= 46 && ranout <= 65)
                {
                    if (ranout2 <= 49)
                    {
                        _3x17 = 4;
                    }
                    if (ranout2 >= 50)
                    {
                        _3x17 = 6;
                    }
                }
                if (ranout >= 66)
                {
                    _3x17 = 11;
                }
            }
            if (_5x1 == 11)
            {
                int ranout = random.Next(1, 100);
                int ranout2 = random.Next(1, 99);
                if (ranout <= 45)
                {
                    _5x1 = 3;
                }
                if (ranout >= 46 && ranout <= 65)
                {
                    if (ranout2 <= 49)
                    {
                        _5x1 = 4;
                    }
                    if (ranout2 >= 50)
                    {
                        _5x1 = 6;
                    }
                }
                if (ranout >= 66)
                {
                    _5x1 = 11;
                }
            }
            if (_5x3 == 11)
            {
                int ranout = random.Next(1, 100);
                int ranout2 = random.Next(1, 99);
                if (ranout <= 45)
                {
                    _5x3 = 3;
                }
                if (ranout >= 46 && ranout <= 65)
                {
                    if (ranout2 <= 49)
                    {
                        _5x3 = 4;
                    }
                    if (ranout2 >= 50)
                    {
                        _5x3 = 6;
                    }
                }
                if (ranout >= 66)
                {
                    _5x3 = 11;
                }
            }
            if (_5x5 == 11)
            {
                int ranout = random.Next(1, 100);
                int ranout2 = random.Next(1, 99);
                if (ranout <= 45)
                {
                    _5x5 = 3;
                }
                if (ranout >= 46 && ranout <= 65)
                {
                    if (ranout2 <= 49)
                    {
                        _5x5 = 4;
                    }
                    if (ranout2 >= 50)
                    {
                        _5x5 = 6;
                    }
                }
                if (ranout >= 66)
                {
                    _5x5 = 11;
                }
            }
            if (_5x7 == 11)
            {
                int ranout = random.Next(1, 100);
                int ranout2 = random.Next(1, 99);
                if (ranout <= 45)
                {
                    _5x7 = 3;
                }
                if (ranout >= 46 && ranout <= 65)
                {
                    if (ranout2 <= 49)
                    {
                        _5x7 = 4;
                    }
                    if (ranout2 >= 50)
                    {
                        _5x7 = 6;
                    }
                }
                if (ranout >= 66)
                {
                    _5x7 = 11;
                }
            }
            if (_5x9 == 11)
            {
                int ranout = random.Next(1, 100);
                int ranout2 = random.Next(1, 99);
                if (ranout <= 45)
                {
                    _5x9 = 3;
                }
                if (ranout >= 46 && ranout <= 65)
                {
                    if (ranout2 <= 49)
                    {
                        _5x9 = 4;
                    }
                    if (ranout2 >= 50)
                    {
                        _5x9 = 6;
                    }
                }
                if (ranout >= 66)
                {
                    _5x9 = 11;
                }
            }
            if (_5x11 == 11)
            {
                int ranout = random.Next(1, 100);
                int ranout2 = random.Next(1, 99);
                if (ranout <= 45)
                {
                    _5x11 = 3;
                }
                if (ranout >= 46 && ranout <= 65)
                {
                    if (ranout2 <= 49)
                    {
                        _5x11 = 4;
                    }
                    if (ranout2 >= 50)
                    {
                        _5x11 = 6;
                    }
                }
                if (ranout >= 66)
                {
                    _5x11 = 11;
                }
            }
            if (_5x13 == 11)
            {
                int ranout = random.Next(1, 100);
                int ranout2 = random.Next(1, 99);
                if (ranout <= 45)
                {
                    _5x13 = 3;
                }
                if (ranout >= 46 && ranout <= 65)
                {
                    if (ranout2 <= 49)
                    {
                        _5x13 = 4;
                    }
                    if (ranout2 >= 50)
                    {
                        _5x13 = 6;
                    }
                }
                if (ranout >= 66)
                {
                    _5x13 = 11;
                }
            }
            if (_5x15 == 11)
            {
                int ranout = random.Next(1, 100);
                int ranout2 = random.Next(1, 99);
                if (ranout <= 45)
                {
                    _5x15 = 3;
                }
                if (ranout >= 46 && ranout <= 65)
                {
                    if (ranout2 <= 49)
                    {
                        _5x15 = 4;
                    }
                    if (ranout2 >= 50)
                    {
                        _5x15 = 6;
                    }
                }
                if (ranout >= 66)
                {
                    _5x15 = 11;
                }
            }
            if (_5x17 == 11)
            {
                int ranout = random.Next(1, 100);
                int ranout2 = random.Next(1, 99);
                if (ranout <= 45)
                {
                    _5x17 = 3;
                }
                if (ranout >= 46 && ranout <= 65)
                {
                    if (ranout2 <= 49)
                    {
                        _5x17 = 4;
                    }
                    if (ranout2 >= 50)
                    {
                        _5x17 = 6;
                    }
                }
                if (ranout >= 66)
                {
                    _5x17 = 11;
                }
            }
            if (_7x1 == 11)
            {
                int ranout = random.Next(1, 100);
                int ranout2 = random.Next(1, 99);
                if (ranout <= 45)
                {
                    _7x1 = 3;
                }
                if (ranout >= 46 && ranout <= 65)
                {
                    if (ranout2 <= 49)
                    {
                        _7x1 = 4;
                    }
                    if (ranout2 >= 50)
                    {
                        _7x1 = 6;
                    }
                }
                if (ranout >= 66)
                {
                    _7x1 = 11;
                }
            }
            if (_7x3 == 11)
            {
                int ranout = random.Next(1, 100);
                int ranout2 = random.Next(1, 99);
                if (ranout <= 45)
                {
                    _7x3 = 3;
                }
                if (ranout >= 46 && ranout <= 65)
                {
                    if (ranout2 <= 49)
                    {
                        _7x3 = 4;
                    }
                    if (ranout2 >= 50)
                    {
                        _7x3 = 6;
                    }
                }
                if (ranout >= 66)
                {
                    _7x3 = 11;
                }
            }
            if (_7x5 == 11)
            {
                int ranout = random.Next(1, 100);
                int ranout2 = random.Next(1, 99);
                if (ranout <= 45)
                {
                    _7x5 = 3;
                }
                if (ranout >= 46 && ranout <= 65)
                {
                    if (ranout2 <= 49)
                    {
                        _7x5 = 4;
                    }
                    if (ranout2 >= 50)
                    {
                        _7x5 = 6;
                    }
                }
                if (ranout >= 66)
                {
                    _7x5 = 11;
                }
            }
            if (_7x7 == 11)
            {
                int ranout = random.Next(1, 100);
                int ranout2 = random.Next(1, 99);
                if (ranout <= 45)
                {
                    _7x7 = 3;
                }
                if (ranout >= 46 && ranout <= 65)
                {
                    if (ranout2 <= 49)
                    {
                        _7x7 = 4;
                    }
                    if (ranout2 >= 50)
                    {
                        _7x7 = 6;
                    }
                }
                if (ranout >= 66)
                {
                    _7x7 = 11;
                }
            }
            if (_7x9 == 11)
            {
                int ranout = random.Next(1, 100);
                int ranout2 = random.Next(1, 99);
                if (ranout <= 45)
                {
                    _7x9 = 3;
                }
                if (ranout >= 46 && ranout <= 65)
                {
                    if (ranout2 <= 49)
                    {
                        _7x9 = 4;
                    }
                    if (ranout2 >= 50)
                    {
                        _7x9 = 6;
                    }
                }
                if (ranout >= 66)
                {
                    _7x9 = 11;
                }
            }
            if (_7x11 == 11)
            {
                int ranout = random.Next(1, 100);
                int ranout2 = random.Next(1, 99);
                if (ranout <= 45)
                {
                    _7x11 = 3;
                }
                if (ranout >= 46 && ranout <= 65)
                {
                    if (ranout2 <= 49)
                    {
                        _7x11 = 4;
                    }
                    if (ranout2 >= 50)
                    {
                        _7x11 = 6;
                    }
                }
                if (ranout >= 66)
                {
                    _7x11 = 11;
                }
            }
            if (_7x13 == 11)
            {
                int ranout = random.Next(1, 100);
                int ranout2 = random.Next(1, 99);
                if (ranout <= 45)
                {
                    _7x13 = 3;
                }
                if (ranout >= 46 && ranout <= 65)
                {
                    if (ranout2 <= 49)
                    {
                        _7x13 = 4;
                    }
                    if (ranout2 >= 50)
                    {
                        _7x13 = 6;
                    }
                }
                if (ranout >= 66)
                {
                    _7x13 = 11;
                }
            }
            if (_7x15 == 11)
            {
                int ranout = random.Next(1, 100);
                int ranout2 = random.Next(1, 99);
                if (ranout <= 45)
                {
                    _7x15 = 3;
                }
                if (ranout >= 46 && ranout <= 65)
                {
                    if (ranout2 <= 49)
                    {
                        _7x15 = 4;
                    }
                    if (ranout2 >= 50)
                    {
                        _7x15 = 6;
                    }
                }
                if (ranout >= 66)
                {
                    _7x15 = 11;
                }
            }
            if (_7x17 == 11)
            {
                int ranout = random.Next(1, 100);
                int ranout2 = random.Next(1, 99);
                if (ranout <= 45)
                {
                    _7x17 = 3;
                }
                if (ranout >= 46 && ranout <= 65)
                {
                    if (ranout2 <= 49)
                    {
                        _7x17 = 4;
                    }
                    if (ranout2 >= 50)
                    {
                        _7x17 = 6;
                    }
                }
                if (ranout >= 66)
                {
                    _7x17 = 11;
                }
            }

            population = false;
            save = true;
            genloop = false;

        }
        if (generror == 50)
        {
            eventstate = 1;
            gameloop = false;
            genloop = true;
            genreset = true;
            population1 = true;
            cellgen = true;
            rendermap = false;
            startcell = true;
        }
        generror++;
    }

    while (save)
    {
        if (saveloaded == 1)
        {
            tempfilepath = filepath;
        }
        else if (saveloaded == 2)
        {
            tempfilepath = filepath1;
        }
        else if (saveloaded == 3)
        {
            tempfilepath = filepath2;
        }
        using (StreamWriter writetext = new StreamWriter(tempfilepath))
        {
            writetext.Write("");
        }
        System.IO.File.AppendAllText(tempfilepath, string.Format("{0}{1}{2}{3}{4}{5}{6}{7}{8}{9}",
            "health:" + set1 + "\n", "gold__:" + set2 + "\n", "exp___:" + set3 + "\n", "kills_:" + set4 + "\n", "floor_:" + set5 + "\n", "Empty_:" + set6 + "\n", "Empty_:" + set7 + "\n", "Empty_:" + set8 + "\n", "Empty_:" + set9 + "\n",
            "slot1_:" + slot1 + "\n"));
        int[] strcoords = new int[] { _1x1, _1x2, _1x3, _1x4, _1x5, _1x6, _1x7, _1x8, _1x9, _1x10, _1x11, _1x12, _1x13, _1x14, _1x15, _1x16, _1x17, _2x1, _2x2, _2x3, _2x4, _2x5, _2x6, _2x7, _2x8, _2x9, _3x1, _3x2, _3x3, _3x4, _3x5, _3x6, _3x7, _3x8, _3x9, _3x10, _3x11, _3x12, _3x13, _3x14, _3x15, _3x16, _3x17, _4x1, _4x2, _4x3, _4x4, _4x5, _4x6, _4x7, _4x8, _4x9, _5x1, _5x2, _5x3, _5x4, _5x5, _5x6, _5x7, _5x8, _5x9, _5x10, _5x11, _5x12, _5x13, _5x14, _5x15, _5x16, _5x17, _6x1, _6x2, _6x3, _6x4, _6x5, _6x6, _6x7, _6x8, _6x9, _7x1, _7x2, _7x3, _7x4, _7x5, _7x6, _7x7, _7x8, _7x9, _7x10, _7x11, _7x12, _7x13, _7x14, _7x15, _7x16, _7x17 };
        foreach (int i in strcoords)
        {
            System.IO.File.AppendAllText(tempfilepath, string.Format("{0}", "stagen:" + i + "\n"));
        }
        if (savestate == 1)
        {
            logo = true;
            save = false;
        }
        else if (savestate == 2)
        {
            mainmenu = true;
            save = false;
        }
        else if (savestate == 3)
        {
            mainmenuloop = true;
            savemain = true;
            save = false;
        }
        else if (savestate == 4)
        {
            //never use this for anything
            save = false;
        }
        else if (savestate == 5)
        {
            gameloop = true;
            rendermap = true;
            save = false;
        }
        else
        {
            Console.WriteLine("Error 3");
        }
        Console.WriteLine("Save Saved");
        System.Threading.Thread.Sleep(100);
    }

    while (gameloop) //main game loop st 5
    {

        if (set1 <= 0)
        {
            Console.Clear();
            Console.WriteLine("Game Over");
            System.Threading.Thread.Sleep(5000);
            Environment.Exit(0);
        }

        while (rendermap)
        {
            // reseting rendering
            string _1x1topcell = "         ";
            string _1x2topcell = "         ";
            string _1x3topcell = "         ";
            string _1x4topcell = "         ";
            string _1x5topcell = "         ";
            string _1x6topcell = "         ";
            string _1x7topcell = "         ";
            string _1x8topcell = "         ";
            string _1x9topcell = "         ";
            string _2x1topcell = "         ";
            string _2x2topcell = "         ";
            string _2x3topcell = "         ";
            string _2x4topcell = "         ";
            string _2x5topcell = "         ";
            string _2x6topcell = "         ";
            string _2x7topcell = "         ";
            string _2x8topcell = "         ";
            string _2x9topcell = "         ";
            string _3x1topcell = "         ";
            string _3x2topcell = "         ";
            string _3x3topcell = "         ";
            string _3x4topcell = "         ";
            string _3x5topcell = "         ";
            string _3x6topcell = "         ";
            string _3x7topcell = "         ";
            string _3x8topcell = "         ";
            string _3x9topcell = "         ";
            string _4x1topcell = "         ";
            string _4x2topcell = "         ";
            string _4x3topcell = "         ";
            string _4x4topcell = "         ";
            string _4x5topcell = "         ";
            string _4x6topcell = "         ";
            string _4x7topcell = "         ";
            string _4x8topcell = "         ";
            string _4x9topcell = "         ";
            string _1x1botcell = "         ";
            string _1x2botcell = "         ";
            string _1x3botcell = "         ";
            string _1x4botcell = "         ";
            string _1x5botcell = "         ";
            string _1x6botcell = "         ";
            string _1x7botcell = "         ";
            string _1x8botcell = "         ";
            string _1x9botcell = "         ";
            string _2x1botcell = "         ";
            string _2x2botcell = "         ";
            string _2x3botcell = "         ";
            string _2x4botcell = "         ";
            string _2x5botcell = "         ";
            string _2x6botcell = "         ";
            string _2x7botcell = "         ";
            string _2x8botcell = "         ";
            string _2x9botcell = "         ";
            string _3x1botcell = "         ";
            string _3x2botcell = "         ";
            string _3x3botcell = "         ";
            string _3x4botcell = "         ";
            string _3x5botcell = "         ";
            string _3x6botcell = "         ";
            string _3x7botcell = "         ";
            string _3x8botcell = "         ";
            string _3x9botcell = "         ";
            string _4x1botcell = "         ";
            string _4x2botcell = "         ";
            string _4x3botcell = "         ";
            string _4x4botcell = "         ";
            string _4x5botcell = "         ";
            string _4x6botcell = "         ";
            string _4x7botcell = "         ";
            string _4x8botcell = "         ";
            string _4x9botcell = "         ";
            string _1x1sidecell = " ";
            string _1x2sidecell = " ";
            string _1x3sidecell = " ";
            string _1x4sidecell = " ";
            string _1x5sidecell = " ";
            string _1x6sidecell = " ";
            string _1x7sidecell = " ";
            string _1x8sidecell = " ";
            string _1x9sidecell = " ";
            string _2x1sidecell = " ";
            string _2x2sidecell = " ";
            string _2x3sidecell = " ";
            string _2x4sidecell = " ";
            string _2x5sidecell = " ";
            string _2x6sidecell = " ";
            string _2x7sidecell = " ";
            string _2x8sidecell = " ";
            string _2x9sidecell = " ";
            string _3x1sidecell = " ";
            string _3x2sidecell = " ";
            string _3x3sidecell = " ";
            string _3x4sidecell = " ";
            string _3x5sidecell = " ";
            string _3x6sidecell = " ";
            string _3x7sidecell = " ";
            string _3x8sidecell = " ";
            string _3x9sidecell = " ";
            string _4x1sidecell = " ";
            string _4x2sidecell = " ";
            string _4x3sidecell = " ";
            string _4x4sidecell = " ";
            string _4x5sidecell = " ";
            string _4x6sidecell = " ";
            string _4x7sidecell = " ";
            string _4x8sidecell = " ";
            string _4x9sidecell = " ";
            string _1x1bodycell = "   ";
            string _1x2bodycell = "   ";
            string _1x3bodycell = "   ";
            string _1x4bodycell = "   ";
            string _1x5bodycell = "   ";
            string _1x6bodycell = "   ";
            string _1x7bodycell = "   ";
            string _1x8bodycell = "   ";
            string _1x9bodycell = "   ";
            string _2x1bodycell = "   ";
            string _2x2bodycell = "   ";
            string _2x3bodycell = "   ";
            string _2x4bodycell = "   ";
            string _2x5bodycell = "   ";
            string _2x6bodycell = "   ";
            string _2x7bodycell = "   ";
            string _2x8bodycell = "   ";
            string _2x9bodycell = "   ";
            string _3x1bodycell = "   ";
            string _3x2bodycell = "   ";
            string _3x3bodycell = "   ";
            string _3x4bodycell = "   ";
            string _3x5bodycell = "   ";
            string _3x6bodycell = "   ";
            string _3x7bodycell = "   ";
            string _3x8bodycell = "   ";
            string _3x9bodycell = "   ";
            string _4x1bodycell = "   ";
            string _4x2bodycell = "   ";
            string _4x3bodycell = "   ";
            string _4x4bodycell = "   ";
            string _4x5bodycell = "   ";
            string _4x6bodycell = "   ";
            string _4x7bodycell = "   ";
            string _4x8bodycell = "   ";
            string _4x9bodycell = "   ";
            string _1x1iconcell = " ";
            string _1x2iconcell = " ";
            string _1x3iconcell = " ";
            string _1x4iconcell = " ";
            string _1x5iconcell = " ";
            string _1x6iconcell = " ";
            string _1x7iconcell = " ";
            string _1x8iconcell = " ";
            string _1x9iconcell = " ";
            string _2x1iconcell = " ";
            string _2x2iconcell = " ";
            string _2x3iconcell = " ";
            string _2x4iconcell = " ";
            string _2x5iconcell = " ";
            string _2x6iconcell = " ";
            string _2x7iconcell = " ";
            string _2x8iconcell = " ";
            string _2x9iconcell = " ";
            string _3x1iconcell = " ";
            string _3x2iconcell = " ";
            string _3x3iconcell = " ";
            string _3x4iconcell = " ";
            string _3x5iconcell = " ";
            string _3x6iconcell = " ";
            string _3x7iconcell = " ";
            string _3x8iconcell = " ";
            string _3x9iconcell = " ";
            string _4x1iconcell = " ";
            string _4x2iconcell = " ";
            string _4x3iconcell = " ";
            string _4x4iconcell = " ";
            string _4x5iconcell = " ";
            string _4x6iconcell = " ";
            string _4x7iconcell = " ";
            string _4x8iconcell = " ";
            string _4x9iconcell = " ";
            string _1x1iconcellb = " ";
            string _1x2iconcellb = " ";
            string _1x3iconcellb = " ";
            string _1x4iconcellb = " ";
            string _1x5iconcellb = " ";
            string _1x6iconcellb = " ";
            string _1x7iconcellb = " ";
            string _1x8iconcellb = " ";
            string _1x9iconcellb = " ";
            string _2x1iconcellb = " ";
            string _2x2iconcellb = " ";
            string _2x3iconcellb = " ";
            string _2x4iconcellb = " ";
            string _2x5iconcellb = " ";
            string _2x6iconcellb = " ";
            string _2x7iconcellb = " ";
            string _2x8iconcellb = " ";
            string _2x9iconcellb = " ";
            string _3x1iconcellb = " ";
            string _3x2iconcellb = " ";
            string _3x3iconcellb = " ";
            string _3x4iconcellb = " ";
            string _3x5iconcellb = " ";
            string _3x6iconcellb = " ";
            string _3x7iconcellb = " ";
            string _3x8iconcellb = " ";
            string _3x9iconcellb = " ";
            string _4x1iconcellb = " ";
            string _4x2iconcellb = " ";
            string _4x3iconcellb = " ";
            string _4x4iconcellb = " ";
            string _4x5iconcellb = " ";
            string _4x6iconcellb = " ";
            string _4x7iconcellb = " ";
            string _4x8iconcellb = " ";
            string _4x9iconcellb = " ";
            string _1x1corivert = " ";
            string _1x2corivert = " ";
            string _1x3corivert = " ";
            string _1x4corivert = " ";
            string _1x5corivert = " ";
            string _1x6corivert = " ";
            string _1x7corivert = " ";
            string _1x8corivert = " ";
            string _1x9corivert = " ";
            string _2x1corivert = " ";
            string _2x2corivert = " ";
            string _2x3corivert = " ";
            string _2x4corivert = " ";
            string _2x5corivert = " ";
            string _2x6corivert = " ";
            string _2x7corivert = " ";
            string _2x8corivert = " ";
            string _2x9corivert = " ";
            string _3x1corivert = " ";
            string _3x2corivert = " ";
            string _3x3corivert = " ";
            string _3x4corivert = " ";
            string _3x5corivert = " ";
            string _3x6corivert = " ";
            string _3x7corivert = " ";
            string _3x8corivert = " ";
            string _3x9corivert = " ";
            string _1x1corihorz = "    ";
            string _1x2corihorz = "    ";
            string _1x3corihorz = "    ";
            string _1x4corihorz = "    ";
            string _1x5corihorz = "    ";
            string _1x6corihorz = "    ";
            string _1x7corihorz = "    ";
            string _1x8corihorz = "    ";
            string _2x1corihorz = "    ";
            string _2x2corihorz = "    ";
            string _2x3corihorz = "    ";
            string _2x4corihorz = "    ";
            string _2x5corihorz = "    ";
            string _2x6corihorz = "    ";
            string _2x7corihorz = "    ";
            string _2x8corihorz = "    ";
            string _3x1corihorz = "    ";
            string _3x2corihorz = "    ";
            string _3x3corihorz = "    ";
            string _3x4corihorz = "    ";
            string _3x5corihorz = "    ";
            string _3x6corihorz = "    ";
            string _3x7corihorz = "    ";
            string _3x8corihorz = "    ";
            string _4x1corihorz = "    ";
            string _4x2corihorz = "    ";
            string _4x3corihorz = "    ";
            string _4x4corihorz = "    ";
            string _4x5corihorz = "    ";
            string _4x6corihorz = "    ";
            string _4x7corihorz = "    ";
            string _4x8corihorz = "    ";


            ////logic for render
            //cells 2
            if (_1x1 == 2)
            {
                _1x1iconcell = "█";
                _1x1iconcellb = "█";
            }
            if (_1x3 == 2)
            {
                _1x2iconcell = "█";
                _1x2iconcellb = "█";
            }
            if (_1x5 == 2)
            {
                _1x3iconcell = "█";
                _1x3iconcellb = "█";
            }
            if (_1x7 == 2)
            {
                _1x4iconcell = "█";
                _1x4iconcellb = "█";
            }
            if (_1x9 == 2)
            {
                _1x5iconcell = "█";
                _1x5iconcellb = "█";
            }
            if (_1x11 == 2)
            {
                _1x6iconcell = "█";
                _1x6iconcellb = "█";
            }
            if (_1x13 == 2)
            {
                _1x7iconcell = "█";
                _1x7iconcellb = "█";
            }
            if (_1x15 == 2)
            {
                _1x8iconcell = "█";
                _1x8iconcellb = "█";
            }
            if (_1x17 == 2)
            {
                _1x9iconcell = "█";
                _1x9iconcellb = "█";
            }
            if (_3x1 == 2)
            {
                _2x1iconcell = "█";
                _2x1iconcellb = "█";
            }
            if (_3x3 == 2)
            {
                _2x2iconcell = "█";
                _2x2iconcellb = "█";
            }
            if (_3x5 == 2)
            {
                _2x3iconcell = "█";
                _2x3iconcellb = "█";
            }
            if (_3x7 == 2)
            {
                _2x4iconcell = "█";
                _2x4iconcellb = "█";
            }
            if (_3x9 == 2)
            {
                _2x5iconcell = "█";
                _2x5iconcellb = "█";
            }
            if (_3x11 == 2)
            {
                _2x6iconcell = "█";
                _2x6iconcellb = "█";
            }
            if (_3x13 == 2)
            {
                _2x7iconcell = "█";
                _2x7iconcellb = "█";
            }
            if (_3x15 == 2)
            {
                _2x8iconcell = "█";
                _2x8iconcellb = "█";
            }
            if (_3x17 == 2)
            {
                _2x9iconcell = "█";
                _2x9iconcellb = "█";
            }
            if (_5x1 == 2)
            {
                _3x1iconcell = "█";
                _3x1iconcellb = "█";
            }
            if (_5x3 == 2)
            {
                _3x2iconcell = "█";
                _3x2iconcellb = "█";
            }
            if (_5x5 == 2)
            {
                _3x3iconcell = "█";
                _3x3iconcellb = "█";
            }
            if (_5x7 == 2)
            {
                _3x4iconcell = "█";
                _3x4iconcellb = "█";
            }
            if (_5x9 == 2)
            {
                _3x5iconcell = "█";
                _3x5iconcellb = "█";
            }
            if (_5x11 == 2)
            {
                _3x6iconcell = "█";
                _3x6iconcellb = "█";
            }
            if (_5x13 == 2)
            {
                _3x7iconcell = "█";
                _3x7iconcellb = "█";
            }
            if (_5x15 == 2)
            {
                _3x8iconcell = "█";
                _3x8iconcellb = "█";
            }
            if (_5x17 == 2)
            {
                _3x9iconcell = "█";
                _3x9iconcellb = "█";
            }
            if (_7x1 == 2)
            {
                _4x1iconcell = "█";
                _4x1iconcellb = "█";
            }
            if (_7x3 == 2)
            {
                _4x2iconcell = "█";
                _4x2iconcellb = "█";
            }
            if (_7x5 == 2)
            {
                _4x3iconcell = "█";
                _4x3iconcellb = "█";
            }
            if (_7x7 == 2)
            {
                _4x4iconcell = "█";
                _4x4iconcellb = "█";
            }
            if (_7x9 == 2)
            {
                _4x5iconcell = "█";
                _4x5iconcellb = "█";
            }
            if (_7x11 == 2)
            {
                _4x6iconcell = "█";
                _4x6iconcellb = "█";
            }
            if (_7x13 == 2)
            {
                _4x7iconcell = "█";
                _4x7iconcellb = "█";
            }
            if (_7x15 == 2)
            {
                _4x8iconcell = "█";
                _4x8iconcellb = "█";
            }
            if (_7x17 == 2)
            {
                _4x9iconcell = "█";
                _4x9iconcellb = "█";
            }
            //cels 3
            if (_1x1 == 3)
            {
                _1x1iconcell = "E";
                _1x1iconcellb = "v";
            }
            if (_1x3 == 3)
            {
                _1x2iconcell = "E";
                _1x2iconcellb = "v";
            }
            if (_1x5 == 3)
            {
                _1x3iconcell = "E";
                _1x3iconcellb = "v";
            }
            if (_1x7 == 3)
            {
                _1x4iconcell = "E";
                _1x4iconcellb = "v";
            }
            if (_1x9 == 3)
            {
                _1x5iconcell = "E";
                _1x5iconcellb = "v";
            }
            if (_1x11 == 3)
            {
                _1x6iconcell = "E";
                _1x6iconcellb = "v";
            }
            if (_1x13 == 3)
            {
                _1x7iconcell = "E";
                _1x7iconcellb = "v";
            }
            if (_1x15 == 3)
            {
                _1x8iconcell = "E";
                _1x8iconcellb = "v";
            }
            if (_1x17 == 3)
            {
                _1x9iconcell = "E";
                _1x9iconcellb = "v";
            }
            if (_3x1 == 3)
            {
                _2x1iconcell = "E";
                _2x1iconcellb = "v";
            }
            if (_3x3 == 3)
            {
                _2x2iconcell = "E";
                _2x2iconcellb = "v";
            }
            if (_3x5 == 3)
            {
                _2x3iconcell = "E";
                _2x3iconcellb = "v";
            }
            if (_3x7 == 3)
            {
                _2x4iconcell = "E";
                _2x4iconcellb = "v";
            }
            if (_3x9 == 3)
            {
                _2x5iconcell = "E";
                _2x5iconcellb = "v";
            }
            if (_3x11 == 3)
            {
                _2x6iconcell = "E";
                _2x6iconcellb = "v";
            }
            if (_3x13 == 3)
            {
                _2x7iconcell = "E";
                _2x7iconcellb = "v";
            }
            if (_3x15 == 3)
            {
                _2x8iconcell = "E";
                _2x8iconcellb = "v";
            }
            if (_3x17 == 3)
            {
                _2x9iconcell = "E";
                _2x9iconcellb = "v";
            }
            if (_5x1 == 3)
            {
                _3x1iconcell = "E";
                _3x1iconcellb = "v";
            }
            if (_5x3 == 3)
            {
                _3x2iconcell = "E";
                _3x2iconcellb = "v";
            }
            if (_5x5 == 3)
            {
                _3x3iconcell = "E";
                _3x3iconcellb = "v";
            }
            if (_5x7 == 3)
            {
                _3x4iconcell = "E";
                _3x4iconcellb = "v";
            }
            if (_5x9 == 3)
            {
                _3x5iconcell = "E";
                _3x5iconcellb = "v";
            }
            if (_5x11 == 3)
            {
                _3x6iconcell = "E";
                _3x6iconcellb = "v";
            }
            if (_5x13 == 3)
            {
                _3x7iconcell = "E";
                _3x7iconcellb = "v";
            }
            if (_5x15 == 3)
            {
                _3x8iconcell = "E";
                _3x8iconcellb = "v";
            }
            if (_5x17 == 3)
            {
                _3x9iconcell = "E";
                _3x9iconcellb = "v";
            }
            if (_7x1 == 3)
            {
                _4x1iconcell = "E";
                _4x1iconcellb = "v";
            }
            if (_7x3 == 3)
            {
                _4x2iconcell = "E";
                _4x2iconcellb = "v";
            }
            if (_7x5 == 3)
            {
                _4x3iconcell = "E";
                _4x3iconcellb = "v";
            }
            if (_7x7 == 3)
            {
                _4x4iconcell = "E";
                _4x4iconcellb = "v";
            }
            if (_7x9 == 3)
            {
                _4x5iconcell = "E";
                _4x5iconcellb = "v";
            }
            if (_7x11 == 3)
            {
                _4x6iconcell = "E";
                _4x6iconcellb = "v";
            }
            if (_7x13 == 3)
            {
                _4x7iconcell = "E";
                _4x7iconcellb = "v";
            }
            if (_7x15 == 3)
            {
                _4x8iconcell = "E";
                _4x8iconcellb = "v";
            }
            if (_7x17 == 3)
            {
                _4x9iconcell = "E";
                _4x9iconcellb = "v";
            }
            //cells 4
            if (_1x1 == 4)
            {
                _1x1iconcell = "%";
                _1x1iconcellb = "v";
            }
            if (_1x3 == 4)
            {
                _1x2iconcell = "%";
                _1x2iconcellb = "v";
            }
            if (_1x5 == 4)
            {
                _1x3iconcell = "%";
                _1x3iconcellb = "v";
            }
            if (_1x7 == 4)
            {
                _1x4iconcell = "%";
                _1x4iconcellb = "v";
            }
            if (_1x9 == 4)
            {
                _1x5iconcell = "%";
                _1x5iconcellb = "v";
            }
            if (_1x11 == 4)
            {
                _1x6iconcell = "%";
                _1x6iconcellb = "v";
            }
            if (_1x13 == 4)
            {
                _1x7iconcell = "%";
                _1x7iconcellb = "v";
            }
            if (_1x15 == 4)
            {
                _1x8iconcell = "%";
                _1x8iconcellb = "v";
            }
            if (_1x17 == 4)
            {
                _1x9iconcell = "%";
                _1x9iconcellb = "v";
            }
            if (_3x1 == 4)
            {
                _2x1iconcell = "%";
                _2x1iconcellb = "v";
            }
            if (_3x3 == 4)
            {
                _2x2iconcell = "%";
                _2x2iconcellb = "v";
            }
            if (_3x5 == 4)
            {
                _2x3iconcell = "%";
                _2x3iconcellb = "v";
            }
            if (_3x7 == 4)
            {
                _2x4iconcell = "%";
                _2x4iconcellb = "v";
            }
            if (_3x9 == 4)
            {
                _2x5iconcell = "%";
                _2x5iconcellb = "v";
            }
            if (_3x11 == 4)
            {
                _2x6iconcell = "%";
                _2x6iconcellb = "v";
            }
            if (_3x13 == 4)
            {
                _2x7iconcell = "%";
                _2x7iconcellb = "v";
            }
            if (_3x15 == 4)
            {
                _2x8iconcell = "%";
                _2x8iconcellb = "v";
            }
            if (_3x17 == 4)
            {
                _2x9iconcell = "%";
                _2x9iconcellb = "v";
            }
            if (_5x1 == 4)
            {
                _3x1iconcell = "%";
                _3x1iconcellb = "v";
            }
            if (_5x3 == 4)
            {
                _3x2iconcell = "%";
                _3x2iconcellb = "v";
            }
            if (_5x5 == 4)
            {
                _3x3iconcell = "%";
                _3x3iconcellb = "v";
            }
            if (_5x7 == 4)
            {
                _3x4iconcell = "%";
                _3x4iconcellb = "v";
            }
            if (_5x9 == 4)
            {
                _3x5iconcell = "%";
                _3x5iconcellb = "v";
            }
            if (_5x11 == 4)
            {
                _3x6iconcell = "%";
                _3x6iconcellb = "v";
            }
            if (_5x13 == 4)
            {
                _3x7iconcell = "%";
                _3x7iconcellb = "v";
            }
            if (_5x15 == 4)
            {
                _3x8iconcell = "%";
                _3x8iconcellb = "v";
            }
            if (_5x17 == 4)
            {
                _3x9iconcell = "%";
                _3x9iconcellb = "v";
            }
            if (_7x1 == 4)
            {
                _4x1iconcell = "%";
                _4x1iconcellb = "v";
            }
            if (_7x3 == 4)
            {
                _4x2iconcell = "%";
                _4x2iconcellb = "v";
            }
            if (_7x5 == 4)
            {
                _4x3iconcell = "%";
                _4x3iconcellb = "v";
            }
            if (_7x7 == 4)
            {
                _4x4iconcell = "%";
                _4x4iconcellb = "v";
            }
            if (_7x9 == 4)
            {
                _4x5iconcell = "%";
                _4x5iconcellb = "v";
            }
            if (_7x11 == 4)
            {
                _4x6iconcell = "%";
                _4x6iconcellb = "v";
            }
            if (_7x13 == 4)
            {
                _4x7iconcell = "%";
                _4x7iconcellb = "v";
            }
            if (_7x15 == 4)
            {
                _4x8iconcell = "%";
                _4x8iconcellb = "v";
            }
            if (_7x17 == 4)
            {
                _4x9iconcell = "%";
                _4x9iconcellb = "v";
            }
            //cells 5
            if (_1x1 == 5)
            {
                _1x1iconcell = "B";
                _1x1iconcellb = "v";
            }
            if (_1x3 == 5)
            {
                _1x2iconcell = "B";
                _1x2iconcellb = "v";
            }
            if (_1x5 == 5)
            {
                _1x3iconcell = "B";
                _1x3iconcellb = "v";
            }
            if (_1x7 == 5)
            {
                _1x4iconcell = "B";
                _1x4iconcellb = "v";
            }
            if (_1x9 == 5)
            {
                _1x5iconcell = "B";
                _1x5iconcellb = "v";
            }
            if (_1x11 == 5)
            {
                _1x6iconcell = "B";
                _1x6iconcellb = "v";
            }
            if (_1x13 == 5)
            {
                _1x7iconcell = "B";
                _1x7iconcellb = "v";
            }
            if (_1x15 == 5)
            {
                _1x8iconcell = "B";
                _1x8iconcellb = "v";
            }
            if (_1x17 == 5)
            {
                _1x9iconcell = "B";
                _1x9iconcellb = "v";
            }
            if (_3x1 == 5)
            {
                _2x1iconcell = "B";
                _2x1iconcellb = "v";
            }
            if (_3x3 == 5)
            {
                _2x2iconcell = "B";
                _2x2iconcellb = "v";
            }
            if (_3x5 == 5)
            {
                _2x3iconcell = "B";
                _2x3iconcellb = "v";
            }
            if (_3x7 == 5)
            {
                _2x4iconcell = "B";
                _2x4iconcellb = "v";
            }
            if (_3x9 == 5)
            {
                _2x5iconcell = "B";
                _2x5iconcellb = "v";
            }
            if (_3x11 == 5)
            {
                _2x6iconcell = "B";
                _2x6iconcellb = "v";
            }
            if (_3x13 == 5)
            {
                _2x7iconcell = "B";
                _2x7iconcellb = "v";
            }
            if (_3x15 == 5)
            {
                _2x8iconcell = "B";
                _2x8iconcellb = "v";
            }
            if (_3x17 == 5)
            {
                _2x9iconcell = "B";
                _2x9iconcellb = "v";
            }
            if (_5x1 == 5)
            {
                _3x1iconcell = "B";
                _3x1iconcellb = "v";
            }
            if (_5x3 == 5)
            {
                _3x2iconcell = "B";
                _3x2iconcellb = "v";
            }
            if (_5x5 == 5)
            {
                _3x3iconcell = "B";
                _3x3iconcellb = "v";
            }
            if (_5x7 == 5)
            {
                _3x4iconcell = "B";
                _3x4iconcellb = "v";
            }
            if (_5x9 == 5)
            {
                _3x5iconcell = "B";
                _3x5iconcellb = "v";
            }
            if (_5x11 == 5)
            {
                _3x6iconcell = "B";
                _3x6iconcellb = "v";
            }
            if (_5x13 == 5)
            {
                _3x7iconcell = "B";
                _3x7iconcellb = "v";
            }
            if (_5x15 == 5)
            {
                _3x8iconcell = "B";
                _3x8iconcellb = "v";
            }
            if (_5x17 == 5)
            {
                _3x9iconcell = "B";
                _3x9iconcellb = "v";
            }
            if (_7x1 == 5)
            {
                _4x1iconcell = "B";
                _4x1iconcellb = "v";
            }
            if (_7x3 == 5)
            {
                _4x2iconcell = "B";
                _4x2iconcellb = "v";
            }
            if (_7x5 == 5)
            {
                _4x3iconcell = "B";
                _4x3iconcellb = "v";
            }
            if (_7x7 == 5)
            {
                _4x4iconcell = "B";
                _4x4iconcellb = "v";
            }
            if (_7x9 == 5)
            {
                _4x5iconcell = "B";
                _4x5iconcellb = "v";
            }
            if (_7x11 == 5)
            {
                _4x6iconcell = "B";
                _4x6iconcellb = "v";
            }
            if (_7x13 == 5)
            {
                _4x7iconcell = "B";
                _4x7iconcellb = "v";
            }
            if (_7x15 == 5)
            {
                _4x8iconcell = "B";
                _4x8iconcellb = "v";
            }
            if (_7x17 == 5)
            {
                _4x9iconcell = "B";
                _4x9iconcellb = "v";
            }
            //cels 6
            if (_1x1 == 6)
            {
                _1x1iconcell = "$";
                _1x1iconcellb = "v";
            }
            if (_1x3 == 6)
            {
                _1x2iconcell = "$";
                _1x2iconcellb = "v";
            }
            if (_1x5 == 6)
            {
                _1x3iconcell = "$";
                _1x3iconcellb = "v";
            }
            if (_1x7 == 6)
            {
                _1x4iconcell = "$";
                _1x4iconcellb = "v";
            }
            if (_1x9 == 6)
            {
                _1x5iconcell = "$";
                _1x5iconcellb = "v";
            }
            if (_1x11 == 6)
            {
                _1x6iconcell = "$";
                _1x6iconcellb = "v";
            }
            if (_1x13 == 6)
            {
                _1x7iconcell = "$";
                _1x7iconcellb = "v";
            }
            if (_1x15 == 6)
            {
                _1x8iconcell = "$";
                _1x8iconcellb = "v";
            }
            if (_1x17 == 6)
            {
                _1x9iconcell = "$";
                _1x9iconcellb = "v";
            }
            if (_3x1 == 6)
            {
                _2x1iconcell = "$";
                _2x1iconcellb = "v";
            }
            if (_3x3 == 6)
            {
                _2x2iconcell = "$";
                _2x2iconcellb = "v";
            }
            if (_3x5 == 6)
            {
                _2x3iconcell = "$";
                _2x3iconcellb = "v";
            }
            if (_3x7 == 6)
            {
                _2x4iconcell = "$";
                _2x4iconcellb = "v";
            }
            if (_3x9 == 6)
            {
                _2x5iconcell = "$";
                _2x5iconcellb = "v";
            }
            if (_3x11 == 6)
            {
                _2x6iconcell = "$";
                _2x6iconcellb = "v";
            }
            if (_3x13 == 6)
            {
                _2x7iconcell = "$";
                _2x7iconcellb = "v";
            }
            if (_3x15 == 6)
            {
                _2x8iconcell = "$";
                _2x8iconcellb = "v";
            }
            if (_3x17 == 6)
            {
                _2x9iconcell = "$";
                _2x9iconcellb = "v";
            }
            if (_5x1 == 6)
            {
                _3x1iconcell = "$";
                _3x1iconcellb = "v";
            }
            if (_5x3 == 6)
            {
                _3x2iconcell = "$";
                _3x2iconcellb = "v";
            }
            if (_5x5 == 6)
            {
                _3x3iconcell = "$";
                _3x3iconcellb = "v";
            }
            if (_5x7 == 6)
            {
                _3x4iconcell = "$";
                _3x4iconcellb = "v";
            }
            if (_5x9 == 6)
            {
                _3x5iconcell = "$";
                _3x5iconcellb = "v";
            }
            if (_5x11 == 6)
            {
                _3x6iconcell = "$";
                _3x6iconcellb = "v";
            }
            if (_5x13 == 6)
            {
                _3x7iconcell = "$";
                _3x7iconcellb = "v";
            }
            if (_5x15 == 6)
            {
                _3x8iconcell = "$";
                _3x8iconcellb = "v";
            }
            if (_5x17 == 6)
            {
                _3x9iconcell = "$";
                _3x9iconcellb = "v";
            }
            if (_7x1 == 6)
            {
                _4x1iconcell = "$";
                _4x1iconcellb = "v";
            }
            if (_7x3 == 6)
            {
                _4x2iconcell = "$";
                _4x2iconcellb = "v";
            }
            if (_7x5 == 6)
            {
                _4x3iconcell = "$";
                _4x3iconcellb = "v";
            }
            if (_7x7 == 6)
            {
                _4x4iconcell = "$";
                _4x4iconcellb = "v";
            }
            if (_7x9 == 6)
            {
                _4x5iconcell = "$";
                _4x5iconcellb = "v";
            }
            if (_7x11 == 6)
            {
                _4x6iconcell = "$";
                _4x6iconcellb = "v";
            }
            if (_7x13 == 6)
            {
                _4x7iconcell = "$";
                _4x7iconcellb = "v";
            }
            if (_7x15 == 6)
            {
                _4x8iconcell = "$";
                _4x8iconcellb = "v";
            }
            if (_7x17 == 6)
            {
                _4x9iconcell = "$";
                _4x9iconcellb = "v";
            }
            //cells 13
            if (_1x1 == 13)
            {
                _1x1iconcell = "P";
                _1x1iconcellb = "v";
            }
            if (_1x3 == 13)
            {
                _1x2iconcell = "P";
                _1x2iconcellb = "v";
            }
            if (_1x5 == 13)
            {
                _1x3iconcell = "P";
                _1x3iconcellb = "v";
            }
            if (_1x7 == 13)
            {
                _1x4iconcell = "P";
                _1x4iconcellb = "v";
            }
            if (_1x9 == 13)
            {
                _1x5iconcell = "P";
                _1x5iconcellb = "v";
            }
            if (_1x11 == 13)
            {
                _1x6iconcell = "P";
                _1x6iconcellb = "v";
            }
            if (_1x13 == 13)
            {
                _1x7iconcell = "P";
                _1x7iconcellb = "v";
            }
            if (_1x15 == 13)
            {
                _1x8iconcell = "P";
                _1x8iconcellb = "v";
            }
            if (_1x17 == 13)
            {
                _1x9iconcell = "P";
                _1x9iconcellb = "v";
            }
            if (_3x1 == 13)
            {
                _2x1iconcell = "P";
                _2x1iconcellb = "v";
            }
            if (_3x3 == 13)
            {
                _2x2iconcell = "P";
                _2x2iconcellb = "v";
            }
            if (_3x5 == 13)
            {
                _2x3iconcell = "P";
                _2x3iconcellb = "v";
            }
            if (_3x7 == 13)
            {
                _2x4iconcell = "P";
                _2x4iconcellb = "v";
            }
            if (_3x9 == 13)
            {
                _2x5iconcell = "P";
                _2x5iconcellb = "v";
            }
            if (_3x11 == 13)
            {
                _2x6iconcell = "P";
                _2x6iconcellb = "v";
            }
            if (_3x13 == 13)
            {
                _2x7iconcell = "P";
                _2x7iconcellb = "v";
            }
            if (_3x15 == 13)
            {
                _2x8iconcell = "P";
                _2x8iconcellb = "v";
            }
            if (_3x17 == 13)
            {
                _2x9iconcell = "P";
                _2x9iconcellb = "v";
            }
            if (_5x1 == 13)
            {
                _3x1iconcell = "P";
                _3x1iconcellb = "v";
            }
            if (_5x3 == 13)
            {
                _3x2iconcell = "P";
                _3x2iconcellb = "v";
            }
            if (_5x5 == 13)
            {
                _3x3iconcell = "P";
                _3x3iconcellb = "v";
            }
            if (_5x7 == 13)
            {
                _3x4iconcell = "P";
                _3x4iconcellb = "v";
            }
            if (_5x9 == 13)
            {
                _3x5iconcell = "P";
                _3x5iconcellb = "v";
            }
            if (_5x11 == 13)
            {
                _3x6iconcell = "P";
                _3x6iconcellb = "v";
            }
            if (_5x13 == 13)
            {
                _3x7iconcell = "P";
                _3x7iconcellb = "v";
            }
            if (_5x15 == 13)
            {
                _3x8iconcell = "P";
                _3x8iconcellb = "v";
            }
            if (_5x17 == 13)
            {
                _3x9iconcell = "P";
                _3x9iconcellb = "v";
            }
            if (_7x1 == 13)
            {
                _4x1iconcell = "P";
                _4x1iconcellb = "v";
            }
            if (_7x3 == 13)
            {
                _4x2iconcell = "P";
                _4x2iconcellb = "v";
            }
            if (_7x5 == 13)
            {
                _4x3iconcell = "P";
                _4x3iconcellb = "v";
            }
            if (_7x7 == 13)
            {
                _4x4iconcell = "P";
                _4x4iconcellb = "v";
            }
            if (_7x9 == 13)
            {
                _4x5iconcell = "P";
                _4x5iconcellb = "v";
            }
            if (_7x11 == 13)
            {
                _4x6iconcell = "P";
                _4x6iconcellb = "v";
            }
            if (_7x13 == 13)
            {
                _4x7iconcell = "P";
                _4x7iconcellb = "v";
            }
            if (_7x15 == 13)
            {
                _4x8iconcell = "P";
                _4x8iconcellb = "v";
            }
            if (_7x17 == 13)
            {
                _4x9iconcell = "P";
                _4x9iconcellb = "v";
            }


            //side cell non explored (done)
            if (_1x1 != 2 && _1x1 != 0 && _1x1 != 13)
            {
                _1x1sidecell = "║";
            }
            if (_1x3 != 2 && _1x3 != 0 && _1x3 != 13)
            {
                _1x2sidecell = "║";
            }
            if (_1x5 != 2 && _1x5 != 0 && _1x5 != 13)
            {
                _1x3sidecell = "║";
            }
            if (_1x7 != 2 && _1x7 != 0 && _1x7 != 13)
            {
                _1x4sidecell = "║";
            }
            if (_1x9 != 2 && _1x9 != 0 && _1x9 != 13)
            {
                _1x5sidecell = "║";
            }
            if (_1x11 != 2 && _1x11 != 0 && _1x11 != 13)
            {
                _1x6sidecell = "║";
            }
            if (_1x13 != 2 && _1x13 != 0 && _1x13 != 13)
            {
                _1x7sidecell = "║";
            }
            if (_1x15 != 2 && _1x15 != 0 && _1x15 != 13)
            {
                _1x8sidecell = "║";
            }
            if (_1x17 != 2 && _1x17 != 0 && _1x17 != 13)
            {
                _1x9sidecell = "║";
            }
            if (_3x1 != 2 && _3x1 != 0 && _3x1 != 13)
            {
                _2x1sidecell = "║";
            }
            if (_3x3 != 2 && _3x3 != 0 && _3x3 != 13)
            {
                _2x2sidecell = "║";
            }
            if (_3x5 != 2 && _3x5 != 0 && _3x5 != 13)
            {
                _2x3sidecell = "║";
            }
            if (_3x7 != 2 && _3x7 != 0 && _3x7 != 13)
            {
                _2x4sidecell = "║";
            }
            if (_3x9 != 2 && _3x9 != 0 && _3x9 != 13)
            {
                _2x5sidecell = "║";
            }
            if (_3x11 != 2 && _3x11 != 0 && _3x11 != 13)
            {
                _2x6sidecell = "║";
            }
            if (_3x13 != 2 && _3x13 != 0 && _3x13 != 13)
            {
                _2x7sidecell = "║";
            }
            if (_3x15 != 2 && _3x15 != 0 && _3x15 != 13)
            {
                _2x8sidecell = "║";
            }
            if (_3x17 != 2 && _3x17 != 0 && _3x17 != 13)
            {
                _2x9sidecell = "║";
            }
            if (_5x1 != 2 && _5x1 != 0 && _5x1 != 13)
            {
                _3x1sidecell = "║";
            }
            if (_5x3 != 2 && _5x3 != 0 && _5x3 != 13)
            {
                _3x2sidecell = "║";
            }
            if (_5x5 != 2 && _5x5 != 0 && _5x5 != 13)
            {
                _3x3sidecell = "║";
            }
            if (_5x7 != 2 && _5x7 != 0 && _5x7 != 13)
            {
                _3x4sidecell = "║";
            }
            if (_5x9 != 2 && _5x9 != 0 && _5x9 != 13)
            {
                _3x5sidecell = "║";
            }
            if (_5x11 != 2 && _5x11 != 0 && _5x11 != 13)
            {
                _3x6sidecell = "║";
            }
            if (_5x13 != 2 && _5x13 != 0 && _5x13 != 13)
            {
                _3x7sidecell = "║";
            }
            if (_5x15 != 2 && _5x15 != 0 && _5x15 != 13)
            {
                _3x8sidecell = "║";
            }
            if (_5x17 != 2 && _5x17 != 0 && _5x17 != 13)
            {
                _3x9sidecell = "║";
            }
            if (_7x1 != 2 && _7x1 != 0 && _7x1 != 13)
            {
                _4x1sidecell = "║";
            }
            if (_7x3 != 2 && _7x3 != 0 && _7x3 != 13)
            {
                _4x2sidecell = "║";
            }
            if (_7x5 != 2 && _7x5 != 0 && _7x5 != 13)
            {
                _4x3sidecell = "║";
            }
            if (_7x7 != 2 && _7x7 != 0 && _7x7 != 13)
            {
                _4x4sidecell = "║";
            }
            if (_7x9 != 2 && _7x9 != 0 && _7x9 != 13)
            {
                _4x5sidecell = "║";
            }
            if (_7x11 != 2 && _7x11 != 0 && _7x11 != 13)
            {
                _4x6sidecell = "║";
            }
            if (_7x13 != 2 && _7x13 != 0 && _7x13 != 13)
            {
                _4x7sidecell = "║";
            }
            if (_7x15 != 2 && _7x15 != 0 && _7x15 != 13)
            {
                _4x8sidecell = "║";
            }
            if (_7x17 != 2 && _7x17 != 0 && _7x17 != 13)
            {
                _4x9sidecell = "║";
            }
            //side cell full (done)
            if (_1x1 == 2 || _1x1 == 13)
            {
                _1x1sidecell = "█";
            }
            if (_1x3 == 2 || _1x3 == 13)
            {
                _1x2sidecell = "█";
            }
            if (_1x5 == 2 || _1x5 == 13)
            {
                _1x3sidecell = "█";
            }
            if (_1x7 == 2 || _1x7 == 13)
            {
                _1x4sidecell = "█";
            }
            if (_1x9 == 2 || _1x9 == 13)
            {
                _1x5sidecell = "█";
            }
            if (_1x11 == 2 || _1x11 == 13)
            {
                _1x6sidecell = "█";
            }
            if (_1x13 == 2 || _1x13 == 13)
            {
                _1x7sidecell = "█";
            }
            if (_1x15 == 2 || _1x15 == 13)
            {
                _1x8sidecell = "█";
            }
            if (_1x17 == 2 || _1x17 == 13)
            {
                _1x9sidecell = "█";
            }
            if (_3x1 == 2 || _3x1 == 13)
            {
                _2x1sidecell = "█";
            }
            if (_3x3 == 2 || _3x3 == 13)
            {
                _2x2sidecell = "█";
            }
            if (_3x5 == 2 || _3x5 == 13)
            {
                _2x3sidecell = "█";
            }
            if (_3x7 == 2 || _3x7 == 13)
            {
                _2x4sidecell = "█";
            }
            if (_3x9 == 2 || _3x9 == 13)
            {
                _2x5sidecell = "█";
            }
            if (_3x11 == 2 || _3x11 == 13)
            {
                _2x6sidecell = "█";
            }
            if (_3x13 == 2 || _3x13 == 13)
            {
                _2x7sidecell = "█";
            }
            if (_3x15 == 2 || _3x15 == 13)
            {
                _2x8sidecell = "█";
            }
            if (_3x17 == 2 || _3x17 == 13)
            {
                _2x9sidecell = "█";
            }
            if (_5x1 == 2 || _5x1 == 13)
            {
                _3x1sidecell = "█";
            }
            if (_5x3 == 2 || _5x3 == 13)
            {
                _3x2sidecell = "█";
            }
            if (_5x5 == 2 || _5x5 == 13)
            {
                _3x3sidecell = "█";
            }
            if (_5x7 == 2 || _5x7 == 13)
            {
                _3x4sidecell = "█";
            }
            if (_5x9 == 2 || _5x9 == 13)
            {
                _3x5sidecell = "█";
            }
            if (_5x11 == 2 || _5x11 == 13)
            {
                _3x6sidecell = "█";
            }
            if (_5x13 == 2 || _5x13 == 13)
            {
                _3x7sidecell = "█";
            }
            if (_5x15 == 2 || _5x15 == 13)
            {
                _3x8sidecell = "█";
            }
            if (_5x17 == 2 || _5x17 == 13)
            {
                _3x9sidecell = "█";
            }
            if (_7x1 == 2 || _7x1 == 13)
            {
                _4x1sidecell = "█";
            }
            if (_7x3 == 2 || _7x3 == 13)
            {
                _4x2sidecell = "█";
            }
            if (_7x5 == 2 || _7x5 == 13)
            {
                _4x3sidecell = "█";
            }
            if (_7x7 == 2 || _7x7 == 13)
            {
                _4x4sidecell = "█";
            }
            if (_7x9 == 2 || _7x9 == 13)
            {
                _4x5sidecell = "█";
            }
            if (_7x11 == 2 || _7x11 == 13)
            {
                _4x6sidecell = "█";
            }
            if (_7x13 == 2 || _7x13 == 13)
            {
                _4x7sidecell = "█";
            }
            if (_7x15 == 2 || _7x15 == 13)
            {
                _4x8sidecell = "█";
            }
            if (_7x17 == 2 || _7x17 == 13)
            {
                _4x9sidecell = "█";
            }
            //body cell full
            if (_1x1 == 2 || _1x1 == 13)
            {
                _1x1bodycell = "███";
            }
            if (_1x3 == 2 || _1x3 == 13)
            {
                _1x2bodycell = "███";
            }
            if (_1x5 == 2 || _1x5 == 13)
            {
                _1x3bodycell = "███";
            }
            if (_1x7 == 2 || _1x7 == 13)
            {
                _1x4bodycell = "███";
            }
            if (_1x9 == 2 || _1x9 == 13)
            {
                _1x5bodycell = "███";
            }
            if (_1x11 == 2 || _1x11 == 13)
            {
                _1x6bodycell = "███";
            }
            if (_1x13 == 2 || _1x13 == 13)
            {
                _1x7bodycell = "███";
            }
            if (_1x15 == 2 || _1x15 == 13)
            {
                _1x8bodycell = "███";
            }
            if (_1x17 == 2 || _1x17 == 13)
            {
                _1x9bodycell = "███";
            }
            if (_3x1 == 2 || _3x1 == 13)
            {
                _2x1bodycell = "███";
            }
            if (_3x3 == 2 || _3x3 == 13)
            {
                _2x2bodycell = "███";
            }
            if (_3x5 == 2 || _3x5 == 13)
            {
                _2x3bodycell = "███";
            }
            if (_3x7 == 2 || _3x7 == 13)
            {
                _2x4bodycell = "███";
            }
            if (_3x9 == 2 || _3x9 == 13)
            {
                _2x5bodycell = "███";
            }
            if (_3x11 == 2 || _3x11 == 13)
            {
                _2x6bodycell = "███";
            }
            if (_3x13 == 2 || _3x13 == 13)
            {
                _2x7bodycell = "███";
            }
            if (_3x15 == 2 || _3x15 == 13)
            {
                _2x8bodycell = "███";
            }
            if (_3x17 == 2 || _3x17 == 13)
            {
                _2x9bodycell = "███";
            }
            if (_5x1 == 2 || _5x1 == 13)
            {
                _3x1bodycell = "███";
            }
            if (_5x3 == 2 || _5x3 == 13)
            {
                _3x2bodycell = "███";
            }
            if (_5x5 == 2 || _5x5 == 13)
            {
                _3x3bodycell = "███";
            }
            if (_5x7 == 2 || _5x7 == 13)
            {
                _3x4bodycell = "███";
            }
            if (_5x9 == 2 || _5x9 == 13)
            {
                _3x5bodycell = "███";
            }
            if (_5x11 == 2 || _5x11 == 13)
            {
                _3x6bodycell = "███";
            }
            if (_5x13 == 2 || _5x13 == 13)
            {
                _3x7bodycell = "███";
            }
            if (_5x15 == 2 || _5x15 == 13)
            {
                _3x8bodycell = "███";
            }
            if (_5x17 == 2 || _5x17 == 13)
            {
                _3x9bodycell = "███";
            }
            if (_7x1 == 2 || _7x1 == 13)
            {
                _4x1bodycell = "███";
            }
            if (_7x3 == 2 || _7x3 == 13)
            {
                _4x2bodycell = "███";
            }
            if (_7x5 == 2 || _7x5 == 13)
            {
                _4x3bodycell = "███";
            }
            if (_7x7 == 2 || _7x7 == 13)
            {
                _4x4bodycell = "███";
            }
            if (_7x9 == 2 || _7x9 == 13)
            {
                _4x5bodycell = "███";
            }
            if (_7x11 == 2 || _7x11 == 13)
            {
                _4x6bodycell = "███";
            }
            if (_7x13 == 2 || _7x13 == 13)
            {
                _4x7bodycell = "███";
            }
            if (_7x15 == 2 || _7x15 == 13)
            {
                _4x8bodycell = "███";
            }
            if (_7x17 == 2 || _7x17 == 13)
            {
                _4x9bodycell = "███";
            }
            //bottom cell empty (done)
            if (_1x1 != 2 && _1x1 != 0 && _1x1 != 13)
            {
                _1x1botcell = "╚═══════╝";
            }
            if (_1x3 != 2 && _1x3 != 0 && _1x3 != 13)
            {
                _1x2botcell = "╚═══════╝";
            }
            if (_1x5 != 2 && _1x5 != 0 && _1x5 != 13)
            {
                _1x3botcell = "╚═══════╝";
            }
            if (_1x7 != 2 && _1x7 != 0 && _1x7 != 13)
            {
                _1x4botcell = "╚═══════╝";
            }
            if (_1x9 != 2 && _1x9 != 0 && _1x9 != 13)
            {
                _1x5botcell = "╚═══════╝";
            }
            if (_1x11 != 2 && _1x11 != 0 && _1x11 != 13)
            {
                _1x6botcell = "╚═══════╝";
            }
            if (_1x13 != 2 && _1x13 != 0 && _1x13 != 13)
            {
                _1x7botcell = "╚═══════╝";
            }
            if (_1x15 != 2 && _1x15 != 0 && _1x15 != 13)
            {
                _1x8botcell = "╚═══════╝";
            }
            if (_1x17 != 2 && _1x17 != 0 && _1x17 != 13)
            {
                _1x9botcell = "╚═══════╝";
            }
            if (_3x1 != 2 && _3x1 != 0 && _3x1 != 13)
            {
                _2x1botcell = "╚═══════╝";
            }
            if (_3x3 != 2 && _3x3 != 0 && _3x3 != 13)
            {
                _2x2botcell = "╚═══════╝";
            }
            if (_3x5 != 2 && _3x5 != 0 && _3x5 != 13)
            {
                _2x3botcell = "╚═══════╝";
            }
            if (_3x7 != 2 && _3x7 != 0 && _3x7 != 13)
            {
                _2x4botcell = "╚═══════╝";
            }
            if (_3x9 != 2 && _3x9 != 0 && _3x9 != 13)
            {
                _2x5botcell = "╚═══════╝";
            }
            if (_3x11 != 2 && _3x11 != 0 && _3x11 != 13)
            {
                _2x6botcell = "╚═══════╝";
            }
            if (_3x13 != 2 && _3x13 != 0 && _3x13 != 13)
            {
                _2x7botcell = "╚═══════╝";
            }
            if (_3x15 != 2 && _3x15 != 0 && _3x15 != 13)
            {
                _2x8botcell = "╚═══════╝";
            }
            if (_3x17 != 2 && _3x17 != 0 && _3x17 != 13)
            {
                _2x9botcell = "╚═══════╝";
            }
            if (_5x1 != 2 && _5x1 != 0 && _5x1 != 13)
            {
                _3x1botcell = "╚═══════╝";
            }
            if (_5x3 != 2 && _5x3 != 0 && _5x3 != 13)
            {
                _3x2botcell = "╚═══════╝";
            }
            if (_5x5 != 2 && _5x5 != 0 && _5x5 != 13)
            {
                _3x3botcell = "╚═══════╝";
            }
            if (_5x7 != 2 && _5x7 != 0 && _5x7 != 13)
            {
                _3x4botcell = "╚═══════╝";
            }
            if (_5x9 != 2 && _5x9 != 0 && _5x9 != 13)
            {
                _3x5botcell = "╚═══════╝";
            }
            if (_5x11 != 2 && _5x11 != 0 && _5x11 != 13)
            {
                _3x6botcell = "╚═══════╝";
            }
            if (_5x13 != 2 && _5x13 != 0 && _5x13 != 13)
            {
                _3x7botcell = "╚═══════╝";
            }
            if (_5x15 != 2 && _5x15 != 0 && _5x15 != 13)
            {
                _3x8botcell = "╚═══════╝";
            }
            if (_5x17 != 2 && _5x17 != 0 && _5x17 != 13)
            {
                _3x9botcell = "╚═══════╝";
            }
            if (_7x1 != 2 && _7x1 != 0 && _7x1 != 13)
            {
                _4x1botcell = "╚═══════╝";
            }
            if (_7x3 != 2 && _7x3 != 0 && _7x3 != 13)
            {
                _4x2botcell = "╚═══════╝";
            }
            if (_7x5 != 2 && _7x5 != 0 && _7x5 != 13)
            {
                _4x3botcell = "╚═══════╝";
            }
            if (_7x7 != 2 && _7x7 != 0 && _7x7 != 13)
            {
                _4x4botcell = "╚═══════╝";
            }
            if (_7x9 != 2 && _7x9 != 0 && _7x9 != 13)
            {
                _4x5botcell = "╚═══════╝";
            }
            if (_7x11 != 2 && _7x11 != 0 && _7x11 != 13)
            {
                _4x6botcell = "╚═══════╝";
            }
            if (_7x13 != 2 && _7x13 != 0 && _7x13 != 13)
            {
                _4x7botcell = "╚═══════╝";
            }
            if (_7x15 != 2 && _7x15 != 0 && _7x15 != 13)
            {
                _4x8botcell = "╚═══════╝";
            }
            if (_7x17 != 2 && _7x17 != 0 && _7x17 != 13)
            {
                _4x9botcell = "╚═══════╝";
            }
            //bottom cell full (done)
            if (_1x1 == 2 || _1x1 == 13)
            {
                _1x1botcell = "▀▀▀▀▀▀▀▀▀";
            }
            if (_1x3 == 2 || _1x3 == 13)
            {
                _1x2botcell = "▀▀▀▀▀▀▀▀▀";
            }
            if (_1x5 == 2 || _1x5 == 13)
            {
                _1x3botcell = "▀▀▀▀▀▀▀▀▀";
            }
            if (_1x7 == 2 || _1x7 == 13)
            {
                _1x4botcell = "▀▀▀▀▀▀▀▀▀";
            }
            if (_1x9 == 2 || _1x9 == 13)
            {
                _1x5botcell = "▀▀▀▀▀▀▀▀▀";
            }
            if (_1x11 == 2 || _1x11 == 13)
            {
                _1x6botcell = "▀▀▀▀▀▀▀▀▀";
            }
            if (_1x13 == 2 || _1x13 == 13)
            {
                _1x7botcell = "▀▀▀▀▀▀▀▀▀";
            }
            if (_1x15 == 2 || _1x15 == 13)
            {
                _1x8botcell = "▀▀▀▀▀▀▀▀▀";
            }
            if (_1x17 == 2 || _1x17 == 13)
            {
                _1x9botcell = "▀▀▀▀▀▀▀▀▀";
            }
            if (_3x1 == 2 || _3x1 == 13)
            {
                _2x1botcell = "▀▀▀▀▀▀▀▀▀";
            }
            if (_3x3 == 2 || _3x3 == 13)
            {
                _2x2botcell = "▀▀▀▀▀▀▀▀▀";
            }
            if (_3x5 == 2 || _3x5 == 13)
            {
                _2x3botcell = "▀▀▀▀▀▀▀▀▀";
            }
            if (_3x7 == 2 || _3x7 == 13)
            {
                _2x4botcell = "▀▀▀▀▀▀▀▀▀";
            }
            if (_3x9 == 2 || _3x9 == 13)
            {
                _2x5botcell = "▀▀▀▀▀▀▀▀▀";
            }
            if (_3x11 == 2 || _3x11 == 13)
            {
                _2x6botcell = "▀▀▀▀▀▀▀▀▀";
            }
            if (_3x13 == 2 || _3x13 == 13)
            {
                _2x7botcell = "▀▀▀▀▀▀▀▀▀";
            }
            if (_3x15 == 2 || _3x15 == 13)
            {
                _2x8botcell = "▀▀▀▀▀▀▀▀▀";
            }
            if (_3x17 == 2 || _3x17 == 13)
            {
                _2x9botcell = "▀▀▀▀▀▀▀▀▀";
            }
            if (_5x1 == 2 || _5x1 == 13)
            {
                _3x1botcell = "▀▀▀▀▀▀▀▀▀";
            }
            if (_5x3 == 2 || _5x3 == 13)
            {
                _3x2botcell = "▀▀▀▀▀▀▀▀▀";
            }
            if (_5x5 == 2 || _5x5 == 13)
            {
                _3x3botcell = "▀▀▀▀▀▀▀▀▀";
            }
            if (_5x7 == 2 || _5x7 == 13)
            {
                _3x4botcell = "▀▀▀▀▀▀▀▀▀";
            }
            if (_5x9 == 2 || _5x9 == 13)
            {
                _3x5botcell = "▀▀▀▀▀▀▀▀▀";
            }
            if (_5x11 == 2 || _5x11 == 13)
            {
                _3x6botcell = "▀▀▀▀▀▀▀▀▀";
            }
            if (_5x13 == 2 || _5x13 == 13)
            {
                _3x7botcell = "▀▀▀▀▀▀▀▀▀";
            }
            if (_5x15 == 2 || _5x15 == 13)
            {
                _3x8botcell = "▀▀▀▀▀▀▀▀▀";
            }
            if (_5x17 == 2 || _5x17 == 13)
            {
                _3x9botcell = "▀▀▀▀▀▀▀▀▀";
            }
            if (_7x1 == 2 || _7x1 == 13)
            {
                _4x1botcell = "▀▀▀▀▀▀▀▀▀";
            }
            if (_7x3 == 2 || _7x3 == 13)
            {
                _4x2botcell = "▀▀▀▀▀▀▀▀▀";
            }
            if (_7x5 == 2 || _7x5 == 13)
            {
                _4x3botcell = "▀▀▀▀▀▀▀▀▀";
            }
            if (_7x7 == 2 || _7x7 == 13)
            {
                _4x4botcell = "▀▀▀▀▀▀▀▀▀";
            }
            if (_7x9 == 2 || _7x9 == 13)
            {
                _4x5botcell = "▀▀▀▀▀▀▀▀▀";
            }
            if (_7x11 == 2 || _7x11 == 13)
            {
                _4x6botcell = "▀▀▀▀▀▀▀▀▀";
            }
            if (_7x13 == 2 || _7x13 == 13)
            {
                _4x7botcell = "▀▀▀▀▀▀▀▀▀";
            }
            if (_7x15 == 2 || _7x15 == 13)
            {
                _4x8botcell = "▀▀▀▀▀▀▀▀▀";
            }
            if (_7x17 == 2 || _7x17 == 13)
            {
                _4x9botcell = "▀▀▀▀▀▀▀▀▀";
            }
            //top cell emptry (done)
            if (_1x1 != 2 && _1x1 != 0 && _1x1 != 13)
            {
                _1x1topcell = "╔═══════╗";
            }
            if (_1x3 != 2 && _1x3 != 0 && _1x3 != 13)
            {
                _1x2topcell = "╔═══════╗";
            }
            if (_1x5 != 2 && _1x5 != 0 && _1x5 != 13)
            {
                _1x3topcell = "╔═══════╗";
            }
            if (_1x7 != 2 && _1x7 != 0 && _1x7 != 13)
            {
                _1x4topcell = "╔═══════╗";
            }
            if (_1x9 != 2 && _1x9 != 0 && _1x9 != 13)
            {
                _1x5topcell = "╔═══════╗";
            }
            if (_1x11 != 2 && _1x11 != 0 && _1x11 != 13)
            {
                _1x6topcell = "╔═══════╗";
            }
            if (_1x13 != 2 && _1x13 != 0 && _1x13 != 13)
            {
                _1x7topcell = "╔═══════╗";
            }
            if (_1x15 != 2 && _1x15 != 0 && _1x15 != 13)
            {
                _1x8topcell = "╔═══════╗";
            }
            if (_1x17 != 2 && _1x17 != 0 && _1x17 != 13)
            {
                _1x9topcell = "╔═══════╗";
            }
            if (_3x1 != 2 && _3x1 != 0 && _3x1 != 13)
            {
                _2x1topcell = "╔═══════╗";
            }
            if (_3x3 != 2 && _3x3 != 0 && _3x3 != 13)
            {
                _2x2topcell = "╔═══════╗";
            }
            if (_3x5 != 2 && _3x5 != 0 && _3x5 != 13)
            {
                _2x3topcell = "╔═══════╗";
            }
            if (_3x7 != 2 && _3x7 != 0 && _3x7 != 13)
            {
                _2x4topcell = "╔═══════╗";
            }
            if (_3x9 != 2 && _3x9 != 0 && _3x9 != 13)
            {
                _2x5topcell = "╔═══════╗";
            }
            if (_3x11 != 2 && _3x11 != 0 && _3x11 != 13)
            {
                _2x6topcell = "╔═══════╗";
            }
            if (_3x13 != 2 && _3x13 != 0 && _3x13 != 13)
            {
                _2x7topcell = "╔═══════╗";
            }
            if (_3x15 != 2 && _3x15 != 0 && _3x15 != 13)
            {
                _2x8topcell = "╔═══════╗";
            }
            if (_3x17 != 2 && _3x17 != 0 && _3x17 != 13)
            {
                _2x9topcell = "╔═══════╗";
            }
            if (_5x1 != 2 && _5x1 != 0 && _5x1 != 13)
            {
                _3x1topcell = "╔═══════╗";
            }
            if (_5x3 != 2 && _5x3 != 0 && _5x3 != 13)
            {
                _3x2topcell = "╔═══════╗";
            }
            if (_5x5 != 2 && _5x5 != 0 && _5x5 != 13)
            {
                _3x3topcell = "╔═══════╗";
            }
            if (_5x7 != 2 && _5x7 != 0 && _5x7 != 13)
            {
                _3x4topcell = "╔═══════╗";
            }
            if (_5x9 != 2 && _5x9 != 0 && _5x9 != 13)
            {
                _3x5topcell = "╔═══════╗";
            }
            if (_5x11 != 2 && _5x11 != 0 && _5x11 != 13)
            {
                _3x6topcell = "╔═══════╗";
            }
            if (_5x13 != 2 && _5x13 != 0 && _5x13 != 13)
            {
                _3x7topcell = "╔═══════╗";
            }
            if (_5x15 != 2 && _5x15 != 0 && _5x15 != 13)
            {
                _3x8topcell = "╔═══════╗";
            }
            if (_5x17 != 2 && _5x17 != 0 && _5x17 != 13)
            {
                _3x9topcell = "╔═══════╗";
            }
            if (_7x1 != 2 && _7x1 != 0 && _7x1 != 13)
            {
                _4x1topcell = "╔═══════╗";
            }
            if (_7x3 != 2 && _7x3 != 0 && _7x3 != 13)
            {
                _4x2topcell = "╔═══════╗";
            }
            if (_7x5 != 2 && _7x5 != 0 && _7x5 != 13)
            {
                _4x3topcell = "╔═══════╗";
            }
            if (_7x7 != 2 && _7x7 != 0 && _7x7 != 13)
            {
                _4x4topcell = "╔═══════╗";
            }
            if (_7x9 != 2 && _7x9 != 0 && _7x9 != 13)
            {
                _4x5topcell = "╔═══════╗";
            }
            if (_7x11 != 2 && _7x11 != 0 && _7x11 != 13)
            {
                _4x6topcell = "╔═══════╗";
            }
            if (_7x13 != 2 && _7x13 != 0 && _7x13 != 13)
            {
                _4x7topcell = "╔═══════╗";
            }
            if (_7x15 != 2 && _7x15 != 0 && _7x15 != 13)
            {
                _4x8topcell = "╔═══════╗";
            }
            if (_7x17 != 2 && _7x17 != 0 && _7x17 != 13)
            {
                _4x9topcell = "╔═══════╗";
            }
            //top cell full (done)
            if (_1x1 == 2 || _1x1 == 13)
            {
                _1x1topcell = "▄▄▄▄▄▄▄▄▄";
            }
            if (_1x3 == 2 || _1x3 == 13)
            {
                _1x2topcell = "▄▄▄▄▄▄▄▄▄";
            }
            if (_1x5 == 2 || _1x5 == 13)
            {
                _1x3topcell = "▄▄▄▄▄▄▄▄▄";
            }
            if (_1x7 == 2 || _1x7 == 13)
            {
                _1x4topcell = "▄▄▄▄▄▄▄▄▄";
            }
            if (_1x9 == 2 || _1x9 == 13)
            {
                _1x5topcell = "▄▄▄▄▄▄▄▄▄";
            }
            if (_1x11 == 2 || _1x11 == 13)
            {
                _1x6topcell = "▄▄▄▄▄▄▄▄▄";
            }
            if (_1x13 == 2 || _1x13 == 13)
            {
                _1x7topcell = "▄▄▄▄▄▄▄▄▄";
            }
            if (_1x15 == 2 || _1x15 == 13)
            {
                _1x8topcell = "▄▄▄▄▄▄▄▄▄";
            }
            if (_1x17 == 2 || _1x17 == 13)
            {
                _1x9topcell = "▄▄▄▄▄▄▄▄▄";
            }
            if (_3x1 == 2 || _3x1 == 13)
            {
                _2x1topcell = "▄▄▄▄▄▄▄▄▄";
            }
            if (_3x3 == 2 || _3x3 == 13)
            {
                _2x2topcell = "▄▄▄▄▄▄▄▄▄";
            }
            if (_3x5 == 2 || _3x5 == 13)
            {
                _2x3topcell = "▄▄▄▄▄▄▄▄▄";
            }
            if (_3x7 == 2 || _3x7 == 13)
            {
                _2x4topcell = "▄▄▄▄▄▄▄▄▄";
            }
            if (_3x9 == 2 || _3x9 == 13)
            {
                _2x5topcell = "▄▄▄▄▄▄▄▄▄";
            }
            if (_3x11 == 2 || _3x11 == 13)
            {
                _2x6topcell = "▄▄▄▄▄▄▄▄▄";
            }
            if (_3x13 == 2 || _3x13 == 13)
            {
                _2x7topcell = "▄▄▄▄▄▄▄▄▄";
            }
            if (_3x15 == 2 || _3x15 == 13)
            {
                _2x8topcell = "▄▄▄▄▄▄▄▄▄";
            }
            if (_3x17 == 2 || _3x17 == 13)
            {
                _2x9topcell = "▄▄▄▄▄▄▄▄▄";
            }
            if (_5x1 == 2 || _5x1 == 13)
            {
                _3x1topcell = "▄▄▄▄▄▄▄▄▄";
            }
            if (_5x3 == 2 || _5x3 == 13)
            {
                _3x2topcell = "▄▄▄▄▄▄▄▄▄";
            }
            if (_5x5 == 2 || _5x5 == 13)
            {
                _3x3topcell = "▄▄▄▄▄▄▄▄▄";
            }
            if (_5x7 == 2 || _5x7 == 13)
            {
                _3x4topcell = "▄▄▄▄▄▄▄▄▄";
            }
            if (_5x9 == 2 || _5x9 == 13)
            {
                _3x5topcell = "▄▄▄▄▄▄▄▄▄";
            }
            if (_5x11 == 2 || _5x11 == 13)
            {
                _3x6topcell = "▄▄▄▄▄▄▄▄▄";
            }
            if (_5x13 == 2 || _5x13 == 13)
            {
                _3x7topcell = "▄▄▄▄▄▄▄▄▄";
            }
            if (_5x15 == 2 || _5x15 == 13)
            {
                _3x8topcell = "▄▄▄▄▄▄▄▄▄";
            }
            if (_5x17 == 2 || _5x17 == 13)
            {
                _3x9topcell = "▄▄▄▄▄▄▄▄▄";
            }
            if (_7x1 == 2 || _7x1 == 13)
            {
                _4x1topcell = "▄▄▄▄▄▄▄▄▄";
            }
            if (_7x3 == 2 || _7x3 == 13)
            {
                _4x2topcell = "▄▄▄▄▄▄▄▄▄";
            }
            if (_7x5 == 2 || _7x5 == 13)
            {
                _4x3topcell = "▄▄▄▄▄▄▄▄▄";
            }
            if (_7x7 == 2 || _7x7 == 13)
            {
                _4x4topcell = "▄▄▄▄▄▄▄▄▄";
            }
            if (_7x9 == 2 || _7x9 == 13)
            {
                _4x5topcell = "▄▄▄▄▄▄▄▄▄";
            }
            if (_7x11 == 2 || _7x11 == 13)
            {
                _4x6topcell = "▄▄▄▄▄▄▄▄▄";
            }
            if (_7x13 == 2 || _7x13 == 13)
            {
                _4x7topcell = "▄▄▄▄▄▄▄▄▄";
            }
            if (_7x15 == 2 || _7x15 == 13)
            {
                _4x8topcell = "▄▄▄▄▄▄▄▄▄";
            }
            if (_7x17 == 2 || _7x17 == 13)
            {
                _4x9topcell = "▄▄▄▄▄▄▄▄▄";
            }


            //vertical coridors 1
            if (_2x1 == 1)
            {
                _1x1corivert = "║";
            }
            if (_2x2 == 1)
            {
                _1x2corivert = "║";
            }
            if (_2x3 == 1)
            {
                _1x3corivert = "║";
            }
            if (_2x4 == 1)
            {
                _1x4corivert = "║";
            }
            if (_2x5 == 1)
            {
                _1x5corivert = "║";
            }
            if (_2x6 == 1)
            {
                _1x6corivert = "║";
            }
            if (_2x7 == 1)
            {
                _1x7corivert = "║";
            }
            if (_2x8 == 1)
            {
                _1x8corivert = "║";
            }
            if (_2x9 == 1)
            {
                _1x9corivert = "║";
            }
            if (_4x1 == 1)
            {
                _2x1corivert = "║";
            }
            if (_4x2 == 1)
            {
                _2x2corivert = "║";
            }
            if (_4x3 == 1)
            {
                _2x3corivert = "║";
            }
            if (_4x4 == 1)
            {
                _2x4corivert = "║";
            }
            if (_4x5 == 1)
            {
                _2x5corivert = "║";
            }
            if (_4x6 == 1)
            {
                _2x6corivert = "║";
            }
            if (_4x7 == 1)
            {
                _2x7corivert = "║";
            }
            if (_4x8 == 1)
            {
                _2x8corivert = "║";
            }
            if (_4x9 == 1)
            {
                _2x9corivert = "║";
            }
            if (_6x1 == 1)
            {
                _3x1corivert = "║";
            }
            if (_6x2 == 1)
            {
                _3x2corivert = "║";
            }
            if (_6x3 == 1)
            {
                _3x3corivert = "║";
            }
            if (_6x4 == 1)
            {
                _3x4corivert = "║";
            }
            if (_6x5 == 1)
            {
                _3x5corivert = "║";
            }
            if (_6x6 == 1)
            {
                _3x6corivert = "║";
            }
            if (_6x7 == 1)
            {
                _3x7corivert = "║";
            }
            if (_6x8 == 1)
            {
                _3x8corivert = "║";
            }
            if (_6x9 == 1)
            {
                _3x9corivert = "║";
            }
            //horizontal coridors 1
            if (_1x2 == 1)
            {
                _1x1corihorz = "----";
            }
            if (_1x4 == 1)
            {
                _1x2corihorz = "----";
            }
            if (_1x6 == 1)
            {
                _1x3corihorz = "----";
            }
            if (_1x8 == 1)
            {
                _1x4corihorz = "----";
            }
            if (_1x10 == 1)
            {
                _1x5corihorz = "----";
            }
            if (_1x12 == 1)
            {
                _1x6corihorz = "----";
            }
            if (_1x14 == 1)
            {
                _1x7corihorz = "----";
            }
            if (_1x16 == 1)
            {
                _1x8corihorz = "----";
            }
            if (_3x2 == 1)
            {
                _2x1corihorz = "----";
            }
            if (_3x4 == 1)
            {
                _2x2corihorz = "----";
            }
            if (_3x6 == 1)
            {
                _2x3corihorz = "----";
            }
            if (_3x8 == 1)
            {
                _2x4corihorz = "----";
            }
            if (_3x10 == 1)
            {
                _2x5corihorz = "----";
            }
            if (_3x12 == 1)
            {
                _2x6corihorz = "----";
            }
            if (_3x14 == 1)
            {
                _2x7corihorz = "----";
            }
            if (_3x16 == 1)
            {
                _2x8corihorz = "----";
            }
            if (_5x2 == 1)
            {
                _3x1corihorz = "----";
            }
            if (_5x4 == 1)
            {
                _3x2corihorz = "----";
            }
            if (_5x6 == 1)
            {
                _3x3corihorz = "----";
            }
            if (_5x8 == 1)
            {
                _3x4corihorz = "----";
            }
            if (_5x10 == 1)
            {
                _3x5corihorz = "----";
            }
            if (_5x12 == 1)
            {
                _3x6corihorz = "----";
            }
            if (_5x14 == 1)
            {
                _3x7corihorz = "----";
            }
            if (_5x16 == 1)
            {
                _3x8corihorz = "----";
            }
            if (_7x2 == 1)
            {
                _4x1corihorz = "----";
            }
            if (_7x4 == 1)
            {
                _4x2corihorz = "----";
            }
            if (_7x6 == 1)
            {
                _4x3corihorz = "----";
            }
            if (_7x8 == 1)
            {
                _4x4corihorz = "----";
            }
            if (_7x10 == 1)
            {
                _4x5corihorz = "----";
            }
            if (_7x12 == 1)
            {
                _4x6corihorz = "----";
            }
            if (_7x14 == 1)
            {
                _4x7corihorz = "----";
            }
            if (_7x16 == 1)
            {
                _4x8corihorz = "----";
            }



            //actual render
            Console.Clear();
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------" +
                          "\r\n  |Health|:" + set1 + " |Gold|:" + set2 + " |Exp|: " + set3 +
                          "\r\n------------------------------------------------------------------------------------------------------------------------" +
                          "\r\n                                                                                                                        " +
                          "\r\n    " + _1x1topcell + "    " + _1x2topcell + "    " + _1x3topcell + "    " + _1x4topcell + "    " + _1x5topcell + "    " + _1x6topcell + "    " + _1x7topcell + "    " + _1x8topcell + "    " + _1x9topcell + "   " +
                          "\r\n    " + _1x1sidecell + _1x1bodycell + _1x1iconcell + _1x1bodycell + _1x1sidecell + _1x1corihorz + _1x2sidecell + _1x2bodycell + _1x2iconcell + _1x2bodycell + _1x2sidecell + _1x2corihorz + _1x3sidecell + _1x3bodycell + _1x3iconcell + _1x3bodycell + _1x3sidecell + _1x3corihorz + _1x4sidecell + _1x4bodycell + _1x4iconcell + _1x4bodycell + _1x4sidecell + _1x4corihorz + _1x5sidecell + _1x5bodycell + _1x5iconcell + _1x5bodycell + _1x5sidecell + _1x5corihorz + _1x6sidecell + _1x6bodycell + _1x6iconcell + _1x6bodycell + _1x6sidecell + _1x6corihorz + _1x7sidecell + _1x7bodycell + _1x7iconcell + _1x7bodycell + _1x7sidecell + _1x7corihorz + _1x8sidecell + _1x8bodycell + _1x8iconcell + _1x8bodycell + _1x8sidecell + _1x8corihorz + _1x9sidecell + _1x9bodycell + _1x9iconcell + _1x9bodycell + _1x9sidecell + "   " +
                          "\r\n    " + _1x1sidecell + _1x1bodycell + _1x1iconcellb + _1x1bodycell + _1x1sidecell + _1x1corihorz + _1x2sidecell + _1x2bodycell + _1x2iconcellb + _1x2bodycell + _1x2sidecell + _1x2corihorz + _1x3sidecell + _1x3bodycell + _1x3iconcellb + _1x3bodycell + _1x3sidecell + _1x3corihorz + _1x4sidecell + _1x4bodycell + _1x4iconcellb + _1x4bodycell + _1x4sidecell + _1x4corihorz + _1x5sidecell + _1x5bodycell + _1x5iconcellb + _1x5bodycell + _1x5sidecell + _1x5corihorz + _1x6sidecell + _1x6bodycell + _1x6iconcellb + _1x6bodycell + _1x6sidecell + _1x6corihorz + _1x7sidecell + _1x7bodycell + _1x7iconcellb + _1x7bodycell + _1x7sidecell + _1x7corihorz + _1x8sidecell + _1x8bodycell + _1x8iconcellb + _1x8bodycell + _1x8sidecell + _1x8corihorz + _1x9sidecell + _1x9bodycell + _1x9iconcellb + _1x9bodycell + _1x9sidecell + "   " +
                          "\r\n    " + _1x1botcell + "    " + _1x2botcell + "    " + _1x3botcell + "    " + _1x4botcell + "    " + _1x5botcell + "    " + _1x6botcell + "    " + _1x7botcell + "    " + _1x8botcell + "    " + _1x9botcell + "   " +
                          "\r\n        " + _1x1corivert + "            " + _1x2corivert + "            " + _1x3corivert + "            " + _1x4corivert + "            " + _1x5corivert + "            " + _1x6corivert + "            " + _1x7corivert + "            " + _1x8corivert + "            " + _1x9corivert + "       " +
                          "\r\n        " + _1x1corivert + "            " + _1x2corivert + "            " + _1x3corivert + "            " + _1x4corivert + "            " + _1x5corivert + "            " + _1x6corivert + "            " + _1x7corivert + "            " + _1x8corivert + "            " + _1x9corivert + "       " +
                          "\r\n    " + _2x1topcell + "    " + _2x2topcell + "    " + _2x3topcell + "    " + _2x4topcell + "    " + _2x5topcell + "    " + _2x6topcell + "    " + _2x7topcell + "    " + _2x8topcell + "    " + _2x9topcell + "   " +
                          "\r\n    " + _2x1sidecell + _2x1bodycell + _2x1iconcell + _2x1bodycell + _2x1sidecell + _2x1corihorz + _2x2sidecell + _2x2bodycell + _2x2iconcell + _2x2bodycell + _2x2sidecell + _2x2corihorz + _2x3sidecell + _2x3bodycell + _2x3iconcell + _2x3bodycell + _2x3sidecell + _2x3corihorz + _2x4sidecell + _2x4bodycell + _2x4iconcell + _2x4bodycell + _2x4sidecell + _2x4corihorz + _2x5sidecell + _2x5bodycell + _2x5iconcell + _2x5bodycell + _2x5sidecell + _2x5corihorz + _2x6sidecell + _2x6bodycell + _2x6iconcell + _2x6bodycell + _2x6sidecell + _2x6corihorz + _2x7sidecell + _2x7bodycell + _2x7iconcell + _2x7bodycell + _2x7sidecell + _2x7corihorz + _2x8sidecell + _2x8bodycell + _2x8iconcell + _2x8bodycell + _2x8sidecell + _2x8corihorz + _2x9sidecell + _2x9bodycell + _2x9iconcell + _2x9bodycell + _2x9sidecell + "   " +
                          "\r\n    " + _2x1sidecell + _2x1bodycell + _2x1iconcellb + _2x1bodycell + _2x1sidecell + _2x1corihorz + _2x2sidecell + _2x2bodycell + _2x2iconcellb + _2x2bodycell + _2x2sidecell + _2x2corihorz + _2x3sidecell + _2x3bodycell + _2x3iconcellb + _2x3bodycell + _2x3sidecell + _2x3corihorz + _2x4sidecell + _2x4bodycell + _2x4iconcellb + _2x4bodycell + _2x4sidecell + _2x4corihorz + _2x5sidecell + _2x5bodycell + _2x5iconcellb + _2x5bodycell + _2x5sidecell + _2x5corihorz + _2x6sidecell + _2x6bodycell + _2x6iconcellb + _2x6bodycell + _2x6sidecell + _2x6corihorz + _2x7sidecell + _2x7bodycell + _2x7iconcellb + _2x7bodycell + _2x7sidecell + _2x7corihorz + _2x8sidecell + _2x8bodycell + _2x8iconcellb + _2x8bodycell + _2x8sidecell + _2x8corihorz + _2x9sidecell + _2x9bodycell + _2x9iconcellb + _2x9bodycell + _2x9sidecell + "   " +
                          "\r\n    " + _2x1botcell + "    " + _2x2botcell + "    " + _2x3botcell + "    " + _2x4botcell + "    " + _2x5botcell + "    " + _2x6botcell + "    " + _2x7botcell + "    " + _2x8botcell + "    " + _2x9botcell + "   " +
                          "\r\n        " + _2x1corivert + "            " + _2x2corivert + "            " + _2x3corivert + "            " + _2x4corivert + "            " + _2x5corivert + "            " + _2x6corivert + "            " + _2x7corivert + "            " + _2x8corivert + "            " + _2x9corivert + "       " +
                          "\r\n        " + _2x1corivert + "            " + _2x2corivert + "            " + _2x3corivert + "            " + _2x4corivert + "            " + _2x5corivert + "            " + _2x6corivert + "            " + _2x7corivert + "            " + _2x8corivert + "            " + _2x9corivert + "       " +
                          "\r\n    " + _3x1topcell + "    " + _3x2topcell + "    " + _3x3topcell + "    " + _3x4topcell + "    " + _3x5topcell + "    " + _3x6topcell + "    " + _3x7topcell + "    " + _3x8topcell + "    " + _3x9topcell + "   " +
                          "\r\n    " + _3x1sidecell + _3x1bodycell + _3x1iconcell + _3x1bodycell + _3x1sidecell + _3x1corihorz + _3x2sidecell + _3x2bodycell + _3x2iconcell + _3x2bodycell + _3x2sidecell + _3x2corihorz + _3x3sidecell + _3x3bodycell + _3x3iconcell + _3x3bodycell + _3x3sidecell + _3x3corihorz + _3x4sidecell + _3x4bodycell + _3x4iconcell + _3x4bodycell + _3x4sidecell + _3x4corihorz + _3x5sidecell + _3x5bodycell + _3x5iconcell + _3x5bodycell + _3x5sidecell + _3x5corihorz + _3x6sidecell + _3x6bodycell + _3x6iconcell + _3x6bodycell + _3x6sidecell + _3x6corihorz + _3x7sidecell + _3x7bodycell + _3x7iconcell + _3x7bodycell + _3x7sidecell + _3x7corihorz + _3x8sidecell + _3x8bodycell + _3x8iconcell + _3x8bodycell + _3x8sidecell + _3x8corihorz + _3x9sidecell + _3x9bodycell + _3x9iconcell + _3x9bodycell + _3x9sidecell + "   " +
                          "\r\n    " + _3x1sidecell + _3x1bodycell + _3x1iconcellb + _3x1bodycell + _3x1sidecell + _3x1corihorz + _3x2sidecell + _3x2bodycell + _3x2iconcellb + _3x2bodycell + _3x2sidecell + _3x2corihorz + _3x3sidecell + _3x3bodycell + _3x3iconcellb + _3x3bodycell + _3x3sidecell + _3x3corihorz + _3x4sidecell + _3x4bodycell + _3x4iconcellb + _3x4bodycell + _3x4sidecell + _3x4corihorz + _3x5sidecell + _3x5bodycell + _3x5iconcellb + _3x5bodycell + _3x5sidecell + _3x5corihorz + _3x6sidecell + _3x6bodycell + _3x6iconcellb + _3x6bodycell + _3x6sidecell + _3x6corihorz + _3x7sidecell + _3x7bodycell + _3x7iconcellb + _3x7bodycell + _3x7sidecell + _3x7corihorz + _3x8sidecell + _3x8bodycell + _3x8iconcellb + _3x8bodycell + _3x8sidecell + _3x8corihorz + _3x9sidecell + _3x9bodycell + _3x9iconcellb + _3x9bodycell + _3x9sidecell + "   " +
                          "\r\n    " + _3x1botcell + "    " + _3x2botcell + "    " + _3x3botcell + "    " + _3x4botcell + "    " + _3x5botcell + "    " + _3x6botcell + "    " + _3x7botcell + "    " + _3x8botcell + "    " + _3x9botcell + "   " +
                          "\r\n        " + _3x1corivert + "            " + _3x2corivert + "            " + _3x3corivert + "            " + _3x4corivert + "            " + _3x5corivert + "            " + _3x6corivert + "            " + _3x7corivert + "            " + _3x8corivert + "            " + _3x9corivert + "       " +
                          "\r\n        " + _3x1corivert + "            " + _3x2corivert + "            " + _3x3corivert + "            " + _3x4corivert + "            " + _3x5corivert + "            " + _3x6corivert + "            " + _3x7corivert + "            " + _3x8corivert + "            " + _3x9corivert + "       " +
                          "\r\n    " + _4x1topcell + "    " + _4x2topcell + "    " + _4x3topcell + "    " + _4x4topcell + "    " + _4x5topcell + "    " + _4x6topcell + "    " + _4x7topcell + "    " + _4x8topcell + "    " + _4x9topcell + "   " +
                          "\r\n    " + _4x1sidecell + _4x1bodycell + _4x1iconcell + _4x1bodycell + _4x1sidecell + _4x1corihorz + _4x2sidecell + _4x2bodycell + _4x2iconcell + _4x2bodycell + _4x2sidecell + _4x2corihorz + _4x3sidecell + _4x3bodycell + _4x3iconcell + _4x3bodycell + _4x3sidecell + _4x3corihorz + _4x4sidecell + _4x4bodycell + _4x4iconcell + _4x4bodycell + _4x4sidecell + _4x4corihorz + _4x5sidecell + _4x5bodycell + _4x5iconcell + _4x5bodycell + _4x5sidecell + _4x5corihorz + _4x6sidecell + _4x6bodycell + _4x6iconcell + _4x6bodycell + _4x6sidecell + _4x6corihorz + _4x7sidecell + _4x7bodycell + _4x7iconcell + _4x7bodycell + _4x7sidecell + _4x7corihorz + _4x8sidecell + _4x8bodycell + _4x8iconcell + _4x8bodycell + _4x8sidecell + _4x8corihorz + _4x9sidecell + _4x9bodycell + _4x9iconcell + _4x9bodycell + _4x9sidecell + "   " +
                          "\r\n    " + _4x1sidecell + _4x1bodycell + _4x1iconcellb + _4x1bodycell + _4x1sidecell + _4x1corihorz + _4x2sidecell + _4x2bodycell + _4x2iconcellb + _4x2bodycell + _4x2sidecell + _4x2corihorz + _4x3sidecell + _4x3bodycell + _4x3iconcellb + _4x3bodycell + _4x3sidecell + _4x3corihorz + _4x4sidecell + _4x4bodycell + _4x4iconcellb + _4x4bodycell + _4x4sidecell + _4x4corihorz + _4x5sidecell + _4x5bodycell + _4x5iconcellb + _4x5bodycell + _4x5sidecell + _4x5corihorz + _4x6sidecell + _4x6bodycell + _4x6iconcellb + _4x6bodycell + _4x6sidecell + _4x6corihorz + _4x7sidecell + _4x7bodycell + _4x7iconcellb + _4x7bodycell + _4x7sidecell + _4x7corihorz + _4x8sidecell + _4x8bodycell + _4x8iconcellb + _4x8bodycell + _4x8sidecell + _4x8corihorz + _4x9sidecell + _4x9bodycell + _4x9iconcellb + _4x9bodycell + _4x9sidecell + "   " +
                          "\r\n    " + _4x1botcell + "    " + _4x2botcell + "    " + _4x3botcell + "    " + _4x4botcell + "    " + _4x5botcell + "    " + _4x6botcell + "    " + _4x7botcell + "    " + _4x8botcell + "    " + _4x9botcell + "   " +
                          "\r\n                                                                                                                        " +
                          "\r\n------------------------------------------------------------------------------------------------------------------------" +
                          "\n\r   [1] Numpad 1  |  [2] Numpad 2  |  [3] Numpad 3  |  [Back] Backspace                                              " +
                          "\n\r------------------------------------------------------------------------------------------------------------------------");

            player = true;
            break;
        }

        while (inventory)
        {

        }

        while (player)
        {
            switch (Console.ReadKey().Key)
            {
                case ConsoleKey.Backspace:

                    //chosg2 = 1;
                    break;
                case ConsoleKey.UpArrow:
                    chosg2 = 1;
                    player = false;
                    break;
                case ConsoleKey.LeftArrow:
                    chosg2 = 2;
                    player = false;
                    break;
                case ConsoleKey.RightArrow:
                    chosg2 = 3;
                    player = false;
                    break;
                case ConsoleKey.DownArrow:
                    player = false;
                    chosg2 = 4;
                    break;
                case ConsoleKey.W:
                    player = false;
                    chosg2 = 1;
                    break;
                case ConsoleKey.A:
                    player = false;
                    chosg2 = 2;
                    break;
                case ConsoleKey.D:
                    player = false;
                    chosg2 = 3;
                    break;
                case ConsoleKey.S:
                    player = false;
                    chosg2 = 4;
                    break;
                case ConsoleKey.NumPad1:
                    chosg2 = 5;
                    break;
                case ConsoleKey.NumPad2:
                    //load = true;
                    chosg2 = 6;
                    break;
                case ConsoleKey.NumPad3:
                    //load = true;
                    break;
                case ConsoleKey.Enter:
                    break;
            }
            // up
            if (chosg2 == 1)
            {
                if (_3x1 == 13)
                {
                    if (_2x1 == 1)
                    {
                        if (_1x1 == 3)
                        {
                            _1x1 = 13;
                            battle = true;
                        }
                        else if (_1x1 == 4)
                        {
                            _1x1 = 13;
                            _event = true;
                        }
                        else if (_1x1 == 5)
                        {
                            _1x1 = 13;
                            boss = true;
                        }
                        else if (_1x1 == 6)
                        {
                            _1x1 = 13;
                            shop = true;
                        }
                        else if (_1x1 == 11)
                        {
                            _1x1 = 13;

                        }
                        else if (_1x1 == 2)
                        {
                            _1x1 = 13;

                        }
                        _3x1 = 2;
                    }
                }
                if (_3x3 == 13)
                {
                    if (_2x2 == 1)
                    {
                        if (_1x3 == 3)
                        {
                            _1x3 = 13;
                            battle = true;
                        }
                        else if (_1x3 == 4)
                        {
                            _1x3 = 13;
                            _event = true;
                        }
                        else if (_1x3 == 5)
                        {
                            _1x3 = 13;
                            boss = true;
                        }
                        else if (_1x3 == 6)
                        {
                            _1x3 = 13;
                            shop = true;
                        }
                        else if (_1x3 == 11)
                        {
                            _1x3 = 13;

                        }
                        else if (_1x3 == 2)
                        {
                            _1x3 = 13;

                        }
                        _3x3 = 2;
                    }
                }
                if (_3x5 == 13)
                {
                    if (_2x3 == 1)
                    {
                        if (_1x5 == 3)
                        {
                            _1x5 = 13;
                            battle = true;
                        }
                        else if (_1x5 == 4)
                        {
                            _1x5 = 13;
                            _event = true;
                        }
                        else if (_1x5 == 5)
                        {
                            _1x5 = 13;
                            boss = true;
                        }
                        else if (_1x5 == 6)
                        {
                            _1x5 = 13;
                            shop = true;
                        }
                        else if (_1x5 == 11)
                        {
                            _1x5 = 13;

                        }
                        else if (_1x5 == 2)
                        {
                            _1x5 = 13;

                        }
                        _3x5 = 2;
                    }
                }
                if (_3x7 == 13)
                {
                    if (_2x4 == 1)
                    {
                        if (_1x7 == 3)
                        {
                            _1x7 = 13;
                            battle = true;
                        }
                        else if (_1x7 == 4)
                        {
                            _1x7 = 13;
                            _event = true;
                        }
                        else if (_1x7 == 5)
                        {
                            _1x7 = 13;
                            boss = true;
                        }
                        else if (_1x7 == 6)
                        {
                            _1x7 = 13;
                            shop = true;
                        }
                        else if (_1x7 == 11)
                        {
                            _1x7 = 13;

                        }
                        else if (_1x7 == 2)
                        {
                            _1x7 = 13;

                        }
                        _3x7 = 2;
                    }
                }
                if (_3x9 == 13)
                {
                    if (_2x5 == 1)
                    {
                        if (_1x9 == 3)
                        {
                            _1x9 = 13;
                            battle = true;
                        }
                        else if (_1x9 == 4)
                        {
                            _1x9 = 13;
                            _event = true;
                        }
                        else if (_1x9 == 5)
                        {
                            _1x9 = 13;
                            boss = true;
                        }
                        else if (_1x9 == 6)
                        {
                            _1x9 = 13;
                            shop = true;
                        }
                        else if (_1x9 == 11)
                        {
                            _1x9 = 13;

                        }
                        else if (_1x9 == 2)
                        {
                            _1x9 = 13;

                        }
                        _3x9 = 2;
                    }
                }
                if (_3x11 == 13)
                {
                    if (_2x6 == 1)
                    {
                        if (_1x11 == 3)
                        {
                            _1x11 = 13;
                            battle = true;
                        }
                        else if (_1x11 == 4)
                        {
                            _1x11 = 13;
                            _event = true;
                        }
                        else if (_1x11 == 5)
                        {
                            _1x11 = 13;
                            boss = true;
                        }
                        else if (_1x11 == 6)
                        {
                            _1x11 = 13;
                            shop = true;
                        }
                        else if (_1x11 == 11)
                        {
                            _1x11 = 13;

                        }
                        else if (_1x11 == 2)
                        {
                            _1x11 = 13;

                        }
                        _3x11 = 2;
                    }
                }
                if (_3x13 == 13)
                {
                    if (_2x7 == 1)
                    {
                        if (_1x13 == 3)
                        {
                            _1x13 = 13;
                            battle = true;
                        }
                        else if (_1x13 == 4)
                        {
                            _1x13 = 13;
                            _event = true;
                        }
                        else if (_1x13 == 5)
                        {
                            _1x13 = 13;
                            boss = true;
                        }
                        else if (_1x13 == 6)
                        {
                            _1x13 = 13;
                            shop = true;
                        }
                        else if (_1x13 == 11)
                        {
                            _1x13 = 13;

                        }
                        else if (_1x13 == 2)
                        {
                            _1x13 = 13;

                        }
                        _3x13 = 2;
                    }
                }
                if (_3x15 == 13)
                {
                    if (_2x8 == 1)
                    {
                        if (_1x15 == 3)
                        {
                            _1x15 = 13;
                            battle = true;
                        }
                        else if (_1x15 == 4)
                        {
                            _1x15 = 13;
                            _event = true;
                        }
                        else if (_1x15 == 5)
                        {
                            _1x15 = 13;
                            boss = true;
                        }
                        else if (_1x15 == 6)
                        {
                            _1x15 = 13;
                            shop = true;
                        }
                        else if (_1x15 == 11)
                        {
                            _1x15 = 13;

                        }
                        else if (_1x15 == 2)
                        {
                            _1x15 = 13;

                        }
                        _3x15 = 2;
                    }
                }
                if (_3x17 == 13)
                {
                    if (_2x9 == 1)
                    {
                        if (_1x17 == 3)
                        {
                            _1x17 = 13;
                            battle = true;
                        }
                        else if (_1x17 == 4)
                        {
                            _1x17 = 13;
                            _event = true;
                        }
                        else if (_1x17 == 5)
                        {
                            _1x17 = 13;
                            boss = true;
                        }
                        else if (_1x17 == 6)
                        {
                            _1x17 = 13;
                            shop = true;
                        }
                        else if (_1x17 == 11)
                        {
                            _1x17 = 13;

                        }
                        else if (_1x17 == 2)
                        {
                            _1x17 = 13;

                        }
                        _3x17 = 2;
                    }
                }
                if (_5x1 == 13)
                {
                    if (_4x1 == 1)
                    {
                        if (_3x1 == 3)
                        {
                            _3x1 = 13;
                            battle = true;
                        }
                        else if (_3x1 == 4)
                        {
                            _3x1 = 13;
                            _event = true;
                        }
                        else if (_3x1 == 5)
                        {
                            _3x1 = 13;
                            boss = true;
                        }
                        else if (_3x1 == 6)
                        {
                            _3x1 = 13;
                            shop = true;
                        }
                        else if (_3x1 == 11)
                        {
                            _3x1 = 13;

                        }
                        else if (_3x1 == 2)
                        {
                            _3x1 = 13;

                        }
                        _5x1 = 2;
                    }
                }
                if (_5x3 == 13)
                {
                    if (_4x2 == 1)
                    {
                        if (_3x3 == 3)
                        {
                            _3x3 = 13;
                            battle = true;
                        }
                        else if (_3x3 == 4)
                        {
                            _3x3 = 13;
                            _event = true;
                        }
                        else if (_3x3 == 5)
                        {
                            _3x3 = 13;
                            boss = true;
                        }
                        else if (_3x3 == 6)
                        {
                            _3x3 = 13;
                            shop = true;
                        }
                        else if (_3x3 == 11)
                        {
                            _3x3 = 13;

                        }
                        else if (_3x3 == 2)
                        {
                            _3x3 = 13;

                        }
                        _5x3 = 2;
                    }
                }
                if (_5x5 == 13)
                {
                    if (_4x3 == 1)
                    {
                        if (_3x5 == 3)
                        {
                            _3x5 = 13;
                            battle = true;
                        }
                        else if (_3x5 == 4)
                        {
                            _3x5 = 13;
                            _event = true;
                        }
                        else if (_3x5 == 5)
                        {
                            _3x5 = 13;
                            boss = true;
                        }
                        else if (_3x5 == 6)
                        {
                            _3x5 = 13;
                            shop = true;
                        }
                        else if (_3x5 == 11)
                        {
                            _3x5 = 13;

                        }
                        else if (_3x5 == 2)
                        {
                            _3x5 = 13;

                        }
                        _5x5 = 2;
                    }
                }
                if (_5x7 == 13)
                {
                    if (_4x4 == 1)
                    {
                        if (_3x7 == 3)
                        {
                            _3x7 = 13;
                            battle = true;
                        }
                        else if (_3x7 == 4)
                        {
                            _3x7 = 13;
                            _event = true;
                        }
                        else if (_3x7 == 5)
                        {
                            _3x7 = 13;
                            boss = true;
                        }
                        else if (_3x7 == 6)
                        {
                            _3x7 = 13;
                            shop = true;
                        }
                        else if (_3x7 == 11)
                        {
                            _3x7 = 13;

                        }
                        else if (_3x7 == 2)
                        {
                            _3x7 = 13;

                        }
                        _5x7 = 2;
                    }
                }
                if (_5x9 == 13)
                {
                    if (_4x5 == 1)
                    {
                        if (_3x9 == 3)
                        {
                            _3x9 = 13;
                            battle = true;
                        }
                        else if (_3x9 == 4)
                        {
                            _3x9 = 13;
                            _event = true;
                        }
                        else if (_3x9 == 5)
                        {
                            _3x9 = 13;
                            boss = true;
                        }
                        else if (_3x9 == 6)
                        {
                            _3x9 = 13;
                            shop = true;
                        }
                        else if (_3x9 == 11)
                        {
                            _3x9 = 13;

                        }
                        else if (_3x9 == 2)
                        {
                            _3x9 = 13;

                        }
                        _5x9 = 2;
                    }
                }
                if (_5x11 == 13)
                {
                    if (_4x6 == 1)
                    {
                        if (_3x11 == 3)
                        {
                            _3x11 = 13;
                            battle = true;
                        }
                        else if (_3x11 == 4)
                        {
                            _3x11 = 13;
                            _event = true;
                        }
                        else if (_3x11 == 5)
                        {
                            _3x11 = 13;
                            boss = true;
                        }
                        else if (_3x11 == 6)
                        {
                            _3x11 = 13;
                            shop = true;
                        }
                        else if (_3x11 == 11)
                        {
                            _3x11 = 13;

                        }
                        else if (_3x11 == 2)
                        {
                            _3x11 = 13;

                        }
                        _5x11 = 2;
                    }
                }
                if (_5x13 == 13)
                {
                    if (_4x7 == 1)
                    {
                        if (_3x13 == 3)
                        {
                            _3x13 = 13;
                            battle = true;
                        }
                        else if (_3x13 == 4)
                        {
                            _3x13 = 13;
                            _event = true;
                        }
                        else if (_3x13 == 5)
                        {
                            _3x13 = 13;
                            boss = true;
                        }
                        else if (_3x13 == 6)
                        {
                            _3x13 = 13;
                            shop = true;
                        }
                        else if (_3x13 == 11)
                        {
                            _3x13 = 13;

                        }
                        else if (_3x13 == 2)
                        {
                            _3x13 = 13;

                        }
                        _5x13 = 2;
                    }
                }
                if (_5x15 == 13)
                {
                    if (_4x8 == 1)
                    {
                        if (_3x15 == 3)
                        {
                            _3x15 = 13;
                            battle = true;
                        }
                        else if (_3x15 == 4)
                        {
                            _3x15 = 13;
                            _event = true;
                        }
                        else if (_3x15 == 5)
                        {
                            _3x15 = 13;
                            boss = true;
                        }
                        else if (_3x15 == 6)
                        {
                            _3x15 = 13;
                            shop = true;
                        }
                        else if (_3x15 == 11)
                        {
                            _3x15 = 13;

                        }
                        else if (_3x15 == 2)
                        {
                            _3x15 = 13;

                        }
                        _5x15 = 2;
                    }
                }
                if (_5x17 == 13)
                {
                    if (_4x9 == 1)
                    {
                        if (_3x17 == 3)
                        {
                            _3x17 = 13;
                            battle = true;
                        }
                        else if (_3x17 == 4)
                        {
                            _3x17 = 13;
                            _event = true;
                        }
                        else if (_3x17 == 5)
                        {
                            _3x17 = 13;
                            boss = true;
                        }
                        else if (_3x17 == 6)
                        {
                            _3x17 = 13;
                            shop = true;
                        }
                        else if (_3x17 == 11)
                        {
                            _3x17 = 13;

                        }
                        else if (_3x17 == 2)
                        {
                            _3x17 = 13;

                        }
                        _5x17 = 2;
                    }
                }
                if (_7x1 == 13)
                {
                    if (_6x1 == 1)
                    {
                        if (_5x1 == 3)
                        {
                            _5x1 = 13;
                            battle = true;
                        }
                        else if (_5x1 == 4)
                        {
                            _5x1 = 13;
                            _event = true;
                        }
                        else if (_5x1 == 5)
                        {
                            _5x1 = 13;
                            boss = true;
                        }
                        else if (_5x1 == 6)
                        {
                            _5x1 = 13;
                            shop = true;
                        }
                        else if (_5x1 == 11)
                        {
                            _5x1 = 13;

                        }
                        else if (_5x1 == 2)
                        {
                            _5x1 = 13;

                        }
                        _7x1 = 2;
                    }
                }
                if (_7x3 == 13)
                {
                    if (_6x2 == 1)
                    {
                        if (_5x3 == 3)
                        {
                            _5x3 = 13;
                            battle = true;
                        }
                        else if (_5x3 == 4)
                        {
                            _5x3 = 13;
                            _event = true;
                        }
                        else if (_5x3 == 5)
                        {
                            _5x3 = 13;
                            boss = true;
                        }
                        else if (_5x3 == 6)
                        {
                            _5x3 = 13;
                            shop = true;
                        }
                        else if (_5x3 == 11)
                        {
                            _5x3 = 13;

                        }
                        else if (_5x3 == 2)
                        {
                            _5x3 = 13;

                        }
                        _7x3 = 2;
                    }
                }
                if (_7x5 == 13)
                {
                    if (_6x3 == 1)
                    {
                        if (_5x5 == 3)
                        {
                            _5x5 = 13;
                            battle = true;
                        }
                        else if (_5x5 == 4)
                        {
                            _5x5 = 13;
                            _event = true;
                        }
                        else if (_5x5 == 5)
                        {
                            _5x5 = 13;
                            boss = true;
                        }
                        else if (_5x5 == 6)
                        {
                            _5x5 = 13;
                            shop = true;
                        }
                        else if (_5x5 == 11)
                        {
                            _5x5 = 13;

                        }
                        else if (_5x5 == 2)
                        {
                            _5x5 = 13;

                        }
                        _7x5 = 2;
                    }
                }
                if (_7x7 == 13)
                {
                    if (_6x4 == 1)
                    {
                        if (_5x7 == 3)
                        {
                            _5x7 = 13;
                            battle = true;
                        }
                        else if (_5x7 == 4)
                        {
                            _5x7 = 13;
                            _event = true;
                        }
                        else if (_5x7 == 5)
                        {
                            _5x7 = 13;
                            boss = true;
                        }
                        else if (_5x7 == 6)
                        {
                            _5x7 = 13;
                            shop = true;
                        }
                        else if (_5x7 == 11)
                        {
                            _5x7 = 13;

                        }
                        else if (_5x7 == 2)
                        {
                            _5x7 = 13;

                        }
                        _7x7 = 2;
                    }
                }
                if (_7x9 == 13)
                {
                    if (_6x5 == 1)
                    {
                        if (_5x9 == 3)
                        {
                            _5x9 = 13;
                            battle = true;
                        }
                        else if (_5x9 == 4)
                        {
                            _5x9 = 13;
                            _event = true;
                        }
                        else if (_5x9 == 5)
                        {
                            _5x9 = 13;
                            boss = true;
                        }
                        else if (_5x9 == 6)
                        {
                            _5x9 = 13;
                            shop = true;
                        }
                        else if (_5x9 == 11)
                        {
                            _5x9 = 13;

                        }
                        else if (_5x9 == 2)
                        {
                            _5x9 = 13;

                        }
                        _7x9 = 2;
                    }
                }
                if (_7x11 == 13)
                {
                    if (_6x6 == 1)
                    {
                        if (_5x11 == 3)
                        {
                            _5x11 = 13;
                            battle = true;
                        }
                        else if (_5x11 == 4)
                        {
                            _5x11 = 13;
                            _event = true;
                        }
                        else if (_5x11 == 5)
                        {
                            _5x11 = 13;
                            boss = true;
                        }
                        else if (_5x11 == 6)
                        {
                            _5x11 = 13;
                            shop = true;
                        }
                        else if (_5x11 == 11)
                        {
                            _5x11 = 13;

                        }
                        else if (_5x11 == 2)
                        {
                            _5x11 = 13;

                        }
                        _7x11 = 2;
                    }
                }
                if (_7x13 == 13)
                {
                    if (_6x7 == 1)
                    {
                        if (_5x13 == 3)
                        {
                            _5x13 = 13;
                            battle = true;
                        }
                        else if (_5x13 == 4)
                        {
                            _5x13 = 13;
                            _event = true;
                        }
                        else if (_5x13 == 5)
                        {
                            _5x13 = 13;
                            boss = true;
                        }
                        else if (_5x13 == 6)
                        {
                            _5x13 = 13;
                            shop = true;
                        }
                        else if (_5x13 == 11)
                        {
                            _5x13 = 13;

                        }
                        else if (_5x13 == 2)
                        {
                            _5x13 = 13;

                        }
                        _7x13 = 2;
                    }
                }
                if (_7x15 == 13)
                {
                    if (_6x8 == 1)
                    {
                        if (_5x15 == 3)
                        {
                            _5x15 = 13;
                            battle = true;
                        }
                        else if (_5x15 == 4)
                        {
                            _5x15 = 13;
                            _event = true;
                        }
                        else if (_5x15 == 5)
                        {
                            _5x15 = 13;
                            boss = true;
                        }
                        else if (_5x15 == 6)
                        {
                            _5x15 = 13;
                            shop = true;
                        }
                        else if (_5x15 == 11)
                        {
                            _5x15 = 13;

                        }
                        else if (_5x15 == 2)
                        {
                            _5x15 = 13;

                        }
                        _7x15 = 2;
                    }
                }
                if (_7x17 == 13)
                {
                    if (_6x9 == 1)
                    {
                        if (_5x17 == 3)
                        {
                            _5x17 = 13;
                            battle = true;
                        }
                        else if (_5x17 == 4)
                        {
                            _5x17 = 13;
                            _event = true;
                        }
                        else if (_5x17 == 5)
                        {
                            _5x17 = 13;
                            boss = true;
                        }
                        else if (_5x17 == 6)
                        {
                            _5x17 = 13;
                            shop = true;
                        }
                        else if (_5x17 == 11)
                        {
                            _5x17 = 13;

                        }
                        else if (_5x17 == 2)
                        {
                            _5x17 = 13;

                        }
                        _7x17 = 2;
                    }
                }
            }
            //left
            if (chosg2 == 2)
            {
                if (_1x3 == 13)
                {
                    if (_1x2 == 1)
                    {
                        if (_1x1 == 3)
                        {
                            _1x1 = 13;
                            battle = true;
                        }
                        else if (_1x1 == 4)
                        {
                            _1x1 = 13;
                            _event = true;
                        }
                        else if (_1x1 == 5)
                        {
                            _1x1 = 13;
                            boss = true;
                        }
                        else if (_1x1 == 6)
                        {
                            _1x1 = 13;
                            shop = true;
                        }
                        else if (_1x1 == 11)
                        {
                            _1x1 = 13;

                        }
                        else if (_1x1 == 2)
                        {
                            _1x1 = 13;

                        }
                        _1x3 = 2;
                    }
                }
                if (_1x5 == 13)
                {
                    if (_1x4 == 1)
                    {
                        if (_1x3 == 3)
                        {
                            _1x3 = 13;
                            battle = true;
                        }
                        else if (_1x3 == 4)
                        {
                            _1x3 = 13;
                            _event = true;
                        }
                        else if (_1x3 == 5)
                        {
                            _1x3 = 13;
                            boss = true;
                        }
                        else if (_1x3 == 6)
                        {
                            _1x3 = 13;
                            shop = true;
                        }
                        else if (_1x3 == 11)
                        {
                            _1x3 = 13;

                        }
                        else if (_1x3 == 2)
                        {
                            _1x3 = 13;

                        }
                        _1x5 = 2;
                    }
                }
                if (_1x7 == 13)
                {
                    if (_1x6 == 1)
                    {
                        if (_1x5 == 3)
                        {
                            _1x5 = 13;
                            battle = true;
                        }
                        else if (_1x5 == 4)
                        {
                            _1x5 = 13;
                            _event = true;
                        }
                        else if (_1x5 == 5)
                        {
                            _1x5 = 13;
                            boss = true;
                        }
                        else if (_1x5 == 6)
                        {
                            _1x5 = 13;
                            shop = true;
                        }
                        else if (_1x5 == 11)
                        {
                            _1x5 = 13;

                        }
                        else if (_1x5 == 2)
                        {
                            _1x5 = 13;

                        }
                        _1x7 = 2;
                    }
                }
                if (_1x9 == 13)
                {
                    if (_1x8 == 1)
                    {
                        if (_1x7 == 3)
                        {
                            _1x7 = 13;
                            battle = true;
                        }
                        else if (_1x7 == 4)
                        {
                            _1x7 = 13;
                            _event = true;
                        }
                        else if (_1x7 == 5)
                        {
                            _1x7 = 13;
                            boss = true;
                        }
                        else if (_1x7 == 6)
                        {
                            _1x7 = 13;
                            shop = true;
                        }
                        else if (_1x7 == 11)
                        {
                            _1x7 = 13;

                        }
                        else if (_1x7 == 2)
                        {
                            _1x7 = 13;

                        }
                        _1x9 = 2;
                    }
                }
                if (_1x11 == 13)
                {
                    if (_1x10 == 1)
                    {
                        if (_1x9 == 3)
                        {
                            _1x9 = 13;
                            battle = true;
                        }
                        else if (_1x9 == 4)
                        {
                            _1x9 = 13;
                            _event = true;
                        }
                        else if (_1x9 == 5)
                        {
                            _1x9 = 13;
                            boss = true;
                        }
                        else if (_1x9 == 6)
                        {
                            _1x9 = 13;
                            shop = true;
                        }
                        else if (_1x9 == 11)
                        {
                            _1x9 = 13;

                        }
                        else if (_1x9 == 2)
                        {
                            _1x9 = 13;

                        }
                        _1x11 = 2;
                    }
                }
                if (_1x13 == 13)
                {
                    if (_1x12 == 1)
                    {
                        if (_1x11 == 3)
                        {
                            _1x11 = 13;
                            battle = true;
                        }
                        else if (_1x11 == 4)
                        {
                            _1x11 = 13;
                            _event = true;
                        }
                        else if (_1x11 == 5)
                        {
                            _1x11 = 13;
                            boss = true;
                        }
                        else if (_1x11 == 6)
                        {
                            _1x11 = 13;
                            shop = true;
                        }
                        else if (_1x11 == 11)
                        {
                            _1x11 = 13;

                        }
                        else if (_1x11 == 2)
                        {
                            _1x11 = 13;

                        }
                        _1x13 = 2;
                    }
                }
                if (_1x15 == 13)
                {
                    if (_1x14 == 1)
                    {
                        if (_1x13 == 3)
                        {
                            _1x13 = 13;
                            battle = true;
                        }
                        else if (_1x13 == 4)
                        {
                            _1x13 = 13;
                            _event = true;
                        }
                        else if (_1x13 == 5)
                        {
                            _1x13 = 13;
                            boss = true;
                        }
                        else if (_1x13 == 6)
                        {
                            _1x13 = 13;
                            shop = true;
                        }
                        else if (_1x13 == 11)
                        {
                            _1x13 = 13;

                        }
                        else if (_1x13 == 2)
                        {
                            _1x13 = 13;

                        }
                        _1x15 = 2;
                    }
                }
                if (_1x17 == 13)
                {
                    if (_1x16 == 1)
                    {
                        if (_1x15 == 3)
                        {
                            _1x15 = 13;
                            battle = true;
                        }
                        else if (_1x15 == 4)
                        {
                            _1x15 = 13;
                            _event = true;
                        }
                        else if (_1x15 == 5)
                        {
                            _1x15 = 13;
                            boss = true;
                        }
                        else if (_1x15 == 6)
                        {
                            _1x15 = 13;
                            shop = true;
                        }
                        else if (_1x15 == 11)
                        {
                            _1x15 = 13;

                        }
                        else if (_1x15 == 2)
                        {
                            _1x15 = 13;

                        }
                        _1x17 = 2;
                    }
                }
                if (_3x3 == 13)
                {
                    if (_3x2 == 1)
                    {
                        if (_3x1 == 3)
                        {
                            _3x1 = 13;
                            battle = true;
                        }
                        else if (_3x1 == 4)
                        {
                            _3x1 = 13;
                            _event = true;
                        }
                        else if (_3x1 == 5)
                        {
                            _3x1 = 13;
                            boss = true;
                        }
                        else if (_3x1 == 6)
                        {
                            _3x1 = 13;
                            shop = true;
                        }
                        else if (_3x1 == 11)
                        {
                            _3x1 = 13;

                        }
                        else if (_3x1 == 2)
                        {
                            _3x1 = 13;

                        }
                        _3x3 = 2;
                    }
                }
                if (_3x5 == 13)
                {
                    if (_3x4 == 1)
                    {
                        if (_3x3 == 3)
                        {
                            _3x3 = 13;
                            battle = true;
                        }
                        else if (_3x3 == 4)
                        {
                            _3x3 = 13;
                            _event = true;
                        }
                        else if (_3x3 == 5)
                        {
                            _3x3 = 13;
                            boss = true;
                        }
                        else if (_3x3 == 6)
                        {
                            _3x3 = 13;
                            shop = true;
                        }
                        else if (_3x3 == 11)
                        {
                            _3x3 = 13;

                        }
                        else if (_3x3 == 2)
                        {
                            _3x3 = 13;

                        }
                        _3x5 = 2;
                    }
                }
                if (_3x7 == 13)
                {
                    if (_3x6 == 1)
                    {
                        if (_3x5 == 3)
                        {
                            _3x5 = 13;
                            battle = true;
                        }
                        else if (_3x5 == 4)
                        {
                            _3x5 = 13;
                            _event = true;
                        }
                        else if (_3x5 == 5)
                        {
                            _3x5 = 13;
                            boss = true;
                        }
                        else if (_3x5 == 6)
                        {
                            _3x5 = 13;
                            shop = true;
                        }
                        else if (_3x5 == 11)
                        {
                            _3x5 = 13;

                        }
                        else if (_3x5 == 2)
                        {
                            _3x5 = 13;

                        }
                        _3x7 = 2;
                    }
                }
                if (_3x9 == 13)
                {
                    if (_3x8 == 1)
                    {
                        if (_3x7 == 3)
                        {
                            _3x7 = 13;
                            battle = true;
                        }
                        else if (_3x7 == 4)
                        {
                            _3x7 = 13;
                            _event = true;
                        }
                        else if (_3x7 == 5)
                        {
                            _3x7 = 13;
                            boss = true;
                        }
                        else if (_3x7 == 6)
                        {
                            _3x7 = 13;
                            shop = true;
                        }
                        else if (_3x7 == 11)
                        {
                            _3x7 = 13;

                        }
                        else if (_3x7 == 2)
                        {
                            _3x7 = 13;

                        }
                        _3x9 = 2;
                    }
                }
                if (_3x11 == 13)
                {
                    if (_3x10 == 1)
                    {
                        if (_3x9 == 3)
                        {
                            _3x9 = 13;
                            battle = true;
                        }
                        else if (_3x9 == 4)
                        {
                            _3x9 = 13;
                            _event = true;
                        }
                        else if (_3x9 == 5)
                        {
                            _3x9 = 13;
                            boss = true;
                        }
                        else if (_3x9 == 6)
                        {
                            _3x9 = 13;
                            shop = true;
                        }
                        else if (_3x9 == 11)
                        {
                            _3x9 = 13;

                        }
                        else if (_3x9 == 2)
                        {
                            _3x9 = 13;

                        }
                        _3x11 = 2;
                    }
                }
                if (_3x13 == 13)
                {
                    if (_3x12 == 1)
                    {
                        if (_3x11 == 3)
                        {
                            _3x11 = 13;
                            battle = true;
                        }
                        else if (_3x11 == 4)
                        {
                            _3x11 = 13;
                            _event = true;
                        }
                        else if (_3x11 == 5)
                        {
                            _3x11 = 13;
                            boss = true;
                        }
                        else if (_3x11 == 6)
                        {
                            _3x11 = 13;
                            shop = true;
                        }
                        else if (_3x11 == 11)
                        {
                            _3x11 = 13;

                        }
                        else if (_3x11 == 2)
                        {
                            _3x11 = 13;

                        }
                        _3x13 = 2;
                    }
                }
                if (_3x15 == 13)
                {
                    if (_3x14 == 1)
                    {
                        if (_3x13 == 3)
                        {
                            _3x13 = 13;
                            battle = true;
                        }
                        else if (_3x13 == 4)
                        {
                            _3x13 = 13;
                            _event = true;
                        }
                        else if (_3x13 == 5)
                        {
                            _3x13 = 13;
                            boss = true;
                        }
                        else if (_3x13 == 6)
                        {
                            _3x13 = 13;
                            shop = true;
                        }
                        else if (_3x13 == 11)
                        {
                            _3x13 = 13;

                        }
                        else if (_3x13 == 2)
                        {
                            _3x13 = 13;

                        }
                        _3x15 = 2;
                    }
                }
                if (_3x17 == 13)
                {
                    if (_3x16 == 1)
                    {
                        if (_3x15 == 3)
                        {
                            _3x15 = 13;
                            battle = true;
                        }
                        else if (_3x15 == 4)
                        {
                            _3x15 = 13;
                            _event = true;
                        }
                        else if (_3x15 == 5)
                        {
                            _3x15 = 13;
                            boss = true;
                        }
                        else if (_3x15 == 6)
                        {
                            _3x15 = 13;
                            shop = true;
                        }
                        else if (_3x15 == 11)
                        {
                            _3x15 = 13;

                        }
                        else if (_3x15 == 2)
                        {
                            _3x15 = 13;

                        }
                        _3x17 = 2;
                    }
                }
                if (_5x3 == 13)
                {
                    if (_5x2 == 1)
                    {
                        if (_5x1 == 3)
                        {
                            _5x1 = 13;
                            battle = true;
                        }
                        else if (_5x1 == 4)
                        {
                            _5x1 = 13;
                            _event = true;
                        }
                        else if (_5x1 == 5)
                        {
                            _5x1 = 13;
                            boss = true;
                        }
                        else if (_5x1 == 6)
                        {
                            _5x1 = 13;
                            shop = true;
                        }
                        else if (_5x1 == 11)
                        {
                            _5x1 = 13;

                        }
                        else if (_5x1 == 2)
                        {
                            _5x1 = 13;

                        }
                        _5x3 = 2;
                    }
                }
                if (_5x5 == 13)
                {
                    if (_5x4 == 1)
                    {
                        if (_5x3 == 3)
                        {
                            _5x3 = 13;
                            battle = true;
                        }
                        else if (_5x3 == 4)
                        {
                            _5x3 = 13;
                            _event = true;
                        }
                        else if (_5x3 == 5)
                        {
                            _5x3 = 13;
                            boss = true;
                        }
                        else if (_5x3 == 6)
                        {
                            _5x3 = 13;
                            shop = true;
                        }
                        else if (_5x3 == 11)
                        {
                            _5x3 = 13;

                        }
                        else if (_5x3 == 2)
                        {
                            _5x3 = 13;

                        }
                        _5x5 = 2;
                    }
                }
                if (_5x7 == 13)
                {
                    if (_5x6 == 1)
                    {
                        if (_5x5 == 3)
                        {
                            _5x5 = 13;
                            battle = true;
                        }
                        else if (_5x5 == 4)
                        {
                            _5x5 = 13;
                            _event = true;
                        }
                        else if (_5x5 == 5)
                        {
                            _5x5 = 13;
                            boss = true;
                        }
                        else if (_5x5 == 6)
                        {
                            _5x5 = 13;
                            shop = true;
                        }
                        else if (_5x5 == 11)
                        {
                            _5x5 = 13;

                        }
                        else if (_5x5 == 2)
                        {
                            _5x5 = 13;

                        }
                        _5x7 = 2;
                    }
                }
                if (_5x9 == 13)
                {
                    if (_5x8 == 1)
                    {
                        if (_5x7 == 3)
                        {
                            _5x7 = 13;
                            battle = true;
                        }
                        else if (_5x7 == 4)
                        {
                            _5x7 = 13;
                            _event = true;
                        }
                        else if (_5x7 == 5)
                        {
                            _5x7 = 13;
                            boss = true;
                        }
                        else if (_5x7 == 6)
                        {
                            _5x7 = 13;
                            shop = true;
                        }
                        else if (_5x7 == 11)
                        {
                            _5x7 = 13;

                        }
                        else if (_5x7 == 2)
                        {
                            _5x7 = 13;

                        }
                        _5x9 = 2;
                    }
                }
                if (_5x11 == 13)
                {
                    if (_5x10 == 1)
                    {
                        if (_5x9 == 3)
                        {
                            _5x9 = 13;
                            battle = true;
                        }
                        else if (_5x9 == 4)
                        {
                            _5x9 = 13;
                            _event = true;
                        }
                        else if (_5x9 == 5)
                        {
                            _5x9 = 13;
                            boss = true;
                        }
                        else if (_5x9 == 6)
                        {
                            _5x9 = 13;
                            shop = true;
                        }
                        else if (_5x9 == 11)
                        {
                            _5x9 = 13;

                        }
                        else if (_5x9 == 2)
                        {
                            _5x9 = 13;

                        }
                        _5x11 = 2;
                    }
                }
                if (_5x13 == 13)
                {
                    if (_5x12 == 1)
                    {
                        if (_5x11 == 3)
                        {
                            _5x11 = 13;
                            battle = true;
                        }
                        else if (_5x11 == 4)
                        {
                            _5x11 = 13;
                            _event = true;
                        }
                        else if (_5x11 == 5)
                        {
                            _5x11 = 13;
                            boss = true;
                        }
                        else if (_5x11 == 6)
                        {
                            _5x11 = 13;
                            shop = true;
                        }
                        else if (_5x11 == 11)
                        {
                            _5x11 = 13;

                        }
                        else if (_5x11 == 2)
                        {
                            _5x11 = 13;

                        }
                        _5x13 = 2;
                    }
                }
                if (_5x15 == 13)
                {
                    if (_5x14 == 1)
                    {
                        if (_5x13 == 3)
                        {
                            _5x13 = 13;
                            battle = true;
                        }
                        else if (_5x13 == 4)
                        {
                            _5x13 = 13;
                            _event = true;
                        }
                        else if (_5x13 == 5)
                        {
                            _5x13 = 13;
                            boss = true;
                        }
                        else if (_5x13 == 6)
                        {
                            _5x13 = 13;
                            shop = true;
                        }
                        else if (_5x13 == 11)
                        {
                            _5x13 = 13;

                        }
                        else if (_5x13 == 2)
                        {
                            _5x13 = 13;

                        }
                        _5x15 = 2;
                    }
                }
                if (_5x17 == 13)
                {
                    if (_5x16 == 1)
                    {
                        if (_5x15 == 3)
                        {
                            _5x15 = 13;
                            battle = true;
                        }
                        else if (_5x15 == 4)
                        {
                            _5x15 = 13;
                            _event = true;
                        }
                        else if (_5x15 == 5)
                        {
                            _5x15 = 13;
                            boss = true;
                        }
                        else if (_5x15 == 6)
                        {
                            _5x15 = 13;
                            shop = true;
                        }
                        else if (_5x15 == 11)
                        {
                            _5x15 = 13;

                        }
                        else if (_5x15 == 2)
                        {
                            _5x15 = 13;

                        }
                        _5x17 = 2;
                    }
                }
                if (_7x3 == 13)
                {
                    if (_7x2 == 1)
                    {
                        if (_7x1 == 3)
                        {
                            _7x1 = 13;
                            battle = true;
                        }
                        else if (_7x1 == 4)
                        {
                            _7x1 = 13;
                            _event = true;
                        }
                        else if (_7x1 == 5)
                        {
                            _7x1 = 13;
                            boss = true;
                        }
                        else if (_7x1 == 6)
                        {
                            _7x1 = 13;
                            shop = true;
                        }
                        else if (_7x1 == 11)
                        {
                            _7x1 = 13;

                        }
                        else if (_7x1 == 2)
                        {
                            _7x1 = 13;

                        }
                        _7x3 = 2;
                    }
                }
                if (_7x5 == 13)
                {
                    if (_7x4 == 1)
                    {
                        if (_7x3 == 3)
                        {
                            _7x3 = 13;
                            battle = true;
                        }
                        else if (_7x3 == 4)
                        {
                            _7x3 = 13;
                            _event = true;
                        }
                        else if (_7x3 == 5)
                        {
                            _7x3 = 13;
                            boss = true;
                        }
                        else if (_7x3 == 6)
                        {
                            _7x3 = 13;
                            shop = true;
                        }
                        else if (_7x3 == 11)
                        {
                            _7x3 = 13;

                        }
                        else if (_7x3 == 2)
                        {
                            _7x3 = 13;

                        }
                        _7x5 = 2;
                    }
                }
                if (_7x7 == 13)
                {
                    if (_7x6 == 1)
                    {
                        if (_7x5 == 3)
                        {
                            _7x5 = 13;
                            battle = true;
                        }
                        else if (_7x5 == 4)
                        {
                            _7x5 = 13;
                            _event = true;
                        }
                        else if (_7x5 == 5)
                        {
                            _7x5 = 13;
                            boss = true;
                        }
                        else if (_7x5 == 6)
                        {
                            _7x5 = 13;
                            shop = true;
                        }
                        else if (_7x5 == 11)
                        {
                            _7x5 = 13;

                        }
                        else if (_7x5 == 2)
                        {
                            _7x5 = 13;

                        }
                        _7x7 = 2;
                    }
                }
                if (_7x9 == 13)
                {
                    if (_7x8 == 1)
                    {
                        if (_7x7 == 3)
                        {
                            _7x7 = 13;
                            battle = true;
                        }
                        else if (_7x7 == 4)
                        {
                            _7x7 = 13;
                            _event = true;
                        }
                        else if (_7x7 == 5)
                        {
                            _7x7 = 13;
                            boss = true;
                        }
                        else if (_7x7 == 6)
                        {
                            _7x7 = 13;
                            shop = true;
                        }
                        else if (_7x7 == 11)
                        {
                            _7x7 = 13;

                        }
                        else if (_7x7 == 2)
                        {
                            _7x7 = 13;

                        }
                        _7x9 = 2;
                    }
                }
                if (_7x11 == 13)
                {
                    if (_7x10 == 1)
                    {
                        if (_7x9 == 3)
                        {
                            _7x9 = 13;
                            battle = true;
                        }
                        else if (_7x9 == 4)
                        {
                            _7x9 = 13;
                            _event = true;
                        }
                        else if (_7x9 == 5)
                        {
                            _7x9 = 13;
                            boss = true;
                        }
                        else if (_7x9 == 6)
                        {
                            _7x9 = 13;
                            shop = true;
                        }
                        else if (_7x9 == 11)
                        {
                            _7x9 = 13;

                        }
                        else if (_7x9 == 2)
                        {
                            _7x9 = 13;

                        }
                        _7x11 = 2;
                    }
                }
                if (_7x13 == 13)
                {
                    if (_7x12 == 1)
                    {
                        if (_7x11 == 3)
                        {
                            _7x11 = 13;
                            battle = true;
                        }
                        else if (_7x11 == 4)
                        {
                            _7x11 = 13;
                            _event = true;
                        }
                        else if (_7x11 == 5)
                        {
                            _7x11 = 13;
                            boss = true;
                        }
                        else if (_7x11 == 6)
                        {
                            _7x11 = 13;
                            shop = true;
                        }
                        else if (_7x11 == 11)
                        {
                            _7x11 = 13;

                        }
                        else if (_7x11 == 2)
                        {
                            _7x11 = 13;

                        }
                        _7x13 = 2;
                    }
                }
                if (_7x15 == 13)
                {
                    if (_7x14 == 1)
                    {
                        if (_7x13 == 3)
                        {
                            _7x13 = 13;
                            battle = true;
                        }
                        else if (_7x13 == 4)
                        {
                            _7x13 = 13;
                            _event = true;
                        }
                        else if (_7x13 == 5)
                        {
                            _7x13 = 13;
                            boss = true;
                        }
                        else if (_7x13 == 6)
                        {
                            _7x13 = 13;
                            shop = true;
                        }
                        else if (_7x13 == 11)
                        {
                            _7x13 = 13;

                        }
                        else if (_7x13 == 2)
                        {
                            _7x13 = 13;

                        }
                        _7x15 = 2;
                    }
                }
                if (_7x17 == 13)
                {
                    if (_7x16 == 1)
                    {
                        if (_7x15 == 3)
                        {
                            _7x15 = 13;
                            battle = true;
                        }
                        else if (_7x15 == 4)
                        {
                            _7x15 = 13;
                            _event = true;
                        }
                        else if (_7x15 == 5)
                        {
                            _7x15 = 13;
                            boss = true;
                        }
                        else if (_7x15 == 6)
                        {
                            _7x15 = 13;
                            shop = true;
                        }
                        else if (_7x15 == 11)
                        {
                            _7x15 = 13;

                        }
                        else if (_7x15 == 2)
                        {
                            _7x15 = 13;

                        }
                        _7x17 = 2;
                    }
                }
            }
            //right
            if (chosg2 == 3)
            {
                if (_1x1 == 13)
                {
                    if (_1x2 == 1)
                    {
                        if (_1x3 == 3)
                        {
                            _1x3 = 13;
                            battle = true;
                        }
                        else if (_1x3 == 4)
                        {
                            _1x3 = 13;
                            _event = true;
                        }
                        else if (_1x3 == 5)
                        {
                            _1x3 = 13;
                            boss = true;
                        }
                        else if (_1x3 == 6)
                        {
                            _1x3 = 13;
                            shop = true;
                        }
                        else if (_1x3 == 11)
                        {
                            _1x3 = 13;
                        }
                        else if (_1x3 == 2)
                        {
                            _1x3 = 13;
                        }
                        _1x1 = 2;
                        break;
                    }
                }
                if (_1x3 == 13)
                {
                    if (_1x4 == 1)
                    {
                        if (_1x5 == 3)
                        {
                            _1x5 = 13;
                            battle = true;
                        }
                        else if (_1x5 == 4)
                        {
                            _1x5 = 13;
                            _event = true;
                        }
                        else if (_1x5 == 5)
                        {
                            _1x5 = 13;
                            boss = true;
                        }
                        else if (_1x5 == 6)
                        {
                            _1x5 = 13;
                            shop = true;
                        }
                        else if (_1x5 == 11)
                        {
                            _1x5 = 13;
                        }
                        else if (_1x5 == 2)
                        {
                            _1x5 = 13;
                        }
                        _1x3 = 2;
                        break;
                    }
                }
                if (_1x5 == 13)
                {
                    if (_1x6 == 1)
                    {
                        if (_1x7 == 3)
                        {
                            _1x7 = 13;
                            battle = true;
                        }
                        else if (_1x7 == 4)
                        {
                            _1x7 = 13;
                            _event = true;
                        }
                        else if (_1x7 == 5)
                        {
                            _1x7 = 13;
                            boss = true;
                        }
                        else if (_1x7 == 6)
                        {
                            _1x7 = 13;
                            shop = true;
                        }
                        else if (_1x7 == 11)
                        {
                            _1x7 = 13;
                        }
                        else if (_1x7 == 2)
                        {
                            _1x7 = 13;
                        }
                        _1x5 = 2;
                        break;
                    }
                }
                if (_1x7 == 13)
                {
                    if (_1x8 == 1)
                    {
                        if (_1x9 == 3)
                        {
                            _1x9 = 13;
                            battle = true;
                        }
                        else if (_1x9 == 4)
                        {
                            _1x9 = 13;
                            _event = true;
                        }
                        else if (_1x9 == 5)
                        {
                            _1x9 = 13;
                            boss = true;
                        }
                        else if (_1x9 == 6)
                        {
                            _1x9 = 13;
                            shop = true;
                        }
                        else if (_1x9 == 11)
                        {
                            _1x9 = 13;
                        }
                        else if (_1x9 == 2)
                        {
                            _1x9 = 13;
                        }
                        _1x7 = 2;
                        break;
                    }
                }
                if (_1x9 == 13)
                {
                    if (_1x10 == 1)
                    {
                        if (_1x11 == 3)
                        {
                            _1x11 = 13;
                            battle = true;
                        }
                        else if (_1x11 == 4)
                        {
                            _1x11 = 13;
                            _event = true;
                        }
                        else if (_1x11 == 5)
                        {
                            _1x11 = 13;
                            boss = true;
                        }
                        else if (_1x11 == 6)
                        {
                            _1x11 = 13;
                            shop = true;
                        }
                        else if (_1x11 == 11)
                        {
                            _1x11 = 13;
                        }
                        else if (_1x11 == 2)
                        {
                            _1x11 = 13;
                        }
                        _1x9 = 2;
                        break;
                    }
                }
                if (_1x11 == 13)
                {
                    if (_1x12 == 1)
                    {
                        if (_1x13 == 3)
                        {
                            _1x13 = 13;
                            battle = true;
                        }
                        else if (_1x13 == 4)
                        {
                            _1x13 = 13;
                            _event = true;
                        }
                        else if (_1x13 == 5)
                        {
                            _1x13 = 13;
                            boss = true;
                        }
                        else if (_1x13 == 6)
                        {
                            _1x13 = 13;
                            shop = true;
                        }
                        else if (_1x13 == 11)
                        {
                            _1x13 = 13;
                        }
                        else if (_1x13 == 2)
                        {
                            _1x13 = 13;
                        }
                        _1x11 = 2;
                        break;
                    }
                }
                if (_1x13 == 13)
                {
                    if (_1x14 == 1)
                    {
                        if (_1x15 == 3)
                        {
                            _1x15 = 13;
                            battle = true;
                        }
                        else if (_1x15 == 4)
                        {
                            _1x15 = 13;
                            _event = true;
                        }
                        else if (_1x15 == 5)
                        {
                            _1x15 = 13;
                            boss = true;
                        }
                        else if (_1x15 == 6)
                        {
                            _1x15 = 13;
                            shop = true;
                        }
                        else if (_1x15 == 11)
                        {
                            _1x15 = 13;
                        }
                        else if (_1x15 == 2)
                        {
                            _1x15 = 13;
                        }
                        _1x13 = 2;
                        break;
                    }
                }
                if (_1x15 == 13)
                {
                    if (_1x16 == 1)
                    {
                        if (_1x17 == 3)
                        {
                            _1x17 = 13;
                            battle = true;
                        }
                        else if (_1x17 == 4)
                        {
                            _1x17 = 13;
                            _event = true;
                        }
                        else if (_1x17 == 5)
                        {
                            _1x17 = 13;
                            boss = true;
                        }
                        else if (_1x17 == 6)
                        {
                            _1x17 = 13;
                            shop = true;
                        }
                        else if (_1x17 == 11)
                        {
                            _1x17 = 13;
                        }
                        else if (_1x17 == 2)
                        {
                            _1x17 = 13;
                        }
                        _1x15 = 2;
                        break;
                    }
                }
                if (_3x1 == 13)
                {
                    if (_3x2 == 1)
                    {
                        if (_3x3 == 3)
                        {
                            _3x3 = 13;
                            battle = true;
                        }
                        else if (_3x3 == 4)
                        {
                            _3x3 = 13;
                            _event = true;
                        }
                        else if (_3x3 == 5)
                        {
                            _3x3 = 13;
                            boss = true;
                        }
                        else if (_3x3 == 6)
                        {
                            _3x3 = 13;
                            shop = true;
                        }
                        else if (_3x3 == 11)
                        {
                            _3x3 = 13;
                        }
                        else if (_3x3 == 2)
                        {
                            _3x3 = 13;
                        }
                        _3x1 = 2;
                        break;
                    }
                }
                if (_3x3 == 13)
                {
                    if (_3x4 == 1)
                    {
                        if (_3x5 == 3)
                        {
                            _3x5 = 13;
                            battle = true;
                        }
                        else if (_3x5 == 4)
                        {
                            _3x5 = 13;
                            _event = true;
                        }
                        else if (_3x5 == 5)
                        {
                            _3x5 = 13;
                            boss = true;
                        }
                        else if (_3x5 == 6)
                        {
                            _3x5 = 13;
                            shop = true;
                        }
                        else if (_3x5 == 11)
                        {
                            _3x5 = 13;
                        }
                        else if (_3x5 == 2)
                        {
                            _3x5 = 13;
                        }
                        _3x3 = 2;
                        break;
                    }
                }
                if (_3x5 == 13)
                {
                    if (_3x6 == 1)
                    {
                        if (_3x7 == 3)
                        {
                            _3x7 = 13;
                            battle = true;
                        }
                        else if (_3x7 == 4)
                        {
                            _3x7 = 13;
                            _event = true;
                        }
                        else if (_3x7 == 5)
                        {
                            _3x7 = 13;
                            boss = true;
                        }
                        else if (_3x7 == 6)
                        {
                            _3x7 = 13;
                            shop = true;
                        }
                        else if (_3x7 == 11)
                        {
                            _3x7 = 13;
                        }
                        else if (_3x7 == 2)
                        {
                            _3x7 = 13;
                        }
                        _3x5 = 2;
                        break;
                    }
                }
                if (_3x7 == 13)
                {
                    if (_3x8 == 1)
                    {
                        if (_3x9 == 3)
                        {
                            _3x9 = 13;
                            battle = true;
                        }
                        else if (_3x9 == 4)
                        {
                            _3x9 = 13;
                            _event = true;
                        }
                        else if (_3x9 == 5)
                        {
                            _3x9 = 13;
                            boss = true;
                        }
                        else if (_3x9 == 6)
                        {
                            _3x9 = 13;
                            shop = true;
                        }
                        else if (_3x9 == 11)
                        {
                            _3x9 = 13;
                        }
                        else if (_3x9 == 2)
                        {
                            _3x9 = 13;
                        }
                        _3x7 = 2;
                        break;
                    }
                }
                if (_3x9 == 13)
                {
                    if (_3x10 == 1)
                    {
                        if (_3x11 == 3)
                        {
                            _3x11 = 13;
                            battle = true;
                        }
                        else if (_3x11 == 4)
                        {
                            _3x11 = 13;
                            _event = true;
                        }
                        else if (_3x11 == 5)
                        {
                            _3x11 = 13;
                            boss = true;
                        }
                        else if (_3x11 == 6)
                        {
                            _3x11 = 13;
                            shop = true;
                        }
                        else if (_3x11 == 11)
                        {
                            _3x11 = 13;
                        }
                        else if (_3x11 == 2)
                        {
                            _3x11 = 13;
                        }
                        _3x9 = 2;
                        break;
                    }
                }
                if (_3x11 == 13)
                {
                    if (_3x12 == 1)
                    {
                        if (_3x13 == 3)
                        {
                            _3x13 = 13;
                            battle = true;
                        }
                        else if (_3x13 == 4)
                        {
                            _3x13 = 13;
                            _event = true;
                        }
                        else if (_3x13 == 5)
                        {
                            _3x13 = 13;
                            boss = true;
                        }
                        else if (_3x13 == 6)
                        {
                            _3x13 = 13;
                            shop = true;
                        }
                        else if (_3x13 == 11)
                        {
                            _3x13 = 13;
                        }
                        else if (_3x13 == 2)
                        {
                            _3x13 = 13;
                        }
                        _3x11 = 2;
                        break;
                    }
                }
                if (_3x13 == 13)
                {
                    if (_3x14 == 1)
                    {
                        if (_3x15 == 3)
                        {
                            _3x15 = 13;
                            battle = true;
                        }
                        else if (_3x15 == 4)
                        {
                            _3x15 = 13;
                            _event = true;
                        }
                        else if (_3x15 == 5)
                        {
                            _3x15 = 13;
                            boss = true;
                        }
                        else if (_3x15 == 6)
                        {
                            _3x15 = 13;
                            shop = true;
                        }
                        else if (_3x15 == 11)
                        {
                            _3x15 = 13;
                        }
                        else if (_3x15 == 2)
                        {
                            _3x15 = 13;
                        }
                        _3x13 = 2;
                        break;
                    }
                }
                if (_3x15 == 13)
                {
                    if (_3x16 == 1)
                    {
                        if (_3x17 == 3)
                        {
                            _3x17 = 13;
                            battle = true;
                        }
                        else if (_3x17 == 4)
                        {
                            _3x17 = 13;
                            _event = true;
                        }
                        else if (_3x17 == 5)
                        {
                            _3x17 = 13;
                            boss = true;
                        }
                        else if (_3x17 == 6)
                        {
                            _3x17 = 13;
                            shop = true;
                        }
                        else if (_3x17 == 11)
                        {
                            _3x17 = 13;
                        }
                        else if (_3x17 == 2)
                        {
                            _3x17 = 13;
                        }
                        _3x15 = 2;
                        break;
                    }
                }
                if (_5x1 == 13)
                {
                    if (_5x2 == 1)
                    {
                        if (_5x3 == 3)
                        {
                            _5x3 = 13;
                            battle = true;
                        }
                        else if (_5x3 == 4)
                        {
                            _5x3 = 13;
                            _event = true;
                        }
                        else if (_5x3 == 5)
                        {
                            _5x3 = 13;
                            boss = true;
                        }
                        else if (_5x3 == 6)
                        {
                            _5x3 = 13;
                            shop = true;
                        }
                        else if (_5x3 == 11)
                        {
                            _5x3 = 13;
                        }
                        else if (_5x3 == 2)
                        {
                            _5x3 = 13;
                        }
                        _5x1 = 2;
                        break;
                    }
                }
                if (_5x3 == 13)
                {
                    if (_5x4 == 1)
                    {
                        if (_5x5 == 3)
                        {
                            _5x5 = 13;
                            battle = true;
                        }
                        else if (_5x5 == 4)
                        {
                            _5x5 = 13;
                            _event = true;
                        }
                        else if (_5x5 == 5)
                        {
                            _5x5 = 13;
                            boss = true;
                        }
                        else if (_5x5 == 6)
                        {
                            _5x5 = 13;
                            shop = true;
                        }
                        else if (_5x5 == 11)
                        {
                            _5x5 = 13;
                        }
                        else if (_5x5 == 2)
                        {
                            _5x5 = 13;
                        }
                        _5x3 = 2;
                        break;
                    }
                }
                if (_5x5 == 13)
                {
                    if (_5x6 == 1)
                    {
                        if (_5x7 == 3)
                        {
                            _5x7 = 13;
                            battle = true;
                        }
                        else if (_5x7 == 4)
                        {
                            _5x7 = 13;
                            _event = true;
                        }
                        else if (_5x7 == 5)
                        {
                            _5x7 = 13;
                            boss = true;
                        }
                        else if (_5x7 == 6)
                        {
                            _5x7 = 13;
                            shop = true;
                        }
                        else if (_5x7 == 11)
                        {
                            _5x7 = 13;
                        }
                        else if (_5x7 == 2)
                        {
                            _5x7 = 13;
                        }
                        _5x5 = 2;
                        break;
                    }
                }
                if (_5x7 == 13)
                {
                    if (_5x8 == 1)
                    {
                        if (_5x9 == 3)
                        {
                            _5x9 = 13;
                            battle = true;
                        }
                        else if (_5x9 == 4)
                        {
                            _5x9 = 13;
                            _event = true;
                        }
                        else if (_5x9 == 5)
                        {
                            _5x9 = 13;
                            boss = true;
                        }
                        else if (_5x9 == 6)
                        {
                            _5x9 = 13;
                            shop = true;
                        }
                        else if (_5x9 == 11)
                        {
                            _5x9 = 13;
                        }
                        else if (_5x9 == 2)
                        {
                            _5x9 = 13;
                        }
                        _5x7 = 2;
                        break;
                    }
                }
                if (_5x9 == 13)
                {
                    if (_5x10 == 1)
                    {
                        if (_5x11 == 3)
                        {
                            _5x11 = 13;
                            battle = true;
                        }
                        else if (_5x11 == 4)
                        {
                            _5x11 = 13;
                            _event = true;
                        }
                        else if (_5x11 == 5)
                        {
                            _5x11 = 13;
                            boss = true;
                        }
                        else if (_5x11 == 6)
                        {
                            _5x11 = 13;
                            shop = true;
                        }
                        else if (_5x11 == 11)
                        {
                            _5x11 = 13;
                        }
                        else if (_5x11 == 2)
                        {
                            _5x11 = 13;
                        }
                        _5x9 = 2;
                        break;
                    }
                }
                if (_5x11 == 13)
                {
                    if (_5x12 == 1)
                    {
                        if (_5x13 == 3)
                        {
                            _5x13 = 13;
                            battle = true;
                        }
                        else if (_5x13 == 4)
                        {
                            _5x13 = 13;
                            _event = true;
                        }
                        else if (_5x13 == 5)
                        {
                            _5x13 = 13;
                            boss = true;
                        }
                        else if (_5x13 == 6)
                        {
                            _5x13 = 13;
                            shop = true;
                        }
                        else if (_5x13 == 11)
                        {
                            _5x13 = 13;
                        }
                        else if (_5x13 == 2)
                        {
                            _5x13 = 13;
                        }
                        _5x11 = 2;
                        break;
                    }
                }
                if (_5x13 == 13)
                {
                    if (_5x14 == 1)
                    {
                        if (_5x15 == 3)
                        {
                            _5x15 = 13;
                            battle = true;
                        }
                        else if (_5x15 == 4)
                        {
                            _5x15 = 13;
                            _event = true;
                        }
                        else if (_5x15 == 5)
                        {
                            _5x15 = 13;
                            boss = true;
                        }
                        else if (_5x15 == 6)
                        {
                            _5x15 = 13;
                            shop = true;
                        }
                        else if (_5x15 == 11)
                        {
                            _5x15 = 13;
                        }
                        else if (_5x15 == 2)
                        {
                            _5x15 = 13;
                        }
                        _5x13 = 2;
                        break;
                    }
                }
                if (_5x15 == 13)
                {
                    if (_5x16 == 1)
                    {
                        if (_5x17 == 3)
                        {
                            _5x17 = 13;
                            battle = true;
                        }
                        else if (_5x17 == 4)
                        {
                            _5x17 = 13;
                            _event = true;
                        }
                        else if (_5x17 == 5)
                        {
                            _5x17 = 13;
                            boss = true;
                        }
                        else if (_5x17 == 6)
                        {
                            _5x17 = 13;
                            shop = true;
                        }
                        else if (_5x17 == 11)
                        {
                            _5x17 = 13;
                        }
                        else if (_5x17 == 2)
                        {
                            _5x17 = 13;
                        }
                        _5x15 = 2;
                        break;
                    }
                }
                if (_7x1 == 13)
                {
                    if (_7x2 == 1)
                    {
                        if (_7x3 == 3)
                        {
                            _7x3 = 13;
                            battle = true;
                        }
                        else if (_7x3 == 4)
                        {
                            _7x3 = 13;
                            _event = true;
                        }
                        else if (_7x3 == 5)
                        {
                            _7x3 = 13;
                            boss = true;
                        }
                        else if (_7x3 == 6)
                        {
                            _7x3 = 13;
                            shop = true;
                        }
                        else if (_7x3 == 11)
                        {
                            _7x3 = 13;
                        }
                        else if (_7x3 == 2)
                        {
                            _7x3 = 13;
                        }
                        _7x1 = 2;
                        break;
                    }
                }
                if (_7x3 == 13)
                {
                    if (_7x4 == 1)
                    {
                        if (_7x5 == 3)
                        {
                            _7x5 = 13;
                            battle = true;
                        }
                        else if (_7x5 == 4)
                        {
                            _7x5 = 13;
                            _event = true;
                        }
                        else if (_7x5 == 5)
                        {
                            _7x5 = 13;
                            boss = true;
                        }
                        else if (_7x5 == 6)
                        {
                            _7x5 = 13;
                            shop = true;
                        }
                        else if (_7x5 == 11)
                        {
                            _7x5 = 13;
                        }
                        else if (_7x5 == 2)
                        {
                            _7x5 = 13;
                        }
                        _7x3 = 2;
                        break;
                    }
                }
                if (_7x5 == 13)
                {
                    if (_7x6 == 1)
                    {
                        if (_7x7 == 3)
                        {
                            _7x7 = 13;
                            battle = true;
                        }
                        else if (_7x7 == 4)
                        {
                            _7x7 = 13;
                            _event = true;
                        }
                        else if (_7x7 == 5)
                        {
                            _7x7 = 13;
                            boss = true;
                        }
                        else if (_7x7 == 6)
                        {
                            _7x7 = 13;
                            shop = true;
                        }
                        else if (_7x7 == 11)
                        {
                            _7x7 = 13;
                        }
                        else if (_7x7 == 2)
                        {
                            _7x7 = 13;
                        }
                        _7x5 = 2;
                        break;
                    }
                }
                if (_7x7 == 13)
                {
                    if (_7x8 == 1)
                    {
                        if (_7x9 == 3)
                        {
                            _7x9 = 13;
                            battle = true;
                        }
                        else if (_7x9 == 4)
                        {
                            _7x9 = 13;
                            _event = true;
                        }
                        else if (_7x9 == 5)
                        {
                            _7x9 = 13;
                            boss = true;
                        }
                        else if (_7x9 == 6)
                        {
                            _7x9 = 13;
                            shop = true;
                        }
                        else if (_7x9 == 11)
                        {
                            _7x9 = 13;
                        }
                        else if (_7x9 == 2)
                        {
                            _7x9 = 13;
                        }
                        _7x7 = 2;
                        break;
                    }
                }
                if (_7x9 == 13)
                {
                    if (_7x10 == 1)
                    {
                        if (_7x11 == 3)
                        {
                            _7x11 = 13;
                            battle = true;
                        }
                        else if (_7x11 == 4)
                        {
                            _7x11 = 13;
                            _event = true;
                        }
                        else if (_7x11 == 5)
                        {
                            _7x11 = 13;
                            boss = true;
                        }
                        else if (_7x11 == 6)
                        {
                            _7x11 = 13;
                            shop = true;
                        }
                        else if (_7x11 == 11)
                        {
                            _7x11 = 13;
                        }
                        else if (_7x11 == 2)
                        {
                            _7x11 = 13;
                        }
                        _7x9 = 2;
                        break;
                    }
                }
                if (_7x11 == 13)
                {
                    if (_7x12 == 1)
                    {
                        if (_7x13 == 3)
                        {
                            _7x13 = 13;
                            battle = true;
                        }
                        else if (_7x13 == 4)
                        {
                            _7x13 = 13;
                            _event = true;
                        }
                        else if (_7x13 == 5)
                        {
                            _7x13 = 13;
                            boss = true;
                        }
                        else if (_7x13 == 6)
                        {
                            _7x13 = 13;
                            shop = true;
                        }
                        else if (_7x13 == 11)
                        {
                            _7x13 = 13;
                        }
                        else if (_7x13 == 2)
                        {
                            _7x13 = 13;
                        }
                        _7x11 = 2;
                        break;
                    }
                }
                if (_7x13 == 13)
                {
                    if (_7x14 == 1)
                    {
                        if (_7x15 == 3)
                        {
                            _7x15 = 13;
                            battle = true;
                        }
                        else if (_7x15 == 4)
                        {
                            _7x15 = 13;
                            _event = true;
                        }
                        else if (_7x15 == 5)
                        {
                            _7x15 = 13;
                            boss = true;
                        }
                        else if (_7x15 == 6)
                        {
                            _7x15 = 13;
                            shop = true;
                        }
                        else if (_7x15 == 11)
                        {
                            _7x15 = 13;
                        }
                        else if (_7x15 == 2)
                        {
                            _7x15 = 13;
                        }
                        _7x13 = 2;
                        break;
                    }
                }
                if (_7x15 == 13)
                {
                    if (_7x16 == 1)
                    {
                        if (_7x17 == 3)
                        {
                            _7x17 = 13;
                            battle = true;
                        }
                        else if (_7x17 == 4)
                        {
                            _7x17 = 13;
                            _event = true;
                        }
                        else if (_7x17 == 5)
                        {
                            _7x17 = 13;
                            boss = true;
                        }
                        else if (_7x17 == 6)
                        {
                            _7x17 = 13;
                            shop = true;
                        }
                        else if (_7x17 == 11)
                        {
                            _7x17 = 13;
                        }
                        else if (_7x17 == 2)
                        {
                            _7x17 = 13;
                        }
                        _7x15 = 2;
                        break;
                    }
                }
            }
            //down
            if (chosg2 == 4)
            {
                if (_1x1 == 13)
                {
                    if (_2x1 == 1)
                    {
                        if (_3x1 == 3)
                        {
                            _3x1 = 13;
                            battle = true;
                        }
                        else if (_3x1 == 4)
                        {
                            _3x1 = 13;
                            _event = true;
                        }
                        else if (_3x1 == 5)
                        {
                            _3x1 = 13;
                            boss = true;
                        }
                        else if (_3x1 == 6)
                        {
                            _3x1 = 13;
                            shop = true;
                        }
                        else if (_3x1 == 11)
                        {
                            _3x1 = 13;
                        }
                        else if (_3x1 == 2)
                        {
                            _3x1 = 13;
                        }
                        _1x1 = 2;
                        break;
                    }
                }
                if (_1x3 == 13)
                {
                    if (_2x2 == 1)
                    {
                        if (_3x3 == 3)
                        {
                            _3x3 = 13;
                            battle = true;
                        }
                        else if (_3x3 == 4)
                        {
                            _3x3 = 13;
                            _event = true;
                        }
                        else if (_3x3 == 5)
                        {
                            _3x3 = 13;
                            boss = true;
                        }
                        else if (_3x3 == 6)
                        {
                            _3x3 = 13;
                            shop = true;
                        }
                        else if (_3x3 == 11)
                        {
                            _3x3 = 13;
                        }
                        else if (_3x3 == 2)
                        {
                            _3x3 = 13;
                        }
                        _1x3 = 2;
                        break;
                    }
                }
                if (_1x5 == 13)
                {
                    if (_2x3 == 1)
                    {
                        if (_3x5 == 3)
                        {
                            _3x5 = 13;
                            battle = true;
                        }
                        else if (_3x5 == 4)
                        {
                            _3x5 = 13;
                            _event = true;
                        }
                        else if (_3x5 == 5)
                        {
                            _3x5 = 13;
                            boss = true;
                        }
                        else if (_3x5 == 6)
                        {
                            _3x5 = 13;
                            shop = true;
                        }
                        else if (_3x5 == 11)
                        {
                            _3x5 = 13;
                        }
                        else if (_3x5 == 2)
                        {
                            _3x5 = 13;
                        }
                        _1x5 = 2;
                        break;
                    }
                }
                if (_1x7 == 13)
                {
                    if (_2x4 == 1)
                    {
                        if (_3x7 == 3)
                        {
                            _3x7 = 13;
                            battle = true;
                        }
                        else if (_3x7 == 4)
                        {
                            _3x7 = 13;
                            _event = true;
                        }
                        else if (_3x7 == 5)
                        {
                            _3x7 = 13;
                            boss = true;
                        }
                        else if (_3x7 == 6)
                        {
                            _3x7 = 13;
                            shop = true;
                        }
                        else if (_3x7 == 11)
                        {
                            _3x7 = 13;
                        }
                        else if (_3x7 == 2)
                        {
                            _3x7 = 13;
                        }
                        _1x7 = 2;
                        break;
                    }
                }
                if (_1x9 == 13)
                {
                    if (_2x5 == 1)
                    {
                        if (_3x9 == 3)
                        {
                            _3x9 = 13;
                            battle = true;
                        }
                        else if (_3x9 == 4)
                        {
                            _3x9 = 13;
                            _event = true;
                        }
                        else if (_3x9 == 5)
                        {
                            _3x9 = 13;
                            boss = true;
                        }
                        else if (_3x9 == 6)
                        {
                            _3x9 = 13;
                            shop = true;
                        }
                        else if (_3x9 == 11)
                        {
                            _3x9 = 13;
                        }
                        else if (_3x9 == 2)
                        {
                            _3x9 = 13;
                        }
                        _1x9 = 2;
                        break;
                    }
                }
                if (_1x11 == 13)
                {
                    if (_2x6 == 1)
                    {
                        if (_3x11 == 3)
                        {
                            _3x11 = 13;
                            battle = true;
                        }
                        else if (_3x11 == 4)
                        {
                            _3x11 = 13;
                            _event = true;
                        }
                        else if (_3x11 == 5)
                        {
                            _3x11 = 13;
                            boss = true;
                        }
                        else if (_3x11 == 6)
                        {
                            _3x11 = 13;
                            shop = true;
                        }
                        else if (_3x11 == 11)
                        {
                            _3x11 = 13;
                        }
                        else if (_3x11 == 2)
                        {
                            _3x11 = 13;
                        }
                        _1x11 = 2;
                        break;
                    }
                }
                if (_1x13 == 13)
                {
                    if (_2x7 == 1)
                    {
                        if (_3x13 == 3)
                        {
                            _3x13 = 13;
                            battle = true;
                        }
                        else if (_3x13 == 4)
                        {
                            _3x13 = 13;
                            _event = true;
                        }
                        else if (_3x13 == 5)
                        {
                            _3x13 = 13;
                            boss = true;
                        }
                        else if (_3x13 == 6)
                        {
                            _3x13 = 13;
                            shop = true;
                        }
                        else if (_3x13 == 11)
                        {
                            _3x13 = 13;
                        }
                        else if (_3x13 == 2)
                        {
                            _3x13 = 13;
                        }
                        _1x13 = 2;
                        break;
                    }
                }
                if (_1x15 == 13)
                {
                    if (_2x8 == 1)
                    {
                        if (_3x15 == 3)
                        {
                            _3x15 = 13;
                            battle = true;
                        }
                        else if (_3x15 == 4)
                        {
                            _3x15 = 13;
                            _event = true;
                        }
                        else if (_3x15 == 5)
                        {
                            _3x15 = 13;
                            boss = true;
                        }
                        else if (_3x15 == 6)
                        {
                            _3x15 = 13;
                            shop = true;
                        }
                        else if (_3x15 == 11)
                        {
                            _3x15 = 13;
                        }
                        else if (_3x15 == 2)
                        {
                            _3x15 = 13;
                        }
                        _1x15 = 2;
                        break;
                    }
                }
                if (_1x17 == 13)
                {
                    if (_2x9 == 1)
                    {
                        if (_3x17 == 3)
                        {
                            _3x17 = 13;
                            battle = true;
                        }
                        else if (_3x17 == 4)
                        {
                            _3x17 = 13;
                            _event = true;
                        }
                        else if (_3x17 == 5)
                        {
                            _3x17 = 13;
                            boss = true;
                        }
                        else if (_3x17 == 6)
                        {
                            _3x17 = 13;
                            shop = true;
                        }
                        else if (_3x17 == 11)
                        {
                            _3x17 = 13;
                        }
                        else if (_3x17 == 2)
                        {
                            _3x17 = 13;
                        }
                        _1x17 = 2;
                        break;
                    }
                }
                if (_3x1 == 13)
                {
                    if (_4x1 == 1)
                    {
                        if (_5x1 == 3)
                        {
                            _5x1 = 13;
                            battle = true;
                        }
                        else if (_5x1 == 4)
                        {
                            _5x1 = 13;
                            _event = true;
                        }
                        else if (_5x1 == 5)
                        {
                            _5x1 = 13;
                            boss = true;
                        }
                        else if (_5x1 == 6)
                        {
                            _5x1 = 13;
                            shop = true;
                        }
                        else if (_5x1 == 11)
                        {
                            _5x1 = 13;
                        }
                        else if (_5x1 == 2)
                        {
                            _5x1 = 13;
                        }
                        _3x1 = 2;
                        break;
                    }
                }
                if (_3x3 == 13)
                {
                    if (_4x2 == 1)
                    {
                        if (_5x3 == 3)
                        {
                            _5x3 = 13;
                            battle = true;
                        }
                        else if (_5x3 == 4)
                        {
                            _5x3 = 13;
                            _event = true;
                        }
                        else if (_5x3 == 5)
                        {
                            _5x3 = 13;
                            boss = true;
                        }
                        else if (_5x3 == 6)
                        {
                            _5x3 = 13;
                            shop = true;
                        }
                        else if (_5x3 == 11)
                        {
                            _5x3 = 13;
                        }
                        else if (_5x3 == 2)
                        {
                            _5x3 = 13;
                        }
                        _3x3 = 2;
                        break;
                    }
                }
                if (_3x5 == 13)
                {
                    if (_4x3 == 1)
                    {
                        if (_5x5 == 3)
                        {
                            _5x5 = 13;
                            battle = true;
                        }
                        else if (_5x5 == 4)
                        {
                            _5x5 = 13;
                            _event = true;
                        }
                        else if (_5x5 == 5)
                        {
                            _5x5 = 13;
                            boss = true;
                        }
                        else if (_5x5 == 6)
                        {
                            _5x5 = 13;
                            shop = true;
                        }
                        else if (_5x5 == 11)
                        {
                            _5x5 = 13;
                        }
                        else if (_5x5 == 2)
                        {
                            _5x5 = 13;
                        }
                        _3x5 = 2;
                        break;
                    }
                }
                if (_3x7 == 13)
                {
                    if (_4x4 == 1)
                    {
                        if (_5x7 == 3)
                        {
                            _5x7 = 13;
                            battle = true;
                        }
                        else if (_5x7 == 4)
                        {
                            _5x7 = 13;
                            _event = true;
                        }
                        else if (_5x7 == 5)
                        {
                            _5x7 = 13;
                            boss = true;
                        }
                        else if (_5x7 == 6)
                        {
                            _5x7 = 13;
                            shop = true;
                        }
                        else if (_5x7 == 11)
                        {
                            _5x7 = 13;
                        }
                        else if (_5x7 == 2)
                        {
                            _5x7 = 13;
                        }
                        _3x7 = 2;
                        break;
                    }
                }
                if (_3x9 == 13)
                {
                    if (_4x5 == 1)
                    {
                        if (_5x9 == 3)
                        {
                            _5x9 = 13;
                            battle = true;
                        }
                        else if (_5x9 == 4)
                        {
                            _5x9 = 13;
                            _event = true;
                        }
                        else if (_5x9 == 5)
                        {
                            _5x9 = 13;
                            boss = true;
                        }
                        else if (_5x9 == 6)
                        {
                            _5x9 = 13;
                            shop = true;
                        }
                        else if (_5x9 == 11)
                        {
                            _5x9 = 13;
                        }
                        else if (_5x9 == 2)
                        {
                            _5x9 = 13;
                        }
                        _3x9 = 2;
                        break;
                    }
                }
                if (_3x11 == 13)
                {
                    if (_4x6 == 1)
                    {
                        if (_5x11 == 3)
                        {
                            _5x11 = 13;
                            battle = true;
                        }
                        else if (_5x11 == 4)
                        {
                            _5x11 = 13;
                            _event = true;
                        }
                        else if (_5x11 == 5)
                        {
                            _5x11 = 13;
                            boss = true;
                        }
                        else if (_5x11 == 6)
                        {
                            _5x11 = 13;
                            shop = true;
                        }
                        else if (_5x11 == 11)
                        {
                            _5x11 = 13;
                        }
                        else if (_5x11 == 2)
                        {
                            _5x11 = 13;
                        }
                        _3x11 = 2;
                        break;
                    }
                }
                if (_3x13 == 13)
                {
                    if (_4x7 == 1)
                    {
                        if (_5x13 == 3)
                        {
                            _5x13 = 13;
                            battle = true;
                        }
                        else if (_5x13 == 4)
                        {
                            _5x13 = 13;
                            _event = true;
                        }
                        else if (_5x13 == 5)
                        {
                            _5x13 = 13;
                            boss = true;
                        }
                        else if (_5x13 == 6)
                        {
                            _5x13 = 13;
                            shop = true;
                        }
                        else if (_5x13 == 11)
                        {
                            _5x13 = 13;
                        }
                        else if (_5x13 == 2)
                        {
                            _5x13 = 13;
                        }
                        _3x13 = 2;
                        break;
                    }
                }
                if (_3x15 == 13)
                {
                    if (_4x8 == 1)
                    {
                        if (_5x15 == 3)
                        {
                            _5x15 = 13;
                            battle = true;
                        }
                        else if (_5x15 == 4)
                        {
                            _5x15 = 13;
                            _event = true;
                        }
                        else if (_5x15 == 5)
                        {
                            _5x15 = 13;
                            boss = true;
                        }
                        else if (_5x15 == 6)
                        {
                            _5x15 = 13;
                            shop = true;
                        }
                        else if (_5x15 == 11)
                        {
                            _5x15 = 13;
                        }
                        else if (_5x15 == 2)
                        {
                            _5x15 = 13;
                        }
                        _3x15 = 2;
                        break;
                    }
                }
                if (_3x17 == 13)
                {
                    if (_4x9 == 1)
                    {
                        if (_5x17 == 3)
                        {
                            _5x17 = 13;
                            battle = true;
                        }
                        else if (_5x17 == 4)
                        {
                            _5x17 = 13;
                            _event = true;
                        }
                        else if (_5x17 == 5)
                        {
                            _5x17 = 13;
                            boss = true;
                        }
                        else if (_5x17 == 6)
                        {
                            _5x17 = 13;
                            shop = true;
                        }
                        else if (_5x17 == 11)
                        {
                            _5x17 = 13;
                        }
                        else if (_5x17 == 2)
                        {
                            _5x17 = 13;
                        }
                        _3x17 = 2;
                        break;
                    }
                }
                if (_5x1 == 13)
                {
                    if (_6x1 == 1)
                    {
                        if (_7x1 == 3)
                        {
                            _7x1 = 13;
                            battle = true;
                        }
                        else if (_7x1 == 4)
                        {
                            _7x1 = 13;
                            _event = true;
                        }
                        else if (_7x1 == 5)
                        {
                            _7x1 = 13;
                            boss = true;
                        }
                        else if (_7x1 == 6)
                        {
                            _7x1 = 13;
                            shop = true;
                        }
                        else if (_7x1 == 11)
                        {
                            _7x1 = 13;
                        }
                        else if (_7x1 == 2)
                        {
                            _7x1 = 13;
                        }
                        _5x1 = 2;
                        break;
                    }
                }
                if (_5x3 == 13)
                {
                    if (_6x2 == 1)
                    {
                        if (_7x3 == 3)
                        {
                            _7x3 = 13;
                            battle = true;
                        }
                        else if (_7x3 == 4)
                        {
                            _7x3 = 13;
                            _event = true;
                        }
                        else if (_7x3 == 5)
                        {
                            _7x3 = 13;
                            boss = true;
                        }
                        else if (_7x3 == 6)
                        {
                            _7x3 = 13;
                            shop = true;
                        }
                        else if (_7x3 == 11)
                        {
                            _7x3 = 13;
                        }
                        else if (_7x3 == 2)
                        {
                            _7x3 = 13;
                        }
                        _5x3 = 2;
                        break;
                    }
                }
                if (_5x5 == 13)
                {
                    if (_6x3 == 1)
                    {
                        if (_7x5 == 3)
                        {
                            _7x5 = 13;
                            battle = true;
                        }
                        else if (_7x5 == 4)
                        {
                            _7x5 = 13;
                            _event = true;
                        }
                        else if (_7x5 == 5)
                        {
                            _7x5 = 13;
                            boss = true;
                        }
                        else if (_7x5 == 6)
                        {
                            _7x5 = 13;
                            shop = true;
                        }
                        else if (_7x5 == 11)
                        {
                            _7x5 = 13;
                        }
                        else if (_7x5 == 2)
                        {
                            _7x5 = 13;
                        }
                        _5x5 = 2;
                        break;
                    }
                }
                if (_5x7 == 13)
                {
                    if (_6x4 == 1)
                    {
                        if (_7x7 == 3)
                        {
                            _7x7 = 13;
                            battle = true;
                        }
                        else if (_7x7 == 4)
                        {
                            _7x7 = 13;
                            _event = true;
                        }
                        else if (_7x7 == 5)
                        {
                            _7x7 = 13;
                            boss = true;
                        }
                        else if (_7x7 == 6)
                        {
                            _7x7 = 13;
                            shop = true;
                        }
                        else if (_7x7 == 11)
                        {
                            _7x7 = 13;
                        }
                        else if (_7x7 == 2)
                        {
                            _7x7 = 13;
                        }
                        _5x7 = 2;
                        break;
                    }
                }
                if (_5x9 == 13)
                {
                    if (_6x5 == 1)
                    {
                        if (_7x9 == 3)
                        {
                            _7x9 = 13;
                            battle = true;
                        }
                        else if (_7x9 == 4)
                        {
                            _7x9 = 13;
                            _event = true;
                        }
                        else if (_7x9 == 5)
                        {
                            _7x9 = 13;
                            boss = true;
                        }
                        else if (_7x9 == 6)
                        {
                            _7x9 = 13;
                            shop = true;
                        }
                        else if (_7x9 == 11)
                        {
                            _7x9 = 13;
                        }
                        else if (_7x9 == 2)
                        {
                            _7x9 = 13;
                        }
                        _5x9 = 2;
                        break;
                    }
                }
                if (_5x11 == 13)
                {
                    if (_6x6 == 1)
                    {
                        if (_7x11 == 3)
                        {
                            _7x11 = 13;
                            battle = true;
                        }
                        else if (_7x11 == 4)
                        {
                            _7x11 = 13;
                            _event = true;
                        }
                        else if (_7x11 == 5)
                        {
                            _7x11 = 13;
                            boss = true;
                        }
                        else if (_7x11 == 6)
                        {
                            _7x11 = 13;
                            shop = true;
                        }
                        else if (_7x11 == 11)
                        {
                            _7x11 = 13;
                        }
                        else if (_7x11 == 2)
                        {
                            _7x11 = 13;
                        }
                        _5x11 = 2;
                        break;
                    }
                }
                if (_5x13 == 13)
                {
                    if (_6x7 == 1)
                    {
                        if (_7x13 == 3)
                        {
                            _7x13 = 13;
                            battle = true;
                        }
                        else if (_7x13 == 4)
                        {
                            _7x13 = 13;
                            _event = true;
                        }
                        else if (_7x13 == 5)
                        {
                            _7x13 = 13;
                            boss = true;
                        }
                        else if (_7x13 == 6)
                        {
                            _7x13 = 13;
                            shop = true;
                        }
                        else if (_7x13 == 11)
                        {
                            _7x13 = 13;
                        }
                        else if (_7x13 == 2)
                        {
                            _7x13 = 13;
                        }
                        _5x13 = 2;
                        break;
                    }
                }
                if (_5x15 == 13)
                {
                    if (_6x8 == 1)
                    {
                        if (_7x15 == 3)
                        {
                            _7x15 = 13;
                            battle = true;
                        }
                        else if (_7x15 == 4)
                        {
                            _7x15 = 13;
                            _event = true;
                        }
                        else if (_7x15 == 5)
                        {
                            _7x15 = 13;
                            boss = true;
                        }
                        else if (_7x15 == 6)
                        {
                            _7x15 = 13;
                            shop = true;
                        }
                        else if (_7x15 == 11)
                        {
                            _7x15 = 13;
                        }
                        else if (_7x15 == 2)
                        {
                            _7x15 = 13;
                        }
                        _5x15 = 2;
                        break;
                    }
                }
                if (_5x17 == 13)
                {
                    if (_6x9 == 1)
                    {
                        if (_7x17 == 3)
                        {
                            _7x17 = 13;
                            battle = true;
                        }
                        else if (_7x17 == 4)
                        {
                            _7x17 = 13;
                            _event = true;
                        }
                        else if (_7x17 == 5)
                        {
                            _7x17 = 13;
                            boss = true;
                        }
                        else if (_7x17 == 6)
                        {
                            _7x17 = 13;
                            shop = true;
                        }
                        else if (_7x17 == 11)
                        {
                            _7x17 = 13;
                        }
                        else if (_7x17 == 2)
                        {
                            _7x17 = 13;
                        }
                        _5x17 = 2;
                        break;
                    }
                }
            }
        }

        //https://textart.sh/

        Console.Clear();
        while (battle)
        {
            enemygen = true;
            break;
        }
        while (battle)
        {
            while (enemygen)
            {
                int i = 0;
                Random random = new Random();
                int enemyquant = random.Next(0, 4);
                while (enemyquant >= i)
                {
                    int enemyranid = random.Next(1, 101);
                    if (enemyranid <= 30)
                    {
                        enemyranid = 1;
                    }
                    else if (enemyranid >= 31 && enemyranid <= 50)
                    {
                        enemyranid = 2;
                    }
                    else if (enemyranid >= 51 && enemyranid <= 60)
                    {
                        enemyranid = 3;
                    }
                    else if (enemyranid >= 61 && enemyranid <= 75)
                    {
                        enemyranid = 4;
                    }
                    else if (enemyranid >= 76 && enemyranid <= 95)
                    {
                        enemyranid = 5;
                    }
                    else if (enemyranid >= 96)
                    {
                        enemyranid = 6;
                    }
                    battlelog[i, 0] = enemyranid;
                    enemyranid--;
                    for (int j = 1; j < 6; j++)
                    {
                        battlelog[i, j] = enemystats[enemyranid, --j];
                        j++;
                    }
                    i++;
                }
                enemygen = false;
                turn = true;
            }

            while (turn)
            {
                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------" +
                              "\r\n  |Health|:" + set1 + " |Gold|:" + set2 + " |Exp|: " + set3 +
                              "\r\n------------------------------------------------------------------------------------------------------------------------" +
                              eventrender +
                              "\r\n------------------------------------------------------------------------------------------------------------------------" +
                              "\n\r   [1] Numpad 1  |  [2] Numpad 2  |  [3] Numpad 3                                              " +
                              "\n\r------------------------------------------------------------------------------------------------------------------------");
                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.Backspace:
                        _event = false;
                        //chosg2 = 1;
                        break;
                    case ConsoleKey.NumPad1:
                        _event = false;
                        //chosg2 = 5;
                        break;
                    case ConsoleKey.NumPad2:
                        _event = false;
                        //load = true;
                        //chosg2 = 6;
                        break;
                    case ConsoleKey.NumPad3:
                        _event = false;
                        //load = true;
                        break;
                    case ConsoleKey.Enter:
                        _event = false;
                        break;
                }
            }
            break;
        }
        while (_event)
        {
            Random random = new Random();
            eventid = random.Next(0, 3);
            while (_event)
            {
                if (eventid == 0)
                {
                    uniload = true;
                    gameloop = false;
                    genloop = true;
                    genreset = true;
                    population1 = true;
                    cellgen = true;
                    rendermap = false;
                    startcell = true;
                    eventid = random.Next(1, 3);
                    if (eventid == 1)
                    {
                        eventstate = 1;
                        eventid = random.Next(-4, 0);
                        set5 = set5 + eventid;
                    }
                    else if (eventid >= 2)
                    {
                        eventstate = 2;
                        eventid = random.Next(1, 5);
                        set5 = set5 + eventid;
                    }
                }
                else if (eventid >= 1 && eventid <= 3)
                {
                    eventid = random.Next(1, 11);
                    if (eventid <= 4) //health
                    {
                        eventid = random.Next(1, 6);
                        if (eventid <= 2)
                        {
                            eventid = random.Next(-50, 0);
                            set1 = set1 + eventid;
                        }
                        else if (eventid >= 3)
                        {
                            eventid = random.Next(1, 51);
                            set1 = set1 + eventid;
                        }
                        eventstate = 3;
                    }
                    else if (eventid >= 5) //gold
                    {
                        eventid = random.Next(1, 6);
                        if (eventid <= 2)
                        {
                            eventid = random.Next(-200, 0);
                            int temp = eventid + set2;
                            if (temp > 0)
                            {
                                set2 = set2 + eventid;
                            }
                            else
                            {
                                eventid = 10;
                                set2 = set2 + 10;
                            }
                        }
                        else if (eventid >= 3)
                        {
                            eventid = random.Next(1, 201);
                            set2 = set2 + eventid;
                        }
                        eventstate = 4;
                    }

                    rendermap = false;
                    save = true;
                    savestate = 5;
                }
                else if (eventid >= 4 && eventid <= 6)
                {
                    eventstate = 5;
                    //battle
                }
                else if (eventid >= 7 && eventid <= 10)
                {
                    eventstate = 6;
                    //item
                }

                if (eventstate == 1)
                {
                    eventrender = "\r\n                                                                                                                        " +
                              "\r\n                                                                                                                        " +
                              "\r\n                                                                                                                        " +
                              "\r\n                                                                                                                        " +
                              "\r\n                                                                                      ░░                                " +
                              "\r\n                                                                                    ░░  ░░                              " +
                              "\r\n                                                                                  ░░      ░░                            " +
                              "\r\n                                                                                ░░          ░░                          " +
                              "\r\n                                                                              ░░              ░░                        " +
                              "\r\n                                                                              ░░░░░░░░░░░░░░░░░░                        " +
                              "\r\n                                                                                                                        " +
                              "\r\n                               You dropped by " + eventid + " floors                                                    " +
                              "\r\n                                                                                                                        " +
                              "\r\n                                                                              ██████████████████                        " +
                              "\r\n                                                                              ██████████████████                        " +
                              "\r\n                                                                                ██████████████                          " +
                              "\r\n                                                                                  ██████████                            " +
                              "\r\n                                                                                    ██████                              " +
                              "\r\n                                                                                      ██                                " +
                              "\r\n                                                                                                                        " +
                              "\r\n                                                                                                                        " +
                              "\r\n                                                                                                                        " +
                              "\r\n                                                                                                                        ";
                }
                if (eventstate == 2)
                {
                    eventrender = "\r\n                                                                                                                        " +
                              "\r\n                                                                                                                        " +
                              "\r\n                                                                                                                        " +
                              "\r\n                                                                                                                        " +
                              "\r\n                                                                                      ██                                " +
                              "\r\n                                                                                    ██████                              " +
                              "\r\n                                                                                  ██████████                            " +
                              "\r\n                                                                                ██████████████                          " +
                              "\r\n                                                                              ██████████████████                        " +
                              "\r\n                                                                              ██████████████████                        " +
                              "\r\n                                                                                                                        " +
                              "\r\n                               You elevated by " + eventid + " floors                                                   " +
                              "\r\n                                                                                                                        " +
                              "\r\n                                                                              ░░░░░░░░░░░░░░░░░░                        " +
                              "\r\n                                                                              ░░              ░░                        " +
                              "\r\n                                                                                ░░          ░░                          " +
                              "\r\n                                                                                  ░░      ░░                            " +
                              "\r\n                                                                                    ░░  ░░                              " +
                              "\r\n                                                                                      ░░                                " +
                              "\r\n                                                                                                                        " +
                              "\r\n                                                                                                                        " +
                              "\r\n                                                                                                                        " +
                              "\r\n                                                                                                                        ";
                }
                else if (eventstate == 3)
                {
                    eventrender = "\r\n                                                                                                                        " +
                              "\r\n                                                                                                                        " +
                              "\r\n                                                                                                                        " +
                              "\r\n                                                                                                                        " +
                              "\r\n                                                                                                                        " +
                              "\r\n                                                                                                                        " +
                              "\r\n                                   your healt changed by: " + eventid + "                                                                 " +
                              "\r\n                                                                                                                        " +
                              "\r\n                                                                                                                        " +
                              "\r\n                                                                                                                        " +
                              "\r\n                                                                                                                        " +
                              "\r\n                                                                                                                        " +
                              "\r\n                                                                                                                        " +
                              "\r\n                                                                                                                        " +
                              "\r\n                                                                                                                        " +
                              "\r\n                                                                                                                        " +
                              "\r\n                                                                                                                        " +
                              "\r\n                                                                                                                        " +
                              "\r\n                                                                                                                        " +
                              "\r\n                                                                                                                        " +
                              "\r\n                                                                                                                        " +
                              "\r\n                                                                                                                        " +
                              "\r\n                                                                                                                        ";
                }
                else if (eventstate == 4)
                {
                    eventrender = "\r\n                                                                                                                        " +
                              "\r\n                                                                                                                        " +
                              "\r\n                                                                                                                        " +
                              "\r\n                                                                                                                        " +
                              "\r\n                                                                                                                        " +
                              "\r\n                                                                                                                        " +
                              "\r\n                                  your gold changed by: " + eventid + "                                                                 " +
                              "\r\n                                                                                                                        " +
                              "\r\n                                                                                                                        " +
                              "\r\n                                                                                                                        " +
                              "\r\n                                                                                                                        " +
                              "\r\n                                                                                                                        " +
                              "\r\n                                                                                                                        " +
                              "\r\n                                                                                                                        " +
                              "\r\n                                                                                                                        " +
                              "\r\n                                                                                                                        " +
                              "\r\n                                                                                                                        " +
                              "\r\n                                                                                                                        " +
                              "\r\n                                                                                                                        " +
                              "\r\n                                                                                                                        " +
                              "\r\n                                                                                                                        " +
                              "\r\n                                                                                                                        " +
                              "\r\n                                                                                                                        ";
                }
                else if (eventstate == 5)
                {

                }
                else if (eventstate == 6)
                {

                }


                Console.Clear();
                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------" +
                              "\r\n  |Health|:" + set1 + " |Gold|:" + set2 + " |Exp|: " + set3 +
                              "\r\n------------------------------------------------------------------------------------------------------------------------" +
                              eventrender +
                              "\r\n------------------------------------------------------------------------------------------------------------------------" +
                              "\n\r   [1] Numpad 1  |  [2] Numpad 2  |  [3] Numpad 3                                              " +
                              "\n\r------------------------------------------------------------------------------------------------------------------------");
                //if (Console.ReadKey().Key != ConsoleKey.NumPad1) 
                //{
                //    _event = false;
                //    break;
                //}
                //else if (Console.ReadKey().Key != ConsoleKey.NumPad2)
                //{
                //    _event = false;
                //    break;
                //}
                //else if (Console.ReadKey().Key != ConsoleKey.NumPad3)
                //{
                //    _event = false;
                //    break;
                //}
                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.Backspace:
                        _event = false;
                        //chosg2 = 1;
                        break;
                    case ConsoleKey.NumPad1:
                        _event = false;
                        //chosg2 = 5;
                        break;
                    case ConsoleKey.NumPad2:
                        _event = false;
                        //load = true;
                        //chosg2 = 6;
                        break;
                    case ConsoleKey.NumPad3:
                        _event = false;
                        //load = true;
                        break;
                    case ConsoleKey.Enter:
                        _event = false;
                        break;
                }
                eventid = -1;
            }
        }
        while (shop)
        {
            break;
        }
        while (boss)
        {
            break;
        }
        break;
    }
}