namespace ASP_NET.Models
{
    public class Mark
    {

        public Mark()
        {
            Date = DateTime.Now;
        }

        public int MarkId { get; set; }
        public int StudentId { get; set; }
        public Student Student { get; set; }

        public int SubjectId { get; set; }
        public Subject Subject { get; set; }
        public DateTime Date { get; set; }
        public string StudentMark { get; set; }

    }
}
