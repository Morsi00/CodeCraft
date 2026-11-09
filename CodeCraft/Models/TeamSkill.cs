namespace CodeCraft.Models
{

// خبرة الفريق (SQL Server, C#, React ...)
public class TeamSkill
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public string? IconPath { get; set; }
    public int DisplayOrder { get; set; }

    public ICollection<ProjectSkill> ProjectSkills { get; set; } = new List<ProjectSkill>();
}
}
