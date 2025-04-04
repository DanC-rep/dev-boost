using DevBoost.SharedKernel.Errors;

namespace DevBoost.Core.Models;

public record Envelope
{
    private Envelope(object? result, IEnumerable<ResponseError>? errors)
    {
        Result = result;
        ResponseErrors = errors?.ToList();
        TimeGenerated = DateTime.Now;
    }
    
    public object? Result { get; }
    
    public IReadOnlyList<ResponseError>? ResponseErrors { get; }
    
    public DateTime TimeGenerated { get; }

    public static Envelope Ok(object? result) =>
        new(result, null);

    public static Envelope Error(ErrorList errors)
    {
        var responseErrors = errors
            .Select(e => new ResponseError(e.Code, e.Message, e.InvalidField)).ToList();

        return new Envelope(null, responseErrors);
    }
}