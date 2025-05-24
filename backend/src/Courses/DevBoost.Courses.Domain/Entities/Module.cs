using CSharpFunctionalExtensions;
using DevBoost.Courses.Domain.Entities.Lessons;
using DevBoost.SharedKernel.ValueObjects.Ids;

namespace DevBoost.Courses.Domain.Entities;

public class Module : Entity<ModuleId>
{
    private Module(ModuleId id) : base(id)
    {
    }

    public Module(
        string name,
        string description,
        int serialNumber,
        ModuleId id) : base(id)
    {
        Name = name;
        Description = description;
        SerialNumber = serialNumber;
        CreationDate = DateOnly.FromDateTime(DateTime.Now);
    }

    public string Name { get; private set; } = default!;
    
    public string Description { get; private set; } = default!;
    
    public int SerialNumber { get; private set; } // VO
    
    public DateOnly CreationDate { get; private set; } // VO

    private readonly List<Lesson> _lessons = [];
    
    public IReadOnlyList<Lesson> Lessons => _lessons;
}