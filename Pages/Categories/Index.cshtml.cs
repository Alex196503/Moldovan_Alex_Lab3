using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Moldovan_Alex_Lab2.Data;
using Moldovan_Alex_Lab2.Models;
using Moldovan_Alex_Lab2.Models.ViewModels;

namespace Moldovan_Alex_Lab2.Pages.Categories
{
    public class IndexModel : PageModel
    {
        private readonly Moldovan_Alex_Lab2.Data.Moldovan_Alex_Lab2Context _context;

        public IndexModel(Moldovan_Alex_Lab2.Data.Moldovan_Alex_Lab2Context context)
        {
            _context = context;
        }

        public IList<Category> Category { get; set; } = default!;
        public CategoryIndexData CategoryData { get; set; }
        public int CategoryID { get; set; }

        public async Task OnGetAsync(int? id)
        {
            CategoryData = new CategoryIndexData
            {
                Categories = await _context.Category
                    .Include(c => c.BookCategories)
                    .ThenInclude(bc => bc.Book)
                    .ThenInclude(b => b.Author)
                    .OrderBy(c => c.CategoryName)
                    .ToListAsync()
            };

            if (id != null)
            {
                CategoryID = id.Value;
                var category = CategoryData.Categories.Single(c => c.ID == id.Value);
                CategoryData.Books = category.BookCategories.Select(bc => bc.Book);
            }
        }
    }
}
