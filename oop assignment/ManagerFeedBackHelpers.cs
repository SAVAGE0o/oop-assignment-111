namespace oop_assignment
{
    internal static class ManagerFeedBackHelpers
    {
        private const string V = @"
                    SELECT 
                        f.FeedbackId AS [ID],
                        u.Username AS [Customer Name],
                        o.order_id AS [OrderID],
                        f.FeedbackText AS [Feedback],
                        f.respond AS [Manager Response],
                        f.status AS [Status],
                        f.FeedbackDate AS [Date]
                    FROM Feedback f
                    INNER JOIN Users u ON f.UserId = u.UserId
                    INNER JOIN Orders o ON f.order_id = o.order_id";
    }
}