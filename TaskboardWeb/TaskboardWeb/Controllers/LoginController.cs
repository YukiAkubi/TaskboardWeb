using Microsoft.AspNetCore.Mvc;
using TaskboardWeb.Services;

namespace TaskboardWeb.Controllers;

/// <summary>
/// ログイン画面のコントローラ
/// </summary>
public class LoginController : Controller
{
    public ActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public ActionResult Login(string userCode, string password) 
    {
        // 認証業務
        var loginResult  = Authentication.Instance.Login(userCode, password);

        // ログインに成功した場合
        if(loginResult.Result == ServiceResults.Success) 
        {
            // メニュー画面に遷移
            return View("../Menu/Index");
        }
        else 
        {
            // ログインに失敗した場合はメッセージを返す
            return View("Index");
        }
    }
}
