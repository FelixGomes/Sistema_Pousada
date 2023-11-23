using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using sistema_quinta_do_ypua.Data;
using sistema_quinta_do_ypua.Models;

namespace sistema_quinta_do_ypua.Pages_Contato
{
    public class DeleteModel : PageModel
    {
        private readonly sistema_quinta_do_ypua.Data.ApplicationDbContext _context;

        public DeleteModel(sistema_quinta_do_ypua.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Contato Contato { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Contato = await _context.Contato.FirstOrDefaultAsync(m => m.Id == id);

            if (Contato == null)
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

            Contato = await _context.Contato.FindAsync(id);

            if (Contato != null)
            {
                _context.Contato.Remove(Contato);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
