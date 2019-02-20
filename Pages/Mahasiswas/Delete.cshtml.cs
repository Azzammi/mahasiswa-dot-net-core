using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPageMahasiswa.Models;

namespace RazorPageMahasiswa.Pages.Mahasiswas
{
    public class DeleteModel : PageModel
    {
        private readonly RazorPageMahasiswa.Models.RazorPageMahasiswaContext _context;

        public DeleteModel(RazorPageMahasiswa.Models.RazorPageMahasiswaContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Mahasiswa Mahasiswa { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Mahasiswa = await _context.Mahasiswa.FirstOrDefaultAsync(m => m.ID == id);

            if (Mahasiswa == null)
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

            Mahasiswa = await _context.Mahasiswa.FindAsync(id);

            if (Mahasiswa != null)
            {
                _context.Mahasiswa.Remove(Mahasiswa);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
