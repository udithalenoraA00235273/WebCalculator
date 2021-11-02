using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebCalc.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }

        public void OnPost([FromForm]float left, [FromForm]float right)
        {
            ViewData["result"] = SharedCalc.Calculator.Add(left, right);
            ViewData["result1"] = SharedCalc.Calculator.Sub(left, right);
            ViewData["result2"] = SharedCalc.Calculator.Mul(left, right);
            ViewData["result3"] = SharedCalc.Calculator.Div(left, right);
        }

       
    }
}
