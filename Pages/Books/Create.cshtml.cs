using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Moldovan_Alex_Lab2.Data;
using Moldovan_Alex_Lab2.Models;

namespace Moldovan_Alex_Lab2.Pages.Books
{
    public class CreateModel : PageModel
    {
        private readonly Moldovan_Alex_Lab2.Data.Moldovan_Alex_Lab2Context _context;

        public CreateModel(Moldovan_Alex_Lab2.Data.Moldovan_Alex_Lab2Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            ViewData["PublisherID"] = new SelectList(_context.Set<Publisher>(), "ID", "PublisherName");

            // Modifică concatenarea numelui și prenumelui pentru autori
                ViewData["AuthorID"] = new SelectList(_context.Authors, "ID", "FullName"); // Asigură-te că ai această linie


            return Page();
        }
        

        [BindProperty]
        public Book Book { get; set; } = default!;

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            // Add the selected author to the book
            _context.Book.Add(Book);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}


