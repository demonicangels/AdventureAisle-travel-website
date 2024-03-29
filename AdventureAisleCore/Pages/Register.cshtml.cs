using BusinessLogic;
using BusinessLogic.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AdventureAisleCore.Pages
{
    public class RegisterCoreModel : PageModel
    {
        UserService userService;
        Security security = new Security();

        [BindProperty]
        public UserDTO Usr { get; set; }

       public RegisterCoreModel(UserService u)
       {
            userService = u;
	   }   
        public void OnGet()
        {
            
        }
        public IActionResult OnPost()
        {
			if (!ModelState.IsValid)
            {
                return Page();
            }
            else
            {
                var salt = security.CreateSalt();
                var hash = security.CreateHash(salt, Usr.Password);
			 userService.InsertUser(Usr, salt, hash);
                return RedirectToPage("Login");
            }
        }
    }
}
