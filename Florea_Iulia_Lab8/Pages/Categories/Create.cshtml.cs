using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Florea_Iulia_Lab8.Data;
using Florea_Iulia_Lab8.Models;

namespace Florea_Iulia_Lab8.Pages.Categories
{
    public class CreateModel : PageModel
    {
        private readonly Florea_Iulia_Lab8.Data.Florea_Iulia_Lab8Context _context;

        public CreateModel(Florea_Iulia_Lab8.Data.Florea_Iulia_Lab8Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Category Category { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Category.Add(Category);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
