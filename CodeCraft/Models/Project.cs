namespace CodeCraft.Models

{
    public class Project
    {
        public int Id { get; set; }
        public string Slug { get; set; } = null!;
        public string Title { get; set; } = null!;
        public string? BadgeText { get; set; }
        public string ShortDescription { get; set; } = null!;
        public string? MainImagePath { get; set; }
        public string? ProjectUrl { get; set; }
        //public ProjectStatus Status { get; set; } = ProjectStatus.Completed;
        public DateOnly? CompletedAt { get; set; }

        public int? ServiceId { get; set; }
        public Service? Service { get; set; }

        public int? IndustryId { get; set; }
        public Industry? Industry { get; set; }

        public bool IsPublished { get; set; } = true;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

        // One to One
        public ProjectDetail? Details { get; set; }

        // One to Many
        public ICollection<ProjectImage> Images { get; set; } = new List<ProjectImage>();
        public ICollection<ProjectHighlight> Highlights { get; set; } = new List<ProjectHighlight>();
        public ICollection<ProjectCapability> Capabilities { get; set; } = new List<ProjectCapability>();
        public ICollection<ProjectClientBenefit> ClientBenefits { get; set; } = new List<ProjectClientBenefit>();

        // Many to Many (عبر الجدول الوسيط)
        public ICollection<ProjectSkill> ProjectSkills { get; set; } = new List<ProjectSkill>();
    }
}

