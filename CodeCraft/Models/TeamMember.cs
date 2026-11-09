namespace CodeCraft.Models
{

// أعضاء الفريق (مستقلين تمامًا)
public class TeamMember
{
    public int Id { get; set; }
    public string FullName { get; set; } = null!;
    public string JobTitle { get; set; } = null!;
    public string? ImagePath { get; set; }
    public bool IsActive { get; set; } = true;
}
}
