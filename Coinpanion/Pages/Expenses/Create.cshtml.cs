﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Coinpanion.Data;
using Coinpanion.Models;

namespace Coinpanion.Pages.Expenses
{
    public class CreateModel : PageModel
    {
        private readonly Coinpanion.Data.ApplicationDbContext _context;

        public CreateModel(Coinpanion.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Expense Expense { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Expenses == null || Expense == null)
            {
                return Page();
            }

            _context.Expenses.Add(Expense);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
