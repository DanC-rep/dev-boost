using CSharpFunctionalExtensions;
using DevBoost.SharedKernel.ValueObjects.Ids;

namespace DevBoost.Courses.Domain.Entities.Lessons;

public class VideoLesson : Entity<VideoLessonId>
{
    private VideoLesson(VideoLessonId id) : base(id)
    {
    }

    public VideoLesson(
        string content,
        VideoLessonId id) : base(id)
    {
        Content = content;
    }

    public string Content { get; set; } = default!;

    public LessonId LessonId { get; set; }
}