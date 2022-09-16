using System.ComponentModel.DataAnnotations;

namespace Antertainment.DAL.Entities;

public class Image
{
    public Guid Id { get; set; }
    [MaxLength(100)]
    public string FileName { get; set; }
    [MaxLength(255)]
    [Required]
    public string FilePath { get; set; }

    public Guid? AntId { get; set; }
    public virtual Ant Ant { get; set; }
}