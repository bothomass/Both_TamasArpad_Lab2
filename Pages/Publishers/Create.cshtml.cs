using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Both_TamasArpad_Lab2.Data;
using Both_TamasArpad_Lab2.Models;

namespace Both_TamasArpad_Lab2.Pages.Publishers
{
    public class CreateModel : PageModel
    {
        private readonly Both_TamasArpad_Lab2.Data.Both_TamasArpad_Lab2Context _context;

        public CreateModel(Both_TamasArpad_Lab2.Data.Both_TamasArpad_Lab2Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Publisher Publisher { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Publisher == null || Publisher == null)
            {
                return Page();
            }

            _context.Publisher.Add(Publisher);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
