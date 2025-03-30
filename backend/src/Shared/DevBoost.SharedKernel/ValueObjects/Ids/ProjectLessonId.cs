using CSharpFunctionalExtensions;

namespace DevBoost.SharedKernel.ValueObjects.Ids;

public class ProjectLessonId : ValueObject, IComparable<ProjectLessonId>
{
    private ProjectLessonId(Guid value)
    {
        Value = value;
    }
    
    public Guid Value { get; }

    public static ProjectLessonId NewId() => new(Guid.NewGuid());

    public static ProjectLessonId Empty() => new(Guid.Empty);

    public static ProjectLessonId Create(Guid id) => new(id);

    public static implicit operator Guid(ProjectLessonId courseId)
    {
        ArgumentNullException.ThrowIfNull(courseId);
        
        return courseId.Value;
    }
    
    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
    
    public int CompareTo(ProjectLessonId? courseId)
    {
        if (courseId is null) throw new ArgumentNullException(nameof(courseId));
        return Value.CompareTo(courseId.Value);
    }
}