using System.ComponentModel.DataAnnotations;

namespace AutoKolcsonzo.Models
{
    public class Renter
    {
        [Key]
        public int Id { get; set; }

        [StringLength(80)]
        public string Name { get; set; }

        [StringLength(200)]
        public string Address { get; set; }

        public bool IsRegular { get; set; }

    }
}
