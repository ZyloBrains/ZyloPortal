namespace ZyloApp.Web.Data.Constants;

public static class Permission
{
    // Finance
    public const string FinanceView = "Finance.View";
    public const string FinanceEdit = "Finance.Edit";
    public const string FinanceDelete = "Finance.Delete";

    // Students / Applicants
    public const string StudentsView = "Students.View";
    public const string StudentsEdit = "Students.Edit";
    public const string StudentsApprove = "Students.Approve";

    // Batches
    public const string BatchesView = "Batches.View";
    public const string BatchesEdit = "Batches.Edit";
    public const string BatchesDelete = "Batches.Delete";

    // Schedules
    public const string SchedulesView = "Schedules.View";
    public const string SchedulesEdit = "Schedules.Edit";

    // Attendance
    public const string AttendanceView = "Attendance.View";
    public const string AttendanceEdit = "Attendance.Edit";

    // Assignments
    public const string AssignmentsView = "Assignments.View";
    public const string AssignmentsCreate = "Assignments.Create";
    public const string AssignmentsVerify = "Assignments.Verify";

    // Employees
    public const string EmployeesView = "Employees.View";
    public const string EmployeesEdit = "Employees.Edit";
    public const string EmployeesDelete = "Employees.Delete";

    // Sites / CMS
    public const string SitesView = "Sites.View";
    public const string SitesEdit = "Sites.Edit";
    public const string SitesDelete = "Sites.Delete";

    // Gatherings / Events
    public const string GatheringsView = "Gatherings.View";
    public const string GatheringsEdit = "Gatherings.Edit";
    public const string GatheringsDelete = "Gatherings.Delete";

    // Reviews
    public const string ReviewsView = "Reviews.View";
    public const string ReviewsEdit = "Reviews.Edit";
    public const string ReviewsDelete = "Reviews.Delete";

    // Programs
    public const string ProgramsView = "Programs.View";
    public const string ProgramsEdit = "Programs.Edit";
    public const string ProgramsDelete = "Programs.Delete";

    // Tags
    public const string TagsView = "Tags.View";
    public const string TagsEdit = "Tags.Edit";
    public const string TagsDelete = "Tags.Delete";

    // Teams
    public const string TeamsView = "Teams.View";
    public const string TeamsEdit = "Teams.Edit";
    public const string TeamsDelete = "Teams.Delete";

    // Widgets
    public const string WidgetsView = "Widgets.View";
    public const string WidgetsEdit = "Widgets.Edit";

    // Instructors
    public const string InstructorsView = "Instructors.View";
    public const string InstructorsEdit = "Instructors.Edit";

    // Organizations
    public const string OrganizationsView = "Organizations.View";
    public const string OrganizationsEdit = "Organizations.Edit";
    public const string OrganizationsDelete = "Organizations.Delete";

    // Course Quotes
    public const string CourseQuotesView = "CourseQuotes.View";
    public const string CourseQuotesEdit = "CourseQuotes.Edit";
    public const string CourseQuotesDelete = "CourseQuotes.Delete";

    // Training Modules
    public const string ModulesView = "Modules.View";
    public const string ModulesEdit = "Modules.Edit";

    // Projects
    public const string ProjectsView = "Projects.View";
    public const string ProjectsEdit = "Projects.Edit";

    // Roles
    public const string RolesView = "Roles.View";
    public const string RolesEdit = "Roles.Edit";

    // Users
    public const string UsersView = "Users.View";
    public const string UsersEdit = "Users.Edit";

    // Timeline
    public const string TimelineView = "Timeline.View";
    public const string TimelineEdit = "Timeline.Edit";

    // Dashboard
    public const string DashboardAdmin = "Dashboard.Admin";
    public const string DashboardConsultant = "Dashboard.Consultant";

    // Consulting Plans
    public const string ConsultingPlansView = "ConsultingPlans.View";
    public const string ConsultingPlansEdit = "ConsultingPlans.Edit";

    // Timesheets
    public const string TimesheetsView = "Timesheets.View";

    // Certificates
    public const string CertificatesView = "Certificates.View";
    public const string CertificatesEdit = "Certificates.Edit";

    /// <summary>
    /// Returns all defined permission strings.
    /// </summary>
    public static IReadOnlyList<string> All { get; } = new[]
    {
        FinanceView, FinanceEdit, FinanceDelete,
        StudentsView, StudentsEdit, StudentsApprove,
        BatchesView, BatchesEdit, BatchesDelete,
        SchedulesView, SchedulesEdit,
        AttendanceView, AttendanceEdit,
        AssignmentsView, AssignmentsCreate, AssignmentsVerify,
        EmployeesView, EmployeesEdit, EmployeesDelete,
        SitesView, SitesEdit, SitesDelete,
        GatheringsView, GatheringsEdit, GatheringsDelete,
        ReviewsView, ReviewsEdit, ReviewsDelete,
        ProgramsView, ProgramsEdit, ProgramsDelete,
        TagsView, TagsEdit, TagsDelete,
        TeamsView, TeamsEdit, TeamsDelete,
        WidgetsView, WidgetsEdit,
        InstructorsView, InstructorsEdit,
        OrganizationsView, OrganizationsEdit, OrganizationsDelete,
        CourseQuotesView, CourseQuotesEdit, CourseQuotesDelete,
        ModulesView, ModulesEdit,
        ProjectsView, ProjectsEdit,
        RolesView, RolesEdit,
        UsersView, UsersEdit,
        TimelineView, TimelineEdit,
        DashboardAdmin, DashboardConsultant,
        ConsultingPlansView, ConsultingPlansEdit,
        TimesheetsView,
        CertificatesView, CertificatesEdit
    };

    /// <summary>
    /// Returns all permissions grouped by module for UI rendering.
    /// </summary>
    public static IReadOnlyDictionary<string, IReadOnlyList<string>> ByModule { get; } = new Dictionary<string, IReadOnlyList<string>>
    {
        ["Finance"] = [FinanceView, FinanceEdit, FinanceDelete],
        ["Students"] = [StudentsView, StudentsEdit, StudentsApprove],
        ["Batches"] = [BatchesView, BatchesEdit, BatchesDelete],
        ["Schedules"] = [SchedulesView, SchedulesEdit],
        ["Attendance"] = [AttendanceView, AttendanceEdit],
        ["Assignments"] = [AssignmentsView, AssignmentsCreate, AssignmentsVerify],
        ["Employees"] = [EmployeesView, EmployeesEdit, EmployeesDelete],
        ["Sites"] = [SitesView, SitesEdit, SitesDelete],
        ["Gatherings"] = [GatheringsView, GatheringsEdit, GatheringsDelete],
        ["Reviews"] = [ReviewsView, ReviewsEdit, ReviewsDelete],
        ["Programs"] = [ProgramsView, ProgramsEdit, ProgramsDelete],
        ["Tags"] = [TagsView, TagsEdit, TagsDelete],
        ["Teams"] = [TeamsView, TeamsEdit, TeamsDelete],
        ["Widgets"] = [WidgetsView, WidgetsEdit],
        ["Instructors"] = [InstructorsView, InstructorsEdit],
        ["Organizations"] = [OrganizationsView, OrganizationsEdit, OrganizationsDelete],
        ["Course Quotes"] = [CourseQuotesView, CourseQuotesEdit, CourseQuotesDelete],
        ["Modules"] = [ModulesView, ModulesEdit],
        ["Projects"] = [ProjectsView, ProjectsEdit],
        ["Roles"] = [RolesView, RolesEdit],
        ["Users"] = [UsersView, UsersEdit],
        ["Timeline"] = [TimelineView, TimelineEdit],
        ["Dashboard"] = [DashboardAdmin, DashboardConsultant],
        ["Consulting Plans"] = [ConsultingPlansView, ConsultingPlansEdit],
        ["Timesheets"] = [TimesheetsView],
        ["Certificates"] = [CertificatesView, CertificatesEdit]
    };
}
