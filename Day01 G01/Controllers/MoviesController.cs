using Microsoft.AspNetCore.Mvc;
using System;

namespace MVC_Demo.Controllers
{
    public class MoviesController : Controller
    {
        public IActionResult Index()
        {
            //return "Hello From Index";
            //ContentResult contentResult = new ContentResult();
            //contentResult.Content = "Hello From Index";

            // contentResult.ContentType = "text/html"; // default 
            // contentResult.ContentType = "object/pdf"; // return pdf file
            // contentResult.ContentType = "application/json"; // return json
            // contentResult.ContentType = "text/plain"; // return plain text
            // contentResult.ContentType = "text/xml"; // return xml
            // contentResult.ContentType = "text/csv"; // return csv

            // contentResult.StatusCode = 200; // default
            // contentResult.StatusCode = 302 // Redirect
            // contentResult.StatusCode = 404; // Not Found
            // contentResult.StatusCode = 500; // Internal Server Error

            return Content("Hello From Movies Index", "text/html");
        }

        public IActionResult Test()
        {
            //RedirectResult redirectResult = new RedirectResult("https://localhost:5001/Movies/GetMovie");

            // reutrn /*RedirectToAction(nameof(Index))*/
            // return /*Redirect("https://localhost:5001/Movies/GetMovie")*/

            return RedirectToRoute(new { controller = "Movies", action = "Index"});
        }

        public void GetMovie(int id)
        {
            Response.Redirect("https://www.imdb.com");
        }
    }
}
