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
    public class IndexModel : PageModel
    {
        private readonly sistema_quinta_do_ypua.Data.ApplicationDbContext _context;

        public IndexModel(sistema_quinta_do_ypua.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Contato> Contato { get;set; }

        public async Task OnGetAsync()
        {
            Contato = await _context.Contato.ToListAsync();
        }
    }
}
