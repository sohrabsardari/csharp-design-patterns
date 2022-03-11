namespace Sales.Domain
{
    public class Order
    {
        public long Id { get; private set; }
        public DateTime IssueDate { get; private set; }
        public string Note { get; private set; }

        public Order(long id, string note)
        {
            Id = id;
            Note = note;
            IssueDate = DateTime.UtcNow;
        }
    }
}