using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public interface IConwayMatrixService
    {
        int GetLiveCells(int matrixRow, int matrixCol, int[,] liveMatrix);
        int GetCellsBehaviour(int cell,int numberLiveCells);
    }
}
