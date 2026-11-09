namespace CodeCraft.Models
{

// جدول وسيط: مشروع <-> تقنية (Many to Many)
public class ProjectSkill
{
    public int ProjectId { get; set; }
    public Project Project { get; set; } = null!;

    public int SkillId { get; set; }
    public TeamSkill Skill { get; set; } = null!;
}
}
