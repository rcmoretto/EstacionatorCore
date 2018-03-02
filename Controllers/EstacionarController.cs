using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EstacionatorCore.Models;


namespace Estacionator.Views
{
    public class EstacionarController : Controller
    {
        // GET: Estacionar
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Visualizacao()
        {
            return View();
        }
    }
}