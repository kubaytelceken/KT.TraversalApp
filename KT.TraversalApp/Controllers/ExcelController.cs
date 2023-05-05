using ClosedXML.Excel;
using KT.Traversal.Business.Abstract;
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
        private readonly IExcelService _excelService;

        public ExcelController(IExcelService excelService)
        {
            _excelService = excelService;
        }

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
            return File(_excelService.ExcelList(DestinationList()), "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "DestinationList.xlsx");
        }
    }
}
