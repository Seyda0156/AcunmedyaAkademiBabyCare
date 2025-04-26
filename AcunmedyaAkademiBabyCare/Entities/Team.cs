using System.Security.Claims;

namespace AcunmedyaAkademiBabyCare.Entities
{
    public class Team
    {
        public int TeamId { get; set; }
        public string? NameSurname { get; set; }
        public string? Age { get; set; }
        public string? City { get; set; }
        public string? ImgUrl { get; set; }
        public int BranchId { get; set; }
        public Branch Branch { get; set; }
        List<Class> Classes { get; set; }

    }
}
