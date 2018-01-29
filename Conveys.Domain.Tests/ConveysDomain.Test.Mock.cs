using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp3;
using Moq;

namespace Conveys.Domain.Testss
{
    [TestClass]
    public class ConveysDomainMockTests
    {
        ConwayMatrix _conwayMatrix;
        [TestMethod, TestCategory("MockTests")]
        public void GetLiveCells_WithinputMatrix_ReturnsNotNull()
        {
            Mock<ConwayMatrixService> mockService = new Mock<ConwayMatrixService>();
            int matrixRow = 2;
            int matrixCol = 1;
            int[,] matrix = new int[,]
            {
                { 1, 0, 0, 0},
                { 0, 0, 1, 0},
                { 1, 1, 1, 0},
                { 0, 1, 0, 0},
            };
            mockService.Setup(x => x.GetLiveCells(matrixRow, matrixCol, matrix)).Returns(1);
            _conwayMatrix = new ConwayMatrix(mockService.Object);
            _conwayMatrix.ActiveMatrix(matrix);
            Assert.IsNotNull(_conwayMatrix);
        }

        [TestMethod, TestCategory("MockTests")]
        public void GetCellsBehavior_WithinputElement_ReturnsLiveCell()
        {
            Mock<ConwayMatrixService> mockService = new Mock<ConwayMatrixService>();
            int numberOfLiveCells = 2;
            int matrixElement = 1;
            int[,] matrix = new int[,]
            {
                { 1, 0, 0, 0},
                { 0, 0, 1, 0},
                { 1, 1, 1, 0},
                { 0, 1, 0, 0},
            };
            mockService.Setup(x => x.GetCellsBehaviour(matrixElement, numberOfLiveCells)).Returns(1);
            _conwayMatrix = new ConwayMatrix(mockService.Object);
            _conwayMatrix.ActiveMatrix(matrix);
            Assert.IsNotNull(_conwayMatrix);
        }

    }
}
