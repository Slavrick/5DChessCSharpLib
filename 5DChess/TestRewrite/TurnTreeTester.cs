using FiveDChess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileIO5D;

namespace Test
{
    class TurnTreeTester
    {

        public static void TestRewind()
        {
            GameStateManager gsm = FENParser.ShadSTDGSM("C:\\Users\\mavmi\\Documents\\5DRewrite\\5DChess\\5DChess\\PGN\\testPGNs\\ShadTestGame2.txt");
            gsm.NavigateToTurn(2);

        }
    }
}
