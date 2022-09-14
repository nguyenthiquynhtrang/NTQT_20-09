using Microsoft.AspNetCore.Mvc;
using  DemoMVC.Models;
using DemoMVC.Controllers;

namespace DemoMVC.Controllers
{
    public class PersonController : Controller
    {
       public ActionResult Index()
        {
            //khoi tao list Person
            List<Person> stdList= new List<Person>
            { 
                new Person { PersonID = 1, PersonName = "Nguyen Van Bo ", PersonAge = 10 },
                new Person { PersonID = 2, PersonName = "Nguyen Thi My ", PersonAge = 11 },
                new Person { PersonID = 3, PersonName = "Nguyen Van Bi", PersonAge = 12 },
                new Person { PersonID = 4, PersonName = "Nguyen Thi Mai ",PersonAge =13},
               
            };
            ViewData["Persons"] = stdList;
            return View();
        }
    }
}