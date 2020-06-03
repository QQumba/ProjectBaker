using System;

namespace ProjectBaker.Domain.Entities
{
    public class ProjectParticipant : BaseEntity
    {
        public int ProjectId { get; set; }
        public int UserId { get; set; }
        public string Position { get; set; }
    }
}