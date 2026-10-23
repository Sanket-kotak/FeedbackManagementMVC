using FeedbackManagementMVC.Data;
using FeedbackManagementMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace FeedbackManagementMVC.Controllers;

public class FeedbackController : Controller
{
    public IActionResult Index()
    {
        return View(FeedbackRepository.GetAll());
    }

    public IActionResult Create()
    {
        return View(new Feedback());
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Create(Feedback feedback)
    {
        if (!ModelState.IsValid)
        {
            // Return the form so validation messages can be displayed.
            return View(feedback);
        }

        FeedbackRepository.Add(feedback);
        TempData["SuccessMessage"] = "Thank you! Your feedback was submitted successfully.";
        return RedirectToAction(nameof(Index));
    }

    public IActionResult Details(int id)
    {
        var feedback = FeedbackRepository.GetById(id);
        if (feedback is null) return NotFound();
        return View(feedback);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Delete(int id)
    {
        if (FeedbackRepository.Delete(id))
            TempData["SuccessMessage"] = "Feedback deleted successfully.";
        else
            TempData["ErrorMessage"] = "Feedback was not found.";

        return RedirectToAction(nameof(Index));
    }
}
