using DevBoost.Courses.Domain.Enums;
using DevBoost.SharedKernel.ValueObjects.Ids;

namespace DevBoost.Courses.Domain.Entities.Lessons;

public class CodeLesson : Lesson
{
    public CodeLesson(
        string name,
        string description,
        LessonType lessonType,
        ProgrammingLanguage language,
        string? starterCode,
        string? solutionCode,
        string expectedOutput,
        LessonId id) : base(name, description, lessonType, id)
    {
        Language = language;
        StarterCode = starterCode;
        SolutionCode = solutionCode;
        ExpectedOutput = expectedOutput;
    }

    public string Code { get; private set; } = default!;
    
    public ProgrammingLanguage Language { get; private set; }
    
    /// <summary>
    /// Шаблон для задания
    /// </summary>
    public string? StarterCode { get; private set; }
    
    /// <summary>
    /// Решение для проверки
    /// </summary>
    public string? SolutionCode { get; private set; }
    
    public string ExpectedOutput { get; private set; } // заглушка
    
    // Тест-кейсы
    // Environment
}