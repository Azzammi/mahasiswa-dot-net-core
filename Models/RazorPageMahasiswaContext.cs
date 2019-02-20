using Microsoft.EntityFrameworkCore;

namespace RazorPageMahasiswa.Models
{
    public class RazorPageMahasiswaContext : DbContext
    {
        public RazorPageMahasiswaContext (DbContextOptions<RazorPageMahasiswaContext> options)
            : base(options)
        {
        }

        public DbSet<RazorPageMahasiswa.Models.Mahasiswa> Mahasiswa { get; set; }
    }
}