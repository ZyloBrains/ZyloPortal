namespace ZyloApp.Web.Data.Enums;
public enum Status
{
    Applied = 1,                // When application received
    Enrolled,                   // When assigned to appropriate batch
    PendingFee,                 // When fee is pending for individual
    Learning,                   // On training now and fee paid
    Contribution,               // When assinged to a team
    Evaluated,                  // Project done
    Documentation,              // Internship documentation and reports
    Completed                   // Internship done, e-certificate shared
}
