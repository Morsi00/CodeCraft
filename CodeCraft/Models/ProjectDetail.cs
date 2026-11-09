namespace CodeCraft.Models
{
    public class ProjectDetail
    {
        public int Id { get; set; }

        public int ProjectId { get; set; }
        public Project Project { get; set; } = null!;

        public string? CaseCode { get; set; }
        public string? ProjectType { get; set; }
        public string? ClientName { get; set; }
        public string? ServiceSummary { get; set; }
        public string? ChallengeText { get; set; }
        public string? SolutionText { get; set; }
    }
}
