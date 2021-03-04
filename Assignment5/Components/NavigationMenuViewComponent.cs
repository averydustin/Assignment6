using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assignment5.Models;

namespace Assignment5.Components
{
    public class NavigationMenuViewComponent : ViewComponent
    {
        private IBooksRepository repository;

        public NavigationMenuViewComponent (IBooksRepository r)
        {
            repository = r;
        }
        public IViewComponentResult Invoke()
        {
            ViewBag.SelectedCategory = RouteData?.Values["category"];
            return View(repository.books
                .Select(x => x.Category)
                .Distinct()
                .OrderBy(x => x));
        }
    }
}
