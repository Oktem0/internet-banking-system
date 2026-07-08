namespace InternetBankingSystem.Models
{
    public class Account
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        public string AccountNumber { get; set; }

        public string IBAN { get; set; }

        public string Currency { get; set; }

        public decimal Balance { get; set; }

        public DateTime CreatedAt { get; set; }

        public User User { get; set; }
    }
}