using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System.Net.Http.Headers;



namespace WebApp
{
    [Route("api")]
    public class LoginController : Controller
    {
        private readonly IAccountDatabase _db;

        public LoginController(IAccountDatabase db)
        {
            _db = db;
        }

        [HttpPost("sign-in")]
        public async Task Login(string userName)
        {
            var account = await _db.FindByUserNameAsync(userName);
            if (account != null)
            {

                //TODO 1: Generate auth cookie for user 'userName' with external id
                HttpContext.Response.Cookies.Append("ExternalId", account.ExternalId);
                


                ///i dunno how to do all of it. But i want to learn ASP.NET ~^~ 
                ///Please, teach me!
                ///I really tried solve it in the last two days, but as you can see it was needlesly
                ///Hope, my solved first part was at least of some value.
                ///Anyway, Thanks for the interesting tasks with the console. :3

            }
            else
            {
                //TODO 2: return 404 if user not found  
                Response.StatusCode = 404;
                View("Not Found");
                
                
            }
           
        }
    }
}