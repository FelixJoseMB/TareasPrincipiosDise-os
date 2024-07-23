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
        // Aqui, codigo para suscribirse a un curso en linea
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
        // Aqui, codigo para suscribirse a un curso Presencial
    }

    public override string GetCourseDetails()
    {
        return $"Offline Course: {Title}";
    }
}

public class HybridCourse : Course
{
    public override void Subscribe(Student std)
    {
        // Aqui, codigo para suscribirse a un curso Hibrido
    }

    public override string GetCourseDetails()
    {
        return $"Hybrid Course: {Title}";
    }
}


public class Student
{
    public int StudentId { get; set; }
    public string Name { get; set; }
}

// Este codigo es para probar la implementación
public class Program
{
    public static void Main()
    {
        Course onlineCourse = new OnlineCourse { CourseId = 1, Title = "C# para principiantes" };
        Course offlineCourse = new OfflineCourse { CourseId = 2, Title = "c# avanzado" };
        Course hybridCourse = new HybridCourse { CourseId = 3, Title = "C# Intermedio" };

        Student student = new Student { StudentId = 1, Name = "Carlos montana montana" };

        onlineCourse.Subscribe(student);
        offlineCourse.Subscribe(student);
        hybridCourse.Subscribe(student);

        Console.WriteLine(onlineCourse.GetCourseDetails());
        Console.WriteLine(offlineCourse.GetCourseDetails());
        Console.WriteLine(hybridCourse.GetCourseDetails());
    }
}
