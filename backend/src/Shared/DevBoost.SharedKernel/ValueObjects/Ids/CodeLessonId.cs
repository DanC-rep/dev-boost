using CSharpFunctionalExtensions;

namespace DevBoost.SharedKernel.ValueObjects.Ids;

public class CodeLessonId : ValueObject, IComparable<CodeLessonId>
{
    private CodeLessonId(Guid value)
    {
        Value = value;
    }
    
    public Guid Value { get; }

    public static CodeLessonId NewId() => new(Guid.NewGuid());

    public static CodeLessonId Empty() => new(Guid.Empty);

    public static CodeLessonId Create(Guid id) => new(id);

    public static implicit operator Guid(CodeLessonId courseId)
    {
        ArgumentNullException.ThrowIfNull(courseId);
        
        return courseId.Value;
    }
    
    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
    
    public int CompareTo(CodeLessonId? courseId)
    {
        if (courseId is null) throw new ArgumentNullException(nameof(courseId));
        return Value.CompareTo(courseId.Value);
    }
}