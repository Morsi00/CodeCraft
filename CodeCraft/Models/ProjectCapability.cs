namespace CodeCraft.Models
{

public class ProjectCapability
{
    public int Id { get; set; }

    public int ProjectId { get; set; }
    public Project Project { get; set; } = null!;

    public string? Icon { get; set; }
    public string Title { get; set; } = null!;
    public string? Description { get; set; }
    public int DisplayOrder { get; set; }
}
}
