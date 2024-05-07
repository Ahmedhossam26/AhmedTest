using System.ComponentModel.DataAnnotations;

namespace AhmedTest.Models
{
    public class Item
    {
        [Key]
        public int id { get; set; }
        [Required]
        public string name { get; set; }
        [Required]
        public decimal price { get; set; }

        public DateTime CreatedData { get; set; } = DateTime.Now;
    }
}
