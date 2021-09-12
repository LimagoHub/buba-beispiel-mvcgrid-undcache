using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;




/*
 * ##############################################
 *
 *  https://aspnet-core-grid.azurewebsites.net/installation Webseite mit Anleitung. Es gibt aber auch viele Alternativen
 *
 *##############################################
 *
 *
 */


namespace WebGridDemo.Pages
{
    public class IndexModel : PageModel
    {
        public IQueryable<Person> People { get; set; }

        public void OnGet()
        {
            People = GetPeople().AsQueryable();
        }

        private List<Person> GetPeople()
        {return new List<Person> { 
                 new Person ("Max", "Mustermann", "Single", 18, DateTime.Now,  true),
                 new Person ("Max", "Mustermann", "Single", 18, DateTime.Now,  true),
                 new Person ("Max", "Mustermann", "Single", 18, DateTime.Now,  true),
                 new Person ("Max", "Mustermann", "Single", 18, DateTime.Now,  true)

            };
            
        }
    }
}
