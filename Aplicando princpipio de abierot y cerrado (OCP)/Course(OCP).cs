using System;

public abstract class Course
{
    public int CourseId { get; set; }
    public string Title { get; set; }

    public abstract void Subscribe(Student std);
    public abstract string GetCourseDetails();
}

public class OnlineCourse : Course
{
    public override void Subscribe(Student std)
    {
        // Código pa inscribirte en un curso en linea
    }

    public override string GetCourseDetails()
    {
        return $"Online Course: {Title}";
    }
}

public class OfflineCourse : Course
{
    public override void Subscribe(Student std)
    {
        // Código para inscribirte a un curso offline
    }

    public override string GetCourseDetails()
    {
        return $"Offline Course: {Title}";
    }
}

public class HybridCourse : Course
{
    private OnlineCourse _onlineCourse;
    private OfflineCourse _offlineCourse;

    public HybridCourse(int courseId, string title)
    {
        CourseId = courseId;
        Title = title;
        _onlineCourse = new OnlineCourse { CourseId = courseId, Title = $"{title} (Online)" };
        _offlineCourse = new OfflineCourse { CourseId = courseId, Title = $"{title} (Offline)" };
    }

    public override void Subscribe(Student std)
    {
        _onlineCourse.Subscribe(std);
        _offlineCourse.Subscribe(std);
    }

    public override string GetCourseDetails()
    {
        return $"Hybrid Course: {Title}\n{_onlineCourse.GetCourseDetails()}\n{_offlineCourse.GetCourseDetails()}";
    }
}

// Este es un ejemplo de estudiante
public class Student
{
    public int StudentId { get; set; }
    public string Name { get; set; }
}

// codigo pa probar la implementacion
public class Program
{
    public static void Main()
    {
        Course onlineCourse = new OnlineCourse { CourseId = 1, Title = "C# Desde 0, empiece hoy" };
        Course offlineCourse = new OfflineCourse { CourseId = 2, Title = "C# avanzado para gaming" };
        Course hybridCourse = new HybridCourse(3, "C# intermedio");

        Student student = new Student { StudentId = 1, Name = "Felix Jose" };

        onlineCourse.Subscribe(student);
        offlineCourse.Subscribe(student);
        hybridCourse.Subscribe(student);

        Console.WriteLine(onlineCourse.GetCourseDetails());
        Console.WriteLine(offlineCourse.GetCourseDetails());
        Console.WriteLine(hybridCourse.GetCourseDetails());
    }
}
