using DevBoost.Courses.Domain.Enums;
using DevBoost.SharedKernel.ValueObjects.Ids;

namespace DevBoost.Courses.Domain.Entities.Lessons;

public class VideoLesson : Lesson
{
    public VideoLesson(
        string name,
        string description,
        LessonType lessonType,
        string videoUrl,
        LessonId id) : base(name, description, lessonType, id)
    {
        VideoUrl = videoUrl;
    }

    public string VideoUrl { get; private set; }
}