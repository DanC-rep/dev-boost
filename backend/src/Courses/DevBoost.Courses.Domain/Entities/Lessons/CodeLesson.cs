using CSharpFunctionalExtensions;
using DevBoost.SharedKernel.ValueObjects.Ids;

namespace DevBoost.Courses.Domain.Entities.Lessons;

public class CodeLesson : Entity<CodeLessonId>
{
    private CodeLesson(CodeLessonId id) : base(id)
    {
    }

    public CodeLesson(
        string content,
        CodeLessonId id) : base(id)
    {
        Content = content;
    }

    public string Content { get; set; } = default!;

    public LessonId LessonId { get; set; }
}