using System;

namespace customChessLibrary
{
    public class Class1
    {
        public static void Main()
        {
            var chess = new ChessBoard();
            Console.WriteLine(chess.ToAscii());
        }
    }
}