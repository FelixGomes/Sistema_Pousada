using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using sistema_quinta_do_ypua.Data;
using sistema_quinta_do_ypua.Models;

namespace sistema_quinta_do_ypua.Pages_Funcionario
{
    public class DetailsModel : PageModel
    {
        private readonly sistema_quinta_do_ypua.Data.ApplicationDbContext _context;

        public DetailsModel(sistema_quinta_do_ypua.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public Funcionario Funcionario { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Funcionario = await _context.Funcionario.FirstOrDefaultAsync(m => m.Id == id);

            if (Funcionario == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
