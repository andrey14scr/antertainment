using Microsoft.EntityFrameworkCore;

using System.ComponentModel.DataAnnotations;

namespace Antertainment.DAL.Entities;

[Index(nameof(UserName), nameof(Email), IsUnique = true)]
public class User : BaseEntity
{
    [MaxLength(100)]
    [Required]
    public string UserName { get; set; }

    [MaxLength(100)]
    [Required]
    public string Password { get; set; }

    [MaxLength(100)]
    [Required]
    public string Email { get; set; }

    [MaxLength(50)]
    public string FirstName { get; set; }

    [MaxLength(50)]
    public string SecondName { get; set; }

    public Guid? RoleId { get; set; }
    public virtual Role Role { get; set; }
}