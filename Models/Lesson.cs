namespace Task.Models
{
    public class Lesson
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal ExamResult { get; set; }
        public string LessonDate { get; set; }
        public List<Student>? Students { get; set; }
    }
}
