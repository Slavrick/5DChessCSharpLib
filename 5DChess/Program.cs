// See https://aka.ms/new-console-template for more information
using Test;

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