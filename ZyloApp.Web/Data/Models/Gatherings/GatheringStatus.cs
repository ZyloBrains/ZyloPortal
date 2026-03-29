namespace ZyloApp.Web.Data.Models.Gatherings;
public enum GatheringStatus
{
    Requested = 1,
    Created,
    Scheduled,
    Ongoing,
    PaymentDue,
    Completed,
    Cancelled
}
