using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LetsStudy.Pages
{
    public class IndexModel : PageModel
    {
        public string messagetype;
        public string searchText;
        public string searchcategory;
        
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet(string searchText = "", string searchcategory = "")
        {
            if ( !searchText.Equals("")) 
            { 
                
            }

        }
        public void OnPost(string messagetype)
        {
            if (messagetype.Equals("ZoomMeeting")) 
            { 
            
            }
            else if (messagetype.Equals("ModulesMeeting"))
            {
            
            }
            if (messagetype.Equals("Note"))
            {
            
            }

        }
    }
}
