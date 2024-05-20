using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MT_Superfolio.ViewComponents.Feature
{
    public class FeatureList:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
