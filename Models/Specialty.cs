namespace Task.Models
{
    public class Specialty
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Teacher>? Teachers { get; set; }
        public List<Student>? Students { get; set; }
    }
}
