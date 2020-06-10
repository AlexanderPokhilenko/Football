using System.ComponentModel.DataAnnotations;

namespace DAL.Entities
{
    public class Country : IWithId<int>

    {
    [Key, Required] public int Id { get; set; }
    [Required] public string Name { get; set; }
    }
}
