using Autofac;
using EgitimPortal.Business.ValidationRules.FluentValidation;
using EgitimPortal.Entities.Concrete;
using EgitimPortalProject.Core.Entities.Concrete;
using FluentValidation;
using Module = Autofac.Module;

namespace EgitimPortalProject.Business.DependencyResolvers.Autofac
{
    public class AutoFacValidationModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            // program.cs de eklendi burada gerek kalmayabilir denenecek
            builder.RegisterAssemblyTypes(ThisAssembly)
                    .Where(t => t.Name.EndsWith("Validator"))
                    .AsImplementedInterfaces()
                    .InstancePerLifetimeScope();

            builder.RegisterType<IValidator<Announcements>>().As<AnnouncementsValidatior>().SingleInstance();
            builder.RegisterType<IValidator<AnnouncementUsers>>().As<AnnouncementUsersValidatior>().SingleInstance();
            builder.RegisterType<IValidator<AuditLogs>>().As<AuditLogsValidatior>().SingleInstance();
            builder.RegisterType<IValidator<Categories>>().As<CategoriesValidatior>().SingleInstance();
            builder.RegisterType<IValidator<Cauntries>>().As<CauntriesValidatior>().SingleInstance();
            builder.RegisterType<IValidator<Cities>>().As<CitiesValidatior>().SingleInstance();
            builder.RegisterType<IValidator<CourseCategories>>().As<CourseCategoriesValidatior>().SingleInstance();
            builder.RegisterType<IValidator<Courses>>().As<CoursesValidatior>().SingleInstance();
            builder.RegisterType<IValidator<CourseTeachers>>().As<CourseTeachersValidatior>().SingleInstance();
            builder.RegisterType<IValidator<Districts>>().As<DistrictsValidatior>().SingleInstance();
            builder.RegisterType<IValidator<ExamQuestionMap>>().As<ExamQuestionMapValidatior>().SingleInstance();
            builder.RegisterType<IValidator<Exams>>().As<ExamsValidatior>().SingleInstance();
            builder.RegisterType<IValidator<ExamTest>>().As<ExamTestValidatior>().SingleInstance();
            builder.RegisterType<IValidator<ExamType>>().As<ExamTypeValidatior>().SingleInstance();
            builder.RegisterType<IValidator<Gender>>().As<GenderValidatior>().SingleInstance();
            builder.RegisterType<IValidator<Language>>().As<LanguageValidatior>().SingleInstance();
            builder.RegisterType<IValidator<LanguageText>>().As<LanguageTextValidatior>().SingleInstance();
            builder.RegisterType<IValidator<LessonCategories>>().As<LessonCategoriesValidatior>().SingleInstance();
            builder.RegisterType<IValidator<LessonMaterials>>().As<LessonMaterialsValidatior>().SingleInstance();
            builder.RegisterType<IValidator<Lessons>>().As<LessonsValidatior>().SingleInstance();
            builder.RegisterType<IValidator<MaterialTypes>>().As<MaterialTypesValidatior>().SingleInstance();
            builder.RegisterType<IValidator<Permissions>>().As<PermissionsValidatior>().SingleInstance();
            builder.RegisterType<IValidator<PermissionTypes>>().As<PermissionTypesValidatior>().SingleInstance();
            builder.RegisterType<IValidator<PrivateCourseLessons>>().As<PrivateCourseLessonsValidatior>().SingleInstance();
            builder.RegisterType<IValidator<QuestionAnswers>>().As<QuestionAnswersValidatior>().SingleInstance();
            builder.RegisterType<IValidator<QuestionCorrectAnswers>>().As<QuestionCorrectAnswersValidatior>().SingleInstance();
            builder.RegisterType<IValidator<QuestionLevels>>().As<QuestionLevelsValidatior>().SingleInstance();
            builder.RegisterType<IValidator<QuestionOptions>>().As<QuestionOptionsValidatior>().SingleInstance();
            builder.RegisterType<IValidator<QuestionOptionsMap>>().As<QuestionOptionsMapValidatior>().SingleInstance();
            builder.RegisterType<IValidator<QuestionOptionTypes>>().As<QuestionOptionTypesValidatior>().SingleInstance();
            builder.RegisterType<IValidator<Questions>>().As<QuestionsValidatior>().SingleInstance();
            builder.RegisterType<IValidator<QuestionTypes>>().As<QuestionTypesValidatior>().SingleInstance();
            builder.RegisterType<IValidator<Roles>>().As<RolesValidatior>().SingleInstance();
            builder.RegisterType<IValidator<Settings>>().As<SettingsValidatior>().SingleInstance();
            builder.RegisterType<IValidator<StudentCourses>>().As<StudentCoursesValidatior>().SingleInstance();
            builder.RegisterType<IValidator<StudentCourseWatchLog>>().As<StudentCourseWatchLogValidatior>().SingleInstance();
            builder.RegisterType<IValidator<Students>>().As<StudentsValidatior>().SingleInstance();
            builder.RegisterType<IValidator<SurveyQuestionAnswers>>().As<SurveyQuestionAnswersValidatior>().SingleInstance();
            builder.RegisterType<IValidator<SurveyQuestionOptionMap>>().As<SurveyQuestionOptionMapValidatior>().SingleInstance();
            builder.RegisterType<IValidator<SurveyQuestionOptions>>().As<SurveyQuestionOptionsValidatior>().SingleInstance();
            builder.RegisterType<IValidator<SurveyQuestionOptionsTypes>>().As<SurveyQuestionOptionsTypesValidatior>().SingleInstance();
            builder.RegisterType<IValidator<SurveyQuestions>>().As<SurveyQuestionsValidatior>().SingleInstance();
            builder.RegisterType<IValidator<Surveys>>().As<SurveysValidatior>().SingleInstance();
            builder.RegisterType<IValidator<TeacherCourseLessons>>().As<TeacherCourseLessonsValidatior>().SingleInstance();
            builder.RegisterType<IValidator<Teachers>>().As<TeachersValidatior>().SingleInstance();
            builder.RegisterType<IValidator<TestExamTypes>>().As<TestExamTypesValidatior>().SingleInstance();
            builder.RegisterType<IValidator<UserRoles>>().As<UserRolesValidatior>().SingleInstance();
            builder.RegisterType<IValidator<Users>>().As<UsersValidatior>().SingleInstance();

            builder.RegisterType<AutofacValidatorFactory>().As<IValidatorFactory>().SingleInstance();

            base.Load(builder);
        }
    }
}