namespace Task.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string ImgUrl { get; set; }
        public string Description { get; set; }
        public bool IsCompletedSpringSem {  get; set; }
        public bool IsCompletedSummerSem {  get; set; }
        public bool IsCompletedFallSem {  get; set; }
        public bool TuitionFeeStatus { get; set; }
        public bool ScholarshipStatus { get; set; }
        public bool RegistrationStatus { get; set; }
        public bool GraduationStatus { get; set; }
        public decimal AvgPoint { get; set; }
        public bool LibraryPenalty { get; set; }
        public int LessonId { get; set; }
        public Lesson? Lesson { get; set; }
        public int BookId { get; set; }
        public Book? Book { get; set; }
        public int SpecialtyId { get; set; }
        public Specialty? Specialty { get; set; }
    }
}
