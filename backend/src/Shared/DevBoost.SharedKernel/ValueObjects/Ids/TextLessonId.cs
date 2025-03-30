using CSharpFunctionalExtensions;

namespace DevBoost.SharedKernel.ValueObjects.Ids;

public class TextLessonId : ValueObject, IComparable<TextLessonId>
{
    private TextLessonId(Guid value)
    {
        Value = value;
    }
    
    public Guid Value { get; }

    public static TextLessonId NewId() => new(Guid.NewGuid());

    public static TextLessonId Empty() => new(Guid.Empty);

    public static TextLessonId Create(Guid id) => new(id);

    public static implicit operator Guid(TextLessonId courseId)
    {
        ArgumentNullException.ThrowIfNull(courseId);
        
        return courseId.Value;
    }
    
    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
    
    public int CompareTo(TextLessonId? courseId)
    {
        if (courseId is null) throw new ArgumentNullException(nameof(courseId));
        return Value.CompareTo(courseId.Value);
    }
}