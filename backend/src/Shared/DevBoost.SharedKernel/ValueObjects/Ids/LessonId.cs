using CSharpFunctionalExtensions;

namespace DevBoost.SharedKernel.ValueObjects.Ids;

public class LessonId : ValueObject, IComparable<LessonId>
{
    private LessonId(Guid value)
    {
        Value = value;
    }
    
    public Guid Value { get; }

    public static LessonId NewId() => new(Guid.NewGuid());

    public static LessonId Empty() => new(Guid.Empty);

    public static LessonId Create(Guid id) => new(id);

    public static implicit operator Guid(LessonId courseId)
    {
        ArgumentNullException.ThrowIfNull(courseId);
        
        return courseId.Value;
    }
    
    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
    
    public int CompareTo(LessonId? lessonId)
    {
        if (lessonId is null) throw new ArgumentNullException(nameof(lessonId));
        return Value.CompareTo(lessonId.Value);
    }
}