using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using CallCare_Gameification_FE.Classes;

namespace CallCare_Gameification_FE.Pages.User
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private Users user = new Users();

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
            user = new Users();
        }

        public void OnGet(int id)
        {
            var userDetails = user.getUserDetails(id);
        }
    }
}
