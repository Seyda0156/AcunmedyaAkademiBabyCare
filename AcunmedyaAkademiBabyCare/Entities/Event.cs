namespace AcunmedyaAkademiBabyCare.Entities
{
    public class Event
    {
        public int EventId { get; set; }
        public string? EventName { get; set; }
        public string? Description { get; set; }
        public DateTime Date { get; set; }
        public string? Time { get; set; }
        public string? City { get; set; }
        public string? ImgUrl { get; set; }
    }
}
