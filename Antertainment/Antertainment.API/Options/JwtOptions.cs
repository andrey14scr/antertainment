namespace Antertainment.API.Options;

public sealed class JwtOptions
{
    public string SecretKey { get; set; }

    public string Issuer { get; set; }

    public string Audience { get; set; }

    public int Expires { get; set; }
}