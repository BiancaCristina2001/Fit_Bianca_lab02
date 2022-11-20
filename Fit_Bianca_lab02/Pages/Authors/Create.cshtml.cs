﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Fit_Bianca_lab02.Data;
using Fit_Bianca_lab02.Models;

namespace Fit_Bianca_lab02.Pages.Authors
{
    public class CreateModel : PageModel
    {
        private readonly Fit_Bianca_lab02.Data.Fit_Bianca_lab02Context _context;

        public CreateModel(Fit_Bianca_lab02.Data.Fit_Bianca_lab02Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Author Author { get; set; }
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Author.Add(Author);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}