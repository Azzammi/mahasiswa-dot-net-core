using System;
using System.ComponentModel.DataAnnotations;

namespace RazorPageMahasiswa.Models
{
    public class Mahasiswa
    {
        public int ID { get; set; }
        public string NPM { get; set; }
        public string NamaMahasiswa {get;set;}
        public string TempatLahir {get;set;}
        public string ProgramStudy {get;set;}
        // To specify the type of data, only the data is displayed
        [DataType(DataType.Date)]
        public DateTime TanggalLahir { get; set; }
        public string JenisKelamin { get; set; }
        public string Email { get; set; }
        public string Jurusan {get;set;}
    }
}