using System.ComponentModel.DataAnnotations;

namespace Antertainment.DAL.Entities;

public class Ant : BaseEntity
{
    [MaxLength(100)]
    [Required]
    public string Name { get; set; }

    [MaxLength(255)]
    [Required]
    public string Description { get; set; }

    [MaxLength(255)]
    [Required]
    public string Advice { get; set; }

    public virtual IList<Image> Images { get; set; }
}