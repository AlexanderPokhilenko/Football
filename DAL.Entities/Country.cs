using System.ComponentModel.DataAnnotations;

namespace DAL.Entities
{
    public class Country
    {
        [Key, Required]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
    }
}
