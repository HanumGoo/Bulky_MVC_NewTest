using System.ComponentModel.DataAnnotations;

namespace BulkyWeb1.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string name { get; set; }
        public int DisplayOrder { get; set; }
    }
}
