namespace InternetBankingSystem.Models
{
    public class Transaction
    {
        public int Id { get; set; }

        public int SenderAccountId { get; set; }

        public int? ReceiverAccountId { get; set; }

        public string? ReceiverIban { get; set; }

        public string? ReceiverName { get; set; }

        public decimal Amount { get; set; }

        public string Currency { get; set; }

        public string? Description { get; set; }

        public string TransactionType { get; set; }

        public string Status { get; set; }

        public DateTime TransactionDate { get; set; }
        public Account SenderAccount { get; set; }

        public Account? ReceiverAccount { get; set; }
    }
}