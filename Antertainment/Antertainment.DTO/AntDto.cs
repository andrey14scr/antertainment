namespace Antertainment.DTO;

public class AntDto
{
    public Guid Id { get; set; }

    public string Name { get; set; }

    public string Description { get; set; }

    public string Advice { get; set; }

    public virtual IList<ImageDto> Images { get; set; }
}