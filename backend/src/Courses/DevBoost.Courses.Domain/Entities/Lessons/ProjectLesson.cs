using CSharpFunctionalExtensions;
using DevBoost.SharedKernel.ValueObjects.Ids;

namespace DevBoost.Courses.Domain.Entities.Lessons;

public class ProjectLesson : Entity<ProjectLessonId>
{
    private ProjectLesson(ProjectLessonId id) : base(id)
    {
    }

    public ProjectLesson(
        string content,
        ProjectLessonId id) : base(id)
    {
        Content = content;
    }

    public string Content { get; set; } = default!;

    public LessonId LessonId { get; set; }
}