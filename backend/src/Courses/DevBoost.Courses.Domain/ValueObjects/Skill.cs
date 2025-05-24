using CSharpFunctionalExtensions;
using DevBoost.SharedKernel.Errors;

namespace DevBoost.Courses.Domain.ValueObjects;

public class Skill : ValueObject
{
    private Skill(string value)
    {
        Value = value;
    }

    public string Value { get; }

    public static Result<Skill, Error> Create(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
            return Errors.General.ValueIsRequired("skill");

        return new Skill(value);
    }

    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
}