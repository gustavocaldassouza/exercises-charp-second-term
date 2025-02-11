namespace WorkspaceCSharp;

public class ExerciseFirstArray
{
    class Professor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float Seniority { get; set; }
        public List<Discipline> ListOfDisciplines { get; set; }
    }

    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Course> CompletedCourses { get; set; }
    }

    class Course
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Hours { get; set; }
        public Discipline Discipline { get; set; }
        public List<Course> Prerequisites { get; set; }
    }

    class Discipline
    {
        public int Id { get; set; }
        public string Title { get; set; }
    }
}

