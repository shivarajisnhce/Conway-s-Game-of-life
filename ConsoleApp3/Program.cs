using ConsoleApp3;
using System;
using System.Collections.Generic;

using Unity;

namespace grid
{
    class Program
    {
        static void Main(string[] args)
        {
            bool endgame = false;
            var container = new UnityContainer();
         
            int[,] matrix = new int[,]
            {
                { 1, 0, 0, 0},
                { 0, 0, 1, 0},
                { 1, 1, 1, 0},
                { 0, 1, 0, 0},
            };
            ConwayMatrix conwayMatrix = new ConwayMatrix(new ConwayMatrixService());
            while (endgame == false)
            {
                Console.WriteLine();
                conwayMatrix.ActiveMatrix(matrix);
            }
        }

    }
}