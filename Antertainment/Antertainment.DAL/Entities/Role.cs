using System.ComponentModel.DataAnnotations;

namespace Antertainment.DAL.Entities;

public class Role : BaseEntity
{
    [MaxLength(50)]
    [Required]
    public string RoleName { get; set; }
}