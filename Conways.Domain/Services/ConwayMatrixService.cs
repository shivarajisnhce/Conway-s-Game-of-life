using Conways.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class ConwayMatrixService: IConwayMatrixService
    {
        public int GetCellsBehaviour(int cell, int numberLiveCells)
        {
            int newCell;
            if (cell == Cells.LiveCell())
            {
                if (numberLiveCells <= 1)
                {
                    newCell = Cells.DeadCell();
                }
                else if (numberLiveCells == 2 || numberLiveCells == 3)
                {
                    newCell = Cells.LiveCell();
                }
                else
                {
                    newCell = Cells.DeadCell();
                }
            }
            else
            {
                if (numberLiveCells == 3)
                {
                    newCell = Cells.LiveCell();
                }
                else
                {
                    newCell = Cells.DeadCell();
                }
            }
            return newCell;
        }

        public int GetLiveCells(int matrixRow, int matrixCol, int[,] liveMatrix)
        {
            int livecells = 0;
            int colLength = liveMatrix.GetLength(0);
            int rowLength = liveMatrix.GetLength(1);
            if (matrixRow < rowLength - 1 && matrixCol < colLength - 1)
            {
                if (liveMatrix[matrixRow + 1, matrixCol + 1] == Cells.LiveCell())
                {
                    livecells++;
                }
            }

            if (matrixRow < rowLength - 1)
            {
                if (liveMatrix[matrixRow + 1, matrixCol] == Cells.LiveCell())
                {
                    livecells++;
                }
            }
            if (matrixCol < colLength - 1)
            {
                if (liveMatrix[matrixRow, matrixCol + 1] == Cells.LiveCell())
                {
                    livecells++;
                }

            }
            if (matrixRow > 0 && matrixCol > 0)
            {
                if (liveMatrix[matrixRow - 1, matrixCol - 1] == Cells.LiveCell())
                {
                    livecells++;
                }
            }
            if (matrixCol > 0)
            {
                if (liveMatrix[matrixRow, matrixCol - 1] == Cells.LiveCell())
                {
                    livecells++;
                }
            }
            if (matrixRow > 0)
            {
                if (liveMatrix[matrixRow - 1, matrixCol] == Cells.LiveCell())
                {
                    livecells++;
                }
            }
            if (matrixRow < rowLength - 1 && matrixCol > 0)
            {
                if (liveMatrix[matrixRow + 1, matrixCol - 1] == Cells.LiveCell())
                {
                    livecells++;
                }
            }
            if (matrixRow > 0 && matrixCol < colLength - 1)
            {
                if (liveMatrix[matrixRow - 1, matrixCol + 1] == Cells.LiveCell())
                {
                    livecells++;
                }
            }
            return livecells;
        }
    }
}
