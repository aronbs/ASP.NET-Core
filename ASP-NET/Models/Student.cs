namespace ASP_NET.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
         
        public int GroupId { get; set; } //Foreign key

        public Group Group { get; set; }
    }
}
