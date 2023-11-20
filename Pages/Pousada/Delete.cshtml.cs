using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using sistema_quinta_do_ypua.Data;
using sistema_quinta_do_ypua.Models;

namespace sistema_quinta_do_ypua.Pages_Pousada
{
    public class DeleteModel : PageModel
    {
        private readonly sistema_quinta_do_ypua.Data.ApplicationDbContext _context;

        public DeleteModel(sistema_quinta_do_ypua.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Pousada Pousada { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Pousada = await _context.Pousada.FirstOrDefaultAsync(m => m.Id == id);

            if (Pousada == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Pousada = await _context.Pousada.FindAsync(id);

            if (Pousada != null)
            {
                _context.Pousada.Remove(Pousada);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
