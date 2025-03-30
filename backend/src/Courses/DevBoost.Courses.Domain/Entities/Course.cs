using CSharpFunctionalExtensions;
using DevBoost.Courses.Domain.Enums;
using DevBoost.SharedKernel.ValueObjects.Ids;

namespace DevBoost.Courses.Domain.Entities;

public class Course : Entity<CourseId>
{
    private Course(CourseId id) : base(id)
    {
    }

    public Course(
        string name,
        string description,
        CourseDifficult courseDifficult,
        int duration,
        IEnumerable<string> requiredSkills,
        DateOnly creationDate,
        string author,
        CourseId id) : base(id)
    {
        Name = name;
        Description = description;
        Difficult = courseDifficult;
        Duration = duration;
        RequiredSkills = requiredSkills.ToList();
        CreationDate = creationDate;
        Author = author;
    }

    public string Name { get; private set; } = default!;

    public string Description { get; private set; } = default!;
    
    public CourseDifficult Difficult { get; private set; }

    public int Duration { get; private set; } // VO
    
    public List<string> RequiredSkills { get; private set; } // VO List
    
    public DateOnly CreationDate { get; private set; } // VO
    
    public string Author { get; private set; } // VO

    private readonly List<Module> _modules = [];
    
    public IReadOnlyList<Module> Modules => _modules;
}