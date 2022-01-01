using Microsoft.AspNetCore.Mvc;

namespace LanzhouBeefNoodles.Controllers;

public class NoodleController : Controller
{
    // GET
    public IList<String> Index()
    {
        return new List<string> {"牛肉面，羊肉面，鸡蛋面"};
    }
}