using CSharpFunctionalExtensions;

namespace DevBoost.SharedKernel.ValueObjects.Ids;

public class CourseId : ValueObject, IComparable<CourseId>
{
    private CourseId(Guid value)
    {
        Value = value;
    }
    
    public Guid Value { get; }

    public static CourseId NewId() => new(Guid.NewGuid());

    public static CourseId Empty() => new(Guid.Empty);

    public static CourseId Create(Guid id) => new(id);

    public static implicit operator Guid(CourseId courseId)
    {
        ArgumentNullException.ThrowIfNull(courseId);
        
        return courseId.Value;
    }
    
    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public int CompareTo(CourseId? courseId)
    {
        if (courseId is null) throw new ArgumentNullException(nameof(courseId));
        return Value.CompareTo(courseId.Value);
    }
}