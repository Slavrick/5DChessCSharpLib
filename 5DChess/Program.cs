// See https://aka.ms/new-console-template for more information
using Test;
using TestRewrite;

FENParserTest.TestFENFileParser();
TurnTester.TestTurnEquals();
CoordTester.TestAllCoordFiveFuncs();
FENParserTest.TestMoveParser();
FENParserTest.TestSANParser();
FENParserTest.TestShadParser();
FENParserTest.TestShadFEN();
FENParserTest.TestAmbiguityInfoParser();
GameStateTest.TestGameStateMutation();
MateTest.BenchmarkMates();


ConsolePlay c = new ConsolePlay("C:\\Users\\mavmi\\Documents\\5DRewrite\\5DChess\\5DChess\\PGN\\Standard.PGN5.txt");

while (true)
{
    c.MakeMove();
}