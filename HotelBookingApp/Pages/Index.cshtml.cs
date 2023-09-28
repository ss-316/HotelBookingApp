<<<<<<< HEAD
﻿using Microsoft.AspNetCore.Mvc;
=======
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc;
>>>>>>> 309619e (register setup)
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HotelBookingApp.Pages
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
    }
}