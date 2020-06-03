namespace ProjectBaker.Domain.Entities
{
    public class Review : BaseEntity
    {
        public int UserId { get; set; }
        public string Text { get; set; }
        public string PostDate { get; set; }
    }
}