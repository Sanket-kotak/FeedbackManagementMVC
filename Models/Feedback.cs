using System.ComponentModel.DataAnnotations;

namespace FeedbackManagementMVC.Models;

public class Feedback
{
    public int Id { get; set; }

    [Required(ErrorMessage = "Please enter your name.")]
    [StringLength(60, MinimumLength = 2, ErrorMessage = "Name must be between 2 and 60 characters.")]
    [Display(Name = "Your Name")]
    public string Name { get; set; } = string.Empty;

    [Required(ErrorMessage = "Please enter your email address.")]
    [EmailAddress(ErrorMessage = "Enter a valid email address.")]
    [Display(Name = "Email Address")]
    public string Email { get; set; } = string.Empty;

    [Required(ErrorMessage = "Please select a feedback category.")]
    [Display(Name = "Feedback Category")]
    public string Category { get; set; } = string.Empty;

    [Required(ErrorMessage = "Please provide your comments.")]
    [StringLength(500, MinimumLength = 10, ErrorMessage = "Comments must be between 10 and 500 characters.")]
    [Display(Name = "Comments")]
    public string Comments { get; set; } = string.Empty;

    [Range(1, 5, ErrorMessage = "Please rate us from 1 to 5.")]
    [Display(Name = "Rating (1-5)")]
    public int Rating { get; set; } = 5;

    public DateTime SubmittedAt { get; set; } = DateTime.Now;
}
