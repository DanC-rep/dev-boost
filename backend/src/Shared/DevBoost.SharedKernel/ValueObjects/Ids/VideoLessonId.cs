using CSharpFunctionalExtensions;

namespace DevBoost.SharedKernel.ValueObjects.Ids;

public class VideoLessonId : ValueObject, IComparable<VideoLessonId>
{
    private VideoLessonId(Guid value)
    {
        Value = value;
    }
    
    public Guid Value { get; }

    public static VideoLessonId NewId() => new(Guid.NewGuid());

    public static VideoLessonId Empty() => new(Guid.Empty);

    public static VideoLessonId Create(Guid id) => new(id);

    public static implicit operator Guid(VideoLessonId courseId)
    {
        ArgumentNullException.ThrowIfNull(courseId);
        
        return courseId.Value;
    }
    
    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
    
    public int CompareTo(VideoLessonId? courseId)
    {
        if (courseId is null) throw new ArgumentNullException(nameof(courseId));
        return Value.CompareTo(courseId.Value);
    }
}