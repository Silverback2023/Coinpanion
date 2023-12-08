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
    public class IndexModel : PageModel
    {
        private readonly Coinpanion.Data.ApplicationDbContext _context;

        public IndexModel(Coinpanion.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Expense> Expense { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Expenses != null)
            {
                Expense = await _context.Expenses.ToListAsync();
            }
        }
    }
}
