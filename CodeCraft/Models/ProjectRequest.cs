namespace CodeCraft.Models
{
    public class ProjectRequest
    {
        public int Id { get; set; }
        public string ClientName { get; set; } = null!;
        public string Phone { get; set; } = null!;
        public string? Email { get; set; }
        public string ProjectName { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string? ReferenceLink { get; set; }
        public string? Budget { get; set; }
        public string? Duration { get; set; }

        public int? ServiceId { get; set; }
        public Service? Service { get; set; }

        public int? IndustryId { get; set; }
        public Industry? Industry { get; set; }

        //public RequestStatus Status { get; set; } = RequestStatus.New;
        public string? AdminNotes { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

        public ICollection<RequestImage> Images { get; set; } = new List<RequestImage>();

    }
}


// طلبات العملاء

