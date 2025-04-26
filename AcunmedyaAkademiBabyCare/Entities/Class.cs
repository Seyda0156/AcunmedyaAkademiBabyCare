using NuGet.DependencyResolver;

namespace AcunmedyaAkademiBabyCare.Entities
{
    public class Class
    {
        public int ClassId { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? ImgUrl { get; set; }
        public double? Price { get; set; }
        public string? StudentCount { get; set; }
        public string? LessonCount { get; set; }
        public string? ClassTime { get; set; }

        public int? TeamId { get; set; }
        public Team Team { get; set; }
    }
}
