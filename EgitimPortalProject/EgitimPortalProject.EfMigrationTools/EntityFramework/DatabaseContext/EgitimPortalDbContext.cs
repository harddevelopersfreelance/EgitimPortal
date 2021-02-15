using EgitimPortal.Entities.Concrete;
using EgitimPortalProject.Core.Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace EgitimPortalProject.EfMigrationTools.EntityFramework.DatabaseContext
{
    public class EgitimPortalDbContext : DbContext
    {
        public EgitimPortalDbContext()
        {
        }

        public EgitimPortalDbContext(DbContextOptionsBuilder optionsBuilder) : base()
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=EgitimPortal;Trusted_Connection=True;");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=EgitimPortal;Trusted_Connection=True;");
            }
        }

        public virtual DbSet<Announcements> Announcements { get; set; }
        public virtual DbSet<AnnouncementUsers> AnnouncementUsers { get; set; }
        public virtual DbSet<AuditLogs> AuditLogs { get; set; }
        public virtual DbSet<Categories> Categories { get; set; }
        public virtual DbSet<Cauntries> Cauntries { get; set; }
        public virtual DbSet<Cities> Cities { get; set; }
        public virtual DbSet<CourseCategories> CourseCategories { get; set; }
        public virtual DbSet<Courses> Courses { get; set; }
        public virtual DbSet<CourseTeachers> CourseTeachers { get; set; }
        public virtual DbSet<Districts> Districts { get; set; }
        public virtual DbSet<ExamQuestionMap> ExamQuestionMap { get; set; }
        public virtual DbSet<Exams> Exams { get; set; }
        public virtual DbSet<ExamTest> ExamTest { get; set; }
        public virtual DbSet<ExamType> ExamType { get; set; }
        public virtual DbSet<Gender> Gender { get; set; }
        public virtual DbSet<Language> Language { get; set; }
        public virtual DbSet<LanguageText> LanguageText { get; set; }
        public virtual DbSet<LessonCategories> LessonCategories { get; set; }
        public virtual DbSet<LessonMaterials> LessonMaterials { get; set; }
        public virtual DbSet<Lessons> Lessons { get; set; }
        public virtual DbSet<MaterialTypes> MaterialTypes { get; set; }
        public virtual DbSet<Permissions> Permissions { get; set; }
        public virtual DbSet<PermissionTypes> PermissionTypes { get; set; }
        public virtual DbSet<PrivateCourseLessons> PrivateCourseLessons { get; set; }
        public virtual DbSet<QuestionAnswers> QuestionAnswers { get; set; }
        public virtual DbSet<QuestionCorrectAnswers> QuestionCorrectAnswers { get; set; }
        public virtual DbSet<QuestionLevels> QuestionLevels { get; set; }
        public virtual DbSet<QuestionOptions> QuestionOptions { get; set; }
        public virtual DbSet<QuestionOptionsMap> QuestionOptionsMap { get; set; }
        public virtual DbSet<QuestionOptionTypes> QuestionOptionTypes { get; set; }
        public virtual DbSet<Questions> Questions { get; set; }
        public virtual DbSet<QuestionTypes> QuestionTypes { get; set; }
        public virtual DbSet<Roles> Roles { get; set; }
        public virtual DbSet<Settings> Settings { get; set; }
        public virtual DbSet<StudentCourses> StudentCourses { get; set; }
        public virtual DbSet<StudentCourseWatchLog> StudentCourseWatchLog { get; set; }
        public virtual DbSet<Students> Students { get; set; }
        public virtual DbSet<SurveyQuestionAnswers> SurveyQuestionAnswers { get; set; }
        public virtual DbSet<SurveyQuestionOptionMap> SurveyQuestionOptionMap { get; set; }
        public virtual DbSet<SurveyQuestionOptions> SurveyQuestionOptions { get; set; }
        public virtual DbSet<SurveyQuestionOptionsTypes> SurveyQuestionOptionsTypes { get; set; }
        public virtual DbSet<SurveyQuestions> SurveyQuestions { get; set; }
        public virtual DbSet<Surveys> Surveys { get; set; }
        public virtual DbSet<TeacherCourseLessons> TeacherCourseLessons { get; set; }
        public virtual DbSet<Teachers> Teachers { get; set; }
        public virtual DbSet<TestExamTypes> TestExamTypes { get; set; }
        public virtual DbSet<UserRoles> UserRoles { get; set; }
        public virtual DbSet<Users> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //modelBuilder  IEntityTypeConfiguration bakılacak

            modelBuilder.Entity<Announcements>().ToTable("Announcements").HasKey(x => x.Id);
            modelBuilder.Entity<AnnouncementUsers>().ToTable("AnnouncementUsers").HasKey(x => x.Id);
            modelBuilder.Entity<AuditLogs>().ToTable("AuditLogs").HasKey(x => x.Id);
            modelBuilder.Entity<Categories>().ToTable("Categories").HasKey(x => x.Id);
            modelBuilder.Entity<Cauntries>().ToTable("Cauntries").HasKey(x => x.Id);
            modelBuilder.Entity<Cities>().ToTable("Cities").HasKey(x => x.Id);
            modelBuilder.Entity<CourseCategories>().ToTable("CourseCategories").HasKey(x => x.Id);
            modelBuilder.Entity<Courses>().ToTable("Courses").HasKey(x => x.Id);
            modelBuilder.Entity<CourseTeachers>().ToTable("CourseTeachers").HasKey(x => x.Id);
            modelBuilder.Entity<Districts>().ToTable("Districts").HasKey(x => x.Id);
            modelBuilder.Entity<ExamQuestionMap>().ToTable("ExamQuestionMap").HasKey(x => x.Id);
            modelBuilder.Entity<Exams>().ToTable("Exams").HasKey(x => x.Id);
            modelBuilder.Entity<ExamTest>().ToTable("ExamTest").HasKey(x => x.Id);
            modelBuilder.Entity<ExamType>().ToTable("ExamType").HasKey(x => x.Id);
            modelBuilder.Entity<Gender>().ToTable("Gender").HasKey(x => x.Id);
            modelBuilder.Entity<Language>().ToTable("Language").HasKey(x => x.Id);
            modelBuilder.Entity<LanguageText>().ToTable("LanguageText").HasKey(x => x.Id);
            modelBuilder.Entity<LessonCategories>().ToTable("LessonCategories").HasKey(x => x.Id);
            modelBuilder.Entity<LessonMaterials>().ToTable("LessonMaterials").HasKey(x => x.Id);
            modelBuilder.Entity<Lessons>().ToTable("Lessons").HasKey(x => x.Id);
            modelBuilder.Entity<MaterialTypes>().ToTable("MaterialTypes").HasKey(x => x.Id);
            modelBuilder.Entity<Permissions>().ToTable("Permissions").HasKey(x => x.Id);
            modelBuilder.Entity<PermissionTypes>().ToTable("PermissionTypes").HasKey(x => x.Id);
            modelBuilder.Entity<PrivateCourseLessons>().ToTable("PrivateCourseLessons").HasKey(x => x.Id);
            modelBuilder.Entity<QuestionAnswers>().ToTable("QuestionAnswers").HasKey(x => x.Id);
            modelBuilder.Entity<QuestionCorrectAnswers>().ToTable("QuestionCorrectAnswers").HasKey(x => x.Id);
            modelBuilder.Entity<QuestionLevels>().ToTable("QuestionLevels").HasKey(x => x.Id);
            modelBuilder.Entity<QuestionOptions>().ToTable("QuestionOptions").HasKey(x => x.Id);
            modelBuilder.Entity<QuestionOptionsMap>().ToTable("QuestionOptionsMap").HasKey(x => x.Id);
            modelBuilder.Entity<QuestionOptionTypes>().ToTable("QuestionOptionTypes").HasKey(x => x.Id);
            modelBuilder.Entity<Questions>().ToTable("Questions").HasKey(x => x.Id);
            modelBuilder.Entity<QuestionTypes>().ToTable("QuestionTypes").HasKey(x => x.Id);
            modelBuilder.Entity<Roles>().ToTable("Roles").HasKey(x => x.Id);
            modelBuilder.Entity<Settings>().ToTable("Settings").HasKey(x => x.Id);
            modelBuilder.Entity<StudentCourses>().ToTable("StudentCourses").HasKey(x => x.Id);
            modelBuilder.Entity<StudentCourseWatchLog>().ToTable("StudentCourseWatchLog").HasKey(x => x.Id);
            modelBuilder.Entity<Students>().ToTable("Students").HasKey(x => x.Id);
            modelBuilder.Entity<SurveyQuestionAnswers>().ToTable("SurveyQuestionAnswers").HasKey(x => x.Id);
            modelBuilder.Entity<SurveyQuestionOptionMap>().ToTable("SurveyQuestionOptionMap").HasKey(x => x.Id);
            modelBuilder.Entity<SurveyQuestionOptions>().ToTable("SurveyQuestionOptions").HasKey(x => x.Id);
            modelBuilder.Entity<SurveyQuestionOptionsTypes>().ToTable("SurveyQuestionOptionsTypes").HasKey(x => x.Id);
            modelBuilder.Entity<SurveyQuestions>().ToTable("SurveyQuestions").HasKey(x => x.Id);
            modelBuilder.Entity<Surveys>().ToTable("Surveys").HasKey(x => x.Id);
            modelBuilder.Entity<TeacherCourseLessons>().ToTable("TeacherCourseLessons").HasKey(x => x.Id);
            modelBuilder.Entity<Teachers>().ToTable("Teachers").HasKey(x => x.Id);
            modelBuilder.Entity<TestExamTypes>().ToTable("TestExamTypes").HasKey(x => x.Id);
            modelBuilder.Entity<UserRoles>().ToTable("UserRoles").HasKey(x => x.Id);
            modelBuilder.Entity<Users>().ToTable("Users").HasKey(x => x.Id);
            //modelBuilder.Entity<Users>().ToTable("User").HasKey(u => u.UserId);
            //modelBuilder.Entity<Roles>().ToTable("Role").HasKey(op => op.RoleId);
            //modelBuilder.Entity<UserRoles>()
            //    .ToTable("UserRole")
            //    .HasKey(c => c.UserRoleId);

            //modelBuilder.Entity<UserRoles>()
            //    .HasOne(sc => sc.User)
            //    .WithMany(s => s.UserRoles)
            //    .HasForeignKey(sc => sc.UserId);

            //modelBuilder.Entity<UserRoles>()
            //    .HasOne(sc => sc.Role)
            //    .WithMany(s => s.UserRoles)
            //    .HasForeignKey(sc => sc.RoleId);
        }
    }
}