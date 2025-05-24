using CSharpFunctionalExtensions;
using DevBoost.SharedKernel.Errors;

namespace DevBoost.Courses.Domain.ValueObjects;

public class CourseDuration : ValueObject
{
    private CourseDuration(double value)
    {
        Value = value;
    }

    public double Value { get; } = default!;

    public static Result<CourseDuration, Error> Create(double value)
    {
        if (value < 0)
            return Errors.General.ValueIsInvalid("duration");

        return new CourseDuration(value);
    }

    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
}