using Astras.JobPortal.API.Entities;

namespace Astras.JobPortal.API
{
    public class Application
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        public required User User { get; set; }

        public int JobId { get; set; }

        public required Job Job { get; set; }

        public string CVFileUrl { get; set; } = string.Empty;

        public DateTime AppliedAt { get; set; } = DateTime.UtcNow;

        public string? Notes { get; set; }
    }
}