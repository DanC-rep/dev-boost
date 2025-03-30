using CSharpFunctionalExtensions;
using DevBoost.SharedKernel.ValueObjects.Ids;

namespace DevBoost.Courses.Domain.Entities.Lessons;

public class TextLesson : Entity<TextLessonId>
{
    private TextLesson(TextLessonId id) : base(id)
    {
    }

    public TextLesson(
        string content,
        TextLessonId id) : base(id)
    {
        Content = content;
    }

    public string Content { get; set; } = default!;

    public LessonId LessonId { get; set; }
}