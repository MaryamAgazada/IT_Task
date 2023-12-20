namespace Task.Models
{
    public class Teacher
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; } 
        public string ImgUrl { get; set; }
        public int SpecialtyId { get; set; }
        public Specialty? Specialty { get; set; }

    }
}
