using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyMVCProject.Data;
using Microsoft.AspNetCore.Authorization;

namespace MyMVCProject.Controllers
{
    [Authorize(Policy = "readypolicy")]
    public class DataAnalyticsController : Controller
    {

        private readonly DimensionDatasetContext _context;
        private DimensionDatasetContext context;

        public IActionResult Index(DimensionDatasetContext context)
        {
            this.context = context;
            return View();
        }
        //public IActionResult DimensionCharts()
        //{
        //    int female = _context.DimensionDataset.Where(s => s.Gender == "Female").Select(s => s).Count();
        //    int male = _context.DimensionDataset.Where(s => s.Gender == "male").Select(s => s).Count();

        //    ViewBag.FEM = female;
        //    ViewBag.MA = male;

        //    (int, int, int, int, int, int) ageTuple = (_context.DimensionDataset.Where(a => a.Age < 20).Select(a => a).Count(),
        //                                                _context.DimensionDataset.Where(a => a.Age >= 20 && a.Age < 30).Select(a => a).Count(),
        //                                                _context.DimensionDataset.Where(a => a.Age >= 30 && a.Age < 40).Select(a => a).Count(),
        //                                                _context.DimensionDataset.Where(a => a.Age >= 40 && a.Age < 50).Select(a => a).Count(),
        //                                                _context.DimensionDataset.Where(a => a.Age >= 50 && a.Age < 60).Select(a => a).Count(),
        //                                                _context.DimensionDataset.Where(a => a.Age >= 60).Select(a => a).Count());
        //}
    }
}
