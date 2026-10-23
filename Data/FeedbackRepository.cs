using FeedbackManagementMVC.Models;

namespace FeedbackManagementMVC.Data;

// Simple in-memory repository for this lab activity.
// Data resets when the application restarts; no database is required.
public static class FeedbackRepository
{
    private static readonly List<Feedback> Items = new()
    {
        new Feedback
        {
            Id = 1, Name = "Demo Student", Email = "student@example.com",
            Category = "Suggestion", Comments = "The portal is easy to use.",
            Rating = 4, SubmittedAt = DateTime.Now.AddDays(-1)
        }
    };

    private static int _nextId = 2;
    private static readonly object Sync = new();

    public static List<Feedback> GetAll()
    {
        lock (Sync) return Items.OrderByDescending(x => x.SubmittedAt).ToList();
    }

    public static Feedback? GetById(int id)
    {
        lock (Sync) return Items.FirstOrDefault(x => x.Id == id);
    }

    public static void Add(Feedback feedback)
    {
        lock (Sync)
        {
            feedback.Id = _nextId++;
            feedback.SubmittedAt = DateTime.Now;
            Items.Add(feedback);
        }
    }

    public static bool Delete(int id)
    {
        lock (Sync)
        {
            var item = Items.FirstOrDefault(x => x.Id == id);
            if (item is null) return false;
            Items.Remove(item);
            return true;
        }
    }
}
