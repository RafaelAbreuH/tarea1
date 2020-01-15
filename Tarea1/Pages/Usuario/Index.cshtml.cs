using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Tarea1.Data;
using Tarea1.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Tarea1
{
    public class IndexModel : PageModel
    {
        private readonly Tarea1.Data.Tarea1Context _context;

        public IndexModel(Tarea1.Data.Tarea1Context context)
        {
            _context = context;
        }

        public IList<Usuario> Usuario { get;set; }
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        public SelectList Nombres { get; set; }
        [BindProperty(SupportsGet = true)]
        public string UsuarioNombre { get; set; }


        public async Task OnGetAsync()
        {
            var usuarios = from m in _context.Usuario
                         select m;
            if (!string.IsNullOrEmpty(SearchString))
            {
                usuarios = usuarios.Where(s => s.Nombre.Contains(SearchString));
            }
            Usuario = await usuarios.ToListAsync();
        }
    }
}
