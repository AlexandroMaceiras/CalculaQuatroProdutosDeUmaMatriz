using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculaQuatroProdutosAdjacentesDeUmaMatriz
{
    class Program
    {
        static void Main(string[] args)
        {
            const int x = 20, y = 20;
            int[,] matriz = new int[x, y] 
            { 
                { 08, 02, 22, 97, 38, 15, 00, 40, 00, 75, 04, 05, 07, 78, 52, 12, 50, 77, 91, 08 }, 
                { 49, 49, 99, 40, 17, 81, 18, 57, 60, 87, 17, 40, 98, 43, 69, 48, 04, 56, 62, 00 }, 
                { 81, 49, 31, 73, 55, 79, 14, 29, 93, 71, 40, 67, 53, 88, 30, 03, 49, 13, 36, 65 }, 
                { 52, 70, 95, 23, 04, 60, 11, 42, 69, 24, 68, 56, 01, 32, 56, 71, 37, 02, 36, 91 }, 
                { 22, 31, 16, 71, 51, 67, 63, 89, 41, 92, 36, 54, 22, 40, 40, 28, 66, 33, 13, 80 }, 
                { 24, 47, 32, 60, 99, 03, 45, 02, 44, 75, 33, 53, 78, 36, 84, 20, 35, 17, 12, 50 }, 
                { 32, 98, 81, 28, 64, 23, 67, 10, 26, 38, 40, 67, 59, 54, 70, 66, 18, 38, 64, 70 }, 
                { 67, 26, 20, 68, 02, 62, 12, 20, 95, 63, 94, 39, 63, 08, 40, 91, 66, 49, 94, 21 }, 
                { 24, 55, 58, 05, 66, 73, 99, 26, 97, 17, 78, 78, 96, 83, 14, 88, 34, 89, 63, 72 }, 
                { 21, 36, 23, 09, 75, 00, 76, 44, 20, 45, 35, 14, 00, 61, 33, 97, 34, 31, 33, 95 }, 
                { 78, 17, 53, 28, 22, 75, 31, 67, 15, 94, 03, 80, 04, 62, 16, 14, 09, 53, 56, 92 }, 
                { 16, 39, 05, 42, 96, 35, 31, 47, 55, 58, 88, 24, 00, 17, 54, 24, 36, 29, 85, 57 }, 
                { 86, 56, 00, 48, 35, 71, 89, 07, 05, 44, 44, 37, 44, 60, 21, 58, 51, 54, 17, 58 }, 
                { 19, 80, 81, 68, 05, 94, 47, 69, 28, 73, 92, 13, 86, 52, 17, 77, 04, 89, 55, 40 }, 
                { 04, 52, 08, 83, 97, 35, 99, 16, 07, 97, 57, 32, 16, 26, 26, 79, 33, 27, 98, 66 }, 
                { 88, 36, 68, 87, 57, 62, 20, 72, 03, 46, 33, 67, 46, 55, 12, 32, 63, 93, 53, 69 }, 
                { 04, 42, 16, 73, 38, 25, 39, 11, 24, 94, 72, 18, 08, 46, 29, 32, 40, 62, 76, 36 }, 
                { 20, 69, 36, 41, 72, 30, 23, 88, 34, 62, 99, 69, 82, 67, 59, 85, 74, 04, 36, 16 }, 
                { 20, 73, 35, 29, 78, 31, 90, 01, 74, 31, 49, 71, 48, 86, 81, 16, 23, 57, 05, 54 }, 
                { 01, 70, 54, 71, 83, 51, 54, 69, 16, 92, 33, 48, 61, 43, 52, 01, 89, 19, 67, 48 }
            };
            int linha = 0, coluna = 0, h1 = 0, h2 = 0, h3 = 0, h4 = 0;
            int theGreat1 = 0, theGreatX1 = 0, theGreatY1 = 0;
            int theGreat2 = 0, theGreatX2 = 0, theGreatY2 = 0;
            int theGreat3 = 0, theGreatX3 = 0, theGreatY3 = 0;
            int theGreat4 = 0, theGreatX4 = 0, theGreatY4 = 0;
            int theGreatFinally = 0;
            for (coluna = 0; coluna < 20; coluna++)
            {

                for (linha = 0; linha < 17; linha++)
                {
                    h1 = matriz[coluna, linha] * matriz[coluna, linha + 1] * matriz[coluna, linha + 2] * matriz[coluna, linha + 3];
                    //Console.WriteLine(matriz[coluna, linha] + " --> " + h1);
                    if (h1 > theGreat1)
                    {
                        theGreat1 = h1;
                        theGreatX1 = linha;
                        theGreatY1 = coluna;
                    }
                    h1 = 0;
                }
            }
            if (theGreatFinally < theGreat1) theGreatFinally = theGreat1;
            linha = 0;
            coluna = 0;
            for (linha = 0; linha < 20; linha++) 
            {
                for (coluna = 0; coluna < 17; coluna++)
                {
                    h2 = matriz[coluna, linha] * matriz[coluna + 1, linha] * matriz[coluna + 2, linha] * matriz[coluna + 3, linha];
                    //Console.WriteLine(matriz[coluna, linha] + " --> " + h2);
                    if (h2 > theGreat2)
                    {
                        theGreat2 = h2;
                        theGreatX2 = linha;
                        theGreatY2 = coluna;
                    }
                    h2 = 0;
                }
            }
            if (theGreatFinally < theGreat2) theGreatFinally = theGreat2;
            linha = 0;
            coluna = 0;
            for (coluna = 0; coluna < 17; coluna++)
            {

                for (linha = 0; linha < 17; linha++)
                {
                    h3 = matriz[coluna, linha] * matriz[coluna + 1, linha + 1] * matriz[coluna + 2, linha + 2] * matriz[coluna + 3, linha + 3];
                    //Console.WriteLine(matriz[coluna, linha] + " --> " + h3);
                    if (h3 > theGreat3)
                    {
                        theGreat3 = h3;
                        theGreatX3 = linha;
                        theGreatY3 = coluna;
                    }
                    h3 = 0;
                }
            }
            if (theGreatFinally < theGreat3) theGreatFinally = theGreat3;
            linha = 0;
            coluna = 0;
            for (coluna = 3; coluna < 20 ; coluna++)
            {

                for (linha = 0; linha < 17; linha++)
                {
                    h4 = matriz[coluna, linha] * matriz[coluna - 1, linha + 1] * matriz[coluna - 2, linha + 2] * matriz[coluna - 3, linha + 3];
                    //Console.WriteLine(matriz[coluna, linha] + " --> " + h4);
                    if (h4 > theGreat4)
                    {
                        theGreat4 = h4;
                        theGreatX4 = coluna;
                        theGreatY4 = linha;
                    }
                    h4 = 0;
                }
            }
            if (theGreatFinally < theGreat4) theGreatFinally = theGreat4;

            Console.WriteLine("H Great Product => " + theGreat1 + " -> [" + theGreatX1 + "," + theGreatY1 + "] * [" + theGreatX1 + "," + (theGreatY1 + 1) + "] * ["  + theGreatX1 + "," + (theGreatY1 + 2) + "] * ["  + theGreatX1 + "," + (theGreatY1 + 3) + "]");
            Console.WriteLine("V Great Product => " + theGreat2 + " -> [" + theGreatX2 + "," + theGreatY2 + "] * [" + (theGreatX2 + 1) + "," + theGreatY2 + "] * [" + (theGreatX2 + 2) + "," + theGreatY2 + "] * [" + (theGreatX2 + 3) + "," + theGreatY2 + "]");
            Console.WriteLine("P Diagonal Great Product => " + theGreat3 + " -> [" + theGreatX3 + "," + theGreatY3 + "] * [" + (theGreatX3 + 1) + "," + (theGreatY3 + 1) + "] * [" + (theGreatX3 + 2) + "," + (theGreatY3 + 2) + "] * [" + (theGreatX3 + 3) + "," + (theGreatY3 + 3) + "]");
            Console.WriteLine("N Diagonal Great Product => " + theGreat4 + " -> [" + theGreatX4 + "," + theGreatY4 + "] * [" + (theGreatX4 - 1) + "," + (theGreatY4 + 1) + "] * [" + (theGreatX4 - 2) + "," + (theGreatY4 + 2) + "] * [" + (theGreatX4 - 3) + "," + (theGreatY4 + 3) + "]");

            Console.WriteLine("The greatest product of four adjacent numbers in the same direction => " + theGreatFinally);
            
            Console.ReadKey();
        }
    }
}
