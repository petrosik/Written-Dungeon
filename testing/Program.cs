// See https://aka.ms/new-console-template for more information
/*
int set1 = 9999; //health
int set2 = 999999; // gold
int set3 = 999999; // exp
Console.WriteLine("------------------------------------------------------------------------------------------------------------------------" +
              "\r\n  |Health|:" + set1 + " |Gold|:" + set2 + " |Exp|: " + set3 +
              "\r\n------------------------------------------------------------------------------------------------------------------------" +
              "\r\n........................................................................................................................" +
              "\r\n....vvvvvvvvv....vvvvvvvvv....vvvvvvvvv....vvvvvvvvv....vvvvvvvvv....vvvvvvvvv....vvvvvvvvv....vvvvvvvvv....vvvvvvvvv..." +
              "\r\n....vvvvFvvvvxxxxvvvvFvvvvxxxxvvvvFvvvvxxxxvvvvFvvvvxxxxvvvvFvvvvxxxxvvvvFvvvvxxxxvvvvFvvvvxxxxvvvvFvvvvxxxxvvvvFvvvv..." +
              "\r\n....vvvvFvvvvxxxxvvvvFvvvvxxxxvvvvFvvvvxxxxvvvvFvvvvxxxxvvvvFvvvvxxxxvvvvFvvvvxxxxvvvvFvvvvxxxxvvvvFvvvvxxxxvvvvFvvvv..." +
              "\r\n....vvvvvvvvv....vvvvvvvvv....vvvvvvvvv....vvvvvvvvv....vvvvvvvvv....vvvvvvvvv....vvvvvvvvv....vvvvvvvvv....vvvvvvvvv..." +
              "\r\n........x............X............X............X............X............X............X............X............X......." +
              "\r\n........x............x............X............X............X............X............X............X............X......." +
              "\r\n....vvvvvvvvv....vvvvvvvvv....vvvvvvvvv....vvvvvvvvv....vvvvvvvvv....vvvvvvvvv....vvvvvvvvv....vvvvvvvvv....vvvvvvvvv..." +
              "\r\n....vvvvFvvvvxxxxvvvvFvvvvxxxxvvvvFvvvvxxxxvvvvFvvvvxxxxvvvvFvvvvxxxxvvvvFvvvvxxxxvvvvFvvvvxxxxvvvvFvvvvxxxxvvvvFvvvv..." +
              "\r\n....vvvvFvvvvxxxxvvvvFvvvvxxxxvvvvFvvvvxxxxvvvvFvvvvxxxxvvvvFvvvvxxxxvvvvFvvvvxxxxvvvvFvvvvxxxxvvvvFvvvvxxxxvvvvFvvvv..." +
              "\r\n....vvvvvvvvv....vvvvvvvvv....vvvvvvvvv....vvvvvvvvv....vvvvvvvvv....vvvvvvvvv....vvvvvvvvv....vvvvvvvvv....vvvvvvvvv..." +
              "\r\n........x............X............X............X............X............X............X............X............X......." +
              "\r\n........x............X............X............X............X............X............X............X............X......." +
              "\r\n....vvvvvvvvv....vvvvvvvvv....vvvvvvvvv....vvvvvvvvv....vvvvvvvvv....vvvvvvvvv....vvvvvvvvv....vvvvvvvvv....vvvvvvvvv..." +
              "\r\n....vvvvFvvvvxxxxvvvvFvvvvxxxxvvvvFvvvvxxxxvvvvFvvvvxxxxvvvvFvvvvxxxxvvvvFvvvvxxxxvvvvFvvvvxxxxvvvvFvvvvxxxxvvvvFvvvv..." +
              "\r\n....vvvvFvvvvxxxxvvvvFvvvvxxxxvvvvFvvvvxxxxvvvvFvvvvxxxxvvvvFvvvvxxxxvvvvFvvvvxxxxvvvvFvvvvxxxxvvvvFvvvvxxxxvvvvFvvvv..." +
              "\r\n....vvvvvvvvv....vvvvvvvvv....vvvvvvvvv....vvvvvvvvv....vvvvvvvvv....vvvvvvvvv....vvvvvvvvv....vvvvvvvvv....vvvvvvvvv..." +
              "\r\n........x............X............X............X............X............X............X............X............X......." +
              "\r\n........x............X............X............X............X............X............X............X............X......." +
              "\r\n....vvvvvvvvv....vvvvvvvvv....vvvvvvvvv....vvvvvvvvv....vvvvvvvvv....vvvvvvvvv....vvvvvvvvv....vvvvvvvvv....vvvvvvvvv..." +
              "\r\n....vvvvFvvvvxxxxvvvvFvvvvxxxxvvvvFvvvvxxxxvvvvFvvvvxxxxvvvvFvvvvxxxxvvvvFvvvvxxxxvvvvFvvvvxxxxvvvvFvvvvxxxxvvvvFvvvv..." +
              "\r\n....vvvvFvvvvxxxxvvvvFvvvvxxxxvvvvFvvvvxxxxvvvvFvvvvxxxxvvvvFvvvvxxxxvvvvFvvvvxxxxvvvvFvvvvxxxxvvvvFvvvvxxxxvvvvFvvvv..." +
              "\r\n....vvvvvvvvv....vvvvvvvvv....vvvvvvvvv....vvvvvvvvv....vvvvvvvvv....vvvvvvvvv....vvvvvvvvv....vvvvvvvvv....vvvvvvvvv..." +
              "\r\n........................................................................................................................" +
              "\r\n------------------------------------------------------------------------------------------------------------------------" +
              "\n\r   [1] Numpad 1  |  [2] Numpad 2  |  [3] Numpad 3  |  [Back] Backspace                                              " +
              "\n\r------------------------------------------------------------------------------------------------------------------------");

*/
using System;
using System.IO;

bool test = true;
int tempx = 1;
int tempy = 2;
int temptype = 3;
int coordsdone;
int stagen;

bool startcell = true;
bool cellgen = true;
int cellcount = 0;

int moveup = 0;

int _1x1 = 0; //cell
int _1x16 = 0; //coridor
int _1x14 = 0; //coridor
int _1x12 = 0; //coridor
int _1x10 = 0; //coridor
int _1x8 = 0; //coridor
int _1x6 = 0; //coridor
int _1x4 = 0; //coridor
int _1x2 = 0; //coridor
int _1x3 = 0; //cell
int _1x5 = 0; //cell
int _1x7 = 0; //cell
int _1x9 = 0; //cell
int _1x11 = 0; //cell
int _1x13 = 0; //cell
int _1x15 = 0; //cell
int _1x17 = 0; //cell
int _3x1 = 0; //cell
int _3x10 = 0; //coridor
int _3x12 = 0;
int _3x14 = 0;
int _3x16 = 0;
int _3x2 = 0;
int _3x4 = 0;
int _3x6 = 0;
int _3x8 = 0;
int _3x3 = 0; //cell
int _3x5 = 0; //cell
int _3x7 = 0; //cell
int _3x9 = 0; //cell
int _3x11 = 0;
int _3x13 = 0;
int _3x15 = 0;
int _3x17 = 0;
int _5x1 = 0; //cell
int _5x2 = 0; //coridor
int _5x4 = 0;
int _5x6 = 0;
int _5x8 = 0;
int _5x10 = 0; //coridor
int _5x12 = 0;
int _5x14 = 0;
int _5x16 = 0;
int _5x3 = 0;
int _5x5 = 0;
int _5x7 = 0;
int _5x9 = 0;
int _5x11 = 0; //cell
int _5x13 = 0; //cell
int _5x15 = 0; //cell
int _5x17 = 0; //cell
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



int _2x1 = 0; //coridor
int _2x2 = 0;
int _2x3 = 0;
int _2x4 = 0;
int _2x5 = 0;
int _2x6 = 0;
int _2x7 = 0;
int _2x8 = 0;
int _2x9 = 0; //coridor
int _4x1 = 0;
int _4x2 = 0; //cell
int _4x4 = 0; //cell
int _4x6 = 0; //cell
int _4x8 = 0; //cell
int _4x3 = 0;
int _4x5 = 0;
int _4x7 = 0;
int _4x9 = 0;
int _6x1 = 0;
int _6x2 = 0; //cell
int _6x4 = 0; //cell
int _6x6 = 0; //cell
int _6x8 = 0; //cell
int _6x3 = 0;
int _6x5 = 0;
int _6x7 = 0;
int _6x9 = 0;


Console.WriteLine("ddd{0,15}{0,10}{2,10}{3,10}{4,10}",
  "bla1",
  "bla2",
  "bla3",
  "bla4",
  "bla5");


//while (startcell)
//{
//    Random random = new Random();
//    int ranout = random.Next(1, 36);
//    Console.WriteLine(ranout);
//    if (ranout == 1)
//    {
//        _1x1 = 10;
//    }
//    else if (ranout == 2)
//    {
//        _1x3 = 10;
//    }
//    else if (ranout == 3)
//    {
//        _1x5 = 10;
//    }
//    else if (ranout == 4)
//    {
//        _1x7 = 10;
//    }
//    else if (ranout == 5)
//    {
//        _1x9 = 10;
//    }
//    else if (ranout == 6)
//    {
//        _1x11 = 10;
//    }
//    else if (ranout == 7)
//    {
//        _1x13 = 10;
//    }
//    else if (ranout == 8)
//    {
//        _1x15 = 10;
//    }
//    else if (ranout == 9)
//    {
//        _1x17 = 10;
//    }
//    else if (ranout == 10)
//    {
//        _3x1 = 10;
//    }
//    else if (ranout == 11)
//    {
//        _3x3 = 10;
//    }
//    else if (ranout == 12)
//    {
//        _3x5 = 10;
//    }
//    else if (ranout == 13)
//    {
//        _3x7 = 10;
//    }
//    else if (ranout == 14)
//    {
//        _3x9 = 10;
//    }
//    else if (ranout == 15)
//    {
//        _3x11 = 10;
//    }
//    else if (ranout == 16)
//    {
//        _3x13 = 10;
//    }
//    else if (ranout == 17)
//    {
//        _3x15 = 10;
//    }
//    else if (ranout == 18)
//    {
//        _3x17 = 10;
//    }
//    else if (ranout == 19)
//    {
//        _5x1 = 10;
//    }
//    else if (ranout == 20)
//    {
//        _5x3 = 10;
//    }
//    else if (ranout == 21)
//    {
//        _5x5 = 10;
//    }
//    else if (ranout == 22)
//    {
//        _5x7 = 10;
//    }
//    else if (ranout == 23)
//    {
//        _5x9 = 10;
//    }
//    else if (ranout == 24)
//    {
//        _5x11 = 10;
//    }
//    else if (ranout == 25)
//    {
//        _5x13 = 10;
//    }
//    else if (ranout == 26)
//    {
//        _5x15 = 10;
//    }
//    else if (ranout == 27)
//    {
//        _5x17 = 10;
//    }
//    else if (ranout == 28)
//    {
//        _7x1 = 10;
//    }
//    else if (ranout == 29)
//    {
//        _7x3 = 10;
//    }
//    else if (ranout == 30)
//    {
//        _7x5 = 10;
//    }
//    else if (ranout == 31)
//    {
//        _7x7 = 10;
//    }
//    else if (ranout == 32)
//    {
//        _7x9 = 10;
//    }
//    else if (ranout == 33)
//    {
//        _7x11 = 10;
//    }
//    else if (ranout == 34)
//    {
//        _7x13 = 10;
//    }
//    else if (ranout == 35)
//    {
//        _7x15 = 10;
//    }
//    else if (ranout == 36)
//    {
//        _7x17 = 10;
//    }
//    startcell = false;
//}
///*
//9 x 4 = 36 stages
//8 x 4 + 9 x 3 = 59 paths
//X:1 - 7 * Y:1 - 17 = 119 grid

////cell index
//0 - doesnt exist
//1 - empty non explored (gen only)
//2 - empty explored (base after evyrting)
//3 - enemy
//E
//v
//4 - evnt cell (idk yet)
//%
//v
//5 - boss cell (end floor)
//B
//v
//....
//10 - also start in gen
//11 - generated empty non conectable (not explored )
//12 - dead end empty non explored
//13 - player pos
//*/

//while (cellgen)
//{
//    Random random4 = new Random();
//    int ranout4 = random4.Next(2, 25);


//    if (_1x1 == 10 || _1x1 == 1)
//    {
//        if (ranout4 == cellcount)
//        {
//            _1x1 = 5;
//            break;
//        }
//        Random random = new Random();
//        int ranout = random.Next(1, 100);
//        int ranout2 = random.Next(1, 100);
//        if (ranout <= 34)
//        {
//            if (ranout2 <= 50 && _3x1 == 0)
//            {
//                _2x1 = 1;
//                _3x1 = 12;
//            }
//            if (ranout2 >= 50 && _1x3 == 0)
//            {
//                _1x2 = 1;
//                _1x3 = 12;
//            }
//            ranout2 = random.Next(1, 100);
//            if (ranout2 <= 50 && _3x1 == 0)
//            {
//                _2x1 = 1;
//                _3x1 = 12;
//            }
//            if (ranout2 >= 50 && _1x3 == 0)
//            {
//                _1x2 = 1;
//                _1x3 = 12;
//            }
//            _2x1 = 1;
//            _1x1 = 1;
//        }
//        if (ranout >= 34 && ranout <= 66)
//        {
//            if (ranout2 <= 50 && _1x1 == 0)
//            {
//                _2x1 = 1;
//                _1x1 = 12;
//            }
//            if (ranout2 >= 50 && _3x1 == 0)
//            {
//                _2x1 = 1;
//                _3x1 = 12;
//            }
//            ranout2 = random.Next(1, 100);
//            if (ranout2 <= 50 && _1x1 == 0)
//            {
//                _2x1 = 1;
//                _1x1 = 12;
//            }
//            if (ranout2 >= 150 && _3x1 == 0)
//            {
//                _2x1 = 1;
//                _3x1 = 12;
//            }
//            _1x2 = 1;
//            _1x3 = 1;
//        }
//        if (ranout >= 66)
//        {
//            if (ranout2 <= 50 && _1x1 == 0)
//            {
//                _2x1 = 1;
//                _1x1 = 12;
//            }
//            if (ranout2 >= 50 && _1x3 == 0)
//            {
//                _1x2 = 1;
//                _1x3 = 12;
//            }
//            ranout2 = random.Next(1, 100);
//            if (ranout2 <= 50 && _1x1 == 0)
//            {
//                _2x1 = 1;
//                _1x1 = 12;
//            }
//            if (ranout2 >= 50 && _1x3 == 0)
//            {
//                _1x2 = 1;
//                _1x3 = 12;
//            }
//            _2x1 = 1;
//            _3x1 = 1;
//        }
//        if (_1x1 == 1)
//        {
//            _1x1 = 11;
//        }
//        cellcount++;
//    }

//    if (_1x3 == 10 || _1x3 == 1)
//    {
//        if (ranout4 == cellcount)
//        {
//            _1x3 = 5;
//            break;
//        }
//        Random random = new Random();
//        int ranout = random.Next(1, 100);
//        int ranout2 = random.Next(1, 100);
//        if (ranout <= 25)
//        {
//            if (ranout2 <= 34 && _3x3 == 0)
//            {
//                _2x2 = 1;
//                _3x3 = 12;
//            }
//            if (ranout2 <= 34 && ranout2 >= 66 && _1x1 == 0)
//            {
//                _1x2 = 1;
//                _1x1 = 12;
//            }
//            if (ranout2 <= 66 && ranout2 >= 100 && _1x5 == 0)
//            {
//                _1x4 = 1;
//                _1x5 = 12;
//            }
//            ranout2 = random.Next(1, 100);
//            if (ranout2 <= 34 && _3x3 == 0)
//            {
//                _2x2 = 1;
//                _3x3 = 12;
//            }
//            if (ranout2 <= 34 && ranout2 >= 66 && _1x1 == 0)
//            {
//                _1x2 = 1;
//                _1x1 = 12;
//            }
//            if (ranout2 <= 66 && ranout2 >= 100 && _1x5 == 0)
//            {
//                _1x4 = 1;
//                _1x5 = 12;
//            }
//            _2x2 = 1;
//            _1x3 = 1;
//        }
//        if (ranout >= 25 && ranout <= 50)
//        {
//            if (ranout2 <= 34 && _1x3 == 0)
//            {
//                _2x2 = 1;
//                _1x3 = 12;
//            }
//            if (ranout2 <= 34 && ranout2 >= 66 && _3x3 == 0)
//            {
//                _2x2 = 1;
//                _3x3 = 12;
//            }
//            if (ranout2 <= 66 && ranout2 >= 100 && _1x5 == 0)
//            {
//                _1x4 = 1;
//                _1x5 = 12;
//            }
//            ranout2 = random.Next(1, 100);
//            if (ranout2 <= 34 && _1x3 == 0)
//            {
//                _2x2 = 1;
//                _1x3 = 12;
//            }
//            if (ranout2 <= 34 && ranout2 >= 66 && _3x3 == 0)
//            {
//                _2x2 = 1;
//                _3x3 = 12;
//            }
//            if (ranout2 <= 66 && ranout2 >= 100 && _1x5 == 0)
//            {
//                _1x4 = 1;
//                _1x5 = 12;
//            }
//            _1x2 = 1;
//            _1x1 = 1;
//        }
//        if (ranout >= 50 && ranout <= 75)
//        {
//            if (ranout2 <= 34 && _1x3 == 0)
//            {
//                _2x2 = 1;
//                _1x3 = 12;
//            }
//            if (ranout2 <= 34 && ranout2 >= 66 && _1x1 == 0)
//            {
//                _1x2 = 1;
//                _1x1 = 12;
//            }
//            if (ranout2 <= 66 && ranout2 >= 100 && _3x3 == 0)
//            {
//                _2x2 = 1;
//                _3x3 = 12;
//            }
//            ranout2 = random.Next(1, 100);
//            if (ranout2 <= 34 && _1x3 == 0)
//            {
//                _2x2 = 1;
//                _1x3 = 12;
//            }
//            if (ranout2 <= 34 && ranout2 >= 66 && _1x1 == 0)
//            {
//                _1x2 = 1;
//                _1x1 = 12;
//            }
//            if (ranout2 <= 66 && ranout2 >= 100 && _3x3 == 0)
//            {
//                _2x2 = 1;
//                _3x3 = 12;
//            }
//            _1x4 = 1;
//            _1x5 = 1;
//        }
//        if (ranout >= 75)
//        {
//            if (ranout2 <= 34 && _1x3 == 0)
//            {
//                _2x2 = 1;
//                _1x3 = 12;
//            }
//            if (ranout2 <= 34 && ranout2 >= 66 && _1x1 == 0)
//            {
//                _1x2 = 1;
//                _1x1 = 12;
//            }
//            if (ranout2 <= 66 && ranout2 >= 100 && _1x5 == 0)
//            {
//                _1x4 = 1;
//                _1x5 = 12;
//            }
//            ranout2 = random.Next(1, 100);
//            if (ranout2 <= 34 && _1x3 == 0)
//            {
//                _2x2 = 1;
//                _1x3 = 12;
//            }
//            if (ranout2 <= 34 && ranout2 >= 66 && _1x1 == 0)
//            {
//                _1x2 = 1;
//                _1x1 = 12;
//            }
//            if (ranout2 <= 66 && ranout2 >= 100 && _1x5 == 0)
//            {
//                _1x4 = 1;
//                _1x5 = 12;
//            }
//            _2x2 = 1;
//            _3x3 = 1;
//        }
//        if (_1x3 == 1)
//        {
//            _1x3 = 11;
//        }
//        cellcount++;
//    }

//    if (_1x5 == 10 || _1x5 == 1)
//    {
//        if (ranout4 == cellcount)
//        {
//            _1x5 = 5;
//            break;
//        }
//        Random random = new Random();
//        int ranout = random.Next(1, 100);
//        int ranout2 = random.Next(1, 100);
//        if (ranout <= 25)
//        {
//            if (ranout2 <= 34 && _3x5 == 0)
//            {
//                _2x3 = 1;
//                _3x5 = 12;
//            }
//            if (ranout2 <= 34 && ranout2 >= 66 && _1x3 == 0)
//            {
//                _1x4 = 1;
//                _1x3 = 12;
//            }
//            if (ranout2 <= 66 && ranout2 >= 100 && _1x7 == 0)
//            {
//                _1x6 = 1;
//                _1x7 = 12;
//            }
//            ranout2 = random.Next(1, 100);
//            if (ranout2 <= 34 && _3x5 == 0)
//            {
//                _2x3 = 1;
//                _3x5 = 12;
//            }
//            if (ranout2 <= 34 && ranout2 >= 66 && _1x3 == 0)
//            {
//                _1x4 = 1;
//                _1x3 = 12;
//            }
//            if (ranout2 <= 66 && ranout2 >= 100 && _1x7 == 0)
//            {
//                _1x6 = 1;
//                _1x7 = 12;
//            }
//            _2x3 = 1;
//            _1x5 = 1;
//        }
//        if (ranout >= 25 && ranout <= 50)
//        {
//            if (ranout2 <= 34 && _1x5 == 0)
//            {
//                _2x3 = 1;
//                _1x5 = 12;
//            }
//            if (ranout2 <= 34 && ranout2 >= 66 && _3x5 == 0)
//            {
//                _2x3 = 1;
//                _3x5 = 12;
//            }
//            if (ranout2 <= 66 && ranout2 >= 100 && _1x7 == 0)
//            {
//                _1x6 = 1;
//                _1x7 = 12;
//            }
//            ranout2 = random.Next(1, 100);
//            if (ranout2 <= 34 && _1x5 == 0)
//            {
//                _2x3 = 1;
//                _1x5 = 12;
//            }
//            if (ranout2 <= 34 && ranout2 >= 66 && _3x5 == 0)
//            {
//                _2x3 = 1;
//                _3x5 = 12;
//            }
//            if (ranout2 <= 66 && ranout2 >= 100 && _1x7 == 0)
//            {
//                _1x6 = 1;
//                _1x7 = 12;
//            }
//            _1x4 = 1;
//            _1x3 = 1;
//        }
//        if (ranout >= 50 && ranout <= 75)
//        {
//            if (ranout2 <= 34 && _1x5 == 0)
//            {
//                _2x3 = 1;
//                _1x5 = 12;
//            }
//            if (ranout2 <= 34 && ranout2 >= 66 && _1x3 == 0)
//            {
//                _1x4 = 1;
//                _1x3 = 12;
//            }
//            if (ranout2 <= 66 && ranout2 >= 100 && _3x5 == 0)
//            {
//                _2x3 = 1;
//                _3x5 = 12;
//            }
//            ranout2 = random.Next(1, 100);
//            if (ranout2 <= 34 && _1x5 == 0)
//            {
//                _2x3 = 1;
//                _1x5 = 12;
//            }
//            if (ranout2 <= 34 && ranout2 >= 66 && _1x3 == 0)
//            {
//                _1x4 = 1;
//                _1x3 = 12;
//            }
//            if (ranout2 <= 66 && ranout2 >= 100 && _3x5 == 0)
//            {
//                _2x3 = 1;
//                _3x5 = 12;
//            }
//            _1x6 = 1;
//            _1x7 = 1;
//        }
//        if (ranout >= 75)
//        {
//            if (ranout2 <= 34 && _1x5 == 0)
//            {
//                _2x3 = 1;
//                _1x5 = 12;
//            }
//            if (ranout2 <= 34 && ranout2 >= 66 && _1x3 == 0)
//            {
//                _1x4 = 1;
//                _1x3 = 12;
//            }
//            if (ranout2 <= 66 && ranout2 >= 100 && _1x7 == 0)
//            {
//                _1x6 = 1;
//                _1x7 = 12;
//            }
//            ranout2 = random.Next(1, 100);
//            if (ranout2 <= 34 && _1x5 == 0)
//            {
//                _2x3 = 1;
//                _1x5 = 12;
//            }
//            if (ranout2 <= 34 && ranout2 >= 66 && _1x3 == 0)
//            {
//                _1x4 = 1;
//                _1x3 = 12;
//            }
//            if (ranout2 <= 66 && ranout2 >= 100 && _1x7 == 0)
//            {
//                _1x6 = 1;
//                _1x7 = 12;
//            }
//            _2x3 = 1;
//            _3x5 = 1;
//        }
//        if (_1x5 == 1)
//        {
//            _1x5 = 11;
//        }
//        cellcount++;
//    }

//    if (_1x7 == 10 || _1x7 == 1)
//    {
//        if (ranout4 == cellcount)
//        {
//            _1x7 = 5;
//            break;
//        }
//        Random random = new Random();
//        int ranout = random.Next(1, 100);
//        int ranout2 = random.Next(1, 100);
//        if (ranout <= 25)
//        {
//            if (ranout2 <= 34 && _3x7 == 0)
//            {
//                _2x4 = 1;
//                _3x7 = 12;
//            }
//            if (ranout2 <= 34 && ranout2 >= 66 && _1x5 == 0)
//            {
//                _1x6 = 1;
//                _1x5 = 12;
//            }
//            if (ranout2 <= 66 && ranout2 >= 100 && _1x9 == 0)
//            {
//                _1x8 = 1;
//                _1x9 = 12;
//            }
//            ranout2 = random.Next(1, 100);
//            if (ranout2 <= 34 && _3x7 == 0)
//            {
//                _2x4 = 1;
//                _3x7 = 12;
//            }
//            if (ranout2 <= 34 && ranout2 >= 66 && _1x5 == 0)
//            {
//                _1x6 = 1;
//                _1x5 = 12;
//            }
//            if (ranout2 <= 66 && ranout2 >= 100 && _1x9 == 0)
//            {
//                _1x8 = 1;
//                _1x9 = 12;
//            }
//            _2x4 = 1;
//            _1x7 = 1;
//        }
//        if (ranout >= 25 && ranout <= 50)
//        {
//            if (ranout2 <= 34 && _1x7 == 0)
//            {
//                _2x4 = 1;
//                _1x7 = 12;
//            }
//            if (ranout2 <= 34 && ranout2 >= 66 && _3x7 == 0)
//            {
//                _2x4 = 1;
//                _3x7 = 12;
//            }
//            if (ranout2 <= 66 && ranout2 >= 100 && _1x9 == 0)
//            {
//                _1x8 = 1;
//                _1x9 = 12;
//            }
//            ranout2 = random.Next(1, 100);
//            if (ranout2 <= 34 && _1x7 == 0)
//            {
//                _2x4 = 1;
//                _1x7 = 12;
//            }
//            if (ranout2 <= 34 && ranout2 >= 66 && _3x7 == 0)
//            {
//                _2x4 = 1;
//                _3x7 = 12;
//            }
//            if (ranout2 <= 66 && ranout2 >= 100 && _1x9 == 0)
//            {
//                _1x8 = 1;
//                _1x9 = 12;
//            }
//            _1x6 = 1;
//            _1x5 = 1;
//        }
//        if (ranout >= 50 && ranout <= 75)
//        {
//            if (ranout2 <= 34 && _1x7 == 0)
//            {
//                _2x4 = 1;
//                _1x7 = 12;
//            }
//            if (ranout2 <= 34 && ranout2 >= 66 && _1x5 == 0)
//            {
//                _1x6 = 1;
//                _1x5 = 12;
//            }
//            if (ranout2 <= 66 && ranout2 >= 100 && _3x7 == 0)
//            {
//                _2x4 = 1;
//                _3x7 = 12;
//            }
//            ranout2 = random.Next(1, 100);
//            if (ranout2 <= 34 && _1x7 == 0)
//            {
//                _2x4 = 1;
//                _1x7 = 12;
//            }
//            if (ranout2 <= 34 && ranout2 >= 66 && _1x5 == 0)
//            {
//                _1x6 = 1;
//                _1x5 = 12;
//            }
//            if (ranout2 <= 66 && ranout2 >= 100 && _3x7 == 0)
//            {
//                _2x4 = 1;
//                _3x7 = 12;
//            }
//            _1x8 = 1;
//            _1x9 = 1;
//        }
//        if (ranout >= 75)
//        {
//            if (ranout2 <= 34 && _1x7 == 0)
//            {
//                _2x4 = 1;
//                _1x7 = 12;
//            }
//            if (ranout2 <= 34 && ranout2 >= 66 && _1x5 == 0)
//            {
//                _1x6 = 1;
//                _1x5 = 12;
//            }
//            if (ranout2 <= 66 && ranout2 >= 100 && _1x9 == 0)
//            {
//                _1x8 = 1;
//                _1x9 = 12;
//            }
//            ranout2 = random.Next(1, 100);
//            if (ranout2 <= 34 && _1x7 == 0)
//            {
//                _2x4 = 1;
//                _1x7 = 12;
//            }
//            if (ranout2 <= 34 && ranout2 >= 66 && _1x5 == 0)
//            {
//                _1x6 = 1;
//                _1x5 = 12;
//            }
//            if (ranout2 <= 66 && ranout2 >= 100 && _1x9 == 0)
//            {
//                _1x8 = 1;
//                _1x9 = 12;
//            }
//            _2x4 = 1;
//            _3x7 = 1;
//        }
//        if (_1x7 == 1)
//        {
//            _1x7 = 11;
//        }
//        cellcount++;
//    }

//    if (_1x9 == 10 || _1x9 == 1)
//    {
//        if (ranout4 == cellcount)
//        {
//            _1x9 = 5;
//            break;
//        }
//        Random random = new Random();
//        int ranout = random.Next(1, 100);
//        int ranout2 = random.Next(1, 100);
//        if (ranout <= 25)
//        {
//            if (ranout2 <= 34 && _3x9 == 0)
//            {
//                _2x5 = 1;
//                _3x9 = 12;
//            }
//            if (ranout2 <= 34 && ranout2 >= 66 && _1x7 == 0)
//            {
//                _1x8 = 1;
//                _1x7 = 12;
//            }
//            if (ranout2 <= 66 && ranout2 >= 100 && _1x11 == 0)
//            {
//                _1x10 = 1;
//                _1x11 = 12;
//            }
//            ranout2 = random.Next(1, 100);
//            if (ranout2 <= 34 && _3x9 == 0)
//            {
//                _2x5 = 1;
//                _3x9 = 12;
//            }
//            if (ranout2 <= 34 && ranout2 >= 66 && _1x7 == 0)
//            {
//                _1x8 = 1;
//                _1x7 = 12;
//            }
//            if (ranout2 <= 66 && ranout2 >= 100 && _1x11 == 0)
//            {
//                _1x10 = 1;
//                _1x11 = 12;
//            }
//            _2x5 = 1;
//            _1x9 = 1;
//        }
//        if (ranout >= 25 && ranout <= 50)
//        {
//            if (ranout2 <= 34 && _1x9 == 0)
//            {
//                _2x5 = 1;
//                _1x9 = 12;
//            }
//            if (ranout2 <= 34 && ranout2 >= 66 && _3x9 == 0)
//            {
//                _2x5 = 1;
//                _3x9 = 12;
//            }
//            if (ranout2 <= 66 && ranout2 >= 100 && _1x11 == 0)
//            {
//                _1x10 = 1;
//                _1x11 = 12;
//            }
//            ranout2 = random.Next(1, 100);
//            if (ranout2 <= 34 && _1x9 == 0)
//            {
//                _2x5 = 1;
//                _1x9 = 12;
//            }
//            if (ranout2 <= 34 && ranout2 >= 66 && _3x9 == 0)
//            {
//                _2x5 = 1;
//                _3x9 = 12;
//            }
//            if (ranout2 <= 66 && ranout2 >= 100 && _1x11 == 0)
//            {
//                _1x10 = 1;
//                _1x11 = 12;
//            }
//            _1x8 = 1;
//            _1x7 = 1;
//        }
//        if (ranout >= 50 && ranout <= 75)
//        {
//            if (ranout2 <= 34 && _1x9 == 0)
//            {
//                _2x5 = 1;
//                _1x9 = 12;
//            }
//            if (ranout2 <= 34 && ranout2 >= 66 && _1x7 == 0)
//            {
//                _1x8 = 1;
//                _1x7 = 12;
//            }
//            if (ranout2 <= 66 && ranout2 >= 100 && _3x9 == 0)
//            {
//                _2x5 = 1;
//                _3x9 = 12;
//            }
//            ranout2 = random.Next(1, 100);
//            if (ranout2 <= 34 && _1x9 == 0)
//            {
//                _2x5 = 1;
//                _1x9 = 12;
//            }
//            if (ranout2 <= 34 && ranout2 >= 66 && _1x7 == 0)
//            {
//                _1x8 = 1;
//                _1x7 = 12;
//            }
//            if (ranout2 <= 66 && ranout2 >= 100 && _3x9 == 0)
//            {
//                _2x5 = 1;
//                _3x9 = 12;
//            }
//            _1x10 = 1;
//            _1x11 = 1;
//        }
//        if (ranout >= 75)
//        {
//            if (ranout2 <= 34 && _1x9 == 0)
//            {
//                _2x5 = 1;
//                _1x9 = 12;
//            }
//            if (ranout2 <= 34 && ranout2 >= 66 && _1x7 == 0)
//            {
//                _1x8 = 1;
//                _1x7 = 12;
//            }
//            if (ranout2 <= 66 && ranout2 >= 100 && _1x11 == 0)
//            {
//                _1x10 = 1;
//                _1x11 = 12;
//            }
//            ranout2 = random.Next(1, 100);
//            if (ranout2 <= 34 && _1x9 == 0)
//            {
//                _2x5 = 1;
//                _1x9 = 12;
//            }
//            if (ranout2 <= 34 && ranout2 >= 66 && _1x7 == 0)
//            {
//                _1x8 = 1;
//                _1x7 = 12;
//            }
//            if (ranout2 <= 66 && ranout2 >= 100 && _1x11 == 0)
//            {
//                _1x10 = 1;
//                _1x11 = 12;
//            }
//            _2x5 = 1;
//            _3x9 = 1;
//        }
//        if (_1x9 == 1)
//        {
//            _1x9 = 11;
//        }
//        cellcount++;
//    }

//    if (_1x11 == 10 || _1x11 == 1)
//    {
//        if (ranout4 == cellcount)
//        {
//            _1x11 = 5;
//            break;
//        }
//        Random random = new Random();
//        int ranout = random.Next(1, 100);
//        int ranout2 = random.Next(1, 100);
//        if (ranout <= 25)
//        {
//            if (ranout2 <= 34 && _3x11 == 0)
//            {
//                _2x6 = 1;
//                _3x11 = 12;
//            }
//            if (ranout2 <= 34 && ranout2 >= 66 && _1x9 == 0)
//            {
//                _1x10 = 1;
//                _1x9 = 12;
//            }
//            if (ranout2 <= 66 && ranout2 >= 100 && _1x13 == 0)
//            {
//                _1x12 = 1;
//                _1x13 = 12;
//            }
//            ranout2 = random.Next(1, 100);
//            if (ranout2 <= 34 && _3x11 == 0)
//            {
//                _2x6 = 1;
//                _3x11 = 12;
//            }
//            if (ranout2 <= 34 && ranout2 >= 66 && _1x9 == 0)
//            {
//                _1x10 = 1;
//                _1x9 = 12;
//            }
//            if (ranout2 <= 66 && ranout2 >= 100 && _1x13 == 0)
//            {
//                _1x12 = 1;
//                _1x13 = 12;
//            }
//            _2x6 = 1;
//            _1x11 = 1;
//        }
//        if (ranout >= 25 && ranout <= 50)
//        {
//            if (ranout2 <= 34 && _1x11 == 0)
//            {
//                _2x6 = 1;
//                _1x11 = 12;
//            }
//            if (ranout2 <= 34 && ranout2 >= 66 && _3x11 == 0)
//            {
//                _2x6 = 1;
//                _3x11 = 12;
//            }
//            if (ranout2 <= 66 && ranout2 >= 100 && _1x13 == 0)
//            {
//                _1x12 = 1;
//                _1x13 = 12;
//            }
//            ranout2 = random.Next(1, 100);
//            if (ranout2 <= 34 && _1x11 == 0)
//            {
//                _2x6 = 1;
//                _1x11 = 12;
//            }
//            if (ranout2 <= 34 && ranout2 >= 66 && _3x11 == 0)
//            {
//                _2x6 = 1;
//                _3x11 = 12;
//            }
//            if (ranout2 <= 66 && ranout2 >= 100 && _1x13 == 0)
//            {
//                _1x12 = 1;
//                _1x13 = 12;
//            }
//            _1x10 = 1;
//            _1x9 = 1;
//        }
//        if (ranout >= 50 && ranout <= 75)
//        {
//            if (ranout2 <= 34 && _1x11 == 0)
//            {
//                _2x6 = 1;
//                _1x11 = 12;
//            }
//            if (ranout2 <= 34 && ranout2 >= 66 && _1x9 == 0)
//            {
//                _1x10 = 1;
//                _1x9 = 12;
//            }
//            if (ranout2 <= 66 && ranout2 >= 100 && _3x11 == 0)
//            {
//                _2x6 = 1;
//                _3x11 = 12;
//            }
//            ranout2 = random.Next(1, 100);
//            if (ranout2 <= 34 && _1x11 == 0)
//            {
//                _2x6 = 1;
//                _1x11 = 12;
//            }
//            if (ranout2 <= 34 && ranout2 >= 66 && _1x9 == 0)
//            {
//                _1x10 = 1;
//                _1x9 = 12;
//            }
//            if (ranout2 <= 66 && ranout2 >= 100 && _3x11 == 0)
//            {
//                _2x6 = 1;
//                _3x11 = 12;
//            }
//            _1x12 = 1;
//            _1x13 = 1;
//        }
//        if (ranout >= 75)
//        {
//            if (ranout2 <= 34 && _1x11 == 0)
//            {
//                _2x6 = 1;
//                _1x11 = 12;
//            }
//            if (ranout2 <= 34 && ranout2 >= 66 && _1x9 == 0)
//            {
//                _1x10 = 1;
//                _1x9 = 12;
//            }
//            if (ranout2 <= 66 && ranout2 >= 100 && _1x13 == 0)
//            {
//                _1x12 = 1;
//                _1x13 = 12;
//            }
//            ranout2 = random.Next(1, 100);
//            if (ranout2 <= 34 && _1x11 == 0)
//            {
//                _2x6 = 1;
//                _1x11 = 12;
//            }
//            if (ranout2 <= 34 && ranout2 >= 66 && _1x9 == 0)
//            {
//                _1x10 = 1;
//                _1x9 = 12;
//            }
//            if (ranout2 <= 66 && ranout2 >= 100 && _1x13 == 0)
//            {
//                _1x12 = 1;
//                _1x13 = 12;
//            }
//            _2x6 = 1;
//            _3x11 = 1;
//        }
//        if (_1x11 == 1)
//        {
//            _1x11 = 11;
//        }
//        cellcount++;
//    }

//    if (_1x13 == 10 || _1x13 == 1)
//    {
//        if (ranout4 == cellcount)
//        {
//            _1x13 = 5;
//            break;
//        }
//        Random random = new Random();
//        int ranout = random.Next(1, 100);
//        int ranout2 = random.Next(1, 100);
//        if (ranout <= 25)
//        {
//            if (ranout2 <= 34 && _3x13 == 0)
//            {
//                _2x7 = 1;
//                _3x13 = 12;
//            }
//            if (ranout2 <= 34 && ranout2 >= 66 && _1x11 == 0)
//            {
//                _1x12 = 1;
//                _1x11 = 12;
//            }
//            if (ranout2 <= 66 && ranout2 >= 100 && _1x15 == 0)
//            {
//                _1x14 = 1;
//                _1x15 = 12;
//            }
//            ranout2 = random.Next(1, 100);
//            if (ranout2 <= 34 && _3x13 == 0)
//            {
//                _2x7 = 1;
//                _3x13 = 12;
//            }
//            if (ranout2 <= 34 && ranout2 >= 66 && _1x11 == 0)
//            {
//                _1x12 = 1;
//                _1x11 = 12;
//            }
//            if (ranout2 <= 66 && ranout2 >= 100 && _1x15 == 0)
//            {
//                _1x14 = 1;
//                _1x15 = 12;
//            }
//            _2x7 = 1;
//            _1x13 = 1;
//        }
//        if (ranout >= 25 && ranout <= 50)
//        {
//            if (ranout2 <= 34 && _1x13 == 0)
//            {
//                _2x7 = 1;
//                _1x13 = 12;
//            }
//            if (ranout2 <= 34 && ranout2 >= 66 && _3x13 == 0)
//            {
//                _2x7 = 1;
//                _3x13 = 12;
//            }
//            if (ranout2 <= 66 && ranout2 >= 100 && _1x15 == 0)
//            {
//                _1x14 = 1;
//                _1x15 = 12;
//            }
//            ranout2 = random.Next(1, 100);
//            if (ranout2 <= 34 && _1x13 == 0)
//            {
//                _2x7 = 1;
//                _1x13 = 12;
//            }
//            if (ranout2 <= 34 && ranout2 >= 66 && _3x13 == 0)
//            {
//                _2x7 = 1;
//                _3x13 = 12;
//            }
//            if (ranout2 <= 66 && ranout2 >= 100 && _1x15 == 0)
//            {
//                _1x14 = 1;
//                _1x15 = 12;
//            }
//            _1x12 = 1;
//            _1x11 = 1;
//        }
//        if (ranout >= 50 && ranout <= 75)
//        {
//            if (ranout2 <= 34 && _1x13 == 0)
//            {
//                _2x7 = 1;
//                _1x13 = 12;
//            }
//            if (ranout2 <= 34 && ranout2 >= 66 && _1x11 == 0)
//            {
//                _1x12 = 1;
//                _1x11 = 12;
//            }
//            if (ranout2 <= 66 && ranout2 >= 100 && _3x13 == 0)
//            {
//                _2x7 = 1;
//                _3x13 = 12;
//            }
//            ranout2 = random.Next(1, 100);
//            if (ranout2 <= 34 && _1x13 == 0)
//            {
//                _2x7 = 1;
//                _1x13 = 12;
//            }
//            if (ranout2 <= 34 && ranout2 >= 66 && _1x11 == 0)
//            {
//                _1x12 = 1;
//                _1x11 = 12;
//            }
//            if (ranout2 <= 66 && ranout2 >= 100 && _3x13 == 0)
//            {
//                _2x7 = 1;
//                _3x13 = 12;
//            }
//            _1x14 = 1;
//            _1x15 = 1;
//        }
//        if (ranout >= 75)
//        {
//            if (ranout2 <= 34 && _1x13 == 0)
//            {
//                _2x7 = 1;
//                _1x13 = 12;
//            }
//            if (ranout2 <= 34 && ranout2 >= 66 && _1x11 == 0)
//            {
//                _1x12 = 1;
//                _1x11 = 12;
//            }
//            if (ranout2 <= 66 && ranout2 >= 100 && _1x15 == 0)
//            {
//                _1x14 = 1;
//                _1x15 = 12;
//            }
//            ranout2 = random.Next(1, 100);
//            if (ranout2 <= 34 && _1x13 == 0)
//            {
//                _2x7 = 1;
//                _1x13 = 12;
//            }
//            if (ranout2 <= 34 && ranout2 >= 66 && _1x11 == 0)
//            {
//                _1x12 = 1;
//                _1x11 = 12;
//            }
//            if (ranout2 <= 66 && ranout2 >= 100 && _1x15 == 0)
//            {
//                _1x14 = 1;
//                _1x15 = 12;
//            }
//            _2x7 = 1;
//            _3x13 = 1;
//        }
//        if (_1x13 == 1)
//        {
//            _1x13 = 11;
//        }
//        cellcount++;
//    }

//    if (_1x15 == 10 || _1x15 == 1)
//    {
//        if (ranout4 == cellcount)
//        {
//            _1x15 = 5;
//            break;
//        }
//        Random random = new Random();
//        int ranout = random.Next(1, 100);
//        int ranout2 = random.Next(1, 100);
//        if (ranout <= 25)
//        {
//            if (ranout2 <= 34 && _3x15 == 0)
//            {
//                _2x8 = 1;
//                _3x15 = 12;
//            }
//            if (ranout2 <= 34 && ranout2 >= 66 && _1x13 == 0)
//            {
//                _1x14 = 1;
//                _1x13 = 12;
//            }
//            if (ranout2 <= 66 && ranout2 >= 100 && _1x17 == 0)
//            {
//                _1x16 = 1;
//                _1x17 = 12;
//            }
//            ranout2 = random.Next(1, 100);
//            if (ranout2 <= 34 && _3x15 == 0)
//            {
//                _2x8 = 1;
//                _3x15 = 12;
//            }
//            if (ranout2 <= 34 && ranout2 >= 66 && _1x13 == 0)
//            {
//                _1x14 = 1;
//                _1x13 = 12;
//            }
//            if (ranout2 <= 66 && ranout2 >= 100 && _1x17 == 0)
//            {
//                _1x16 = 1;
//                _1x17 = 12;
//            }
//            _2x8 = 1;
//            _1x15 = 1;
//        }
//        if (ranout >= 25 && ranout <= 50)
//        {
//            if (ranout2 <= 34 && _1x15 == 0)
//            {
//                _2x8 = 1;
//                _1x15 = 12;
//            }
//            if (ranout2 <= 34 && ranout2 >= 66 && _3x15 == 0)
//            {
//                _2x8 = 1;
//                _3x15 = 12;
//            }
//            if (ranout2 <= 66 && ranout2 >= 100 && _1x17 == 0)
//            {
//                _1x16 = 1;
//                _1x17 = 12;
//            }
//            ranout2 = random.Next(1, 100);
//            if (ranout2 <= 34 && _1x15 == 0)
//            {
//                _2x8 = 1;
//                _1x15 = 12;
//            }
//            if (ranout2 <= 34 && ranout2 >= 66 && _3x15 == 0)
//            {
//                _2x8 = 1;
//                _3x15 = 12;
//            }
//            if (ranout2 <= 66 && ranout2 >= 100 && _1x17 == 0)
//            {
//                _1x16 = 1;
//                _1x17 = 12;
//            }
//            _1x14 = 1;
//            _1x13 = 1;
//        }
//        if (ranout >= 50 && ranout <= 75)
//        {
//            if (ranout2 <= 34 && _1x15 == 0)
//            {
//                _2x8 = 1;
//                _1x15 = 12;
//            }
//            if (ranout2 <= 34 && ranout2 >= 66 && _1x13 == 0)
//            {
//                _1x14 = 1;
//                _1x13 = 12;
//            }
//            if (ranout2 <= 66 && ranout2 >= 100 && _3x15 == 0)
//            {
//                _2x8 = 1;
//                _3x15 = 12;
//            }
//            ranout2 = random.Next(1, 100);
//            if (ranout2 <= 34 && _1x15 == 0)
//            {
//                _2x8 = 1;
//                _1x15 = 12;
//            }
//            if (ranout2 <= 34 && ranout2 >= 66 && _1x13 == 0)
//            {
//                _1x14 = 1;
//                _1x13 = 12;
//            }
//            if (ranout2 <= 66 && ranout2 >= 100 && _3x15 == 0)
//            {
//                _2x8 = 1;
//                _3x15 = 12;
//            }
//            _1x16 = 1;
//            _1x17 = 1;
//        }
//        if (ranout >= 75)
//        {
//            if (ranout2 <= 34 && _1x15 == 0)
//            {
//                _2x8 = 1;
//                _1x15 = 12;
//            }
//            if (ranout2 <= 34 && ranout2 >= 66 && _1x13 == 0)
//            {
//                _1x14 = 1;
//                _1x13 = 12;
//            }
//            if (ranout2 <= 66 && ranout2 >= 100 && _1x17 == 0)
//            {
//                _1x16 = 1;
//                _1x17 = 12;
//            }
//            ranout2 = random.Next(1, 100);
//            if (ranout2 <= 34 && _1x15 == 0)
//            {
//                _2x8 = 1;
//                _1x15 = 12;
//            }
//            if (ranout2 <= 34 && ranout2 >= 66 && _1x13 == 0)
//            {
//                _1x14 = 1;
//                _1x13 = 12;
//            }
//            if (ranout2 <= 66 && ranout2 >= 100 && _1x17 == 0)
//            {
//                _1x16 = 1;
//                _1x17 = 12;
//            }
//            _2x8 = 1;
//            _3x15 = 1;
//        }
//        if (_1x15 == 1)
//        {
//            _1x15 = 11;
//        }
//        cellcount++;
//    }

//    if (_1x17 == 10 || _1x17 == 1)
//    {
//        if (ranout4 == cellcount)
//        {
//            _1x17 = 5;
//            break;
//        }
//        Random random = new Random();
//        int ranout = random.Next(1, 100);
//        int ranout2 = random.Next(1, 100);
//        if (ranout <= 34)
//        {
//            if (ranout2 <= 50 && _3x17 == 0)
//            {
//                _2x9 = 1;
//                _3x17 = 12;
//            }
//            if (ranout2 >= 50 && _1x15 == 0)
//            {
//                _1x16 = 1;
//                _1x15 = 12;
//            }
//            ranout2 = random.Next(1, 100);
//            if (ranout2 <= 50 && _3x17 == 0)
//            {
//                _2x9 = 1;
//                _3x17 = 12;
//            }
//            if (ranout2 >= 50 && _1x15 == 0)
//            {
//                _1x16 = 1;
//                _1x15 = 12;
//            }
//            _2x9 = 1;
//            _1x17 = 1;
//        }
//        if (ranout >= 34 && ranout <= 66)
//        {
//            if (ranout2 <= 50 && _1x17 == 0)
//            {
//                _2x9 = 1;
//                _1x17 = 12;
//            }
//            if (ranout2 >= 50 && _3x17 == 0)
//            {
//                _2x9 = 1;
//                _3x17 = 12;
//            }
//            ranout2 = random.Next(1, 100);
//            if (ranout2 <= 50 && _1x17 == 0)
//            {
//                _2x9 = 1;
//                _1x17 = 12;
//            }
//            if (ranout2 >= 50 && _3x17 == 0)
//            {
//                _2x9 = 1;
//                _3x17 = 12;
//            }
//            _1x16 = 1;
//            _1x15 = 1;
//        }
//        if (ranout >= 66)
//        {
//            if (ranout2 <= 50 && _1x17 == 0)
//            {
//                _2x9 = 1;
//                _1x17 = 12;
//            }
//            if (ranout2 >= 50 && _1x15 == 0)
//            {
//                _1x16 = 1;
//                _1x15 = 12;
//            }
//            ranout2 = random.Next(1, 100);
//            if (ranout2 <= 50 && _1x17 == 0)
//            {
//                _2x9 = 1;
//                _1x17 = 12;
//            }
//            if (ranout2 >= 50 && _1x15 == 0)
//            {
//                _1x16 = 1;
//                _1x15 = 12;
//            }
//            _2x9 = 1;
//            _3x17 = 1;
//        }
//        if (_1x17 == 1)
//        {
//            _1x17 = 11;
//        }
//        cellcount++;
//    }
//    // coridors done from here                                                                            //////////////////////
//    if (_3x1 == 10 || _3x1 == 1)
//    {
//        if (ranout4 == cellcount)
//        {
//            _3x1 = 5;
//            break;
//        }
//        Random random = new Random();
//        int ranout = random.Next(1, 100);
//        int ranout2 = random.Next(1, 100);
//        if (ranout <= 34)
//        {
//            if (ranout2 <= 50 && _5x1 == 0)
//            {
//                _4x1 = 1;
//                _5x1 = 12;
//            }
//            if (ranout2 >= 50 && _3x3 == 0)
//            {
//                _3x2 = 1;
//                _3x3 = 12;
//            }
//            ranout2 = random.Next(1, 100);
//            if (ranout2 <= 50 && _5x1 == 0)
//            {
//                _4x1 = 1;
//                _5x1 = 12;
//            }
//            if (ranout2 >= 50 && _3x3 == 0)
//            {
//                _3x2 = 1;
//                _3x3 = 12;
//            }
//            _2x1 = 1;
//            _1x1 = 1;
//        }
//        if (ranout >= 34 && ranout <= 66)
//        {
//            if (ranout2 <= 50 && _1x1 == 0)
//            {
//                _2x1 = 1;
//                _1x1 = 12;
//            }
//            if (ranout2 >= 50 && _5x1 == 0)
//            {
//                _4x1 = 1;
//                _5x1 = 12;
//            }
//            ranout2 = random.Next(1, 100);
//            if (ranout2 <= 50 && _1x1 == 0)
//            {
//                _2x1 = 1;
//                _1x1 = 12;
//            }
//            if (ranout2 >= 50 && _5x1 == 0)
//            {
//                _4x1 = 1;
//                _5x1 = 12;
//            }
//            _3x2 = 1;
//            _3x3 = 1;
//        }
//        if (ranout >= 66)
//        {
//            if (ranout2 <= 50 && _1x1 == 0)
//            {
//                _2x1 = 1;
//                _1x1 = 12;
//            }
//            if (ranout2 >= 50 && _3x3 == 0)
//            {
//                _3x2 = 1;
//                _3x3 = 12;
//            }
//            ranout2 = random.Next(1, 100);
//            if (ranout2 <= 50 && _1x1 == 0)
//            {
//                _2x1 = 1;
//                _1x1 = 12;
//            }
//            if (ranout2 >= 50 && _3x3 == 0)
//            {
//                _3x2 = 1;
//                _3x3 = 12;
//            }
//            _4x1 = 1;
//            _5x1 = 1;
//        }
//        if (_3x1 == 1)
//        {
//            _3x1 = 11;
//        }
//        cellcount++;
//    }

//    if (_3x3 == 10 || _3x3 == 1)
//    {
//        if (ranout4 == cellcount)
//        {
//            _3x3 = 5;
//            break;
//        }
//        Random random = new Random();
//        int ranout = random.Next(1, 100);
//        int ranout2 = random.Next(1, 100);
//        if (ranout <= 25)
//        {
//            if (ranout2 <= 34 && _5x3 == 0)
//            {
//                _4x2 = 1;
//                _5x3 = 12;
//            }
//            if (ranout2 <= 34 && ranout2 >= 66 && _3x1 == 0)
//            {
//                _3x2 = 1;
//                _3x1 = 12;
//            }
//            if (ranout2 <= 66 && ranout2 >= 100 && _3x5 == 0)
//            {
//                _3x4 = 1;
//                _3x5 = 12;
//            }
//            ranout2 = random.Next(1, 100);
//            if (ranout2 <= 34 && _5x3 == 0)
//            {
//                _4x2 = 1;
//                _5x3 = 12;
//            }
//            if (ranout2 <= 34 && ranout2 >= 66 && _3x1 == 0)
//            {
//                _3x2 = 1;
//                _3x1 = 12;
//            }
//            if (ranout2 <= 66 && ranout2 >= 100 && _3x5 == 0)
//            {
//                _3x4 = 1;
//                _3x5 = 12;
//            }
//            _2x2 = 1;
//            _1x3 = 1;
//        }
//        if (ranout >= 25 && ranout <= 50)
//        {
//            if (ranout2 <= 34 && _1x3 == 0)
//            {
//                _2x2 = 1;
//                _1x3 = 12;
//            }
//            if (ranout2 <= 34 && ranout2 >= 66 && _5x3 == 0)
//            {
//                _4x2 = 1;
//                _5x3 = 12;
//            }
//            if (ranout2 <= 66 && ranout2 >= 100 && _3x5 == 0)
//            {
//                _3x4 = 1;
//                _3x5 = 12;
//            }
//            ranout2 = random.Next(1, 100);
//            if (ranout2 <= 34 && _1x3 == 0)
//            {
//                _2x2 = 1;
//                _1x3 = 12;
//            }
//            if (ranout2 <= 34 && ranout2 >= 66 && _5x3 == 0)
//            {
//                _4x2 = 1;
//                _5x3 = 12;
//            }
//            if (ranout2 <= 66 && ranout2 >= 100 && _3x5 == 0)
//            {
//                _3x4 = 1;
//                _3x5 = 12;
//            }
//            _3x2 = 1;
//            _3x1 = 1;
//        }
//        if (ranout >= 50 && ranout <= 75)
//        {
//            if (ranout2 <= 34 && _1x3 == 0)
//            {
//                _2x2 = 1;
//                _1x3 = 12;
//            }
//            if (ranout2 <= 34 && ranout2 >= 66 && _3x1 == 0)
//            {
//                _3x2 = 1;
//                _3x1 = 12;
//            }
//            if (ranout2 <= 66 && ranout2 >= 100 && _5x3 == 0)
//            {
//                _4x2 = 1;
//                _5x3 = 12;
//            }
//            ranout2 = random.Next(1, 100);
//            if (ranout2 <= 34 && _1x3 == 0)
//            {
//                _2x2 = 1;
//                _1x3 = 12;
//            }
//            if (ranout2 <= 34 && ranout2 >= 66 && _3x1 == 0)
//            {
//                _3x2 = 1;
//                _3x1 = 12;
//            }
//            if (ranout2 <= 66 && ranout2 >= 100 && _5x3 == 0)
//            {
//                _4x2 = 1;
//                _5x3 = 12;
//            }
//            _3x4 = 1;
//            _3x5 = 1;
//        }
//        if (ranout >= 75)
//        {
//            if (ranout2 <= 34 && _1x3 == 0)
//            {
//                _2x2 = 1;
//                _1x3 = 12;
//            }
//            if (ranout2 <= 34 && ranout2 >= 66 && _3x1 == 0)
//            {
//                _3x2 = 1;
//                _3x1 = 12;
//            }
//            if (ranout2 <= 66 && ranout2 >= 100 && _3x5 == 0)
//            {
//                _3x4 = 1;
//                _3x5 = 12;
//            }
//            ranout2 = random.Next(1, 100);
//            if (ranout2 <= 34 && _1x3 == 0)
//            {
//                _2x2 = 1;
//                _1x3 = 12;
//            }
//            if (ranout2 <= 34 && ranout2 >= 66 && _3x1 == 0)
//            {
//                _3x2 = 1;
//                _3x1 = 12;
//            }
//            if (ranout2 <= 66 && ranout2 >= 100 && _3x5 == 0)
//            {
//                _3x4 = 1;
//                _3x5 = 12;
//            }
//            _4x2 = 1;
//            _5x3 = 1;
//        }
//        if (_3x3 == 1)
//        {
//            _3x3 = 11;
//        }
//        cellcount++;
//    }

//    if (_3x5 == 10 || _3x5 == 1)
//    {
//        if (ranout4 == cellcount)
//        {
//            _3x5 = 5;
//            break;
//        }
//        Random random = new Random();
//        int ranout = random.Next(1, 100);
//        int ranout2 = random.Next(1, 100);
//        if (ranout <= 25)
//        {
//            if (ranout2 <= 34 && _5x5 == 0)
//            {
//                _4x3 = 1;
//                _5x5 = 12;
//            }
//            if (ranout2 <= 34 && ranout2 >= 66 && _3x3 == 0)
//            {
//                _3x4 = 1;
//                _3x3 = 12;
//            }
//            if (ranout2 <= 66 && ranout2 >= 100 && _3x7 == 0)
//            {
//                _3x6 = 1;
//                _3x7 = 12;
//            }
//            ranout2 = random.Next(1, 100);
//            if (ranout2 <= 34 && _5x5 == 0)
//            {
//                _4x3 = 1;
//                _5x5 = 12;
//            }
//            if (ranout2 <= 34 && ranout2 >= 66 && _3x3 == 0)
//            {
//                _3x4 = 1;
//                _3x3 = 12;
//            }
//            if (ranout2 <= 66 && ranout2 >= 100 && _3x7 == 0)
//            {
//                _3x6 = 1;
//                _3x7 = 12;
//            }
//            _2x3 = 1;
//            _1x5 = 1;
//        }
//        if (ranout >= 25 && ranout <= 50)
//        {
//            if (ranout2 <= 34 && _1x5 == 0)
//            {
//                _2x3 = 1;
//                _1x5 = 12;
//            }
//            if (ranout2 <= 34 && ranout2 >= 66 && _5x5 == 0)
//            {
//                _4x3 = 1;
//                _5x5 = 12;
//            }
//            if (ranout2 <= 66 && ranout2 >= 100 && _3x7 == 0)
//            {
//                _3x6 = 1;
//                _3x7 = 12;
//            }
//            ranout2 = random.Next(1, 100);
//            if (ranout2 <= 34 && _1x5 == 0)
//            {
//                _2x3 = 1;
//                _1x5 = 12;
//            }
//            if (ranout2 <= 34 && ranout2 >= 66 && _5x5 == 0)
//            {
//                _4x3 = 1;
//                _5x5 = 12;
//            }
//            if (ranout2 <= 66 && ranout2 >= 100 && _3x7 == 0)
//            {
//                _3x6 = 1;
//                _3x7 = 12;
//            }
//            _3x4 = 1;
//            _3x3 = 1;
//        }
//        if (ranout >= 50 && ranout <= 75)
//        {
//            if (ranout2 <= 34 && _1x5 == 0)
//            {
//                _2x3 = 1;
//                _1x5 = 12;
//            }
//            if (ranout2 <= 34 && ranout2 >= 66 && _3x3 == 0)
//            {
//                _3x4 = 1;
//                _3x3 = 12;
//            }
//            if (ranout2 <= 66 && ranout2 >= 100 && _5x5 == 0)
//            {
//                _4x3 = 1;
//                _5x5 = 12;
//            }
//            ranout2 = random.Next(1, 100);
//            if (ranout2 <= 34 && _1x5 == 0)
//            {
//                _2x3 = 1;
//                _1x5 = 12;
//            }
//            if (ranout2 <= 34 && ranout2 >= 66 && _3x3 == 0)
//            {
//                _3x4 = 1;
//                _3x3 = 12;
//            }
//            if (ranout2 <= 66 && ranout2 >= 100 && _5x5 == 0)
//            {
//                _4x3 = 1;
//                _5x5 = 12;
//            }
//            _3x6 = 1;
//            _3x7 = 1;
//        }
//        if (ranout >= 75)
//        {
//            if (ranout2 <= 34 && _1x5 == 0)
//            {
//                _2x3 = 1;
//                _1x5 = 12;
//            }
//            if (ranout2 <= 34 && ranout2 >= 66 && _3x3 == 0)
//            {
//                _3x4 = 1;
//                _3x3 = 12;
//            }
//            if (ranout2 <= 66 && ranout2 >= 100 && _3x7 == 0)
//            {
//                _3x6 = 1;
//                _3x7 = 12;
//            }
//            ranout2 = random.Next(1, 100);
//            if (ranout2 <= 34 && _1x5 == 0)
//            {
//                _2x3 = 1;
//                _1x5 = 12;
//            }
//            if (ranout2 <= 34 && ranout2 >= 66 && _3x3 == 0)
//            {
//                _3x4 = 1;
//                _3x3 = 12;
//            }
//            if (ranout2 <= 66 && ranout2 >= 100 && _3x7 == 0)
//            {
//                _3x6 = 1;
//                _3x7 = 12;
//            }
//            _4x3 = 1;
//            _5x5 = 1;
//        }
//        if (_3x5 == 1)
//        {
//            _3x5 = 11;
//        }
//        cellcount++;
//    }

//    if (_3x7 == 10 || _3x7 == 1)
//    {
//        if (ranout4 == cellcount)
//        {
//            _3x7 = 5;
//            break;
//        }
//        Random random = new Random();
//        int ranout = random.Next(1, 100);
//        int ranout2 = random.Next(1, 100);
//        if (ranout <= 25)
//        {
//            if (ranout2 <= 34 && _5x7 == 0)
//            {
//                _4x4 = 1;
//                _5x7 = 12;
//            }
//            if (ranout2 <= 34 && ranout2 >= 66 && _3x5 == 0)
//            {
//                _3x6 = 1;
//                _3x5 = 12;
//            }
//            if (ranout2 <= 66 && ranout2 >= 100 && _3x9 == 0)
//            {
//                _3x8 = 1;
//                _3x9 = 12;
//            }
//            ranout2 = random.Next(1, 100);
//            if (ranout2 <= 34 && _5x7 == 0)
//            {
//                _4x4 = 1;
//                _5x7 = 12;
//            }
//            if (ranout2 <= 34 && ranout2 >= 66 && _3x5 == 0)
//            {
//                _3x6 = 1;
//                _3x5 = 12;
//            }
//            if (ranout2 <= 66 && ranout2 >= 100 && _3x9 == 0)
//            {
//                _3x8 = 1;
//                _3x9 = 12;
//            }
//            _2x4 = 1;
//            _1x7 = 1;
//        }
//        if (ranout >= 25 && ranout <= 50)
//        {
//            if (ranout2 <= 34 && _1x7 == 0)
//            {
//                _2x4 = 1;
//                _1x7 = 12;
//            }
//            if (ranout2 <= 34 && ranout2 >= 66 && _5x7 == 0)
//            {
//                _4x4 = 1;
//                _5x7 = 12;
//            }
//            if (ranout2 <= 66 && ranout2 >= 100 && _3x9 == 0)
//            {
//                _3x8 = 1;
//                _3x9 = 12;
//            }
//            ranout2 = random.Next(1, 100);
//            if (ranout2 <= 34 && _1x7 == 0)
//            {
//                _2x4 = 1;
//                _1x7 = 12;
//            }
//            if (ranout2 <= 34 && ranout2 >= 66 && _5x7 == 0)
//            {
//                _4x4 = 1;
//                _5x7 = 12;
//            }
//            if (ranout2 <= 66 && ranout2 >= 100 && _3x9 == 0)
//            {
//                _3x8 = 1;
//                _3x9 = 12;
//            }
//            _3x6 = 1;
//            _3x5 = 1;
//        }
//        if (ranout >= 50 && ranout <= 75)
//        {
//            if (ranout2 <= 34 && _1x7 == 0)
//            {
//                _2x4 = 1;
//                _1x7 = 12;
//            }
//            if (ranout2 <= 34 && ranout2 >= 66 && _3x5 == 0)
//            {
//                _3x6 = 1;
//                _3x5 = 12;
//            }
//            if (ranout2 <= 66 && ranout2 >= 100 && _5x7 == 0)
//            {
//                _4x4 = 1;
//                _5x7 = 12;
//            }
//            ranout2 = random.Next(1, 100);
//            if (ranout2 <= 34 && _1x7 == 0)
//            {
//                _2x4 = 1;
//                _1x7 = 12;
//            }
//            if (ranout2 <= 34 && ranout2 >= 66 && _3x5 == 0)
//            {
//                _3x6 = 1;
//                _3x5 = 12;
//            }
//            if (ranout2 <= 66 && ranout2 >= 100 && _5x7 == 0)
//            {
//                _4x4 = 1;
//                _5x7 = 12;
//            }
//            _3x8 = 1;
//            _3x9 = 1;
//        }
//        if (ranout >= 75)
//        {
//            if (ranout2 <= 34 && _1x7 == 0)
//            {
//                _2x4 = 1;
//                _1x7 = 12;
//            }
//            if (ranout2 <= 34 && ranout2 >= 66 && _3x5 == 0)
//            {
//                _3x6 = 1;
//                _3x5 = 12;
//            }
//            if (ranout2 <= 66 && ranout2 >= 100 && _3x9 == 0)
//            {
//                _3x8 = 1;
//                _3x9 = 12;
//            }
//            ranout2 = random.Next(1, 100);
//            if (ranout2 <= 34 && _1x7 == 0)
//            {
//                _2x4 = 1;
//                _1x7 = 12;
//            }
//            if (ranout2 <= 34 && ranout2 >= 66 && _3x5 == 0)
//            {
//                _3x6 = 1;
//                _3x5 = 12;
//            }
//            if (ranout2 <= 66 && ranout2 >= 100 && _3x9 == 0)
//            {
//                _3x8 = 1;
//                _3x9 = 12;
//            }
//            _4x4 = 1;
//            _5x7 = 1;
//        }
//        if (_3x7 == 1)
//        {
//            _3x7 = 11;
//        }
//        cellcount++;
//    }

//    if (_3x9 == 10 || _3x9 == 1)
//    {
//        if (ranout4 == cellcount)
//        {
//            _3x9 = 5;
//            break;
//        }
//        Random random = new Random();
//        int ranout = random.Next(1, 100);
//        int ranout2 = random.Next(1, 100);
//        if (ranout <= 25)
//        {
//            if (ranout2 <= 34 && _5x9 == 0)
//            {
//                _4x5 = 1;
//                _5x9 = 12;
//            }
//            if (ranout2 <= 34 && ranout2 >= 66 && _3x7 == 0)
//            {
//                _3x8 = 1;
//                _3x7 = 12;
//            }
//            if (ranout2 <= 66 && ranout2 >= 100 && _3x11 == 0)
//            {
//                _3x10 = 1;
//                _3x11 = 12;
//            }
//            ranout2 = random.Next(1, 100);
//            if (ranout2 <= 34 && _5x9 == 0)
//            {
//                _4x5 = 1;
//                _5x9 = 12;
//            }
//            if (ranout2 <= 34 && ranout2 >= 66 && _3x7 == 0)
//            {
//                _3x8 = 1;
//                _3x7 = 12;
//            }
//            if (ranout2 <= 66 && ranout2 >= 100 && _3x11 == 0)
//            {
//                _3x10 = 1;
//                _3x11 = 12;
//            }
//            _2x5 = 1;
//            _1x9 = 1;
//        }
//        if (ranout >= 25 && ranout <= 50)
//        {
//            if (ranout2 <= 34 && _1x9 == 0)
//            {
//                _2x5 = 1;
//                _1x9 = 12;
//            }
//            if (ranout2 <= 34 && ranout2 >= 66 && _5x9 == 0)
//            {
//                _4x5 = 1;
//                _5x9 = 12;
//            }
//            if (ranout2 <= 66 && ranout2 >= 100 && _3x11 == 0)
//            {
//                _3x10 = 1;
//                _3x11 = 12;
//            }
//            ranout2 = random.Next(1, 100);
//            if (ranout2 <= 34 && _1x9 == 0)
//            {
//                _2x5 = 1;
//                _1x9 = 12;
//            }
//            if (ranout2 <= 34 && ranout2 >= 66 && _5x9 == 0)
//            {
//                _4x5 = 1;
//                _5x9 = 12;
//            }
//            if (ranout2 <= 66 && ranout2 >= 100 && _3x11 == 0)
//            {
//                _3x10 = 1;
//                _3x11 = 12;
//            }
//            _3x8 = 1;
//            _3x7 = 1;
//        }
//        if (ranout >= 50 && ranout <= 75)
//        {
//            if (ranout2 <= 34 && _1x9 == 0)
//            {
//                _2x5 = 1;
//                _1x9 = 12;
//            }
//            if (ranout2 <= 34 && ranout2 >= 66 && _3x7 == 0)
//            {
//                _3x8 = 1;
//                _3x7 = 12;
//            }
//            if (ranout2 <= 66 && ranout2 >= 100 && _5x9 == 0)
//            {
//                _4x5 = 1;
//                _5x9 = 12;
//            }
//            ranout2 = random.Next(1, 100);
//            if (ranout2 <= 34 && _1x9 == 0)
//            {
//                _2x5 = 1;
//                _1x9 = 12;
//            }
//            if (ranout2 <= 34 && ranout2 >= 66 && _3x7 == 0)
//            {
//                _3x8 = 1;
//                _3x7 = 12;
//            }
//            if (ranout2 <= 66 && ranout2 >= 100 && _5x9 == 0)
//            {
//                _4x5 = 1;
//                _5x9 = 12;
//            }
//            _3x10 = 1;
//            _3x11 = 1;
//        }
//        if (ranout >= 75)
//        {
//            if (ranout2 <= 34 && _1x9 == 0)
//            {
//                _2x5 = 1;
//                _1x9 = 12;
//            }
//            if (ranout2 <= 34 && ranout2 >= 66 && _3x7 == 0)
//            {
//                _3x8 = 1;
//                _3x7 = 12;
//            }
//            if (ranout2 <= 66 && ranout2 >= 100 && _3x11 == 0)
//            {
//                _3x10 = 1;
//                _3x11 = 12;
//            }
//            ranout2 = random.Next(1, 100);
//            if (ranout2 <= 34 && _1x9 == 0)
//            {
//                _2x5 = 1;
//                _1x9 = 12;
//            }
//            if (ranout2 <= 34 && ranout2 >= 66 && _3x7 == 0)
//            {
//                _3x8 = 1;
//                _3x7 = 12;
//            }
//            if (ranout2 <= 66 && ranout2 >= 100 && _3x11 == 0)
//            {
//                _3x10 = 1;
//                _3x11 = 12;
//            }
//            _4x5 = 1;
//            _5x9 = 1;
//        }
//        if (_3x9 == 1)
//        {
//            _3x9 = 11;
//        }
//        cellcount++;
//    }

//    if (_3x11 == 10 || _3x11 == 1)
//    {
//        if (ranout4 == cellcount)
//        {
//            _3x11 = 5;
//            break;
//        }
//        Random random = new Random();
//        int ranout = random.Next(1, 100);
//        int ranout2 = random.Next(1, 100);
//        if (ranout <= 25)
//        {
//            if (ranout2 <= 34 && _5x11 == 0)
//            {
//                _4x6 = 1;
//                _5x11 = 12;
//            }
//            if (ranout2 <= 34 && ranout2 >= 66 && _3x9 == 0)
//            {
//                _3x10 = 1;
//                _3x9 = 12;
//            }
//            if (ranout2 <= 66 && ranout2 >= 100 && _3x13 == 0)
//            {
//                _3x12 = 1;
//                _3x13 = 12;
//            }
//            ranout2 = random.Next(1, 100);
//            if (ranout2 <= 34 && _5x11 == 0)
//            {
//                _4x6 = 1;
//                _5x11 = 12;
//            }
//            if (ranout2 <= 34 && ranout2 >= 66 && _3x9 == 0)
//            {
//                _3x10 = 1;
//                _3x9 = 12;
//            }
//            if (ranout2 <= 66 && ranout2 >= 100 && _3x13 == 0)
//            {
//                _3x12 = 1;
//                _3x13 = 12;
//            }
//            _2x6 = 1;
//            _1x11 = 1;
//        }
//        if (ranout >= 25 && ranout <= 50)
//        {
//            if (ranout2 <= 34 && _1x11 == 0)
//            {
//                _2x6 = 1;
//                _1x11 = 12;
//            }
//            if (ranout2 <= 34 && ranout2 >= 66 && _5x11 == 0)
//            {
//                _4x6 = 1;
//                _5x11 = 12;
//            }
//            if (ranout2 <= 66 && ranout2 >= 100 && _3x13 == 0)
//            {
//                _3x12 = 1;
//                _3x13 = 12;
//            }
//            ranout2 = random.Next(1, 100);
//            if (ranout2 <= 34 && _1x11 == 0)
//            {
//                _2x6 = 1;
//                _1x11 = 12;
//            }
//            if (ranout2 <= 34 && ranout2 >= 66 && _5x11 == 0)
//            {
//                _4x6 = 1;
//                _5x11 = 12;
//            }
//            if (ranout2 <= 66 && ranout2 >= 100 && _3x13 == 0)
//            {
//                _3x12 = 1;
//                _3x13 = 12;
//            }
//            _3x10 = 1;
//            _3x9 = 1;
//        }
//        if (ranout >= 50 && ranout <= 75)
//        {
//            if (ranout2 <= 34 && _1x11 == 0)
//            {
//                _2x6 = 1;
//                _1x11 = 12;
//            }
//            if (ranout2 <= 34 && ranout2 >= 66 && _3x9 == 0)
//            {
//                _3x10 = 1;
//                _3x9 = 12;
//            }
//            if (ranout2 <= 66 && ranout2 >= 100 && _5x11 == 0)
//            {
//                _4x6 = 1;
//                _5x11 = 12;
//            }
//            ranout2 = random.Next(1, 100);
//            if (ranout2 <= 34 && _1x11 == 0)
//            {
//                _2x6 = 1;
//                _1x11 = 12;
//            }
//            if (ranout2 <= 34 && ranout2 >= 66 && _3x9 == 0)
//            {
//                _3x10 = 1;
//                _3x9 = 12;
//            }
//            if (ranout2 <= 66 && ranout2 >= 100 && _5x11 == 0)
//            {
//                _4x6 = 1;
//                _5x11 = 12;
//            }
//            _3x12 = 1;
//            _3x13 = 1;
//        }
//        if (ranout >= 75)
//        {
//            if (ranout2 <= 34 && _1x11 == 0)
//            {
//                _2x6 = 1;
//                _1x11 = 12;
//            }
//            if (ranout2 <= 34 && ranout2 >= 66 && _3x9 == 0)
//            {
//                _3x10 = 1;
//                _3x9 = 12;
//            }
//            if (ranout2 <= 66 && ranout2 >= 100 && _3x13 == 0)
//            {
//                _3x12 = 1;
//                _3x13 = 12;
//            }
//            ranout2 = random.Next(1, 100);
//            if (ranout2 <= 34 && _1x11 == 0)
//            {
//                _2x6 = 1;
//                _1x11 = 12;
//            }
//            if (ranout2 <= 34 && ranout2 >= 66 && _3x9 == 0)
//            {
//                _3x10 = 1;
//                _3x9 = 12;
//            }
//            if (ranout2 <= 66 && ranout2 >= 100 && _3x13 == 0)
//            {
//                _3x12 = 1;
//                _3x13 = 12;
//            }
//            _4x6 = 1;
//            _5x11 = 1;
//        }
//        if (_3x11 == 1)
//        {
//            _3x11 = 11;
//        }
//        cellcount++;
//    }

//    if (_3x13 == 10 || _3x13 == 1)
//    {
//        if (ranout4 == cellcount)
//        {
//            _3x13 = 5;
//            break;
//        }
//        Random random = new Random();
//        int ranout = random.Next(1, 100);
//        int ranout2 = random.Next(1, 100);
//        if (ranout <= 25)
//        {
//            if (ranout2 <= 34 && _5x13 == 0)
//            {
//                _4x7 = 1;
//                _5x13 = 12;
//            }
//            if (ranout2 <= 34 && ranout2 >= 66 && _3x11 == 0)
//            {
//                _3x12 = 1;
//                _3x11 = 12;
//            }
//            if (ranout2 <= 66 && ranout2 >= 100 && _3x15 == 0)
//            {
//                _3x14 = 1;
//                _3x15 = 12;
//            }
//            ranout2 = random.Next(1, 100);
//            if (ranout2 <= 34 && _5x13 == 0)
//            {
//                _4x7 = 1;
//                _5x13 = 12;
//            }
//            if (ranout2 <= 34 && ranout2 >= 66 && _3x11 == 0)
//            {
//                _3x12 = 1;
//                _3x11 = 12;
//            }
//            if (ranout2 <= 66 && ranout2 >= 100 && _3x15 == 0)
//            {
//                _3x14 = 1;
//                _3x15 = 12;
//            }
//            _2x7 = 1;
//            _1x13 = 1;
//        }
//        if (ranout >= 25 && ranout <= 50)
//        {
//            if (ranout2 <= 34 && _1x13 == 0)
//            {
//                _2x7 = 1;
//                _1x13 = 12;
//            }
//            if (ranout2 <= 34 && ranout2 >= 66 && _5x13 == 0)
//            {
//                _4x7 = 1;
//                _5x13 = 12;
//            }
//            if (ranout2 <= 66 && ranout2 >= 100 && _3x15 == 0)
//            {
//                _3x14 = 1;
//                _3x15 = 12;
//            }
//            ranout2 = random.Next(1, 100);
//            if (ranout2 <= 34 && _1x13 == 0)
//            {
//                _2x7 = 1;
//                _1x13 = 12;
//            }
//            if (ranout2 <= 34 && ranout2 >= 66 && _5x13 == 0)
//            {
//                _4x7 = 1;
//                _5x13 = 12;
//            }
//            if (ranout2 <= 66 && ranout2 >= 100 && _3x15 == 0)
//            {
//                _3x14 = 1;
//                _3x15 = 12;
//            }
//            _3x12 = 1;
//            _3x11 = 1;
//        }
//        if (ranout >= 50 && ranout <= 75)
//        {
//            if (ranout2 <= 34 && _1x13 == 0)
//            {
//                _2x7 = 1;
//                _1x13 = 12;
//            }
//            if (ranout2 <= 34 && ranout2 >= 66 && _3x11 == 0)
//            {
//                _3x12 = 1;
//                _3x11 = 12;
//            }
//            if (ranout2 <= 66 && ranout2 >= 100 && _5x13 == 0)
//            {
//                _4x7 = 1;
//                _5x13 = 12;
//            }
//            ranout2 = random.Next(1, 100);
//            if (ranout2 <= 34 && _1x13 == 0)
//            {
//                _2x7 = 1;
//                _1x13 = 12;
//            }
//            if (ranout2 <= 34 && ranout2 >= 66 && _3x11 == 0)
//            {
//                _3x12 = 1;
//                _3x11 = 12;
//            }
//            if (ranout2 <= 66 && ranout2 >= 100 && _5x13 == 0)
//            {
//                _4x7 = 1;
//                _5x13 = 12;
//            }
//            _3x14 = 1;
//            _3x15 = 1;
//        }
//        if (ranout >= 75)
//        {
//            if (ranout2 <= 34 && _1x13 == 0)
//            {
//                _2x7 = 1;
//                _1x13 = 12;
//            }
//            if (ranout2 <= 34 && ranout2 >= 66 && _3x11 == 0)
//            {
//                _3x12 = 1;
//                _3x11 = 12;
//            }
//            if (ranout2 <= 66 && ranout2 >= 100 && _3x15 == 0)
//            {
//                _3x14 = 1;
//                _3x15 = 12;
//            }
//            ranout2 = random.Next(1, 100);
//            if (ranout2 <= 34 && _1x13 == 0)
//            {
//                _2x7 = 1;
//                _1x13 = 12;
//            }
//            if (ranout2 <= 34 && ranout2 >= 66 && _3x11 == 0)
//            {
//                _3x12 = 1;
//                _3x11 = 12;
//            }
//            if (ranout2 <= 66 && ranout2 >= 100 && _3x15 == 0)
//            {
//                _3x14 = 1;
//                _3x15 = 12;
//            }
//            _4x7 = 1;
//            _5x13 = 1;
//        }
//        if (_3x13 == 1)
//        {
//            _3x13 = 11;
//        }
//        cellcount++;
//    }

//    if (_3x15 == 10 || _3x15 == 1)
//    {
//        if (ranout4 == cellcount)
//        {
//            _3x15 = 5;
//            break;
//        }
//        Random random = new Random();
//        int ranout = random.Next(1, 100);
//        int ranout2 = random.Next(1, 100);
//        if (ranout <= 25)
//        {
//            if (ranout2 <= 34 && _5x15 == 0)
//            {
//                _4x8 = 1;
//                _5x15 = 12;
//            }
//            if (ranout2 <= 34 && ranout2 >= 66 && _3x13 == 0)
//            {
//                _3x14 = 1;
//                _3x13 = 12;
//            }
//            if (ranout2 <= 66 && ranout2 >= 100 && _3x17 == 0)
//            {
//                _3x16 = 1;
//                _3x17 = 12;
//            }
//            ranout2 = random.Next(1, 100);
//            if (ranout2 <= 34 && _5x15 == 0)
//            {
//                _4x8 = 1;
//                _5x15 = 12;
//            }
//            if (ranout2 <= 34 && ranout2 >= 66 && _3x13 == 0)
//            {
//                _3x14 = 1;
//                _3x13 = 12;
//            }
//            if (ranout2 <= 66 && ranout2 >= 100 && _3x17 == 0)
//            {
//                _3x16 = 1;
//                _3x17 = 12;
//            }
//            _2x8 = 1;
//            _1x15 = 1;
//        }
//        if (ranout >= 25 && ranout <= 50)
//        {
//            if (ranout2 <= 34 && _1x15 == 0)
//            {
//                _2x8 = 1;
//                _1x15 = 12;
//            }
//            if (ranout2 <= 34 && ranout2 >= 66 && _5x15 == 0)
//            {
//                _4x8 = 1;
//                _5x15 = 12;
//            }
//            if (ranout2 <= 66 && ranout2 >= 100 && _3x17 == 0)
//            {
//                _3x16 = 1;
//                _3x17 = 12;
//            }
//            ranout2 = random.Next(1, 100);
//            if (ranout2 <= 34 && _1x15 == 0)
//            {
//                _2x8 = 1;
//                _1x15 = 12;
//            }
//            if (ranout2 <= 34 && ranout2 >= 66 && _5x15 == 0)
//            {
//                _4x8 = 1;
//                _5x15 = 12;
//            }
//            if (ranout2 <= 66 && ranout2 >= 100 && _3x17 == 0)
//            {
//                _3x16 = 1;
//                _3x17 = 12;
//            }
//            _3x14 = 1;
//            _3x13 = 1;
//        }
//        if (ranout >= 50 && ranout <= 75)
//        {
//            if (ranout2 <= 34 && _1x15 == 0)
//            {
//                _2x8 = 1;
//                _1x15 = 12;
//            }
//            if (ranout2 <= 34 && ranout2 >= 66 && _3x13 == 0)
//            {
//                _3x14 = 1;
//                _3x13 = 12;
//            }
//            if (ranout2 <= 66 && ranout2 >= 100 && _5x15 == 0)
//            {
//                _4x8 = 1;
//                _5x15 = 12;
//            }
//            ranout2 = random.Next(1, 100);
//            if (ranout2 <= 34 && _1x15 == 0)
//            {
//                _2x8 = 1;
//                _1x15 = 12;
//            }
//            if (ranout2 <= 34 && ranout2 >= 66 && _3x13 == 0)
//            {
//                _3x14 = 1;
//                _3x13 = 12;
//            }
//            if (ranout2 <= 66 && ranout2 >= 100 && _5x15 == 0)
//            {
//                _4x8 = 1;
//                _5x15 = 12;
//            }
//            _3x16 = 1;
//            _3x17 = 1;
//        }
//        if (ranout >= 75)
//        {
//            if (ranout2 <= 34 && _1x15 == 0)
//            {
//                _2x8 = 1;
//                _1x15 = 12;
//            }
//            if (ranout2 <= 34 && ranout2 >= 66 && _3x13 == 0)
//            {
//                _3x14 = 1;
//                _3x13 = 12;
//            }
//            if (ranout2 <= 66 && ranout2 >= 100 && _3x17 == 0)
//            {
//                _3x16 = 1;
//                _3x17 = 12;
//            }
//            ranout2 = random.Next(1, 100);
//            if (ranout2 <= 34 && _1x15 == 0)
//            {
//                _2x8 = 1;
//                _1x15 = 12;
//            }
//            if (ranout2 <= 34 && ranout2 >= 66 && _3x13 == 0)
//            {
//                _3x14 = 1;
//                _3x13 = 12;
//            }
//            if (ranout2 <= 66 && ranout2 >= 100 && _3x17 == 0)
//            {
//                _3x16 = 1;
//                _3x17 = 12;
//            }
//            _4x8 = 1;
//            _5x15 = 1;
//        }
//        if (_3x15 == 1)
//        {
//            _3x15 = 11;
//        }
//        cellcount++;
//    }

//    if (_3x17 == 10 || _3x17 == 1)
//    {
//        if (ranout4 == cellcount)
//        {
//            _3x17 = 5;
//            break;
//        }
//        Random random = new Random();
//        int ranout = random.Next(1, 100);
//        int ranout2 = random.Next(1, 100);
//        if (ranout <= 34)
//        {
//            if (ranout2 <= 50 && _5x17 == 0)
//            {
//                _4x9 = 1;
//                _5x17 = 12;
//            }
//            if (ranout2 >= 50 && _3x15 == 0)
//            {
//                _3x16 = 1;
//                _3x15 = 12;
//            }
//            ranout2 = random.Next(1, 100);
//            if (ranout2 <= 50 && _5x17 == 0)
//            {
//                _4x9 = 1;
//                _5x17 = 12;
//            }
//            if (ranout2 >= 50 && _3x15 == 0)
//            {
//                _3x16 = 1;
//                _3x15 = 12;
//            }
//            _2x9 = 1;
//            _1x17 = 1;
//        }
//        if (ranout >= 34 && ranout <= 66)
//        {
//            if (ranout2 <= 34 && _1x17 == 0)
//            {
//                _2x9 = 1;
//                _1x17 = 12;
//            }
//            if (ranout2 <= 34 && ranout2 >= 66 && _5x17 == 0)
//            {
//                _4x9 = 1;
//                _5x17 = 12;
//            }
//            ranout2 = random.Next(1, 100);
//            if (ranout2 <= 50 && _1x17 == 0)
//            {
//                _2x9 = 1;
//                _1x17 = 12;
//            }
//            if (ranout2 >= 50 && _5x17 == 0)
//            {
//                _4x9 = 1;
//                _5x17 = 12;
//            }
//            _3x16 = 1;
//            _3x15 = 1;
//        }
//        if (ranout >= 66)
//        {
//            if (ranout2 <= 50 && _1x17 == 0)
//            {
//                _2x9 = 1;
//                _1x17 = 12;
//            }
//            if (ranout2 >= 50 && _3x15 == 0)
//            {
//                _3x16 = 1;
//                _3x15 = 12;
//            }
//            ranout2 = random.Next(1, 100);
//            if (ranout2 <= 50 && _1x17 == 0)
//            {
//                _2x9 = 1;
//                _1x17 = 12;
//            }
//            if (ranout2 >= 650 && _3x15 == 0)
//            {
//                _3x16 = 1;
//                _3x15 = 12;
//            }
//            _4x9 = 1;
//            _5x17 = 1;
//        }
//        if (_3x17 == 1)
//        {
//            _3x17 = 11;
//        }
//        cellcount++;
//    }

//    if (_5x1 == 10 || _5x1 == 1)
//    {
//        if (ranout4 == cellcount)
//        {
//            _5x1 = 5;
//            break;
//        }
//        Random random = new Random();
//        int ranout = random.Next(1, 100);
//        int ranout2 = random.Next(1, 100);
//        if (ranout <= 34)
//        {
//            if (ranout2 <= 50 && _7x1 == 0)
//            {
//                _6x1 = 1;
//                _7x1 = 12;
//            }
//            if (ranout2 >= 50 && _5x3 == 0)
//            {
//                _5x2 = 1;
//                _5x3 = 12;
//            }
//            ranout2 = random.Next(1, 100);
//            if (ranout2 <= 34 && _7x1 == 0)
//            {
//                _6x1 = 1;
//                _7x1 = 12;
//                if (ranout2 <= 66 && ranout2 >= 100 && _5x3 == 0)
//                {
//                    _5x2 = 1;
//                    _5x3 = 12;
//                }
//                _4x1 = 1;
//                _3x1 = 1;
//            }
//            if (ranout >= 34 && ranout <= 66)
//            {
//                if (ranout2 <= 50 && _3x1 == 0)
//                {
//                    _4x1 = 1;
//                    _3x1 = 12;
//                }
//                if (ranout2 >= 50 && _7x1 == 0)
//                {
//                    _6x1 = 1;
//                    _7x1 = 12;
//                }
//                ranout2 = random.Next(1, 100);
//                if (ranout2 <= 34 && _3x1 == 0)
//                {
//                    _4x1 = 1;
//                    _3x1 = 12;
//                }
//                if (ranout2 <= 66 && ranout2 >= 100 && _7x1 == 0)
//                {
//                    _6x1 = 1;
//                    _7x1 = 12;
//                }
//                _5x2 = 1;
//                _5x3 = 1;
//            }
//            if (ranout >= 66)
//            {
//                if (ranout2 <= 50 && _3x1 == 0)
//                {
//                    _4x1 = 1;
//                    _3x1 = 12;
//                }
//                if (ranout2 >= 50 && _5x3 == 0)
//                {
//                    _5x2 = 1;
//                    _5x3 = 12;
//                }
//                ranout2 = random.Next(1, 100);
//                if (ranout2 <= 50 && _3x1 == 0)
//                {
//                    _4x1 = 1;
//                    _3x1 = 12;
//                }
//                if (ranout2 >= 50 && _5x3 == 0)
//                {
//                    _5x2 = 1;
//                    _5x3 = 12;
//                }
//                _6x1 = 1;
//                _7x1 = 1;
//            }
//            if (_5x1 == 1)
//            {
//                _5x1 = 11;
//            }
//            cellcount++;
//        }
//    }
//    if (_5x3 == 10 || _5x3 == 1)
//    {
//        if (ranout4 == cellcount)
//        {
//            _5x3 = 5;
//            break;
//        }
//        Random random = new Random();
//        int ranout = random.Next(1, 100);
//        int ranout2 = random.Next(1, 100);
//        if (ranout <= 25)
//        {
//            if (ranout2 <= 34 && _7x3 == 0)
//            {
//                _6x2 = 1;
//                _7x3 = 12;
//            }
//            if (ranout2 <= 34 && ranout2 >= 66 && _5x1 == 0)
//            {
//                _5x2 = 1;
//                _5x1 = 12;
//            }
//            if (ranout2 <= 66 && ranout2 >= 100 && _5x5 == 0)
//            {
//                _5x4 = 1;
//                _5x5 = 12;
//            }
//            ranout2 = random.Next(1, 100);
//            if (ranout2 <= 34 && _7x3 == 0)
//            {
//                _6x2 = 1;
//                _7x3 = 12;
//            }
//            if (ranout2 <= 34 && ranout2 >= 66 && _5x1 == 0)
//            {
//                _5x2 = 1;
//                _5x1 = 12;
//            }
//            if (ranout2 <= 66 && ranout2 >= 100 && _5x5 == 0)
//            {
//                _5x4 = 1;
//                _5x5 = 12;
//            }
//            _4x2 = 1;
//            _3x3 = 1;
//        }
//        if (ranout >= 25 && ranout <= 50)
//        {
//            if (ranout2 <= 34 && _3x3 == 0)
//            {
//                _4x2 = 1;
//                _3x3 = 12;
//            }
//            if (ranout2 <= 34 && ranout2 >= 66 && _7x3 == 0)
//            {
//                _6x2 = 1;
//                _7x3 = 12;
//            }
//            if (ranout2 <= 66 && ranout2 >= 100 && _5x5 == 0)
//            {
//                _5x4 = 1;
//                _5x5 = 12;
//            }
//            ranout2 = random.Next(1, 100);
//            if (ranout2 <= 34 && _3x3 == 0)
//            {
//                _4x2 = 1;
//                _3x3 = 12;
//            }
//            if (ranout2 <= 34 && ranout2 >= 66 && _7x3 == 0)
//            {
//                _6x2 = 1;
//                _7x3 = 12;
//            }
//            if (ranout2 <= 66 && ranout2 >= 100 && _5x5 == 0)
//            {
//                _5x4 = 1;
//                _5x5 = 12;
//            }
//            _5x2 = 1;
//            _5x1 = 1;
//        }
//        if (ranout >= 50 && ranout <= 75)
//        {
//            if (ranout2 <= 34 && _3x3 == 0)
//            {
//                _4x2 = 1;
//                _3x3 = 12;
//            }
//            if (ranout2 <= 34 && ranout2 >= 66 && _5x1 == 0)
//            {
//                _5x2 = 1;
//                _5x1 = 12;
//            }
//            if (ranout2 <= 66 && ranout2 >= 100 && _7x3 == 0)
//            {
//                _6x2 = 1;
//                _7x3 = 12;
//            }
//            ranout2 = random.Next(1, 100);
//            if (ranout2 <= 34 && _3x3 == 0)
//            {
//                _4x2 = 1;
//                _3x3 = 12;
//            }
//            if (ranout2 <= 34 && ranout2 >= 66 && _5x1 == 0)
//            {
//                _5x2 = 1;
//                _5x1 = 12;
//            }
//            if (ranout2 <= 66 && ranout2 >= 100 && _7x3 == 0)
//            {
//                _6x2 = 1;
//                _7x3 = 12;
//            }
//            _5x4 = 1;
//            _5x5 = 1;
//        }
//        if (ranout >= 75)
//        {
//            if (ranout2 <= 34 && _3x3 == 0)
//            {
//                _4x2 = 1;
//                _3x3 = 12;
//            }
//            if (ranout2 <= 34 && ranout2 >= 66 && _5x1 == 0)
//            {
//                _5x2 = 1;
//                _5x1 = 12;
//            }
//            if (ranout2 <= 66 && ranout2 >= 100 && _5x5 == 0)
//            {
//                _5x4 = 1;
//                _5x5 = 12;
//            }
//            ranout2 = random.Next(1, 100);
//            if (ranout2 <= 34 && _3x3 == 0)
//            {
//                _4x2 = 1;
//                _3x3 = 12;
//            }
//            if (ranout2 <= 34 && ranout2 >= 66 && _5x1 == 0)
//            {
//                _5x2 = 1;
//                _5x1 = 12;
//            }
//            if (ranout2 <= 66 && ranout2 >= 100 && _5x5 == 0)
//            {
//                _5x4 = 1;
//                _5x5 = 12;
//            }
//            _6x2 = 1;
//            _7x3 = 1;
//        }
//        if (_5x3 == 1)
//        {
//            _5x3 = 11;
//        }
//        cellcount++;
//    }

//    if (_5x5 == 10 || _5x5 == 1)
//    {
//        if (ranout4 == cellcount)
//        {
//            _5x5 = 5;
//            break;
//        }
//        Random random = new Random();
//        int ranout = random.Next(1, 100);
//        int ranout2 = random.Next(1, 100);
//        if (ranout <= 25)
//        {
//            if (ranout2 <= 34 && _7x5 == 0)
//            {
//                _6x3 = 1;
//                _7x5 = 12;
//            }
//            if (ranout2 <= 34 && ranout2 >= 66 && _5x3 == 0)
//            {
//                _5x4 = 1;
//                _5x3 = 12;
//            }
//            if (ranout2 <= 66 && ranout2 >= 100 && _5x7 == 0)
//            {
//                _5x6 = 1;
//                _5x7 = 12;
//            }
//            ranout2 = random.Next(1, 100);
//            if (ranout2 <= 34 && _7x5 == 0)
//            {
//                _6x3 = 1;
//                _7x5 = 12;
//            }
//            if (ranout2 <= 34 && ranout2 >= 66 && _5x3 == 0)
//            {
//                _5x4 = 1;
//                _5x3 = 12;
//            }
//            if (ranout2 <= 66 && ranout2 >= 100 && _5x7 == 0)
//            {
//                _5x6 = 1;
//                _5x7 = 12;
//            }
//            _4x3 = 1;
//            _3x5 = 1;
//        }
//        if (ranout >= 25 && ranout <= 50)
//        {
//            if (ranout2 <= 34 && _3x5 == 0)
//            {
//                _4x3 = 1;
//                _3x5 = 12;
//            }
//            if (ranout2 <= 34 && ranout2 >= 66 && _7x5 == 0)
//            {
//                _6x3 = 1;
//                _7x5 = 12;
//            }
//            if (ranout2 <= 66 && ranout2 >= 100 && _5x7 == 0)
//            {
//                _5x6 = 1;
//                _5x7 = 12;
//            }
//            ranout2 = random.Next(1, 100);
//            if (ranout2 <= 34 && _3x5 == 0)
//            {
//                _4x3 = 1;
//                _3x5 = 12;
//            }
//            if (ranout2 <= 34 && ranout2 >= 66 && _7x5 == 0)
//            {
//                _6x3 = 1;
//                _7x5 = 12;
//            }
//            if (ranout2 <= 66 && ranout2 >= 100 && _5x7 == 0)
//            {
//                _5x6 = 1;
//                _5x7 = 12;
//            }
//            _5x4 = 1;
//            _5x3 = 1;
//        }
//        if (ranout >= 50 && ranout <= 75)
//        {
//            if (ranout2 <= 34 && _3x5 == 0)
//            {
//                _4x3 = 1;
//                _3x5 = 12;
//            }
//            if (ranout2 <= 34 && ranout2 >= 66 && _5x3 == 0)
//            {
//                _5x4 = 1;
//                _5x3 = 12;
//            }
//            if (ranout2 <= 66 && ranout2 >= 100 && _7x5 == 0)
//            {
//                _6x3 = 1;
//                _7x5 = 12;
//            }
//            ranout2 = random.Next(1, 100);
//            if (ranout2 <= 34 && _3x5 == 0)
//            {
//                _4x3 = 1;
//                _3x5 = 12;
//            }
//            if (ranout2 <= 34 && ranout2 >= 66 && _5x3 == 0)
//            {
//                _5x4 = 1;
//                _5x3 = 12;
//            }
//            if (ranout2 <= 66 && ranout2 >= 100 && _7x5 == 0)
//            {
//                _6x3 = 1;
//                _7x5 = 12;
//            }
//            _5x6 = 1;
//            _5x7 = 1;
//        }
//        if (ranout >= 75)
//        {
//            if (ranout2 <= 34 && _3x5 == 0)
//            {
//                _4x3 = 1;
//                _3x5 = 12;
//            }
//            if (ranout2 <= 34 && ranout2 >= 66 && _5x3 == 0)
//            {
//                _5x4 = 1;
//                _5x3 = 12;
//            }
//            if (ranout2 <= 66 && ranout2 >= 100 && _5x7 == 0)
//            {
//                _5x6 = 1;
//                _5x7 = 12;
//            }
//            ranout2 = random.Next(1, 100);
//            if (ranout2 <= 34 && _3x5 == 0)
//            {
//                _4x3 = 1;
//                _3x5 = 12;
//            }
//            if (ranout2 <= 34 && ranout2 >= 66 && _5x3 == 0)
//            {
//                _5x4 = 1;
//                _5x3 = 12;
//            }
//            if (ranout2 <= 66 && ranout2 >= 100 && _5x7 == 0)
//            {
//                _5x6 = 1;
//                _5x7 = 12;
//            }
//            _6x3 = 1;
//            _7x5 = 1;
//        }
//        if (_5x5 == 1)
//        {
//            _5x5 = 11;
//        }
//        cellcount++;
//    }

//    if (_5x7 == 10 || _5x7 == 1)
//    {
//        if (ranout4 == cellcount)
//        {
//            _5x7 = 5;
//            break;
//        }
//        Random random = new Random();
//        int ranout = random.Next(1, 100);
//        int ranout2 = random.Next(1, 100);
//        if (ranout <= 25)
//        {
//            if (ranout2 <= 34 && _7x7 == 0)
//            {
//                _6x4 = 1;
//                _7x7 = 12;
//            }
//            if (ranout2 <= 34 && ranout2 >= 66 && _5x5 == 0)
//            {
//                _5x6 = 1;
//                _5x5 = 12;
//            }
//            if (ranout2 <= 66 && ranout2 >= 100 && _5x9 == 0)
//            {
//                _5x8 = 1;
//                _5x9 = 12;
//            }
//            ranout2 = random.Next(1, 100);
//            if (ranout2 <= 34 && _7x7 == 0)
//            {
//                _6x4 = 1;
//                _7x7 = 12;
//            }
//            if (ranout2 <= 34 && ranout2 >= 66 && _5x5 == 0)
//            {
//                _5x6 = 1;
//                _5x5 = 12;
//            }
//            if (ranout2 <= 66 && ranout2 >= 100 && _5x9 == 0)
//            {
//                _5x8 = 1;
//                _5x9 = 12;
//            }
//            _4x4 = 1;
//            _3x7 = 1;
//        }
//        if (ranout >= 25 && ranout <= 50)
//        {
//            if (ranout2 <= 34 && _3x7 == 0)
//            {
//                _4x4 = 1;
//                _3x7 = 12;
//            }
//            if (ranout2 <= 34 && ranout2 >= 66 && _7x7 == 0)
//            {
//                _6x4 = 1;
//                _7x7 = 12;
//            }
//            if (ranout2 <= 66 && ranout2 >= 100 && _5x9 == 0)
//            {
//                _5x8 = 1;
//                _5x9 = 12;
//            }
//            ranout2 = random.Next(1, 100);
//            if (ranout2 <= 34 && _3x7 == 0)
//            {
//                _4x4 = 1;
//                _3x7 = 12;
//            }
//            if (ranout2 <= 34 && ranout2 >= 66 && _7x7 == 0)
//            {
//                _6x4 = 1;
//                _7x7 = 12;
//            }
//            if (ranout2 <= 66 && ranout2 >= 100 && _5x9 == 0)
//            {
//                _5x8 = 1;
//                _5x9 = 12;
//            }
//            _5x6 = 1;
//            _5x5 = 1;
//        }
//        if (ranout >= 50 && ranout <= 75)
//        {
//            if (ranout2 <= 34 && _3x7 == 0)
//            {
//                _4x4 = 1;
//                _3x7 = 12;
//            }
//            if (ranout2 <= 34 && ranout2 >= 66 && _5x5 == 0)
//            {
//                _5x6 = 1;
//                _5x5 = 12;
//            }
//            if (ranout2 <= 66 && ranout2 >= 100 && _7x7 == 0)
//            {
//                _6x4 = 1;
//                _7x7 = 12;
//            }
//            ranout2 = random.Next(1, 100);
//            if (ranout2 <= 34 && _3x7 == 0)
//            {
//                _4x4 = 1;
//                _3x7 = 12;
//            }
//            if (ranout2 <= 34 && ranout2 >= 66 && _5x5 == 0)
//            {
//                _5x6 = 1;
//                _5x5 = 12;
//            }
//            if (ranout2 <= 66 && ranout2 >= 100 && _7x7 == 0)
//            {
//                _6x4 = 1;
//                _7x7 = 12;
//            }
//            _5x8 = 1;
//            _5x9 = 1;
//        }
//        if (ranout >= 75)
//        {
//            if (ranout2 <= 34 && _3x7 == 0)
//            {
//                _4x4 = 1;
//                _3x7 = 12;
//            }
//            if (ranout2 <= 34 && ranout2 >= 66 && _5x5 == 0)
//            {
//                _5x6 = 1;
//                _5x5 = 12;
//            }
//            if (ranout2 <= 66 && ranout2 >= 100 && _5x9 == 0)
//            {
//                _5x8 = 1;
//                _5x9 = 12;
//            }
//            ranout2 = random.Next(1, 100);
//            if (ranout2 <= 34 && _3x7 == 0)
//            {
//                _4x4 = 1;
//                _3x7 = 12;
//            }
//            if (ranout2 <= 34 && ranout2 >= 66 && _5x5 == 0)
//            {
//                _5x6 = 1;
//                _5x5 = 12;
//            }
//            if (ranout2 <= 66 && ranout2 >= 100 && _5x9 == 0)
//            {
//                _5x8 = 1;
//                _5x9 = 12;
//            }
//            _6x4 = 1;
//            _7x7 = 1;
//        }
//        if (_5x7 == 1)
//        {
//            _5x7 = 11;
//        }
//        cellcount++;
//    }

//    if (_5x9 == 10 || _5x9 == 1)
//    {
//        if (ranout4 == cellcount)
//        {
//            _5x9 = 5;
//            break;
//        }
//        Random random = new Random();
//        int ranout = random.Next(1, 100);
//        int ranout2 = random.Next(1, 100);
//        if (ranout <= 25)
//        {
//            if (ranout2 <= 34 && _7x9 == 0)
//            {
//                _6x5 = 1;
//                _7x9 = 12;
//            }
//            if (ranout2 <= 34 && ranout2 >= 66 && _5x7 == 0)
//            {
//                _5x8 = 1;
//                _5x7 = 12;
//            }
//            if (ranout2 <= 66 && ranout2 >= 100 && _5x11 == 0)
//            {
//                _5x10 = 1;
//                _5x11 = 12;
//            }
//            ranout2 = random.Next(1, 100);
//            if (ranout2 <= 34 && _7x9 == 0)
//            {
//                _6x5 = 1;
//                _7x9 = 12;
//            }
//            if (ranout2 <= 34 && ranout2 >= 66 && _5x7 == 0)
//            {
//                _5x8 = 1;
//                _5x7 = 12;
//            }
//            if (ranout2 <= 66 && ranout2 >= 100 && _5x11 == 0)
//            {
//                _5x10 = 1;
//                _5x11 = 12;
//            }
//            _4x5 = 1;
//            _3x9 = 1;
//        }
//        if (ranout >= 25 && ranout <= 50)
//        {
//            if (ranout2 <= 34 && _3x9 == 0)
//            {
//                _4x5 = 1;
//                _3x9 = 12;
//            }
//            if (ranout2 <= 34 && ranout2 >= 66 && _7x9 == 0)
//            {
//                _6x5 = 1;
//                _7x9 = 12;
//            }
//            if (ranout2 <= 66 && ranout2 >= 100 && _5x11 == 0)
//            {
//                _5x10 = 1;
//                _5x11 = 12;
//            }
//            ranout2 = random.Next(1, 100);
//            if (ranout2 <= 34 && _3x9 == 0)
//            {
//                _4x5 = 1;
//                _3x9 = 12;
//            }
//            if (ranout2 <= 34 && ranout2 >= 66 && _7x9 == 0)
//            {
//                _6x5 = 1;
//                _7x9 = 12;
//            }
//            if (ranout2 <= 66 && ranout2 >= 100 && _5x11 == 0)
//            {
//                _5x10 = 1;
//                _5x11 = 12;
//            }
//            _5x8 = 1;
//            _5x7 = 1;
//        }
//        if (ranout >= 50 && ranout <= 75)
//        {
//            if (ranout2 <= 34 && _3x9 == 0)
//            {
//                _4x5 = 1;
//                _3x9 = 12;
//            }
//            if (ranout2 <= 34 && ranout2 >= 66 && _5x7 == 0)
//            {
//                _5x8 = 1;
//                _5x7 = 12;
//            }
//            if (ranout2 <= 66 && ranout2 >= 100 && _7x9 == 0)
//            {
//                _6x5 = 1;
//                _7x9 = 12;
//            }
//            ranout2 = random.Next(1, 100);
//            if (ranout2 <= 34 && _3x9 == 0)
//            {
//                _4x5 = 1;
//                _3x9 = 12;
//            }
//            if (ranout2 <= 34 && ranout2 >= 66 && _5x7 == 0)
//            {
//                _5x8 = 1;
//                _5x7 = 12;
//            }
//            if (ranout2 <= 66 && ranout2 >= 100 && _7x9 == 0)
//            {
//                _6x5 = 1;
//                _7x9 = 12;
//            }
//            _5x10 = 1;
//            _5x11 = 1;
//        }
//        if (ranout >= 75)
//        {
//            if (ranout2 <= 34 && _3x9 == 0)
//            {
//                _4x5 = 1;
//                _3x9 = 12;
//            }
//            if (ranout2 <= 34 && ranout2 >= 66 && _5x7 == 0)
//            {
//                _5x8 = 1;
//                _5x7 = 12;
//            }
//            if (ranout2 <= 66 && ranout2 >= 100 && _5x11 == 0)
//            {
//                _5x10 = 1;
//                _5x11 = 12;
//            }
//            ranout2 = random.Next(1, 100);
//            if (ranout2 <= 34 && _3x9 == 0)
//            {
//                _4x5 = 1;
//                _3x9 = 12;
//            }
//            if (ranout2 <= 34 && ranout2 >= 66 && _5x7 == 0)
//            {
//                _5x8 = 1;
//                _5x7 = 12;
//            }
//            if (ranout2 <= 66 && ranout2 >= 100 && _5x11 == 0)
//            {
//                _5x10 = 1;
//                _5x11 = 12;
//            }
//            _6x5 = 1;
//            _7x9 = 1;
//        }
//        if (_5x9 == 1)
//        {
//            _5x9 = 11;
//        }
//        cellcount++;
//    }

//    if (_5x11 == 10 || _5x11 == 1)
//    {
//        if (ranout4 == cellcount)
//        {
//            _5x11 = 5;
//            break;
//        }
//        Random random = new Random();
//        int ranout = random.Next(1, 100);
//        int ranout2 = random.Next(1, 100);
//        if (ranout <= 25)
//        {
//            if (ranout2 <= 34 && _7x11 == 0)
//            {
//                _6x6 = 1;
//                _7x11 = 12;
//            }
//            if (ranout2 <= 34 && ranout2 >= 66 && _5x9 == 0)
//            {
//                _5x10 = 1;
//                _5x9 = 12;
//            }
//            if (ranout2 <= 66 && ranout2 >= 100 && _5x13 == 0)
//            {
//                _5x12 = 1;
//                _5x13 = 12;
//            }
//            ranout2 = random.Next(1, 100);
//            if (ranout2 <= 34 && _7x11 == 0)
//            {
//                _6x6 = 1;
//                _7x11 = 12;
//            }
//            if (ranout2 <= 34 && ranout2 >= 66 && _5x9 == 0)
//            {
//                _5x10 = 1;
//                _5x9 = 12;
//            }
//            if (ranout2 <= 66 && ranout2 >= 100 && _5x13 == 0)
//            {
//                _5x12 = 1;
//                _5x13 = 12;
//            }
//            _4x6 = 1;
//            _3x11 = 1;
//        }
//        if (ranout >= 25 && ranout <= 50)
//        {
//            if (ranout2 <= 34 && _3x11 == 0)
//            {
//                _4x6 = 1;
//                _3x11 = 12;
//            }
//            if (ranout2 <= 34 && ranout2 >= 66 && _7x11 == 0)
//            {
//                _6x6 = 1;
//                _7x11 = 12;
//            }
//            if (ranout2 <= 66 && ranout2 >= 100 && _5x13 == 0)
//            {
//                _5x12 = 1;
//                _5x13 = 12;
//            }
//            ranout2 = random.Next(1, 100);
//            if (ranout2 <= 34 && _3x11 == 0)
//            {
//                _4x6 = 1;
//                _3x11 = 12;
//            }
//            if (ranout2 <= 34 && ranout2 >= 66 && _7x11 == 0)
//            {
//                _6x6 = 1;
//                _7x11 = 12;
//            }
//            if (ranout2 <= 66 && ranout2 >= 100 && _5x13 == 0)
//            {
//                _5x12 = 1;
//                _5x13 = 12;
//            }
//            _5x10 = 1;
//            _5x9 = 1;
//        }
//        if (ranout >= 50 && ranout <= 75)
//        {
//            if (ranout2 <= 34 && _3x11 == 0)
//            {
//                _4x6 = 1;
//                _3x11 = 12;
//            }
//            if (ranout2 <= 34 && ranout2 >= 66 && _5x9 == 0)
//            {
//                _5x10 = 1;
//                _5x9 = 12;
//            }
//            if (ranout2 <= 66 && ranout2 >= 100 && _7x11 == 0)
//            {
//                _6x6 = 1;
//                _7x11 = 12;
//            }
//            ranout2 = random.Next(1, 100);
//            if (ranout2 <= 34 && _3x11 == 0)
//            {
//                _4x6 = 1;
//                _3x11 = 12;
//            }
//            if (ranout2 <= 34 && ranout2 >= 66 && _5x9 == 0)
//            {
//                _5x10 = 1;
//                _5x9 = 12;
//            }
//            if (ranout2 <= 66 && ranout2 >= 100 && _7x11 == 0)
//            {
//                _6x6 = 1;
//                _7x11 = 12;
//            }
//            _5x12 = 1;
//            _5x13 = 1;
//        }
//        if (ranout >= 75)
//        {
//            if (ranout2 <= 34 && _3x11 == 0)
//            {
//                _4x6 = 1;
//                _3x11 = 12;
//            }
//            if (ranout2 <= 34 && ranout2 >= 66 && _5x9 == 0)
//            {
//                _5x10 = 1;
//                _5x9 = 12;
//            }
//            if (ranout2 <= 66 && ranout2 >= 100 && _5x13 == 0)
//            {
//                _5x12 = 1;
//                _5x13 = 12;
//            }
//            ranout2 = random.Next(1, 100);
//            if (ranout2 <= 34 && _3x11 == 0)
//            {
//                _4x6 = 1;
//                _3x11 = 12;
//            }
//            if (ranout2 <= 34 && ranout2 >= 66 && _5x9 == 0)
//            {
//                _5x10 = 1;
//                _5x9 = 12;
//            }
//            if (ranout2 <= 66 && ranout2 >= 100 && _5x13 == 0)
//            {
//                _5x12 = 1;
//                _5x13 = 12;
//            }
//            _6x6 = 1;
//            _7x11 = 1;
//        }
//        if (_5x11 == 1)
//        {
//            _5x11 = 11;
//        }
//        cellcount++;
//    }

//    if (_5x13 == 10 || _5x13 == 1)
//    {
//        if (ranout4 == cellcount)
//        {
//            _5x13 = 5;
//            break;
//        }
//        Random random = new Random();
//        int ranout = random.Next(1, 100);
//        int ranout2 = random.Next(1, 100);
//        if (ranout <= 25)
//        {
//            if (ranout2 <= 34 && _7x13 == 0)
//            {
//                _6x7 = 1;
//                _7x13 = 12;
//            }
//            if (ranout2 <= 34 && ranout2 >= 66 && _5x11 == 0)
//            {
//                _5x12 = 1;
//                _5x11 = 12;
//            }
//            if (ranout2 <= 66 && ranout2 >= 100 && _5x15 == 0)
//            {
//                _5x14 = 1;
//                _5x15 = 12;
//            }
//            ranout2 = random.Next(1, 100);
//            if (ranout2 <= 34 && _7x13 == 0)
//            {
//                _6x7 = 1;
//                _7x13 = 12;
//            }
//            if (ranout2 <= 34 && ranout2 >= 66 && _5x11 == 0)
//            {
//                _5x12 = 1;
//                _5x11 = 12;
//            }
//            if (ranout2 <= 66 && ranout2 >= 100 && _5x15 == 0)
//            {
//                _5x14 = 1;
//                _5x15 = 12;
//            }
//            _4x7 = 1;
//            _3x13 = 1;
//        }
//        if (ranout >= 25 && ranout <= 50)
//        {
//            if (ranout2 <= 34 && _3x13 == 0)
//            {
//                _4x7 = 1;
//                _3x13 = 12;
//            }
//            if (ranout2 <= 34 && ranout2 >= 66 && _7x13 == 0)
//            {
//                _6x7 = 1;
//                _7x13 = 12;
//            }
//            if (ranout2 <= 66 && ranout2 >= 100 && _5x15 == 0)
//            {
//                _5x14 = 1;
//                _5x15 = 12;
//            }
//            ranout2 = random.Next(1, 100);
//            if (ranout2 <= 34 && _3x13 == 0)
//            {
//                _4x7 = 1;
//                _3x13 = 12;
//            }
//            if (ranout2 <= 34 && ranout2 >= 66 && _7x13 == 0)
//            {
//                _6x7 = 1;
//                _7x13 = 12;
//            }
//            if (ranout2 <= 66 && ranout2 >= 100 && _5x15 == 0)
//            {
//                _5x14 = 1;
//                _5x15 = 12;
//            }
//            _5x12 = 1;
//            _5x11 = 1;
//        }
//        if (ranout >= 50 && ranout <= 75)
//        {
//            if (ranout2 <= 34 && _3x13 == 0)
//            {
//                _4x7 = 1;
//                _3x13 = 12;
//            }
//            if (ranout2 <= 34 && ranout2 >= 66 && _5x11 == 0)
//            {
//                _5x12 = 1;
//                _5x11 = 12;
//            }
//            if (ranout2 <= 66 && ranout2 >= 100 && _7x13 == 0)
//            {
//                _6x7 = 1;
//                _7x13 = 12;
//            }
//            ranout2 = random.Next(1, 100);
//            if (ranout2 <= 34 && _3x13 == 0)
//            {
//                _4x7 = 1;
//                _3x13 = 12;
//            }
//            if (ranout2 <= 34 && ranout2 >= 66 && _5x11 == 0)
//            {
//                _5x12 = 1;
//                _5x11 = 12;
//            }
//            if (ranout2 <= 66 && ranout2 >= 100 && _7x13 == 0)
//            {
//                _6x7 = 1;
//                _7x13 = 12;
//            }
//            _5x14 = 1;
//            _5x15 = 1;
//        }
//        if (ranout >= 75)
//        {
//            if (ranout2 <= 34 && _3x13 == 0)
//            {
//                _4x7 = 1;
//                _3x13 = 12;
//            }
//            if (ranout2 <= 34 && ranout2 >= 66 && _5x11 == 0)
//            {
//                _5x12 = 1;
//                _5x11 = 12;
//            }
//            if (ranout2 <= 66 && ranout2 >= 100 && _5x15 == 0)
//            {
//                _5x14 = 1;
//                _5x15 = 12;
//            }
//            ranout2 = random.Next(1, 100);
//            if (ranout2 <= 34 && _3x13 == 0)
//            {
//                _4x7 = 1;
//                _3x13 = 12;
//            }
//            if (ranout2 <= 34 && ranout2 >= 66 && _5x11 == 0)
//            {
//                _5x12 = 1;
//                _5x11 = 12;
//            }
//            if (ranout2 <= 66 && ranout2 >= 100 && _5x15 == 0)
//            {
//                _5x14 = 1;
//                _5x15 = 12;
//            }
//            _6x7 = 1;
//            _7x13 = 1;
//        }
//        if (_5x13 == 1)
//        {
//            _5x13 = 11;
//        }
//        cellcount++;
//    }

//    if (_5x15 == 10 || _5x15 == 1)
//    {
//        if (ranout4 == cellcount)
//        {
//            _5x15 = 5;
//            break;
//        }
//        Random random = new Random();
//        int ranout = random.Next(1, 100);
//        int ranout2 = random.Next(1, 100);
//        if (ranout <= 25)
//        {
//            if (ranout2 <= 34 && _7x15 == 0)
//            {
//                _6x8 = 1;
//                _7x15 = 12;
//            }
//            if (ranout2 <= 34 && ranout2 >= 66 && _5x13 == 0)
//            {
//                _5x14 = 1;
//                _5x13 = 12;
//            }
//            if (ranout2 <= 66 && ranout2 >= 100 && _5x17 == 0)
//            {
//                _5x16 = 1;
//                _5x17 = 12;
//            }
//            ranout2 = random.Next(1, 100);
//            if (ranout2 <= 34 && _7x15 == 0)
//            {
//                _6x8 = 1;
//                _7x15 = 12;
//            }
//            if (ranout2 <= 34 && ranout2 >= 66 && _5x13 == 0)
//            {
//                _5x14 = 1;
//                _5x13 = 12;
//            }
//            if (ranout2 <= 66 && ranout2 >= 100 && _5x17 == 0)
//            {
//                _5x16 = 1;
//                _5x17 = 12;
//            }
//            _4x8 = 1;
//            _3x15 = 1;
//        }
//        if (ranout >= 25 && ranout <= 50)
//        {
//            if (ranout2 <= 34 && _3x15 == 0)
//            {
//                _4x8 = 1;
//                _3x15 = 12;
//            }
//            if (ranout2 <= 34 && ranout2 >= 66 && _7x15 == 0)
//            {
//                _6x8 = 1;
//                _7x15 = 12;
//            }
//            if (ranout2 <= 66 && ranout2 >= 100 && _5x17 == 0)
//            {
//                _5x16 = 1;
//                _5x17 = 12;
//            }
//            ranout2 = random.Next(1, 100);
//            if (ranout2 <= 34 && _3x15 == 0)
//            {
//                _4x8 = 1;
//                _3x15 = 12;
//            }
//            if (ranout2 <= 34 && ranout2 >= 66 && _7x15 == 0)
//            {
//                _6x8 = 1;
//                _7x15 = 12;
//            }
//            if (ranout2 <= 66 && ranout2 >= 100 && _5x17 == 0)
//            {
//                _5x16 = 1;
//                _5x17 = 12;
//            }
//            _5x14 = 1;
//            _5x13 = 1;
//        }
//        if (ranout >= 50 && ranout <= 75)
//        {
//            if (ranout2 <= 34 && _3x15 == 0)
//            {
//                _4x8 = 1;
//                _3x15 = 12;
//            }
//            if (ranout2 <= 34 && ranout2 >= 66 && _5x13 == 0)
//            {
//                _5x14 = 1;
//                _5x13 = 12;
//            }
//            if (ranout2 <= 66 && ranout2 >= 100 && _7x15 == 0)
//            {
//                _6x8 = 1;
//                _7x15 = 12;
//            }
//            ranout2 = random.Next(1, 100);
//            if (ranout2 <= 34 && _3x15 == 0)
//            {
//                _4x8 = 1;
//                _3x15 = 12;
//            }
//            if (ranout2 <= 34 && ranout2 >= 66 && _5x13 == 0)
//            {
//                _5x14 = 1;
//                _5x13 = 12;
//            }
//            if (ranout2 <= 66 && ranout2 >= 100 && _7x15 == 0)
//            {
//                _6x8 = 1;
//                _7x15 = 12;
//            }
//            _5x16 = 1;
//            _5x17 = 1;
//        }
//        if (ranout >= 75)
//        {
//            if (ranout2 <= 34 && _3x15 == 0)
//            {
//                _4x8 = 1;
//                _3x15 = 12;
//            }
//            if (ranout2 <= 34 && ranout2 >= 66 && _5x13 == 0)
//            {
//                _5x14 = 1;
//                _5x13 = 12;
//            }
//            if (ranout2 <= 66 && ranout2 >= 100 && _5x17 == 0)
//            {
//                _5x16 = 1;
//                _5x17 = 12;
//            }
//            ranout2 = random.Next(1, 100);
//            if (ranout2 <= 34 && _3x15 == 0)
//            {
//                _4x8 = 1;
//                _3x15 = 12;
//            }
//            if (ranout2 <= 34 && ranout2 >= 66 && _5x13 == 0)
//            {
//                _5x14 = 1;
//                _5x13 = 12;
//            }
//            if (ranout2 <= 66 && ranout2 >= 100 && _5x17 == 0)
//            {
//                _5x16 = 1;
//                _5x17 = 12;
//            }
//            _6x8 = 1;
//            _7x15 = 1;
//        }
//        if (_5x15 == 1)
//        {
//            _5x15 = 11;
//        }
//        cellcount++;
//    }

//    if (_5x17 == 10 || _5x17 == 1)
//    {
//        if (ranout4 == cellcount)
//        {
//            _5x17 = 5;
//            break;
//        }
//        Random random = new Random();
//        int ranout = random.Next(1, 100);
//        int ranout2 = random.Next(1, 100);
//        if (ranout <= 34)
//        {
//            if (ranout2 <= 50 && _7x17 == 0)
//            {
//                _6x9 = 1;
//                _7x17 = 12;
//            }
//            if (ranout2 >= 50 && _5x15 == 0)
//            {
//                _5x16 = 1;
//                _5x15 = 12;
//            }
//            ranout2 = random.Next(1, 100);
//            if (ranout2 <= 50 && _7x17 == 0)
//            {
//                _6x9 = 1;
//                _7x17 = 12;
//            }
//            if (ranout2 >= 50 && _5x15 == 0)
//            {
//                _5x16 = 1;
//                _5x15 = 12;
//            }
//            _4x9 = 1;
//            _3x17 = 1;
//        }
//        if (ranout >= 34 && ranout <= 66)
//        {
//            if (ranout2 <= 50 && _3x17 == 0)
//            {
//                _4x9 = 1;
//                _3x17 = 12;
//            }
//            if (ranout2 >= 50 && _7x17 == 0)
//            {
//                _6x9 = 1;
//                _7x17 = 12;
//            }
//            ranout2 = random.Next(1, 100);
//            if (ranout2 <= 50 && _3x17 == 0)
//            {
//                _4x9 = 1;
//                _3x17 = 12;
//            }
//            if (ranout2 >= 50 && _7x17 == 0)
//            {
//                _6x9 = 1;
//                _7x17 = 12;
//            }
//            _5x16 = 1;
//            _5x15 = 1;
//        }
//        if (ranout >= 66)
//        {
//            if (ranout2 <= 50 && _3x17 == 0)
//            {
//                _4x9 = 1;
//                _3x17 = 12;
//            }
//            if (ranout2 >= 50 && _5x15 == 0)
//            {
//                _5x16 = 1;
//                _5x15 = 12;
//            }
//            ranout2 = random.Next(1, 100);
//            if (ranout2 <= 50 && _3x17 == 0)
//            {
//                _4x9 = 1;
//                _3x17 = 12;
//            }
//            if (ranout2 >= 50 && _5x15 == 0)
//            {
//                _5x16 = 1;
//                _5x15 = 12;
//            }
//            _6x9 = 1;
//            _7x17 = 1;
//        }
//        if (_5x17 == 1)
//        {
//            _5x17 = 11;
//        }
//        cellcount++;
//    }

//    if (_7x1 == 10 || _7x1 == 1)
//    {
//        if (ranout4 == cellcount)
//        {
//            _7x1 = 5;
//            break;
//        }
//        Random random = new Random();
//        int ranout = random.Next(1, 100);
//        int ranout2 = random.Next(1, 100);
//        if (ranout <= 50)
//        {
//            if (ranout2 >= 50 && _7x3 == 0)
//            {
//                _7x2 = 1;
//                _7x3 = 12;
//            }
//            if (ranout2 <= 50 && _7x3 == 0)
//            {
//                _7x2 = 1;
//                _7x3 = 12;
//            }
//            _6x1 = 1;
//            _5x1 = 1;
//        }
//        if (ranout >= 50)
//        {
//            if (ranout2 <= 34 && _5x1 == 0)
//            {
//                _6x1 = 1;
//                _5x1 = 12;
//            }
//            if (ranout2 <= 34 && _5x1 == 0)
//            {
//                _6x1 = 1;
//                _5x1 = 12;
//            }
//            _7x2 = 1;
//            _7x3 = 1;
//        }
//        if (_7x1 == 1)
//        {
//            _7x1 = 11;
//        }
//        cellcount++;
//    }

//    if (_7x3 == 10 || _7x3 == 1)
//    {
//        if (ranout4 == cellcount)
//        {
//            _7x3 = 5;
//            break;
//        }
//        Random random = new Random();
//        int ranout = random.Next(1, 100);
//        int ranout2 = random.Next(1, 100);
//        if (ranout <= 34)
//        {
//            if (ranout2 >= 50 && _7x1 == 0)
//            {
//                _7x2 = 1;
//                _7x1 = 12;
//            }
//            if (ranout2 <= 50 && _7x5 == 0)
//            {
//                _7x4 = 1;
//                _7x5 = 12;
//            }
//            ranout2 = random.Next(1, 100);
//            if (ranout2 <= 50 && _7x1 == 0)
//            {
//                _7x2 = 1;
//                _7x1 = 12;
//            }
//            if (ranout2 >= 50 && _7x5 == 0)
//            {
//                _7x4 = 1;
//                _7x5 = 12;
//            }
//            _6x2 = 1;
//            _5x3 = 1;
//        }
//        if (ranout >= 34 && ranout <= 66)
//        {
//            if (ranout2 <= 50 && _5x3 == 0)
//            {
//                _6x2 = 1;
//                _5x3 = 12;
//            }
//            if (ranout2 >= 50 && _7x5 == 0)
//            {
//                _7x4 = 1;
//                _7x5 = 12;
//            }
//            ranout2 = random.Next(1, 100);
//            if (ranout2 <= 50 && _5x3 == 0)
//            {
//                _6x2 = 1;
//                _5x3 = 12;
//            }
//            if (ranout2 >= 50 && _7x5 == 0)
//            {
//                _7x4 = 1;
//                _7x5 = 12;
//            }
//            _7x2 = 1;
//            _7x1 = 1;
//        }
//        if (ranout >= 66)
//        {
//            if (ranout2 <= 50 && _5x3 == 0)
//            {
//                _6x2 = 1;
//                _5x3 = 12;
//            }
//            if (ranout2 >= 50 && _7x1 == 0)
//            {
//                _7x2 = 1;
//                _7x1 = 12;
//            }
//            ranout2 = random.Next(1, 100);
//            if (ranout2 <= 50 && _5x3 == 0)
//            {
//                _6x2 = 1;
//                _5x3 = 12;
//            }
//            if (ranout2 >= 50 && _7x1 == 0)
//            {
//                _7x2 = 1;
//                _7x1 = 12;
//            }
//            _7x4 = 1;
//            _7x5 = 1;
//        }
//        if (_7x3 == 1)
//        {
//            _7x3 = 11;
//        }
//        cellcount++;
//    }

//    if (_7x5 == 10 || _7x5 == 1)
//    {
//        if (ranout4 == cellcount)
//        {
//            _7x5 = 5;
//            break;
//        }
//        Random random = new Random();
//        int ranout = random.Next(1, 100);
//        int ranout2 = random.Next(1, 100);
//        if (ranout <= 34)
//        {
//            if (ranout2 <= 50 && _7x3 == 0)
//            {
//                _7x4 = 1;
//                _7x3 = 12;
//            }
//            if (ranout2 >= 50 && _7x7 == 0)
//            {
//                _7x6 = 1;
//                _7x7 = 12;
//            }
//            ranout2 = random.Next(1, 100);
//            if (ranout2 <= 50 && _7x3 == 0)
//            {
//                _7x4 = 1;
//                _7x3 = 12;
//            }
//            if (ranout2 >= 50 && _7x7 == 0)
//            {
//                _7x6 = 1;
//                _7x7 = 12;
//            }
//            _6x3 = 1;
//            _5x5 = 1;
//        }
//        if (ranout >= 34 && ranout <= 66)                           //////////////////////////////////////
//        {
//            if (ranout2 <= 50 && _5x5 == 0)
//            {
//                _6x3 = 1;
//                _5x5 = 12;
//            }
//            if (ranout2 >= 50 && _7x7 == 0)
//            {
//                _7x6 = 1;
//                _7x7 = 12;
//            }
//            ranout2 = random.Next(1, 100);
//            if (ranout2 <= 50 && _5x5 == 0)
//            {
//                _6x3 = 1;
//                _5x5 = 12;
//            }
//            if (ranout2 >= 50 && _7x7 == 0)
//            {
//                _7x6 = 1;
//                _7x7 = 12;
//            }
//            _7x4 = 1;
//            _7x3 = 1;
//        }
//        if (ranout <= 66)
//        {
//            if (ranout2 <= 50 && _5x5 == 0)
//            {
//                _6x3 = 1;
//                _5x5 = 12;
//            }
//            if (ranout2 >= 50 && _7x3 == 0)
//            {
//                _7x4 = 1;
//                _7x3 = 12;
//            }
//            ranout2 = random.Next(1, 100);
//            if (ranout2 <= 50 && _5x5 == 0)
//            {
//                _6x3 = 1;
//                _5x5 = 12;
//            }
//            if (ranout2 >= 50 && _7x3 == 0)
//            {
//                _7x4 = 1;
//                _7x3 = 12;
//            }
//            _7x6 = 1;
//            _7x7 = 1;
//        }
//        if (_7x5 == 1)
//        {
//            _7x5 = 11;
//        }
//        cellcount++;
//    }

//    if (_7x7 == 10 || _7x7 == 1)
//    {
//        if (ranout4 == cellcount)
//        {
//            _7x7 = 5;
//            break;
//        }
//        Random random = new Random();
//        int ranout = random.Next(1, 100);
//        int ranout2 = random.Next(1, 100);
//        if (ranout <= 50)
//        {
//            if (ranout2 >= 50 && _7x5 == 0)
//            {
//                _7x6 = 1;
//                _7x5 = 12;
//            }
//            if (ranout2 <= 50 && _7x9 == 0)
//            {
//                _7x8 = 1;
//                _7x9 = 12;
//            }
//            ranout2 = random.Next(1, 100);
//            if (ranout2 >= 50 && _7x5 == 0)
//            {
//                _7x6 = 1;
//                _7x5 = 12;
//            }
//            if (ranout2 <= 50 && _7x9 == 0)
//            {
//                _7x8 = 1;
//                _7x9 = 12;
//            }
//            _6x4 = 1;
//            _5x7 = 1;
//        }
//        if (ranout >= 50)
//        {
//            if (ranout2 <= 50 && _5x7 == 0)
//            {
//                _6x4 = 1;
//                _5x7 = 12;
//            }
//            if (ranout2 >= 50 && _7x9 == 0)
//            {
//                _7x8 = 1;
//                _7x9 = 12;
//            }
//            ranout2 = random.Next(1, 100);
//            if (ranout2 <= 50 && _5x7 == 0)
//            {
//                _6x4 = 1;
//                _5x7 = 12;
//            }
//            if (ranout2 >= 50 && _7x9 == 0)
//            {
//                _7x8 = 1;
//                _7x9 = 12;
//            }
//            _7x6 = 1;
//            _7x5 = 1;
//        }
//        if (_7x7 == 1)
//        {
//            _7x7 = 11;
//        }
//        cellcount++;
//    }

//    if (_7x9 == 10 || _7x9 == 1)
//    {
//        if (ranout4 == cellcount)
//        {
//            _7x9 = 5;
//            break;
//        }
//        Random random = new Random();
//        int ranout = random.Next(1, 100);
//        int ranout2 = random.Next(1, 100);
//        if (ranout <= 34)
//        {
//            if (ranout2 <= 50 && _7x7 == 0)
//            {
//                _7x8 = 1;
//                _7x7 = 12;
//            }
//            if (ranout2 >= 50 && _7x11 == 0)
//            {
//                _7x10 = 1;
//                _7x11 = 12;
//            }
//            ranout2 = random.Next(1, 100);
//            if (ranout2 <= 50 && _7x7 == 0)
//            {
//                _7x8 = 1;
//                _7x7 = 12;
//            }
//            if (ranout2 >= 50 && _7x11 == 0)
//            {
//                _7x10 = 1;
//                _7x11 = 12;
//            }
//            _6x5 = 1;
//            _5x9 = 1;
//        }
//        if (ranout >= 34 && ranout <= 66)
//        {
//            if (ranout2 <= 50 && _5x9 == 0)
//            {
//                _6x5 = 1;
//                _5x9 = 12;
//            }
//            if (ranout2 >= 50 && _7x11 == 0)
//            {
//                _7x10 = 1;
//                _7x11 = 12;
//            }
//            ranout2 = random.Next(1, 100);
//            if (ranout2 <= 50 && _5x9 == 0)
//            {
//                _6x5 = 1;
//                _5x9 = 12;
//            }
//            if (ranout2 >= 50 && _7x11 == 0)
//            {
//                _7x10 = 1;
//                _7x11 = 12;
//            }
//            _7x8 = 1;
//            _7x7 = 1;
//        }
//        if (ranout >= 66)
//        {
//            if (ranout2 <= 50 && _5x9 == 0)
//            {
//                _6x5 = 1;
//                _5x9 = 12;
//            }
//            if (ranout2 >= 650 && _7x7 == 0)
//            {
//                _7x8 = 1;
//                _7x7 = 12;
//            }
//            ranout2 = random.Next(1, 100);
//            if (ranout2 <= 50 && _5x9 == 0)
//            {
//                _6x5 = 1;
//                _5x9 = 12;
//            }
//            if (ranout2 >= 50 && _7x7 == 0)
//            {
//                _7x8 = 1;
//                _7x7 = 12;
//            }
//            _7x10 = 1;
//            _7x11 = 1;
//        }
//        if (_7x9 == 1)
//        {
//            _7x9 = 11;
//        }
//        cellcount++;
//    }

//    if (_7x11 == 10 || _7x11 == 1)
//    {
//        if (ranout4 == cellcount)
//        {
//            _7x11 = 5;
//            break;
//        }
//        Random random = new Random();
//        int ranout = random.Next(1, 100);
//        int ranout2 = random.Next(1, 100);
//        if (ranout <= 34)
//        {
//            if (ranout2 <= 50 && _7x9 == 0)
//            {
//                _7x10 = 1;
//                _7x9 = 12;
//            }
//            if (ranout2 >= 50 && _7x13 == 0)
//            {
//                _7x12 = 1;
//                _7x13 = 12;
//            }
//            ranout2 = random.Next(1, 100);
//            if (ranout2 <= 34 && ranout2 >= 66 && _7x9 == 0)
//            {
//                _7x10 = 1;
//                _7x9 = 12;
//            }
//            if (ranout2 <= 66 && ranout2 >= 100 && _7x13 == 0)
//            {
//                _7x12 = 1;
//                _7x13 = 12;
//            }
//            _6x6 = 1;
//            _5x11 = 1;
//        }
//        if (ranout >= 34 && ranout <= 66)
//        {
//            if (ranout2 <= 50 && _5x11 == 0)
//            {
//                _6x6 = 1;
//                _5x11 = 12;
//            }
//            if (ranout2 >= 50 && _7x13 == 0)
//            {
//                _7x12 = 1;
//                _7x13 = 12;
//            }
//            ranout2 = random.Next(1, 100);
//            if (ranout2 <= 50 && _5x11 == 0)
//            {
//                _6x6 = 1;
//                _5x11 = 12;
//            }
//            if (ranout2 >= 50 && _7x13 == 0)
//            {
//                _7x12 = 1;
//                _7x13 = 12;
//            }
//            _7x10 = 1;
//            _7x9 = 1;
//        }
//        if (ranout >= 66)
//        {
//            if (ranout2 <= 50 && _5x11 == 0)
//            {
//                _6x6 = 1;
//                _5x11 = 12;
//            }
//            if (ranout2 >= 50 && _7x9 == 0)
//            {
//                _7x10 = 1;
//                _7x9 = 12;
//            }
//            ranout2 = random.Next(1, 100);
//            if (ranout2 <= 50 && _5x11 == 0)
//            {
//                _6x6 = 1;
//                _5x11 = 12;
//            }
//            if (ranout2 >= 50 && _7x9 == 0)
//            {
//                _7x10 = 1;
//                _7x9 = 12;
//            }
//            _7x12 = 1;
//            _7x13 = 1;
//        }
//        if (_7x11 == 1)
//        {
//            _7x11 = 11;
//        }
//        cellcount++;
//    }

//    if (_7x13 == 10 || _7x13 == 1)
//    {
//        if (ranout4 == cellcount)
//        {
//            _7x13 = 5;
//            break;
//        }
//        Random random = new Random();
//        int ranout = random.Next(1, 100);
//        int ranout2 = random.Next(1, 100);
//        if (ranout <= 34)
//        {
//            if (ranout2 <= 50 && _7x11 == 0)
//            {
//                _7x12 = 1;
//                _7x11 = 12;
//            }
//            if (ranout2 >= 50 && _7x15 == 0)
//            {
//                _7x14 = 1;
//                _7x15 = 12;
//            }
//            ranout2 = random.Next(1, 100);
//            if (ranout2 <= 50 && _7x11 == 0)
//            {
//                _7x12 = 1;
//                _7x11 = 12;
//            }
//            if (ranout2 >= 50 && _7x15 == 0)
//            {
//                _7x14 = 1;
//                _7x15 = 12;
//            }
//            _6x7 = 1;
//            _5x13 = 1;
//        }
//        if (ranout >= 34 && ranout <= 66)
//        {
//            if (ranout2 <= 50 && _5x13 == 0)
//            {
//                _6x7 = 1;
//                _5x13 = 12;
//            }
//            if (ranout2 >= 50 && _7x15 == 0)
//            {
//                _7x14 = 1;
//                _7x15 = 12;
//            }
//            ranout2 = random.Next(1, 100);
//            if (ranout2 <= 50 && _5x13 == 0)
//            {
//                _6x7 = 1;
//                _5x13 = 12;
//            }
//            if (ranout2 >= 50 && _7x15 == 0)
//            {
//                _7x14 = 1;
//                _7x15 = 12;
//            }
//            _7x12 = 1;
//            _7x11 = 1;
//        }
//        if (ranout >= 66)
//        {
//            if (ranout2 <= 50 && _5x13 == 0)
//            {
//                _6x7 = 1;
//                _5x13 = 12;
//            }
//            if (ranout2 >= 50 && _7x11 == 0)
//            {
//                _7x12 = 1;
//                _7x11 = 12;
//            }
//            ranout2 = random.Next(1, 100);
//            if (ranout2 <= 50 && _5x13 == 0)
//            {
//                _6x7 = 1;
//                _5x13 = 12;
//            }
//            if (ranout2 >= 50 && _7x11 == 0)
//            {
//                _7x12 = 1;
//                _7x11 = 12;
//            }
//            _7x14 = 1;
//            _7x15 = 1;
//        }
//        if (_7x13 == 1)
//        {
//            _7x13 = 11;
//        }
//        cellcount++;
//    }

//    if (_7x15 == 10 || _7x15 == 1)
//    {
//        if (ranout4 == cellcount)
//        {
//            _7x15 = 5;
//            break;
//        }
//        Random random = new Random();
//        int ranout = random.Next(1, 100);
//        int ranout2 = random.Next(1, 100);
//        if (ranout <= 34)
//        {
//            if (ranout2 <= 50 && _7x13 == 0)
//            {
//                _7x14 = 1;
//                _7x13 = 12;
//            }
//            if (ranout2 >= 50 && _7x17 == 0)
//            {
//                _7x16 = 1;
//                _7x17 = 12;
//            }
//            ranout2 = random.Next(1, 100);
//            if (ranout2 <= 50 && _7x13 == 0)
//            {
//                _7x14 = 1;
//                _7x13 = 12;
//            }
//            if (ranout2 >= 50 && _7x17 == 0)
//            {
//                _7x16 = 1;
//                _7x17 = 12;
//            }
//            _6x8 = 1;
//            _5x15 = 1;
//        }
//        if (ranout >= 34 && ranout <= 66)
//        {
//            if (ranout2 <= 50 && _5x15 == 0)
//            {
//                _6x8 = 1;
//                _5x15 = 12;
//            }
//            if (ranout2 >= 50 && _7x17 == 0)
//            {
//                _7x16 = 1;
//                _7x17 = 12;
//            }
//            ranout2 = random.Next(1, 100);
//            if (ranout2 <= 50 && _5x15 == 0)
//            {
//                _6x8 = 1;
//                _5x15 = 12;
//            }
//            if (ranout2 >= 50 && _7x17 == 0)
//            {
//                _7x16 = 1;
//                _7x17 = 12;
//            }
//            _7x14 = 1;
//            _7x13 = 1;
//        }
//        if (ranout >= 66)
//        {
//            if (ranout2 <= 50 && _5x15 == 0)
//            {
//                _6x8 = 1;
//                _5x15 = 12;
//            }
//            if (ranout2 >= 50 && _7x13 == 0)
//            {
//                _7x14 = 1;
//                _7x13 = 12;
//            }
//            ranout2 = random.Next(1, 100);
//            if (ranout2 <= 50 && _5x15 == 0)
//            {
//                _6x8 = 1;
//                _5x15 = 12;
//            }
//            if (ranout2 >= 50 && _7x13 == 0)
//            {
//                _7x14 = 1;
//                _7x13 = 12;
//            }
//            _7x16 = 1;
//            _7x17 = 1;
//        }
//        if (_7x15 == 1)
//        {
//            _7x15 = 11;
//        }
//        cellcount++;
//    }

//    if (_7x17 == 10 || _7x17 == 1)
//    {
//        if (ranout4 == cellcount)
//        {
//            _7x17 = 5;
//            break;
//        }
//        Random random = new Random();
//        int ranout = random.Next(1, 100);
//        int ranout2 = random.Next(1, 100);
//        if (ranout <= 50)
//        {
//            if (ranout2 <= 50 && _7x15 == 0)
//            {
//                _7x16 = 1;
//                _7x15 = 12;
//            }
//            if (ranout2 >= 50 && _7x15 == 0)
//            {
//                _7x16 = 1;
//                _7x15 = 12;
//            }
//            _6x9 = 1;
//            _5x17 = 1;
//        }
//        if (ranout <= 50)
//        {
//            if (ranout2 <= 50 && _5x17 == 0)
//            {
//                _6x9 = 1;
//                _5x17 = 12;
//            }
//            if (ranout2 >= 50 && _5x17 == 0)
//            {
//                _6x9 = 1;
//                _5x17 = 12;
//            }
//            _7x16 = 1;
//            _7x15 = 1;
//        }
//        if (_7x17 == 1)
//        {
//            _7x17 = 11;
//        }
//        cellcount++;
//    }




//    if (_1x1 != 1 && _1x3 != 1 && _1x5 != 1 && _1x7 != 1 && _1x9 != 1 && _1x11 != 1 && _1x13 != 1 && _1x15 != 1 && _1x17 != 1 && _3x1 != 1 && _3x3 != 1 && _3x5 != 1 && _3x7 != 1 && _3x9 != 1 && _3x11 != 1 && _3x13 != 1 && _3x15 != 1 && _3x17 != 1 && _5x1 != 1 && _5x3 != 1 && _5x5 != 1 && _5x7 != 1 && _5x9 != 1 && _5x11 != 1 && _5x13 != 1 && _5x15 != 1 && _5x17 != 1 && _7x1 != 1 && _7x3 != 1 && _7x5 != 1 && _7x7 != 1 && _7x9 != 1 && _7x11 != 1 && _7x13 != 1 && _7x15 != 1 && _7x17 != 1)
//    {
//        cellgen = false;
//    }

//}
//Console.WriteLine("" + _1x1 + _1x2 + _1x3 + _1x4 + _1x5 + _1x6 + _1x7 + _1x8 + _1x9 + _1x10 + _1x11 + _1x12 + _1x13 + _1x14 + _1x15 + _1x16 + _1x17 + _2x1 + _2x2 + _2x3 + _2x4 + _2x5 + _2x6 + _2x7 + _2x8 + _2x9 + _3x1 + _3x2 + _3x3 + _3x4 + _3x5 + _3x6 + _3x7 + _3x8 + _3x9 + _3x10 + _3x11 + _3x12 + _3x13 + _3x14 + _3x15 + _3x16 + _3x17 + _4x1 + _4x2 + _4x3 + _4x4 + _4x5 + _4x6 + _4x7 + _4x8 + _4x9 + _5x1 + _5x2 + _5x3 + _5x4 + _5x5 + _5x6 + _5x7 + _5x8 + _5x9 + _5x10 + _5x11 + _5x12 + _5x13 + _5x14 + _5x15 + _5x16 + _5x17 + _6x1 + _6x2 + _6x3 + _6x4 + _6x5 + _6x6 + _6x7 + _6x8 + _6x9 + _7x1 + _7x2 + _7x3 + _7x4 + _7x5 + _7x6 + _7x7 + _7x8 + _7x9 + _7x10 + _7x11 + _7x12 + _7x13 + _7x14 + _7x15 + _7x16 + _7x17);
/*
int _1x1 = 0; //cell
int _1x2 = 0; //coridor
int _1x3 = 0; //cell
int _1x4 = 0; //coridor
int _1x5 = 0; //cell
int _1x6 = 0; //coridor
int _1x7 = 0; //cell
int _1x8 = 0; //coridor
int _1x9 = 0; //cell
int _1x10 = 0; //coridor
int _1x11 = 0; //cell
int _1x12 = 0; //coridor
int _1x13 = 0; //cell
int _1x14 = 0; //coridor
int _1x15 = 0; //cell
int _1x16 = 0; //coridor
int _1x17 = 0; //cell

int _2x1 = 0; //coridor
int _2x2 = 0;
int _2x3 = 0;
int _2x4 = 0;
int _2x5 = 0;
int _2x6 = 0;
int _2x7 = 0;
int _2x8 = 0;
int _2x9 = 0; //coridor

int _2x10 = 0; //cell
int _2x11 = 0;
int _2x12 = 0; //cell
int _2x13 = 0;
int _2x14 = 0; //cell
int _2x15 = 0;
int _2x16 = 0; //cell
int _2x17 = 0;
int _3x1 = 0; //cell
int _3x2 = 0;
int _3x3 = 0; //cell
int _3x4 = 0;
int _3x5 = 0; //cell
int _3x6 = 0;
int _3x7 = 0; //cell
int _3x8 = 0;
int _3x9 = 0; //cell

int _3x10 = 0; //coridor
int _3x11 = 0;
int _3x12 = 0;
int _3x13 = 0;
int _3x14 = 0;
int _3x15 = 0;
int _3x16 = 0;
int _3x17 = 0; //coridor
int _4x1 = 0;

int _4x2 = 0; //cell
int _4x3 = 0; 
int _4x4 = 0; //cell
int _4x5 = 0; 
int _4x6 = 0; //cell
int _4x7 = 0; 
int _4x8 = 0; //cell
int _4x9 = 0; 
int _4x10 = 0; //cell
int _4x11 = 0; 
int _4x12 = 0; //cell
int _4x13 = 0; 
int _4x14 = 0; //cell
int _4x15 = 0; 
int _4x16 = 0; //cell
int _4x17 = 0; 
int _5x1 = 0; //cell

int _5x2 = 0; //coridor
int _5x3 = 0;
int _5x4 = 0;
int _5x5 = 0;
int _5x6 = 0;
int _5x7 = 0;
int _5x8 = 0;
int _5x9 = 0; 
int _5x10 = 0; //coridor

int _5x11 = 0; //cell
int _5x12 = 0; 
int _5x13 = 0; //cell
int _5x14 = 0;  
int _5x15 = 0; //cell
int _5x16 = 0;  
int _5x17 = 0; //cell
int _6x1 = 0; 
int _6x2 = 0; //cell
int _6x3 = 0;  
int _6x4 = 0; //cell
int _6x5 = 0;  
int _6x6 = 0; //cell
int _6x7 = 0;  
int _6x8 = 0; //cell
int _6x9 = 0;  
int _6x10 = 0; //cell
*/

/*
int _6x11 = 0; //coridor
int _6x12 = 0;
int _6x13 = 0;
int _6x14 = 0;
int _6x15 = 0;
int _6x16 = 0;
int _6x17 = 0; 
int _7x1 = 0; 
int _7x2 = 0; //coridor

int _7x3 = 0; //cell
int _7x4 = 0;
int _7x5 = 0; //cell
int _7x6 = 0; 
int _7x7 = 0; //cell
int _7x8 = 0; 
int _7x9 = 0; //cell
int _7x10 = 0; 
int _7x11 = 0; //cell
int _7x12 = 0; 
int _7x13 = 0; //cell
int _7x14 = 0; 
int _7x15 = 0; //cell
int _7x16 = 0; 
int _7x17 = 0; //cell
*/
//cell

//writing the int variables for map
//Console.WriteLine("\r\n                                                                                                                        " +
//                              "\r\n                                                                                                                        " +
//                              "\r\n                                                                                                                        " +
//                              "\r\n                                                                                                                        " +
//                              "\r\n                                                                                      ██                                " +
//                              "\r\n                                                                                    ██████                              " +
//                              "\r\n                                                                                  ██████████                            " +
//                              "\r\n                                                                                ██████████████                          " +
//                              "\r\n                                                                              ██████████████████                        " +
//                              "\r\n                                                                              ██████████████████                        " +
//                              "\r\n                                                                                                                        " +
//                              "\r\n                      You elevated by  floors                                                            " +
//                              "\r\n                                                                                                                        " +
//                              "\r\n                                                                              ░░░░░░░░░░░░░░░░░░                        " +
//                              "\r\n                                                                                                                        " +
//                              "\r\n                                                                                                                        " +
//                              "\r\n                                                                                                                        " +
//                              "\r\n                                                                                                                        " +
//                              "\r\n                                                                                                                        " +
//                              "\r\n                                                                                                                        " +
//                              "\r\n                                                                                                                        " +
//                              "\r\n                                                                                                                        " +
//                              "\r\n                                                                                                                        ");

string fileName = "Test.txt";
var path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Written Dungeon");
string filepath = System.IO.Path.Combine(path, fileName);

//DateTime time1 = DateTime.Now;
////System.Threading.Thread.Sleep(1);
//DateTime time2 = DateTime.Now;
////int delay = DateTime.Compare(time1, time2);
//long delay = time2.Ticks - time1.Ticks;
//delay = delay / 10000;
//Console.WriteLine(delay);
//delay = (delay - 50) * -1;
//Console.WriteLine(time1);
//Console.WriteLine(time2);
//Console.WriteLine(delay);
//if (delay > 0)
//{
//    System.Threading.Thread.Sleep((Int32)delay);
//}
//Console.WriteLine(delay);


//int h = 5;
//float b = 1.5f;
//h = (int)(h * b);
//Console.WriteLine(h);

//for (int i = 0; i < 20; i++)
//{
//    Random random = new Random();
//    int enemyquant = random.Next(-4, 0);
//    Console.WriteLine(enemyquant);
//    int[] enemy1 = new int[5];
//    //Console.WriteLine(enemy1[i]); 
//}





//int count = 1;
//int count1 = 1;
//int count2 = 1;
//int count3 = 1;
//int count4 = 1;
//int count5 = 1;
//int count6 = 3;

//int count7 = 1;
//int count8 = -1;
//int count9 = 1;
//int count10 = 3;

//int cori1 = 0;
//int cori2 = 1;
//int cori3 = 1;
//int cori4 = 0;
//int cori5 = 1;
//int cori6 = 2;
//int cori7 = 2;
//int cori8 = 1;


//int count = 1;
//int count1 = 1;
//int count2 = 1;
//int count3 = -1;
//int count4 = 1;
//int count5 = 1;
//int count6 = -1;

//int count7 = 1;
//int count8 = 3;
//int count9 = 3;
//int count10 = 1;

//while (count1 <= 7)
//{
//    while (count2 <= 17)
//    {
//        if (cori2 == 10)
//        {
//            cori2 = 1;
//        }
//        if (cori8 == 10)
//        {
//            cori8 = 1;
//        }
//        if (cori4 == 18)
//        {
//            cori4 = 0;

//        }
//        if (cori6 == 18)
//        {
//            cori6 = 4;
//        }

//        System.IO.File.AppendAllText(filepath, string.Format("{0}",
//              "if (_" + count1 + "x" + count2 + " == 13)\n" +
//             "{\n" +
//             "if (_" + cori7 + "x" + cori8 + " == 1)" +
//             "{\n" +
//             "if (_" + count9 + "x" + count10 + " == 3)\n" +
//             "{\n" +
//             "_" + count9 + "x" + count10 + " = 13;\n" +
//             "battle = true;" +
//             "}\n" +
//             "else if (_" + count9 + "x" + count10 + " == 4)\n" +
//             "{\n" +
//             "_" + count9 + "x" + count10 + " = 13;\n" +
//             "_event = true;" +
//             "}\n" +
//             "else if (_" + count9 + "x" + count10 + " == 5)\n" +
//             "{\n" +
//             "_" + count9 + "x" + count10 + " = 13;\n" +
//             "boss = true;" +
//             "}\n" +
//             "else if (_" + count9 + "x" + count10 + " == 6)\n" +
//             "{\n" +
//             "_" + count9 + "x" + count10 + " = 13;\n" +
//             "shop = true;" +
//             "}\n" +
//             "else if (_" + count9 + "x" + count10 + " == 11)\n" +
//             "{\n" +
//             "_" + count9 + "x" + count10 + " = 13;\n" +
//             "}\n" +
//             "else if (_" + count9 + "x" + count10 + " == 2)\n" +
//             "{\n" +
//             "_" + count9 + "x" + count10 + " = 13;\n" +
//             "}\n" +
//             "_" + count1 + "x" + count2 + " = 2;\n" +
//             "break;\n" +
//             "}\n" +
//             "}\n"






//            // "if (_" + count1 + "x" + count2 + " == 13)\n" +
//            //"{\n" +
//            //"if (_" + cori1 + "x" + cori2 + " == 1)" +
//            //"{\n" +
//            //"if (_" + count3 + "x" + count4 + " == 3)\n" +
//            //"{\n" +
//            //"_" + count3 + "x" + count4 + " = 13;\n" +
//            //"battle = true;" +
//            //"}\n" +
//            //"else if (_" + count3 + "x" + count4 + " == 4)\n" +
//            //"{\n" +
//            //"_" + count3 + "x" + count4 + " = 13;\n" +
//            //"_event = true;" +
//            //"}\n" +
//            //"else if (_" + count3 + "x" + count4 + " == 5)\n" +
//            //"{\n" +
//            //"_" + count3 + "x" + count4 + " = 13;\n" +
//            //"boss = true;" +
//            //"}\n" +
//            //"else if (_" + count3 + "x" + count4 + " == 6)\n" +
//            //"{\n" +
//            //"_" + count3 + "x" + count4 + " = 13;\n" +
//            //"shop = true;" +
//            //"}\n" +
//            //"else if (_" + count3 + "x" + count4 + " == 11)\n" +
//            //"{\n" +
//            //"_" + count3 + "x" + count4 + " = 13;\n" +
//            //"}\n" +
//            //"else if (_" + count3 + "x" + count4 + " == 2)\n" +
//            //"{\n" +
//            //"_" + count3 + "x" + count4 + " = 13;\n" +
//            //"}\n" +
//            //"_" + count1 + "x" + count2 + " = 2;\n" +
//            //"}\n" +
//            //"}\n"




//            // "if (_" + count1 + "x" + count2 + " == 13)\n" +
//            //"{\n" +
//            //"if (_" + count9 + "x" + count10 + " == 3)\n" +
//            //"{\n" +
//            //"_" + count9 + "x" + count10 + " = 13;\n" +
//            //"battle = true;" +
//            //"}\n" +
//            //"else if (_" + count9 + "x" + count10 + " == 4)\n" +
//            //"{\n" +
//            //"_event = true;" +
//            //"_" + count9 + "x" + count10 + " = 13;\n" +
//            //"}\n" +
//            //"else if (_" + count9 + "x" + count10 + " == 5)\n" +
//            //"{\n" +
//            //"boss = true;" +
//            //"_" + count9 + "x" + count10 + " = 13;\n" +
//            //"}\n" +
//            //"else if (_" + count9 + "x" + count10 + " == 6)\n" +
//            //"{\n" +
//            //"shop = true;" +
//            //"_" + count9 + "x" + count10 + " = 13;\n" +
//            //"}\n" +
//            //"}\n"




//            // "if (ranout4 == cellcount)\n" +
//            // "{\n" +
//            //     "_" + count1 + "x" + count2 + " = 5;\n" +
//            //     "break;\n" +
//            // "}\n" +
//            // "Random random = new Random();\n" +
//            // "int ranout = random.Next(1, 100);\n" +
//            // "int ranout2 = random.Next(1, 100);\n" +
//            // "if (ranout <= 25)\n" +
//            // "{\n" +
//            //"if (ranout2 <= 34 && _" + count6 + "x" + count5 + " == 0)\n" +  //runout needs double selection for 2 dead ends per tile
//            //"{\n" +
//            //"_" + cori7 + "x" + cori8 + "= 1;\n" +
//            //"_" + count6 + "x" + count5 + " = 12;" + "\n" +                     //also needs conections(coridors) generated aswell
//            //"}\n" +
//            //  "if (ranout2 <= 34 && ranout2 >= 66 && _" + count7 + "x" + count8 + " == 0)\n" +
//            //"{\n" +
//            // "_" + cori3 + "x" + cori4 + "= 1;\n" +
//            //"_" + count7 + "x" + count8 + " = 12;" + "\n" +
//            //"}\n" +
//            //"if (ranout2 <= 66 && ranout2 >= 100 && _" + count9 + "x" + count10 + " == 0)\n" +
//            //"{\n" +
//            //"_" + cori5 + "x" + cori6 + "= 1;\n" +
//            //"_" + count9 + "x" + count10 + " = 12;" + "\n" +
//            //"}\n" +
//            //"ranout2 = random.Next(1, 100);\n" +
//            //"if (ranout2 <= 34 && _" + count6 + "x" + count5 + " == 0)\n" +
//            //"{\n" +
//            //"_" + cori7 + "x" + cori8 + "= 1;\n" +
//            //"_" + count6 + "x" + count5 + " = 12;" + "\n" +
//            //"}\n" +
//            //  "if (ranout2 <= 34 && ranout2 >= 66 && _" + count7 + "x" + count8 + " == 0)\n" +
//            //"{\n" +
//            // "_" + cori3 + "x" + cori4 + "= 1;\n" +
//            //"_" + count7 + "x" + count8 + " = 12;" + "\n" +
//            //"}\n" +
//            //"if (ranout2 <= 66 && ranout2 >= 100 && _" + count9 + "x" + count10 + " == 0)\n" +
//            //"{\n" +
//            //"_" + cori5 + "x" + cori6 + "= 1;\n" +
//            //"_" + count9 + "x" + count10 + " = 12;" + "\n" +
//            //"}\n" +


//            //"_" + cori1 + "x" + cori2 + "= 1;\n" +
//            //"_" + count3 + "x" + count4 + " = 1;" + "\n" +
//            //"}\n" +
//            //"if (ranout >= 25 && ranout <= 50)\n" +
//            // "{\n" +
//            //"if (ranout2 <= 34 && _" + count3 + "x" + count4 + " == 0)\n" +
//            //"{\n" +
//            // "_" + cori1 + "x" + cori2 + "= 1;\n" +
//            //"_" + count3 + "x" + count4 + " = 12;" + "\n" +
//            //"}\n" +
//            //  "if (ranout2 <= 34 && ranout2 >= 66 && _" + count6 + "x" + count5 + " == 0)\n" +
//            //"{\n" +
//            //"_" + cori7 + "x" + cori8 + "= 1;\n" +
//            //"_" + count6 + "x" + count5 + " = 12;" + "\n" +
//            //"}\n" +
//            //"if (ranout2 <= 66 && ranout2 >= 100 && _" + count9 + "x" + count10 + " == 0)\n" +
//            //"{\n" +
//            //"_" + cori5 + "x" + cori6 + "= 1;\n" +
//            //"_" + count9 + "x" + count10 + " = 12;" + "\n" +
//            //"}\n" +
//            //"ranout2 = random.Next(1, 100);\n" +
//            // "if (ranout2 <= 34 && _" + count3 + "x" + count4 + " == 0)\n" +
//            //"{\n" +
//            // "_" + cori1 + "x" + cori2 + "= 1;\n" +
//            //"_" + count3 + "x" + count4 + " = 12;" + "\n" +
//            //"}\n" +
//            //  "if (ranout2 <= 34 && ranout2 >= 66 && _" + count6 + "x" + count5 + " == 0)\n" +
//            //"{\n" +
//            //"_" + cori7 + "x" + cori8 + "= 1;\n" +
//            //"_" + count6 + "x" + count5 + " = 12;" + "\n" +
//            //"}\n" +
//            //"if (ranout2 <= 66 && ranout2 >= 100 && _" + count9 + "x" + count10 + " == 0)\n" +
//            //"{\n" +
//            //"_" + cori5 + "x" + cori6 + "= 1;\n" +
//            //"_" + count9 + "x" + count10 + " = 12;" + "\n" +
//            //"}\n" +


//            //"_" + cori3 + "x" + cori4 + "= 1;\n" +
//            // "_" + count7 + "x" + count8 + " = 1;" + "\n" +
//            // "}\n" +
//            // "if (ranout >= 50 && ranout <= 75)\n" +
//            // "{\n" +
//            //"if (ranout2 <= 34 && _" + count3 + "x" + count4 + " == 0)\n" +
//            //"{\n" +
//            // "_" + cori1 + "x" + cori2 + "= 1;\n" +
//            //"_" + count3 + "x" + count4 + " = 12;" + "\n" +
//            //"}\n" +
//            //  "if (ranout2 <= 34 && ranout2 >= 66 && _" + count7 + "x" + count8 + " == 0)\n" +
//            //"{\n" +
//            // "_" + cori3 + "x" + cori4 + "= 1;\n" +
//            //"_" + count7 + "x" + count8 + " = 12;" + "\n" +
//            //"}\n" +
//            //"if (ranout2 <= 66 && ranout2 >= 100 && _" + count6 + "x" + count5 + " == 0)\n" +
//            //"{\n" +
//            //"_" + cori7 + "x" + cori8 + "= 1;\n" +
//            //"_" + count6 + "x" + count5 + " = 12;" + "\n" +
//            //"}\n" +
//            //"ranout2 = random.Next(1, 100);\n" +
//            //"if (ranout2 <= 34 && _" + count3 + "x" + count4 + " == 0)\n" +
//            //"{\n" +
//            // "_" + cori1 + "x" + cori2 + "= 1;\n" +
//            //"_" + count3 + "x" + count4 + " = 12;" + "\n" +
//            //"}\n" +
//            //  "if (ranout2 <= 34 && ranout2 >= 66 && _" + count7 + "x" + count8 + " == 0)\n" +
//            //"{\n" +
//            // "_" + cori3 + "x" + cori4 + "= 1;\n" +
//            //"_" + count7 + "x" + count8 + " = 12;" + "\n" +
//            //"}\n" +
//            //"if (ranout2 <= 66 && ranout2 >= 100 && _" + count6 + "x" + count5 + " == 0)\n" +
//            //"{\n" +
//            //"_" + cori7 + "x" + cori8 + "= 1;\n" +
//            //"_" + count6 + "x" + count5 + " = 12;" + "\n" +
//            //"}\n" +


//            //"_" + cori5 + "x" + cori6 + "= 1;\n" +
//            // "_" + count9 + "x" + count10 + " = 1;" + "\n" +
//            // "}\n" +
//            // "if (ranout >= 75)\n" +
//            // "{\n" +
//            //"if (ranout2 <= 34 && _" + count3 + "x" + count4 + " == 0)\n" +
//            //"{\n" +
//            // "_" + cori1 + "x" + cori2 + "= 1;\n" +
//            //"_" + count3 + "x" + count4 + " = 12;" + "\n" +
//            //"}\n" +
//            //  "if (ranout2 <= 34 && ranout2 >= 66 && _" + count7 + "x" + count8 + " == 0)\n" +
//            //"{\n" +
//            // "_" + cori3 + "x" + cori4 + "= 1;\n" +
//            //"_" + count7 + "x" + count8 + " = 12;" + "\n" +
//            //"}\n" +
//            //"if (ranout2 <= 66 && ranout2 >= 100 && _" + count9 + "x" + count10 + " == 0)\n" +
//            //"{\n" +
//            //"_" + cori5 + "x" + cori6 + "= 1;\n" +
//            //"_" + count9 + "x" + count10 + " = 12;" + "\n" +
//            //"}\n" +
//            //"ranout2 = random.Next(1, 100);\n" +
//            // "if (ranout2 <= 34 && _" + count3 + "x" + count4 + " == 0)\n" +
//            //"{\n" +
//            // "_" + cori1 + "x" + cori2 + "= 1;\n" +
//            //"_" + count3 + "x" + count4 + " = 12;" + "\n" +
//            //"}\n" +
//            //  "if (ranout2 <= 34 && ranout2 >= 66 && _" + count7 + "x" + count8 + " == 0)\n" +
//            //"{\n" +
//            // "_" + cori3 + "x" + cori4 + "= 1;\n" +
//            //"_" + count7 + "x" + count8 + " = 12;" + "\n" +
//            //"}\n" +
//            //"if (ranout2 <= 66 && ranout2 >= 100 && _" + count9 + "x" + count10 + " == 0)\n" +
//            //"{\n" +
//            //"_" + cori5 + "x" + cori6 + "= 1;\n" +
//            //"_" + count9 + "x" + count10 + " = 12;" + "\n" +
//            //"}\n" +


//            //"_" + cori7 + "x" + cori8 + "= 1;\n" +
//            // "_" + count6 + "x" + count5 + " = 1;" + "\n" +
//            // "}\n" +
//            // "if (_" + count1 + "x" + count2 + "== 1)\n" +
//            // "{\n" +
//            // "_" + count1 + "x" + count2 + "= 11;\n" +
//            // "}\n" +
//            // "cellcount++;" +
//            // "}\n\n"
//            ));
//        Console.WriteLine();
//        count++;
//        count2++;
//        count2++;
//        count4++;
//        count4++;
//        count6++;
//        count6++;
//        count8++;
//        count8++;
//        count10++;
//        count10++;
//        cori2++;
//        cori4++;
//        cori6++;
//        cori6++;
//        cori4++;
//        cori8++;
//    }
//    count1++;
//    count1++;
//    count3++;
//    count3++;
//    count5++;
//    count5++;
//    count7++;
//    count7++;
//    count9++;
//    count9++;
//    count2 = 1;
//    count4 = 1;
//    count6 = -1;
//    count8 = 3;
//    count10 = 1;
//    //count4 = 1;
//    cori2 = 1;
//    cori4 = 0;
//    cori6 = 2;
//    cori8 = 1;
//    //count2 = 1;
//    //count8 = -1;
//    //count10 = 3;
//    //count5 = 1;
//    cori1++;
//    cori3++;
//    cori5++;
//    cori7++;
//    cori1++;
//    cori3++;
//    cori5++;
//    cori7++;
//}

//int count1 = 3;
//int count2 = 1;
//int count3 = 1;
//int count4 = 1;
//int count5 = 1;
//int count6 = 5;

//int count7 = 3;
//int count8 = -1;
//int count9 = 3;
//int count10 = 5;

//int cori1 = 2;
//int cori2 = 1;
//int cori3 = 3;
//int cori4 = 0;
//int cori5 = 3;
//int cori6 = 4;
//int cori7 = 4;
//int cori8 = 1;


/*
int count = 0;
int count1 = 3;
int count2 = 1;

while (count1 <= 7)
{
    while (count2 <= 17)
    {
        System.IO.File.AppendAllText(filepath, string.Format("{0}", "if (_" + count1 + "x" + count2 + "== 10 || _" + count1 + "x" + count2 + "== 1)\n" +
            "{\n\n" +

            "}\n"));
        count2++;
        count2++;
    }
    count1++;
    count1++;
    count2 = 1;
}
*/




/*
System.IO.File.AppendAllText("C:\\Users\\petro\\AppData\\Roaming\\Written Dungeon\\Test.txt", string.Format("{0}", "else if (pos ==" + count + ")\n" +
            "{\n" +
                "int.TryParse(temp.Substring(startIndex + 1), out _" + count1 + "x" + count2 + ");\n" +
                "pos++;\n" +
            "}"))
*/

//writting and loading

//_1x1 + _1x2 + _1x3 + _1x4 + _1x5 + _1x6 + _1x7 + _1x8 + _1x9 + _1x10 + _1x11 + _1x12 + _1x13 + _1x14 + _1x15 + _1x16 + _1x17 + _2x1 + _2x2 + _2x3 + _2x4 + _2x5 + _2x6 + _2x7 + _2x8 + _2x9 + _2x10 + _2x11 + _2x12 + _2x13 + _2x14 + _2x15 + _2x16 + _2x17 + _3x1 + _3x2 + _3x3 + _3x4 + _3x5 + _3x6 + _3x7 + _3x8 + _3x9 + _3x10 + _3x11 + _3x12 + _3x13 + _3x14 + _3x15 + _3x16 + _3x17 + _4x1 + _4x2 + _4x3 + _4x4 + _4x5 + _4x6 + _4x7 + _4x8 + _4x9 + _4x10 + _4x11 + _4x12 + _4x13 + _4x14 + _4x15 + _4x16 + _4x17 + _5x1 + _5x2 + _5x3 + _5x4 + _5x5 + _5x6 + _5x7 + _5x8 + _5x9 + _5x10 + _5x11 + _5x12 + _5x13 + _5x14 + _5x15 + _5x16 + _5x17 + _6x1 + _6x2 + _6x3 + _6x4 + _6x5 + _6x6 + _6x7 + _6x8 + _6x9 + _6x10 + _6x11 + _6x12 + _6x13 + _6x14 + _6x15 + _6x16 + _6x17 + _7x1 + _7x2 + _7x3 + _7x4 + _7x5 + _7x6 + _7x7 + _7x8 + _7x9 + _7x10 + _7x11 + _7x12 + _7x13 + _7x14 + _7x15 + _7x16 + _7x17 
/*
int[] strcoords = new int[] { _1x1, _1x2, _1x3, _1x4, _1x5, _1x6, _1x7, _1x8, _1x9, _1x10, _1x11, _1x12, _1x13, _1x14, _1x15, _1x16, _1x17, _2x1, _2x2, _2x3, _2x4, _2x5, _2x6, _2x7, _2x8, _2x9, _2x10, _2x11, _2x12, _2x13, _2x14, _2x15, _2x16, _2x17, _3x1, _3x2, _3x3, _3x4, _3x5, _3x6, _3x7, _3x8, _3x9, _3x10, _3x11, _3x12, _3x13, _3x14, _3x15, _3x16, _3x17, _4x1, _4x2, _4x3, _4x4, _4x5, _4x6, _4x7, _4x8, _4x9, _4x10, _4x11, _4x12, _4x13, _4x14, _4x15, _4x16, _4x17, _5x1, _5x2, _5x3, _5x4, _5x5, _5x6, _5x7, _5x8, _5x9, _5x10, _5x11, _5x12, _5x13, _5x14, _5x15, _5x16, _5x17, _6x1, _6x2, _6x3, _6x4, _6x5, _6x6, _6x7, _6x8, _6x9, _6x10, _6x11, _6x12, _6x13, _6x14, _6x15, _6x16, _6x17, _7x1, _7x2, _7x3, _7x4, _7x5, _7x6, _7x7, _7x8, _7x9, _7x10, _7x11, _7x12, _7x13, _7x14, _7x15, _7x16, _7x17, };
while (test)
{
    foreach (int i in strcoords)
    {
        System.IO.File.AppendAllText("C:\\Users\\petrosik\\AppData\\Roaming\\Written Dungeon\\test.txt", string.Format("{0}","stagen:" + i + "\n"));
        //Console.WriteLine(i);
        
    }
    test = false;
}
int pos = 1;


var filestream = new System.IO.FileStream("C:\\Users\\petrosik\\AppData\\Roaming\\Written Dungeon\\test.txt",
                                                  System.IO.FileMode.Open,
                                                  System.IO.FileAccess.Read,
                                                  System.IO.FileShare.ReadWrite);
var file = new System.IO.StreamReader(filestream, System.Text.Encoding.UTF8, true, 128);
string temp;
while ((temp = file.ReadLine()) != null)
{
    string substring;
    //int useless = 0;
    int startIndex = 0;
    int length = 6;
    substring = temp.Substring(startIndex, length);
        if (substring == "stagen")
        {
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

        }

}

else if (pos ==1)
{
int.TryParse(temp.Substring(startIndex + 1), out _1x1);
pos++;
}else if (pos ==2)
{
int.TryParse(temp.Substring(startIndex + 1), out _1x2);
pos++;
}else if (pos ==3)
{
int.TryParse(temp.Substring(startIndex + 1), out _1x3);
pos++;
}else if (pos ==4)
{
int.TryParse(temp.Substring(startIndex + 1), out _1x4);
pos++;
}else if (pos ==5)
{
int.TryParse(temp.Substring(startIndex + 1), out _1x5);
pos++;
}else if (pos ==6)
{
int.TryParse(temp.Substring(startIndex + 1), out _1x6);
pos++;
}else if (pos ==7)
{
int.TryParse(temp.Substring(startIndex + 1), out _1x7);
pos++;
}else if (pos ==8)
{
int.TryParse(temp.Substring(startIndex + 1), out _1x8);
pos++;
}else if (pos ==9)
{
int.TryParse(temp.Substring(startIndex + 1), out _1x9);
pos++;
}else if (pos ==10)
{
int.TryParse(temp.Substring(startIndex + 1), out _1x10);
pos++;
}else if (pos ==11)
{
int.TryParse(temp.Substring(startIndex + 1), out _1x11);
pos++;
}else if (pos ==12)
{
int.TryParse(temp.Substring(startIndex + 1), out _1x12);
pos++;
}else if (pos ==13)
{
int.TryParse(temp.Substring(startIndex + 1), out _1x13);
pos++;
}else if (pos ==14)
{
int.TryParse(temp.Substring(startIndex + 1), out _1x14);
pos++;
}else if (pos ==15)
{
int.TryParse(temp.Substring(startIndex + 1), out _1x15);
pos++;
}else if (pos ==16)
{
int.TryParse(temp.Substring(startIndex + 1), out _1x16);
pos++;
}else if (pos ==17)
{
int.TryParse(temp.Substring(startIndex + 1), out _1x17);
pos++;
}else if (pos ==18)
{
int.TryParse(temp.Substring(startIndex + 1), out _2x1);
pos++;
}else if (pos ==19)
{
int.TryParse(temp.Substring(startIndex + 1), out _2x2);
pos++;
}else if (pos ==20)
{
int.TryParse(temp.Substring(startIndex + 1), out _2x3);
pos++;
}else if (pos ==21)
{
int.TryParse(temp.Substring(startIndex + 1), out _2x4);
pos++;
}else if (pos ==22)
{
int.TryParse(temp.Substring(startIndex + 1), out _2x5);
pos++;
}else if (pos ==23)
{
int.TryParse(temp.Substring(startIndex + 1), out _2x6);
pos++;
}else if (pos ==24)
{
int.TryParse(temp.Substring(startIndex + 1), out _2x7);
pos++;
}else if (pos ==25)
{
int.TryParse(temp.Substring(startIndex + 1), out _2x8);
pos++;
}else if (pos ==26)
{
int.TryParse(temp.Substring(startIndex + 1), out _2x9);
pos++;
}else if (pos ==27)
{
int.TryParse(temp.Substring(startIndex + 1), out _2x10);
pos++;
}else if (pos ==28)
{
int.TryParse(temp.Substring(startIndex + 1), out _2x11);
pos++;
}else if (pos ==29)
{
int.TryParse(temp.Substring(startIndex + 1), out _2x12);
pos++;
}else if (pos ==30)
{
int.TryParse(temp.Substring(startIndex + 1), out _2x13);
pos++;
}else if (pos ==31)
{
int.TryParse(temp.Substring(startIndex + 1), out _2x14);
pos++;
}else if (pos ==32)
{
int.TryParse(temp.Substring(startIndex + 1), out _2x15);
pos++;
}else if (pos ==33)
{
int.TryParse(temp.Substring(startIndex + 1), out _2x16);
pos++;
}else if (pos ==34)
{
int.TryParse(temp.Substring(startIndex + 1), out _2x17);
pos++;
}else if (pos ==35)
{
int.TryParse(temp.Substring(startIndex + 1), out _3x1);
pos++;
}else if (pos ==36)
{
int.TryParse(temp.Substring(startIndex + 1), out _3x2);
pos++;
}else if (pos ==37)
{
int.TryParse(temp.Substring(startIndex + 1), out _3x3);
pos++;
}else if (pos ==38)
{
int.TryParse(temp.Substring(startIndex + 1), out _3x4);
pos++;
}else if (pos ==39)
{
int.TryParse(temp.Substring(startIndex + 1), out _3x5);
pos++;
}else if (pos ==40)
{
int.TryParse(temp.Substring(startIndex + 1), out _3x6);
pos++;
}else if (pos ==41)
{
int.TryParse(temp.Substring(startIndex + 1), out _3x7);
pos++;
}else if (pos ==42)
{
int.TryParse(temp.Substring(startIndex + 1), out _3x8);
pos++;
}else if (pos ==43)
{
int.TryParse(temp.Substring(startIndex + 1), out _3x9);
pos++;
}else if (pos ==44)
{
int.TryParse(temp.Substring(startIndex + 1), out _3x10);
pos++;
}else if (pos ==45)
{
int.TryParse(temp.Substring(startIndex + 1), out _3x11);
pos++;
}else if (pos ==46)
{
int.TryParse(temp.Substring(startIndex + 1), out _3x12);
pos++;
}else if (pos ==47)
{
int.TryParse(temp.Substring(startIndex + 1), out _3x13);
pos++;
}else if (pos ==48)
{
int.TryParse(temp.Substring(startIndex + 1), out _3x14);
pos++;
}else if (pos ==49)
{
int.TryParse(temp.Substring(startIndex + 1), out _3x15);
pos++;
}else if (pos ==50)
{
int.TryParse(temp.Substring(startIndex + 1), out _3x16);
pos++;
}else if (pos ==51)
{
int.TryParse(temp.Substring(startIndex + 1), out _3x17);
pos++;
}else if (pos ==52)
{
int.TryParse(temp.Substring(startIndex + 1), out _4x1);
pos++;
}else if (pos ==53)
{
int.TryParse(temp.Substring(startIndex + 1), out _4x2);
pos++;
}else if (pos ==54)
{
int.TryParse(temp.Substring(startIndex + 1), out _4x3);
pos++;
}else if (pos ==55)
{
int.TryParse(temp.Substring(startIndex + 1), out _4x4);
pos++;
}else if (pos ==56)
{
int.TryParse(temp.Substring(startIndex + 1), out _4x5);
pos++;
}else if (pos ==57)
{
int.TryParse(temp.Substring(startIndex + 1), out _4x6);
pos++;
}else if (pos ==58)
{
int.TryParse(temp.Substring(startIndex + 1), out _4x7);
pos++;
}else if (pos ==59)
{
int.TryParse(temp.Substring(startIndex + 1), out _4x8);
pos++;
}else if (pos ==60)
{
int.TryParse(temp.Substring(startIndex + 1), out _4x9);
pos++;
}else if (pos ==61)
{
int.TryParse(temp.Substring(startIndex + 1), out _4x10);
pos++;
}else if (pos ==62)
{
int.TryParse(temp.Substring(startIndex + 1), out _4x11);
pos++;
}else if (pos ==63)
{
int.TryParse(temp.Substring(startIndex + 1), out _4x12);
pos++;
}else if (pos ==64)
{
int.TryParse(temp.Substring(startIndex + 1), out _4x13);
pos++;
}else if (pos ==65)
{
int.TryParse(temp.Substring(startIndex + 1), out _4x14);
pos++;
}else if (pos ==66)
{
int.TryParse(temp.Substring(startIndex + 1), out _4x15);
pos++;
}else if (pos ==67)
{
int.TryParse(temp.Substring(startIndex + 1), out _4x16);
pos++;
}else if (pos ==68)
{
int.TryParse(temp.Substring(startIndex + 1), out _4x17);
pos++;
}else if (pos ==69)
{
int.TryParse(temp.Substring(startIndex + 1), out _5x1);
pos++;
}else if (pos ==70)
{
int.TryParse(temp.Substring(startIndex + 1), out _5x2);
pos++;
}else if (pos ==71)
{
int.TryParse(temp.Substring(startIndex + 1), out _5x3);
pos++;
}else if (pos ==72)
{
int.TryParse(temp.Substring(startIndex + 1), out _5x4);
pos++;
}else if (pos ==73)
{
int.TryParse(temp.Substring(startIndex + 1), out _5x5);
pos++;
}else if (pos ==74)
{
int.TryParse(temp.Substring(startIndex + 1), out _5x6);
pos++;
}else if (pos ==75)
{
int.TryParse(temp.Substring(startIndex + 1), out _5x7);
pos++;
}else if (pos ==76)
{
int.TryParse(temp.Substring(startIndex + 1), out _5x8);
pos++;
}else if (pos ==77)
{
int.TryParse(temp.Substring(startIndex + 1), out _5x9);
pos++;
}else if (pos ==78)
{
int.TryParse(temp.Substring(startIndex + 1), out _5x10);
pos++;
}else if (pos ==79)
{
int.TryParse(temp.Substring(startIndex + 1), out _5x11);
pos++;
}else if (pos ==80)
{
int.TryParse(temp.Substring(startIndex + 1), out _5x12);
pos++;
}else if (pos ==81)
{
int.TryParse(temp.Substring(startIndex + 1), out _5x13);
pos++;
}else if (pos ==82)
{
int.TryParse(temp.Substring(startIndex + 1), out _5x14);
pos++;
}else if (pos ==83)
{
int.TryParse(temp.Substring(startIndex + 1), out _5x15);
pos++;
}else if (pos ==84)
{
int.TryParse(temp.Substring(startIndex + 1), out _5x16);
pos++;
}else if (pos ==85)
{
int.TryParse(temp.Substring(startIndex + 1), out _5x17);
pos++;
}else if (pos ==86)
{
int.TryParse(temp.Substring(startIndex + 1), out _6x1);
pos++;
}else if (pos ==87)
{
int.TryParse(temp.Substring(startIndex + 1), out _6x2);
pos++;
}else if (pos ==88)
{
int.TryParse(temp.Substring(startIndex + 1), out _6x3);
pos++;
}else if (pos ==89)
{
int.TryParse(temp.Substring(startIndex + 1), out _6x4);
pos++;
}else if (pos ==90)
{
int.TryParse(temp.Substring(startIndex + 1), out _6x5);
pos++;
}else if (pos ==91)
{
int.TryParse(temp.Substring(startIndex + 1), out _6x6);
pos++;
}else if (pos ==92)
{
int.TryParse(temp.Substring(startIndex + 1), out _6x7);
pos++;
}else if (pos ==93)
{
int.TryParse(temp.Substring(startIndex + 1), out _6x8);
pos++;
}else if (pos ==94)
{
int.TryParse(temp.Substring(startIndex + 1), out _6x9);
pos++;
}else if (pos ==95)
{
int.TryParse(temp.Substring(startIndex + 1), out _6x10);
pos++;
}else if (pos ==96)
{
int.TryParse(temp.Substring(startIndex + 1), out _6x11);
pos++;
}else if (pos ==97)
{
int.TryParse(temp.Substring(startIndex + 1), out _6x12);
pos++;
}else if (pos ==98)
{
int.TryParse(temp.Substring(startIndex + 1), out _6x13);
pos++;
}else if (pos ==99)
{
int.TryParse(temp.Substring(startIndex + 1), out _6x14);
pos++;
}else if (pos ==100)
{
int.TryParse(temp.Substring(startIndex + 1), out _6x15);
pos++;
}else if (pos ==101)
{
int.TryParse(temp.Substring(startIndex + 1), out _6x16);
pos++;
}else if (pos ==102)
{
int.TryParse(temp.Substring(startIndex + 1), out _6x17);
pos++;
}else if (pos ==103)
{
int.TryParse(temp.Substring(startIndex + 1), out _7x1);
pos++;
}else if (pos ==104)
{
int.TryParse(temp.Substring(startIndex + 1), out _7x2);
pos++;
}else if (pos ==105)
{
int.TryParse(temp.Substring(startIndex + 1), out _7x3);
pos++;
}else if (pos ==106)
{
int.TryParse(temp.Substring(startIndex + 1), out _7x4);
pos++;
}else if (pos ==107)
{
int.TryParse(temp.Substring(startIndex + 1), out _7x5);
pos++;
}else if (pos ==108)
{
int.TryParse(temp.Substring(startIndex + 1), out _7x6);
pos++;
}else if (pos ==109)
{
int.TryParse(temp.Substring(startIndex + 1), out _7x7);
pos++;
}else if (pos ==110)
{
int.TryParse(temp.Substring(startIndex + 1), out _7x8);
pos++;
}else if (pos ==111)
{
int.TryParse(temp.Substring(startIndex + 1), out _7x9);
pos++;
}else if (pos ==112)
{
int.TryParse(temp.Substring(startIndex + 1), out _7x10);
pos++;
}else if (pos ==113)
{
int.TryParse(temp.Substring(startIndex + 1), out _7x11);
pos++;
}else if (pos ==114)
{
int.TryParse(temp.Substring(startIndex + 1), out _7x12);
pos++;
}else if (pos ==115)
{
int.TryParse(temp.Substring(startIndex + 1), out _7x13);
pos++;
}else if (pos ==116)
{
int.TryParse(temp.Substring(startIndex + 1), out _7x14);
pos++;
}else if (pos ==117)
{
int.TryParse(temp.Substring(startIndex + 1), out _7x15);
pos++;
}else if (pos ==118)
{
int.TryParse(temp.Substring(startIndex + 1), out _7x16);
pos++;
}else if (pos ==119)
{
int.TryParse(temp.Substring(startIndex + 1), out _7x17);
pos++;
}
Console.WriteLine(_1x1 + "" + _1x2 + _1x3 + _1x4 + _1x5);
*/
/*
9 x 4 = 36 stages
8 x 4 + 9 x 3 = 59 paths
X:1 - 7 * Y:1 - 17 = 119 grid
/*
//cell index
0 - doesnt exist
1 - empty non explored (gen only)
2 - empty explored (base after evyrting)
3 - enemy
4 - evnt cell (idk yet)
5 - boss cell (end floor)
....
10 - player pos (also start in gen)
11 - generated empty non conectable
12 - dead end empty non explored
*/
/*
▀ top square
▄ lower square
█ full square
⬛
▀ selected?
⬛ centered sq selected?
▄▄▄▄▄
██v██
▀▀▀▀▀
╗
═ 
║
╚
╝
╔
░
╔═══╗
║ v ║ non selcted ?
╚═══╝

  empty space?

◄
▬

 */