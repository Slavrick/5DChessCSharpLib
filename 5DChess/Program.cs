// See https://aka.ms/new-console-template for more information
using Test;
using TestRewrite;


FENParserTest.TestFENFileParser();
TurnTreeTester.TestRewind();
TurnTester.TestTurnEquals();
CoordTester.TestAllCoordFiveFuncs();
FENParserTest.TestMoveParser();
FENParserTest.TestSANParser();
FENParserTest.TestShadParser();
FENParserTest.TestShadFEN();
FENParserTest.TestAmbiguityInfoParser();
GameStateTest.TestGameStateMutation();
MateTest.BenchmarkMates();


//FENParserTest.Test5Dinterfaceoutput(); TODO
//FENExporter.ExportGameState(FENParser.ShadSTDGSM("C:\\Users\\mavmi\\Desktop\\Java 5d\\5dchessEngine\\res\\testPGNs\\CastleTest3.txt"), "C:\\Users\\mavmi\\Desktop\\TestNewThing.txt");


ConsolePlay c = new ConsolePlay("C:\\Users\\mavmi\\Documents\\5DRewrite\\5DChess\\5DChess\\PGN\\Standard.PGN5.txt");

while (true)
{
    c.MakeMove();
}