namespace Astras.JobPortal.API.Entities
{
    public class Job
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string CompanyName { get; set; } = string.Empty;
        public string Location { get; set; } = string.Empty;
        public DateTime PostedAt { get; set; } = DateTime.UtcNow;
        public int CompanyId { get; set; }
        public required Company Company { get; set; }
        public List<Application> Applications { get; set; } = [];
    }
}
