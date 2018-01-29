using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp3;

namespace Conveys.Domain.Tests
{
    [TestClass]
    public class ConveysDomainTests
    {
        IConwayMatrixService _conwayMatrixService;
        [TestMethod, TestCategory("DomainTests")]
        public void GetLiveCells_WithinputMatrix_ReturnsLiveCells()
        {
            _conwayMatrixService = new ConwayMatrixService();
            int matrixRow = 2;
            int matrixCol = 1;
            int[,] matrix = new int[,]
            {
                { 1, 0, 0, 0},
                { 0, 0, 1, 0},
                { 1, 1, 1, 0},
                { 0, 1, 0, 0},
            };
            var liveCeels=_conwayMatrixService.GetLiveCells(matrixRow, matrixCol, matrix);
            Assert.IsTrue(liveCeels == 4);
        }

        [TestMethod, TestCategory("DomainTests")]
        public void GetLiveCells_WithinputMatrix_ReturnsZeroCells()
        {
            _conwayMatrixService = new ConwayMatrixService();
            int matrixRow = 0;
            int matrixCol = 0;
            int[,] matrix = new int[,]
            {
                { 1, 0, 0, 0},
                { 0, 0, 1, 0},
                { 1, 1, 1, 0},
                { 0, 1, 0, 0},
            };
            var liveCeels = _conwayMatrixService.GetLiveCells(matrixRow, matrixCol, matrix);
            Assert.IsTrue(liveCeels == 0);
        }

        [TestMethod, TestCategory("DomainTests")]
        [ExpectedException(typeof(NullReferenceException))]
        public void GetLiveCells_WithNullInput_ThrowsException()
        {
            _conwayMatrixService = new ConwayMatrixService();
            int matrixRow = 0;
            int matrixCol = 0;
            int[,] matrix = null;
            var liveCeels = _conwayMatrixService.GetLiveCells(matrixRow, matrixCol, matrix);
        }
        [TestMethod, TestCategory("DomainTests")]
        public void GetCellsBehavior_WithinputElement_ReturnsNewCell()
        {
            _conwayMatrixService = new ConwayMatrixService();
            int numberOfLiveCells = 0;
            int matrixElement = 0;
            
            var newCell = _conwayMatrixService.GetCellsBehaviour(matrixElement, numberOfLiveCells);
            Assert.IsTrue(newCell == 0);
        }
        [TestMethod, TestCategory("DomainTests")]
        public void GetCellsBehavior_WithinputElement_ReturnsDeadCell()
        {
            _conwayMatrixService = new ConwayMatrixService();
            int numberOfLiveCells = 3;
            int matrixElement = 0;

            var newCell = _conwayMatrixService.GetCellsBehaviour(matrixElement, numberOfLiveCells);
            Assert.IsTrue(newCell == 1);
        }
        [TestMethod, TestCategory("DomainTests")]
        public void GetCellsBehavior_WithinputElement_ReturnsLiveCell()
        {
            _conwayMatrixService = new ConwayMatrixService();
            int numberOfLiveCells = 2;
            int matrixElement = 1;

            var newCell = _conwayMatrixService.GetCellsBehaviour(matrixElement, numberOfLiveCells);
            Assert.IsTrue(newCell == 1);
        }
    }
}
