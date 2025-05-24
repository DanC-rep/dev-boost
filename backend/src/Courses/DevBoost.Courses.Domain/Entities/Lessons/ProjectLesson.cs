using DevBoost.Courses.Domain.Enums;
using DevBoost.SharedKernel.ValueObjects.Ids;

namespace DevBoost.Courses.Domain.Entities.Lessons;

public class ProjectLesson : Lesson
{
    public ProjectLesson(
        string name,
        string description,
        LessonType lessonType,
        ProgrammingLanguage language,
        List<string> projectFiles,
        LessonId id) : base(name, description, lessonType, id)
    {
        Language = language;
        ProjectFiles = projectFiles;
    }

    public ProgrammingLanguage Language { get; private set; }
    
    public List<string> ProjectFiles { get; private set; }
}