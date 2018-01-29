using ConsoleApp3;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ConveysGameOfLife.Controllers
{
    public class HomeController : Controller
    {
        int[,] liveMatrix;
        int[,] oldMatrix;
        private IConwayMatrixService _conwayMatrixService;
        public HomeController()
        {
            _conwayMatrixService = new ConwayMatrixService ();
        }
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        [HttpPost]
        public JsonResult GetConveyMatrix(int[,] matrix)
        {
            if (matrix == null)
            {
                matrix= new int[,]
                {
                    { 1, 0, 0, 0},
                    { 0, 0, 1, 0},
                    { 1, 1, 1, 0},
                    { 0, 1, 0, 0},
                };
            }

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
                oldMatrix = (int[,])matrix.Clone();
            }
            string json = JsonConvert.SerializeObject(matrix);
            return Json(json, "application/json",JsonRequestBehavior.AllowGet);
        }
    }
}