namespace ProjectBaker.Domain.Entities
{
    public class ProjectAccount : BaseEntity 
    {
        public int ProjectId { get; set; }
        public int Amount { get; set; }
        public string Deadline { get; set; }
        public string LastUpdate { get; set; }
    }
}