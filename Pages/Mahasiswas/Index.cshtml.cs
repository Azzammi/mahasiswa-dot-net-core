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
    public class IndexModel : PageModel
    {
        private readonly RazorPageMahasiswa.Models.RazorPageMahasiswaContext _context;

        public IndexModel(RazorPageMahasiswa.Models.RazorPageMahasiswaContext context)
        {
            _context = context;
        }

        public IList<Mahasiswa> Mahasiswa { get;set; }

        public async Task OnGetAsync()
        {
            Mahasiswa = await _context.Mahasiswa.ToListAsync();
        }
    }
}
