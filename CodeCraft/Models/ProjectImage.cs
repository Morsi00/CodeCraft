namespace CodeCraft.Models
{

// معرض الصور مع الشرح
public class ProjectImage
{
    public int Id { get; set; }

    public int ProjectId { get; set; }
    public Project Project { get; set; } = null!;

    public string ImagePath { get; set; } = null!;
    public string? Title { get; set; }
    public string? Description { get; set; }
    public int DisplayOrder { get; set; }
}
}
