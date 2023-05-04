using ClosedXML.Excel;
using KT.Traversal.DataAccessLayer.Concrete;
using KT.TraversalApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace KT.TraversalApp.Controllers
{
    public class ExcelController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        public List<DestinationModel> DestinationList()
        {
            List<DestinationModel> destinationModels = new List<DestinationModel>();

            using(var c  = new Context())
            {
                destinationModels = c.Destinations.Select(x => new DestinationModel
                {
                    City = x.City,
                    Price = x.Price,
                    DayNight = x.DayNight,
                    Capacity = x.Capacity
                }).ToList();
            }

            return destinationModels;
        }


        
        public IActionResult DestinationExcelReport()
        {
            using(var workBook = new XLWorkbook())
            {
                var workSheet = workBook.Worksheets.Add("Destinations");
                workSheet.Cell(1, 1).Value = "City";
                workSheet.Cell(1, 2).Value = "Day Night";
                workSheet.Cell(1, 3).Value = "Price";
                workSheet.Cell(1, 4).Value = "Capacity";

                int rowCount = 2;

                foreach (var item in DestinationList())
                {

                    workSheet.Cell(rowCount,1).Value= item.City;
                    workSheet.Cell(rowCount,2).Value= item.DayNight;
                    workSheet.Cell(rowCount,3).Value= item.Price;
                    workSheet.Cell(rowCount,4).Value= item.Capacity;
                    rowCount++;
                }

                using(var stream = new MemoryStream())
                {
                    workBook.SaveAs(stream);
                    var content = stream.ToArray();
                    return File(content, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet","DestinationList.xlsx");
                }
            }
        }
    }
}
