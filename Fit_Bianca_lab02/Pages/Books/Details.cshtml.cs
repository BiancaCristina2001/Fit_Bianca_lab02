using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Fit_Bianca_lab02.Data;
using Fit_Bianca_lab02.Models;

namespace Fit_Bianca_lab02.Pages.Books
{
    public class DetailsModel : PageModel
    {
        private readonly Fit_Bianca_lab02.Data.Fit_Bianca_lab02Context _context;

        public DetailsModel(Fit_Bianca_lab02.Data.Fit_Bianca_lab02Context context)
        {
            _context = context;
        }

      public Book Book { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Book == null)
            {
                return NotFound();
            }

            var book = await _context.Book.FirstOrDefaultAsync(m => m.ID == id);
            if (book == null)
            {
                return NotFound();
            }
            else 
            {
                Book = book;
            }
            return Page();
        }
    }
}
