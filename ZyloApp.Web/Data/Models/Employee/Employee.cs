using Microsoft.AspNetCore.Components.Forms;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZyloApp.Web.Data.Models.Employee;
public class Employee : BaseEntity
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string? Phone { get; set; }
    public string? Designation { get; set; }
    public string? Department { get; set; }
    public string? ProfilePath { get; set; }
    public bool Publish { get; set; } = true;
    public decimal? MonthlyBasic { get; set; }
    public string? Currency { get; set; } = "NPR";
    public string? BankAccountDetails { get; set; }
    public string? OtherDetails { get; set; }

    [NotMapped]
    public IBrowserFile? Profile { get; set; }

    public int? ReportsToId { get; set; }
    public Employee? ReportsTo { get; set; }
    public List<Employee>? DirectReports { get; set; }

    public string? ApplicationUserId { get; set; }
    public ApplicationUser? User { get; set; }
}
