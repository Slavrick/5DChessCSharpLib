// See https://aka.ms/new-console-template for more information
using TestRewrite;


FENParserTest.TestFENFileParser();
TurnTester.TestTurnEquals();
CoordTester.TestAllCoordFiveFuncs();
FENParserTest.TestMoveParser();
FENParserTest.TestSANParser();
FENParserTest.TestShadParser();
FENParserTest.TestShadFEN();
FENParserTest.TestAmbiguityInfoParser();
MateTest.BenchmarkMates();
GameStateTest.TestGameStateMutation();