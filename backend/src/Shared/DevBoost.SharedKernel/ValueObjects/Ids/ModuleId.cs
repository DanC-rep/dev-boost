using CSharpFunctionalExtensions;

namespace DevBoost.SharedKernel.ValueObjects.Ids;

public class ModuleId : ValueObject, IComparable<ModuleId>
{
    private ModuleId(Guid value)
    {
        Value = value;
    }
    
    public Guid Value { get; }

    public static ModuleId NewId() => new(Guid.NewGuid());

    public static ModuleId Empty() => new(Guid.Empty);

    public static ModuleId Create(Guid id) => new(id);

    public static implicit operator Guid(ModuleId courseId)
    {
        ArgumentNullException.ThrowIfNull(courseId);
        
        return courseId.Value;
    }
    
    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
    
    public int CompareTo(ModuleId? courseId)
    {
        if (courseId is null) throw new ArgumentNullException(nameof(courseId));
        return Value.CompareTo(courseId.Value);
    }
}