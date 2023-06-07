using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AspNetCoreCookieAuthentication.Pages.Account
{
    [AllowAnonymous]
    public class LogOutModel : PageModel
    {
        public void OnGet()
        {
        }
        //public LogoutModel(ILogger<LogoutModel> logger)
        //{

        //}

        public async Task<IActionResult> OnPost(string? returnUrl = null)
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            if (returnUrl != null)
            {
                return LocalRedirect(returnUrl);
            }
            else
            {
                return RedirectToPage();
            }
        }
    }
}
