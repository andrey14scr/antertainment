namespace Antertainment.DTO;

public class ImageDto
{
    public Guid? Id { get; set; }
    public string FileName { get; set; }
    public string FilePath { get; set; }
    public Guid? UserId { get; set; }
    public Guid? AntId { get; set; }
    public bool IsPrimary { get; set; }
}