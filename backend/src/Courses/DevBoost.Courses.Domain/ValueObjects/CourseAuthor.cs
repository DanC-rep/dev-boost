using CSharpFunctionalExtensions;
using DevBoost.SharedKernel.Errors;

namespace DevBoost.Courses.Domain.ValueObjects;

public class CourseAuthor : ValueObject
{
    private CourseAuthor(string value)
    {
        Value = value;
    }

    public string Value { get; }

    public static Result<CourseAuthor, Error> Create(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
            return Errors.General.ValueIsRequired("author");

        return new CourseAuthor(value);
    }

    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
}