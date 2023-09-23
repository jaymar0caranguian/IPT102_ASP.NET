using Microsoft.AspNetCore.Mvc;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        var studentInfoArray = new[]
        {
            new StudentInfoModel { Name = "Jaymar Caranguian", StudentId = "21-1476", StudentAge = "21" },
            new StudentInfoModel { Name = "Jerry Caranguian", StudentId = "22-2326", StudentAge = "45" },
            new StudentInfoModel { Name = "Marjorie Caranguian", StudentId = "20-2921", StudentAge = "41" }
        };

        return View(studentInfoArray);
    }
}
