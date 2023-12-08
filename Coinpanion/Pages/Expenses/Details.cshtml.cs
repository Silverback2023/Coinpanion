using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Coinpanion.Data;
using Coinpanion.Models;

namespace Coinpanion.Pages.Expenses
{
    public class DetailsModel : PageModel
    {
        private readonly Coinpanion.Data.ApplicationDbContext _context;

        public DetailsModel(Coinpanion.Data.ApplicationDbContext context)
        {
            _context = context;
        }

      public Expense Expense { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Expenses == null)
            {
                return NotFound();
            }

            var expense = await _context.Expenses.FirstOrDefaultAsync(m => m.Id == id);
            if (expense == null)
            {
                return NotFound();
            }
            else 
            {
                Expense = expense;
            }
            return Page();
        }
    }
}
