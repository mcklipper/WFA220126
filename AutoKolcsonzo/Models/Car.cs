using System.ComponentModel.DataAnnotations;

namespace AutoKolcsonzo.Models
{
    public class Car
    {
        [Key]
        public int Id { get; set; }

        [StringLength(20)]
        public string Make { get; set; }

        [StringLength(30)]
        public string Type { get; set; }

        public int Year { get; set; }

        [StringLength(10)]
        public string Fuel { get; set; }
    }
}
