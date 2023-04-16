

namespace ASP_NET.Models
{
    public class Subject
    {

        public Subject()
        {
            
        }
        public int SubjectId { get; set; }
        public string Title { get; set; }

        public List<Teacher> Teachers { get; set; }
    }
}
