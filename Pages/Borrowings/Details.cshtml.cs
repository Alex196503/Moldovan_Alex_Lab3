﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Moldovan_Alex_Lab2.Data;
using Moldovan_Alex_Lab2.Models;

namespace Moldovan_Alex_Lab2.Pages.Borrowings
{
    public class DetailsModel : PageModel
    {
        private readonly Moldovan_Alex_Lab2.Data.Moldovan_Alex_Lab2Context _context;

        public DetailsModel(Moldovan_Alex_Lab2.Data.Moldovan_Alex_Lab2Context context)
        {
            _context = context;
        }

        public Borrowing Borrowing { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var borrowing = await _context.Borrowing.FirstOrDefaultAsync(m => m.ID == id);
            if (borrowing == null)
            {
                return NotFound();
            }
            else
            {
                Borrowing = borrowing;
            }
            return Page();
        }
    }
}