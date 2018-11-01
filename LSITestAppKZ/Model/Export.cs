using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LSITestApp
{
    public class Export
    {
        [Key, Display(AutoGenerateField = false)]
        public int Id { get; set; }

        [Display(Name = "Nazwa")]
        [StringLength(255)]
        public string Name { get; set; }

        [Display(Name = "Data")]
        [DisplayFormat(DataFormatString = "yyyy-MM-dd")]
        [Column(TypeName = "Date")]
        public DateTime Date { get; set; }

        [Display(Name = "Godzina")]
        [DisplayFormat(DataFormatString = "{0:hh}:{0:mm}")]
        [Column(TypeName = "Time(0)")]
        public TimeSpan Time { get; set; }

        [Display(Name = "Użytkownik")]
        [StringLength(255)]
        public string User { get; set; }

        [Display(Name = "Lokal")]
        [StringLength(255)]
        public string Place { get; set; }
    }
}
