using Microsoft.EntityFrameworkCore;
using CodeCraft.Models;

namespace CodeCraft.Data
{
    public class ApplicationDbContext: DbContext
    {
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Industry> Industries { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<ProjectCapability> ProjectCapabilities { get; set; }
        public DbSet<ProjectClientBenefit> ProjectClientBenefits { get; set; }
        public DbSet<ProjectDetail> ProjectDetails { get; set; }
        public DbSet<ProjectHighlight> ProjectHighlights { get; set; }
        public DbSet<ProjectImage> ProjectImages { get; set; }
        public DbSet<ProjectRequest> ProjectRequests { get; set; }
        public DbSet<ProjectSkill> ProjectSkills { get; set; }
        //public DbSet<ProjectStatus> ProjectStatuses { get; set; }
        public DbSet<RequestImage> RequestImages { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<TeamMember> TeamMembers { get; set; }
        public DbSet<TeamSkill> TeamSkills { get; set; }




        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {



        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // تعريف المفتاح الأساسي المركب (Composite Primary Key) للجدول الوسيط
            modelBuilder.Entity<ProjectSkill>()
                .HasKey(ps => new { ps.ProjectId, ps.SkillId });
        }

    }
}
