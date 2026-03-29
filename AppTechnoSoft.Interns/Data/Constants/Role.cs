namespace ZyloApp.Web.Data.Constants;
public class Role
{
    public const string Admin = nameof(Admin);
    public const string Instructor = nameof(Instructor);
    public const string SuperAdmin = nameof(SuperAdmin);
    public const string Trainee = nameof(Trainee);
    public const string Employee = nameof(Employee);
    public const string Attendee = nameof(Attendee);
    public const string Trainees = $"{Trainee},{Employee}";
    public const string TraineesOrAttendees = $"{Trainee},{Attendee}";
    public const string Admins = $"{Admin},{SuperAdmin}";
    public const string AdminsOrInstructor = $"{Admins},{Instructor}";
    public const string AdminsOrInstructorOrTrainees = $"{AdminsOrInstructor},{Trainee}";
}
