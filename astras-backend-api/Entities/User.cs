namespace Astras.JobPortal.API
{
    public class User
    {
        public int Id { get; set; }

        public string FullName { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;

        public string PasswordHash { get; set; } = string.Empty;

        public string? Address { get; set; }

        public string? ProfilePhotoUrl { get; set; }

        public UserRole Role { get; set; } = UserRole.Applicant;

        public List<Application> Applications { get; set; } = [];
    }

    public enum UserRole
    {
        Applicant,
        Admin
    }
}