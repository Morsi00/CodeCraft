namespace CodeCraft.Models
{

// الخدمات (ERP, E-commerce, Web ...)
public class Service
{
    public int Id { get; set; }
    public string Title { get; set; } = null!;
    public string? Description { get; set; }
    public string? IconPath { get; set; }
    public bool IsActive { get; set; } = true;
    public int DisplayOrder { get; set; }

    public ICollection<Project> Projects { get; set; } = new List<Project>();
    public ICollection<ProjectRequest> Requests { get; set; } = new List<ProjectRequest>();
}
}
