namespace Antertainment.DAL.Entities;

public class Image
{
    public Guid Id { get; set; }
    public string FileName { get; set; }
    public string FilePath { get; set; }

    public Guid AntId { get; set; }
    public virtual Ant Ant { get; set; }
}