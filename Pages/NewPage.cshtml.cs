using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema; 


namespace Lab10_1.Pages
{
    public class NewPageModel : PageModel
    {
        private readonly ILogger _log;
        public NewPageModel(ILogger<NewPageModel> log)
        {
            _log = log;
        }
        public void OnGet()
        {
            Object b = null;
            if(b == null) _log.LogWarning("Object is null!");
            else b.ToString(); 
        }
        [BindProperty]
        [Display(Name = "First Name")]
        [Required]
        [StringLength(20, MinimumLength = 2)]
        public string FirstName {get; set;}
        [Required]
        [StringLength(20, MinimumLength = 2)]
        [Display(Name = "Last Name")]
        [BindProperty]
        public string LastName {get; set;}
        [Required]
        [CreditCard]
        [Display(Name = "Credit Card Number")]
        public string CardNum {get; set;}
        public void OnPost()
        {
            _log.LogWarning($"First Name: {FirstName} Last Name: {LastName}");           
        }
    }
}

