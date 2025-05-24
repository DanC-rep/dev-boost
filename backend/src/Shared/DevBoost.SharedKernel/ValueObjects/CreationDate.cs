using CSharpFunctionalExtensions;
using DevBoost.SharedKernel.Errors;

namespace DevBoost.SharedKernel.ValueObjects;

public class CreationDate : ValueObject
{
    private CreationDate(DateTime value)
    {
        Value = value;
    }
    
    public DateTime Value { get; }

    public static Result<CreationDate, Error> Create(DateTime value)
    {
        if (value > DateTime.Now)
            return Errors.Errors.General.ValueIsInvalid("creation date");

        return new CreationDate(value);
    }

    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
}