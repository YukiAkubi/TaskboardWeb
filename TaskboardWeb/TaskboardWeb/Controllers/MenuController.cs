using Microsoft.AspNetCore.Mvc;

namespace TaskboardWeb.Controllers;

/// <summary>
/// メニュー画面のコントローラ
/// </summary>
public class MenuController : Controller
{
    public ActionResult Index()
    {
        return View();
    }
}
