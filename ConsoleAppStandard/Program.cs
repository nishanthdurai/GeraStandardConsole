// See https://aka.ms/new-console-template for more information

var chess = new ChessBoard();
chess.Move(new Move("f2", "f4"));
chess.Move(new Move("g7", "g5"));
chess.Move(new Move("g2", "g4"));
chess.Move(new Move("h7", "h5"));
chess.Move(new Move("g4", "h5"));
chess.Move(new Move("g5", "g4"));
chess.Move(new Move("h2", "h4"));
chess.Moves(); // causing error
Console.Write(chess.ToAscii());