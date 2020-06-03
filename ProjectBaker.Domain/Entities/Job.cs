namespace ProjectBaker.Domain.Entities
{
    public class Job : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Salary { get; set; }
        public string PostDate { get; set; }
        
        public int EmployeeId { get; set; }

        public int EmployerId { get; set; }
        public int ProjectId { get; set; }
    }
}