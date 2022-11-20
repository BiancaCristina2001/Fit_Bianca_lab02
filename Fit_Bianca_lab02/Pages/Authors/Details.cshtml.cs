using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Fit_Bianca_lab02.Data;
using Fit_Bianca_lab02.Models;

namespace Fit_Bianca_lab02.Pages.Authors
{
    public class DetailsModel : PageModel
    {
        private readonly Fit_Bianca_lab02.Data.Fit_Bianca_lab02Context _context;

        public DetailsModel(Fit_Bianca_lab02.Data.Fit_Bianca_lab02Context context)
        {
            _context = context;
        }

      public Author Author { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Author == null)
            {
                return NotFound();
            }

            var author = await _context.Author.FirstOrDefaultAsync(m => m.ID == id);
            if (author == null)
            {
                return NotFound();
            }
            else 
            {
                Author = author;
            }
            return Page();
        }
    }
}
