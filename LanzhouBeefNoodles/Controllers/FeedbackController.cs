using LanzhouBeefNoodles.Models;
using Microsoft.AspNetCore.Mvc;

namespace LanzhouBeefNoodles.Controllers;

public class FeedbackController : Controller
{
    private readonly IFeedbackRepository _feedbackRepository;

    // GET
    public FeedbackController(IFeedbackRepository feedbackRepository)
    {
        _feedbackRepository = feedbackRepository;
    }

    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Index(Feedback feedback)
    {
        if (ModelState.IsValid)
        {
            _feedbackRepository.AddFeedback(feedback);
            return RedirectToAction("FeedbackCompete");
        }

        return View();
    }

    public IActionResult FeedbackCompete()
    {
        return View();
    }
}