using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class ConwayMatrix
    {
        int[,] liveMatrix;
        int[,] oldMatrix;
        private IConwayMatrixService _conwayMatrixService;
        public ConwayMatrix(IConwayMatrixService conwayMatrixService)
        {
            _conwayMatrixService = conwayMatrixService;
        }
        public void ActiveMatrix(int[,] matrix)
        {
            liveMatrix = (int[,])matrix.Clone();
            int colLength = liveMatrix.GetLength(0);
            int rowLength = liveMatrix.GetLength(1);
            for (int i = 0; i < rowLength; i++)
            {
                for (int j = 0; j < colLength; j++)
                {
                    int numberLiveCells = _conwayMatrixService.GetLiveCells(i, j, liveMatrix);
                    int newCell = _conwayMatrixService.GetCellsBehaviour(matrix[i, j], numberLiveCells);
                    matrix[i, j] = newCell;
                }
            }
            oldMatrix = (int[,])matrix.Clone();
            DisplayMatrix(matrix);
            Console.WriteLine("Enter y to continue: ");
            string option = Console.ReadLine();
            option = option.ToLower();
            if (option == "y")
            {
                ActiveMatrix(oldMatrix);
            }

            else
            {
                return;
            }
        }

        public void DisplayMatrix(int[,] matrix)
        {
            int colLength = matrix.GetLength(0);
            int rowLength = matrix.GetLength(1);

            for (int i = 0; i < colLength; i++)
            {
                for (int j = 0; j < rowLength; j++)
                {
                    Console.Write("{0,2}", matrix[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
