namespace InternetBankingSystem.Models
{
    public class Announcement
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Content { get; set; }

        public bool IsActive { get; set; }

        public DateTime CreatedAt { get; set; }
    }
}