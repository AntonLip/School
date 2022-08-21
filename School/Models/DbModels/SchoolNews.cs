using School.Models.Interfaces;

namespace School.Models.DbModels
{
    public class SchoolNews : IEntity<Guid>
    {
        public Guid Id { get; set; }
        public string NewsName { get; set; }
        public string NewsText { get; set; }
        public string PathIcon { get; set; }
        public DateTime CretedDate { get; set; }
    }
}
