using DevBoost.Courses.Domain.Enums;
using DevBoost.SharedKernel.ValueObjects.Ids;

namespace DevBoost.Courses.Domain.Entities.Lessons;

public class TextLesson : Lesson
{
    public TextLesson(
        string name,
        string description,
        LessonType lessonType,
        string content,
        LessonId id) : base(name, description, lessonType, id)
    {
        Content = content;
    }

    public string Content { get; private set; }

    public List<string> AdditionalResources { get; private set; } = []; // VO List
}