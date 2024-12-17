using Microsoft.AspNetCore.Mvc;
using System;

namespace MVC_Demo.Controllers
{
    public class MoviesController : Controller
    {
        public ContentResult index()
        {
            //return "Hello From Index";
            ContentResult contentResult = new ContentResult();
            contentResult.Content = "Hello From Index";

            return contentResult;


        }
       

        public void GetMovie(int id)
        {
            Response.Redirect("https://www.imdb.com");
        }


    }
}
