using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.OpenIdConnect;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Account.Pages
{
    public class LoginModel : PageModel
    {
        public async Task OnGet(string redirectUri)
        {
            await HttpContext.ChallengeAsync(OpenIdConnectDefaults.AuthenticationScheme, 
                new AuthenticationProperties
                    { RedirectUri = redirectUri });
        }

        //public async Task<ActionResult> OnGetAsync(string redirectUri)
        //{
        //    // remove compiler warning
        //    await Task.CompletedTask;

        //    if (!string.IsNullOrEmpty(redirectUri))
        //    {
        //        redirectUri = Url.Content("~/");
        //    }

        //    // If user is already logged in, we can redirect directly...
        //    if (HttpContext.User.Identity.IsAuthenticated)
        //    {
        //        Response.Redirect(redirectUri);
        //    }

        //    return Challenge(new AuthenticationProperties
        //    {
        //        RedirectUri = redirectUri,
        //    }, OpenIdConnectDefaults.AuthenticationScheme);
        //}
    }
}
