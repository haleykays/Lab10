using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging; 
namespace Lab10_1.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger _log;
        public IndexModel(ILogger<IndexModel> log)
        {
            _log = log;
        }
        public void OnGet()
        {
            Object b = null;
            if(b == null) _log.LogWarning("Object is null!");
            else b.ToString(); 
        }
    }
}
