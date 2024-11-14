using System;
namespace Backtracking
{
    public class Program
    {
        private static int N;
        private const string MsgStateSize = "Indica la mida del tauler (N): ";
        private const string MsgNotFound = "No s'ha trobat cap solució";
        
        public static void PrintBoard(int[,] board)
        {
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write(board[i, j] + " ");
                }
                Console.Write("\n");
            }
        }
        /*Comprova si una reina pot situar-se a board[row,col]. S'invoca
        quan les reines "col" ja s'han situat en columnes de 0 a col-1.
        Per tant, només hem de comprovar la part esquerra per a reines atacants*/
        public static bool ToPlaceOrNotToPlace(int[,] board, int row, int col)
        {
            int i, j;
            /* Comprova aquesta fila a la banda esquerra */
            for (i = 0; i < col; i++)
            {
                if (board[row, i] == 1) return false;
            }
            /* Comprova la diagonal superior al costat esquerre */
            for (i = row, j = col; i >= 0 && j >= 0; i--, j--)
            {
                if (board[i, j] == 1) return false;
            }
            /* Comprova la diagonal inferior al costat esquerre */
            for (i = row, j = col; j >= 0 && i < N; i++, j--)
            {
                if (board[i, j] == 1) return false;
            }
            return true;
        }
        /* Mètode recursiu per a resoldre el problema de les N Reines */
        public static bool BoardSolver(int[,] board, int col)
        {
            /* cas base: si totes les reines estan situades al taulell retorna true */
            if (col >= N) return true;
            /* Considerem aquesta columna i provem de situar aquesta reina a totes les files una per una */
            for (int i = 0; i < N; i++)
            {
                 /* Verifiquem si la reina pot situar-se a board[i,col] */
                if (ToPlaceOrNotToPlace(board, i, col))
                {
                    /* Situem aquesta reina a board[i,col] */
                    board[i, col] = 1;
                    /* Si qualsevol situació és possible retorna true */
                    if (BoardSolver(board, col + 1))  return true;
                    /* Si situar la reina a board[i,col] no porta a una sol·lució, 
                    llavors eliminar la reina de board[i,col] */
                    board[i, col] = 0; //Backtracking
                }
            }
            /* Si la reina no es pot situar a cap fila a la columna "col" retorna false */
            return false;
        }
        public static void Main()
        {
            Console.WriteLine(MsgStateSize);
            N = Convert.ToInt32(Console.ReadLine());
            int[,] board = new int[N, N];
            if (!BoardSolver(board, 0))
            {
                Console.WriteLine(MsgNotFound);
            }
            PrintBoard(board);
            Console.ReadLine();
        }
    }
}
