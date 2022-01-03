using LanzhouBeefNoodles.Models;
using LanzhouBeefNoodles.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace LanzhouBeefNoodles.Controllers;

public class HomeController : Controller
{
    private readonly INoodleRepository _noodleRepository;
    private readonly IFeedbackRepository _feedbackRepository;

    // GET
    public HomeController(
        INoodleRepository noodleRepository,
        IFeedbackRepository feedbackRepository)
    {
        _noodleRepository = noodleRepository;
        _feedbackRepository = feedbackRepository;
    }

    public IActionResult Index()
    {
        var homeVIewModel = new HomeVIewModel()
        {
            Noodles = _noodleRepository.GetAllNoodles().ToList(),
            Feedbacks = _feedbackRepository.GetAllFeedbacks().ToList()
        };
        return View(homeVIewModel);
    }

    public String About()
    {
        return "Hello from About";
    }

    public IActionResult Detail(int id)
    {
        return View(_noodleRepository.GetNoodleById(id));
    }
}