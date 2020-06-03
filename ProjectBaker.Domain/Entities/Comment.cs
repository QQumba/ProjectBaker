using System;

namespace ProjectBaker.Domain.Entities
{
    public class Comment : BaseEntity
    {
        public int ProjectId { get; set; }
        public int UserId { get; set; }
        public string Text { get; set; }
        public string PostDate { get; set; }
    }
}
