using ZyloApp.Web.Data.Constants;
using ZyloApp.Web.Data.Models;
using ZyloApp.Web.Data.Models.Consultant;
using ZyloApp.Web.Data.Models.Gatherings;
using ZyloApp.Web.Data.Models.Sites;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ZyloApp.Web.Data;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
    : IdentityDbContext<ApplicationUser>(options)
{
    public DbSet<TechProgram> TechPrograms { get; set; }
    public DbSet<Student> Students { get; set; }
    public DbSet<FinAccount> FinAccounts { get; set; }
    public DbSet<Widget> Widgets { get; set; }
    public DbSet<Tag> Tags { get; set; }
    public DbSet<Team> Teams { get; set; }
    public DbSet<Batch> Batches { get; set; }
    public DbSet<Project> Projects { get; set; }
    public DbSet<Instructor> Instructors { get; set; }
    public DbSet<Attendance> Attendances { get; set; }
    public DbSet<ClassSchedule> ClassSchedules { get; set; }
    public DbSet<TraineeTimeline> TraineeTimelines { get; set; }
    public DbSet<Assignment> Assignments { get; set; }
    public DbSet<StudentAssignment> StudentAssignments { get; set; }
    public DbSet<Expense> Expenses { get; set; }
    public DbSet<Revenue> Revenues { get; set; }
    public DbSet<BatchBudget> BatchBudgets { get; set; }
    public DbSet<CourseQuote> CourseQuotes { get; set; }
    public DbSet<CourseQuoteModule> CourseQuoteModules { get; set; }
    public DbSet<Organization> Organizations { get; set; }
    public DbSet<Training> Training { get; set; }
    public DbSet<Loan> Loans { get; set; }
    public DbSet<ReviewForm> Reviews { get; set; }
    public DbSet<ConsultantRating> ConsultantRatings { get; set; }
    public DbSet<Gathering> Gatherings { get; set; }
    public DbSet<GatheringCalendar> GatheringCalendars { get; set; }
    public DbSet<GatheringRequest> GatheringRequests { get; set; }
    public DbSet<Certificate> Certificates { get; set; }
    public DbSet<Site> Sites { get; set; }
    public DbSet<Section> Sections { get; set; }
    public DbSet<SectionItem> SectionItems { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.Entity<ApplicationUser>().ToTable("Users");
        builder.Entity<IdentityRole>().ToTable("Roles");
        builder.Entity<IdentityUserClaim<string>>().ToTable("UserClaims");
        builder.Entity<IdentityUserToken<string>>().ToTable("UserTokens");
        builder.Entity<IdentityUserLogin<string>>().ToTable("UserLogins");
        builder.Entity<IdentityRoleClaim<string>>().ToTable("RoleClaims");
        builder.Entity<IdentityUserRole<string>>().ToTable("UserRole");

        builder.Entity<Instructor>()
        .HasMany(e => e.Tags)
        .WithMany();

        builder.Entity<Training>()
        .HasMany(e => e.Tags)
        .WithMany()
        .UsingEntity("TrainingTags");

        builder.Entity<CourseQuote>()
        .HasMany(e => e.Modules)
        .WithMany()
        .UsingEntity<CourseQuoteModule>();

        builder.Entity<Training>()
        .HasMany(e => e.Assignments)
        .WithMany()
        .UsingEntity("TrainingAssignments");

        builder.Entity<Training>()
        .HasMany(e => e.Projects)
        .WithMany()
        .UsingEntity("TrainingProjects");

        builder.Entity<GatheringCalendar>()
        .HasMany(e => e.Consultants)
        .WithMany();
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);

        optionsBuilder.UseSeeding((context, _) =>
         {
             var colleges = context.Set<Organization>().ToList();

             if (colleges == null || colleges.Count == 0)
             {
                 context.Set<Organization>().AddRange(
                     [
                         new Organization { Name = "Mechi Multiple Campus", Details = "Bhadrapur, Jhapa" },
                        new Organization { Name = "Dhankuta Multiple Campus", Details = "Dhankuta" },
                        new Organization { Name = "Central Campus of Technology", Details = "Dharan" },
                        new Organization { Name = "Mahendra Morang Adarsha Multiple Campus", Details = "Biratnagar" },
                        new Organization { Name = "Mahendra Bindeshwori Multiple Campus", Details = "Rajbiraj" },
                        new Organization { Name = "Surya Narayan Satya Na. Mo. Yadav Campus", Details = "Siraha" },
                        new Organization { Name = "Ramsorup Ramsagar Multiple Campus", Details = "Janakpur" },
                        new Organization { Name = "Thakur Ram Multiple Campus", Details = "Birgunj" },
                        new Organization { Name = "Birendra Multiple Campus", Details = "Bharatpur" },
                        new Organization { Name = "Prithivi Narayan Multiple Campus", Details = "Pokhara" },
                        new Organization { Name = "SidhaNath Science Campus", Details = "Mahendranagar" },
                        new Organization { Name = "Mahendra Multiple Campus", Details = "Nepalgunj" },
                        new Organization { Name = "Butwal Multiple Campus", Details = "Butwal" },
                        new Organization { Name = "Padma Kanya Multiple Campus", Details = "Bagbazar" },
                        new Organization { Name = "Mahendra Multiple Campus", Details = "Ghorahi, Dang" },
                        new Organization { Name = "Dhaulagiri Campus", Details = "Baglung" },
                        new Organization { Name = "Gorkha Campus", Details = "Gorkha" },
                        new Organization { Name = "Bhairahawa Multiple Campus", Details = "Bhairahawa" },
                        new Organization { Name = "Degree Campus", Details = "Biratnagar" }
                     ]);

                 context.SaveChanges();
             }

             var programs = context.Set<TechProgram>().ToList();

             if (programs == null || programs.Count == 0)
             {
                 context.Set<TechProgram>().AddRange(
                     [
                         new TechProgram { Name = "BCA", Affliation = "TU" },
                        new TechProgram { Name = "BCA", Affliation = "PU" },
                        new TechProgram { Name = "BIT", Affliation = "TU" },
                        new TechProgram { Name = "BIT", Affliation = "PU" },
                        new TechProgram { Name = "BIM", Affliation = "TU" },
                        new TechProgram { Name = "BScIT", Affliation = "TU" },
                        new TechProgram { Name = "BScIT", Affliation = "PU" },
                    ]);

                 context.SaveChanges();
             }

             // Seed roles and admin user
             string superAdminId = Guid.CreateVersion7().ToString();
             string superAdminRoleId = Guid.CreateVersion7().ToString();
             string adminRoleId = Guid.CreateVersion7().ToString();
             string traineeRoleId = Guid.CreateVersion7().ToString();
             var appUser = new ApplicationUser
             {
                 Id = superAdminId,
                 Email = "rawal.bishnu@live.com",
                 EmailConfirmed = true,
                 UserName = "rawal.bishnu@live.com",
                 NormalizedUserName = "RAWAL.BISHNU@LIVE.COM"
             };
             //set user password
             PasswordHasher<ApplicationUser> ph = new();
             appUser.PasswordHash = ph.HashPassword(appUser, "~Someone1");

             var roles = context.Set<IdentityRole>().ToList();
             if (roles == null || roles.Count == 0)
             {
                 context.Set<IdentityRole>().AddRange(
                     [
                        new IdentityRole
                        {
                            Name = Role.SuperAdmin,
                            NormalizedName = "SUPERADMIN",
                            Id = superAdminRoleId,
                            ConcurrencyStamp = superAdminRoleId
                        },
                        new IdentityRole
                        {
                            Name = Role.Admin,
                            NormalizedName = "ADMIN",
                            Id = adminRoleId,
                            ConcurrencyStamp = adminRoleId
                        },
                        new IdentityRole
                        {
                            Name = Role.Trainee,
                            NormalizedName = "TRAINEE",
                            Id = traineeRoleId,
                            ConcurrencyStamp = traineeRoleId
                        }
                    ]);

                 context.SaveChanges();
             }

             adminRoleId = roles?.FirstOrDefault(x => x.Name == Role.Admin)?.Id ?? adminRoleId;
             superAdminId = roles?.FirstOrDefault(x => x.Name == Role.SuperAdmin)?.Id ?? superAdminId;
             traineeRoleId = roles?.FirstOrDefault(x => x.Name == Role.Trainee)?.Id ?? traineeRoleId;

             var appUserAdmin = context.Set<ApplicationUser>().FirstOrDefault(x => x.UserName == appUser.UserName);
             if (appUserAdmin is null)
             {
                 context.Set<ApplicationUser>().Add(appUser);
                 context.SaveChanges();

                 context.Set<IdentityUserRole<string>>().AddRange(
                     [
                        new IdentityUserRole<string>
                        {
                            RoleId = superAdminRoleId,
                            UserId = superAdminId
                        },
                        new IdentityUserRole<string>
                        {
                            RoleId = adminRoleId,
                            UserId = superAdminId
                        },
                        new IdentityUserRole<string>
                        {
                            RoleId = traineeRoleId,
                            UserId = superAdminId
                        }
                    ]);
                 context.SaveChanges();
             }
         });
    }
}
