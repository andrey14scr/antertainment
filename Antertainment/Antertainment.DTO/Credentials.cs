namespace Antertainment.DTO;

public record Credentials
{
    public Guid Id { get; set; }

    public string Login { get; set; }

    public string Password { get; set; }
}