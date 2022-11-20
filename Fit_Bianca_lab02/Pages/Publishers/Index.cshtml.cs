using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Fit_Bianca_lab02.Data;
using Fit_Bianca_lab02.Models;

namespace Fit_Bianca_lab02.Pages.Publishers
{
    public class IndexModel : PageModel
    {
        private readonly Fit_Bianca_lab02.Data.Fit_Bianca_lab02Context _context;

        public IndexModel(Fit_Bianca_lab02.Data.Fit_Bianca_lab02Context context)
        {
            _context = context;
        }

        public IList<Publisher> Publisher { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Publisher != null)
            {
                Publisher = await _context.Publisher.ToListAsync();
            }
        }
    }
}
