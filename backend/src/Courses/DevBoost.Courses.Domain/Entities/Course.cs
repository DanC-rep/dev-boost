using CSharpFunctionalExtensions;
using DevBoost.Courses.Domain.Enums;
using DevBoost.Courses.Domain.ValueObjects;
using DevBoost.SharedKernel.ValueObjects;
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
        CourseDuration duration,
        ValueObjectList<Skill> requiredSkills,
        CreationDate creationDate,
        CourseAuthor author,
        CourseId id) : base(id)
    {
        Name = name;
        Description = description;
        Difficult = courseDifficult;
        Duration = duration;
        RequiredSkills = requiredSkills;
        CreationDate = creationDate;
        Author = author;
    }

    public string Name { get; private set; } = default!;

    public string Description { get; private set; } = default!;
    
    public CourseDifficult Difficult { get; private set; }

    public CourseDuration Duration { get; private set; }
    
    public ValueObjectList<Skill> RequiredSkills { get; private set; }
    
    public CreationDate CreationDate { get; private set; }
    
    public CourseAuthor Author { get; private set; }

    private readonly List<Module> _modules = [];
    
    public IReadOnlyList<Module> Modules => _modules;
}