namespace ContosoUniversity.Models
{
    public class CourseAssignment
    {
        public int InstructorID { get; set; }
        public int CourseID { get; set; }

        // Navigations
        public Instructor Instructor { get; set; }
        public Course Course { get; set; }
    }
}