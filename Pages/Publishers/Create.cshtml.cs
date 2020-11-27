﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Chitic__Valentina_Lab8.Data;
using Chitic__Valentina_Lab8.Models;

namespace Chitic__Valentina_Lab8.Pages.Publishers
{
    public class CreateModel : PageModel
    {
        private readonly Chitic__Valentina_Lab8.Data.Chitic__Valentina_Lab8Context _context;

        public CreateModel(Chitic__Valentina_Lab8.Data.Chitic__Valentina_Lab8Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Publisher Publisher { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Publisher.Add(Publisher);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
