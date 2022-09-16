using System.ComponentModel.DataAnnotations;

namespace Antertainment.DAL.Entities;

public class User
{
    public Guid Id { get; set; }
    [MaxLength(100)]
    [Required]
    public string UserName { get; set; }
    [MaxLength(100)]
    [Required]
    public string Password { get; set; }
    [MaxLength(100)]
    public string Email { get; set; }
    [MaxLength(50)]
    public string FirstName { get; set; }
    [MaxLength(50)]
    public string SecondName { get; set; }
}