namespace Antertainment.DTO;

public class UserDto
{
    public Guid Id { get; set; }

    public string UserName { get; set; }

    public string Email { get; set; }

    public string FirstName { get; set; }

    public string SecondName { get; set; }

    public string Token { get; set; }
}