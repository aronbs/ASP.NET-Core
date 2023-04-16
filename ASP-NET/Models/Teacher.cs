namespace ASP_NET.Models
{
    public class Teacher
    {

        public Teacher()
        {

        }
        public int TeacherId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }
        public List<Subject> Subjects { get; set; }
    }
}
