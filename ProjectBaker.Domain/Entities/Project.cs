using System.Net.Security;
using System.Reflection.Metadata.Ecma335;

namespace ProjectBaker.Domain.Entities
{
    public class Project
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        /// <summary>
        /// Project owner
        /// </summary>
        public int UserId { get; set; }
        public string PostDate { get; set; }
        public int FundGoal { get; set; }
        public int RatingPoints { get; set; }
    }
}