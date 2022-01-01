using Microsoft.AspNetCore.Mvc;

namespace LanzhouBeefNoodles.Controllers;

[Route("admin/[controller]/[action]")]
public class UserController : Controller
{
    // GET
    public IList<String> Index()
    {
        return new List<string> {"测试", "测试1"};
    }
}