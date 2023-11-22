using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using sistema_quinta_do_ypua.Data;
using sistema_quinta_do_ypua.Models;

namespace sistema_quinta_do_ypua.Pages_Contato
{
    public class CreateModel : PageModel
    {
        private readonly sistema_quinta_do_ypua.Data.ApplicationDbContext _context;

        public CreateModel(sistema_quinta_do_ypua.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Contato Contato { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Contato.Add(Contato);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
