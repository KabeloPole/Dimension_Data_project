using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MyMVCProject.Data;
using MyMVCProject.Models;

namespace MyMVCProject.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly DimensionDatasetContext _context;

        public AccountController(DimensionDatasetContext context, UserManager<IdentityUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

       // [Authorize(Roles = "Employee")]
       // [Authorize(Policy = "readpolicy")]
        public async Task <IActionResult> Index()
        {
            return View(await _context.DimensionDataset.ToListAsync());
        }

       // [Authorize(Policy = "readpolicy")]
       //// [Authorize(Roles = "Admin")]
       // [Authorize(Roles = "Manager")]
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dimensionDataset = await _context.DimensionDataset
                .FirstOrDefaultAsync(m => m.EmployeeNumber == id);
            if (dimensionDataset == null)
            {
                return NotFound();
            }

            return View(dimensionDataset);
        }

        
        public IActionResult Create()
        {
            return View();
        }

       // [Authorize(Policy = "writepolicy")]
       // [Authorize(Roles = "Admin")]
       // [Authorize(Roles = "Manager")]
        public async Task<IActionResult> Create([Bind("Age,Attrition,BusinessTravel,DailyRate,Department,DistanceFromHome,Education,EducationField,EmployeeCount,EmployeeNumber,EnvironmentSatisfaction,Gender,HourlyRate,JobInvolvement,JobLevel,JobRole,JobSatisfaction,MaritalStatus,MonthlyIncome,MonthlyRate,NumCompaniesWorked,Over18,OverTime,PercentSalaryHike,PerformanceRating,RelationshipSatisfaction,StandardHours,StockOptionLevel,TotalWorkingYears,TrainingTimesLastYear,WorkLifeBalance,YearsAtCompany,YearsInCurrentRole,YearsSinceLastPromotion,YearsWithCurrManager")] DimensionDataset dimensionDataset)
        {
            if (ModelState.IsValid)
            {
                _context.Add(dimensionDataset);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(dimensionDataset);
        }

       // [Authorize(Policy = "writepolicy")]
      //  [Authorize(Roles = "Admin")]
       // [Authorize(Roles = "Manager")]
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dimensionDataset = await _context.DimensionDataset.FindAsync(id);
            if (dimensionDataset == null)
            {
                return NotFound();
            }
            return View(dimensionDataset);
        }

       // [Authorize(Policy = "writepolicy")]
       // [Authorize(Roles = "Admin")]
      //  [Authorize(Roles = "Manager")]
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dimensionDataset = await _context.DimensionDataset
                .FirstOrDefaultAsync(m => m.EmployeeNumber == id);
            if (dimensionDataset == null)
            {
                return NotFound();
            }

            return View(dimensionDataset);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
       // [Authorize(Policy = "writepolicy")]
       // [Authorize(Roles = "Admin")]
       // [Authorize(Roles = "Manager")]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var dimensionDataset = await _context.DimensionDataset.FindAsync(id);
            _context.DimensionDataset.Remove(dimensionDataset);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        private bool DimensionDatasetExists(string id)
        {
            return _context.DimensionDataset.Any(e => e.EmployeeNumber == id);
        }
    }
}
