using System.ComponentModel.DataAnnotations;

namespace Antertainment.DAL.Entities;

public class Image : BaseEntity
{
    [MaxLength(100)]
    public string FileName { get; set; }

    [MaxLength(255)]
    [Required]
    public string FilePath { get; set; }

    public bool IsPrimary { get; set; }

    public Guid? UserId { get; set; }
    public virtual User User { get; set; }

    public Guid? AntId { get; set; }
    public virtual Ant Ant { get; set; }
}