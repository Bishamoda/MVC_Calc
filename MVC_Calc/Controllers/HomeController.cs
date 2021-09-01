using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_Calc.Models;

namespace MVC_Calc.Controllers
{
    public class HomeController : Controller
    {
       
        public ActionResult Index(Calculation calc)
        {

            switch (calc.Op)
            {
                case '+': calc.Result = calc.Number1 + calc.Number2;
                    break;

                case '-': calc.Result = calc.Number1 - calc.Number2;
                    break;

                case '*': calc.Result = calc.Number1 * calc.Number2;
                    break;

                case '/':
                    if (calc.Number2 != 0)
                    {
                        calc.Result = calc.Number1 / calc.Number2;
                    }
                    else
                    {
                        calc.Result = 0;
                        calc.Number1 = 0;
                        calc.Number2 = 0;
                    }
                    break;

                case 'c': 
                    calc.Result = 0;
                    calc.Number1 = 0;
                    calc.Number2 = 0;
                    break;

            }

            calc.Number1 = calc.Result;
            //calc.Number2 = 0;

            return View(calc);
        }


    }
}