using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MyMVCProject.Data;
using MyMVCProject.Models;

namespace MyMVCProject.Controllers
{
    public class DimensionDatasetsController : Controller
    {
        private readonly DimensionDatasetContext _context;

        public DimensionDatasetsController(DimensionDatasetContext context)
        {
            _context = context;
        }

        // GET: DimensionDatasets
        public async Task<IActionResult> Index()
        {
            return View(await _context.DimensionDataset.ToListAsync());
        }

        // GET: DimensionDatasets/Details/5
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

        // GET: DimensionDatasets/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: DimensionDatasets/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
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

        // GET: DimensionDatasets/Edit/5
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

        // POST: DimensionDatasets/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Age,Attrition,BusinessTravel,DailyRate,Department,DistanceFromHome,Education,EducationField,EmployeeCount,EmployeeNumber,EnvironmentSatisfaction,Gender,HourlyRate,JobInvolvement,JobLevel,JobRole,JobSatisfaction,MaritalStatus,MonthlyIncome,MonthlyRate,NumCompaniesWorked,Over18,OverTime,PercentSalaryHike,PerformanceRating,RelationshipSatisfaction,StandardHours,StockOptionLevel,TotalWorkingYears,TrainingTimesLastYear,WorkLifeBalance,YearsAtCompany,YearsInCurrentRole,YearsSinceLastPromotion,YearsWithCurrManager")] DimensionDataset dimensionDataset)
        {
            if (id != dimensionDataset.EmployeeNumber)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(dimensionDataset);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DimensionDatasetExists(dimensionDataset.EmployeeNumber))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(dimensionDataset);
        }

        // GET: DimensionDatasets/Delete/5
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

        // POST: DimensionDatasets/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
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
