using CSharpFunctionalExtensions;
using DevBoost.Courses.Domain.Enums;
using DevBoost.SharedKernel.ValueObjects.Ids;

namespace DevBoost.Courses.Domain.Entities.Lessons;

public abstract class Lesson : Entity<LessonId>
{
    private Lesson(LessonId id) : base(id)
    {
    }

    protected Lesson(
        string name,
        string description,
        LessonType lessonType,
        LessonId id) : base(id)
    {
        Name = name;
        Description = description;
        Type = lessonType;
    }

    public string Name { get; private set; } = default!;
    
    public string Description { get; private set; } = default!;
    
    public LessonType Type { get; private set; }
}