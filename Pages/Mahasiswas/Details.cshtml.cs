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
    public class DetailsModel : PageModel
    {
        private readonly RazorPageMahasiswa.Models.RazorPageMahasiswaContext _context;

        public DetailsModel(RazorPageMahasiswa.Models.RazorPageMahasiswaContext context)
        {
            _context = context;
        }

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
    }
}
