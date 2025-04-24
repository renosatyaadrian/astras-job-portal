namespace Astras.JobPortal.API.Entities
{
    public class Company
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; }
        public List<Job> Jobs {get; set; } = [];
    }
}