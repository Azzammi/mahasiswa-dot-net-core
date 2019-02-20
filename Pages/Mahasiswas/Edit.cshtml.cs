using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RazorPageMahasiswa.Models;

namespace RazorPageMahasiswa.Pages.Mahasiswas
{
    public class EditModel : PageModel
    {
        private readonly RazorPageMahasiswa.Models.RazorPageMahasiswaContext _context;

        public EditModel(RazorPageMahasiswa.Models.RazorPageMahasiswaContext context)
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

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Mahasiswa).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MahasiswaExists(Mahasiswa.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool MahasiswaExists(int id)
        {
            return _context.Mahasiswa.Any(e => e.ID == id);
        }
    }
}
