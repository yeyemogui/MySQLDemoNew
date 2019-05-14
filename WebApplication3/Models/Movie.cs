using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication3.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Release Date")]
        public DateTime ReleaseDate { get; set; }
        [StringLength(30)]
        public string Genre { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        [Range(1,100)]
        public decimal Price { get; set; }

        [Display(Name = "Rate")]
        [StringLength(1)]
        [Required]
        [RegularExpression(@"^[A|S|N]")]
        public string Rating { get; set; }
    }
}
