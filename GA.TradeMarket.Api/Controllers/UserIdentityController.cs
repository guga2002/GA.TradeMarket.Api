using GA.TradeMarket.Application.Interfaces;
using GA.TradeMarket.Application.Models;
using GA.TradeMarket.Application.StaticFIles;
using GA.TradeMarket.Application.Validation;
using GA.TradeMarket.Domain.Entitites;
using GA.TradeMarket.Persistance.SMTP;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SignInResult = Microsoft.AspNetCore.Identity.SignInResult;

namespace GA.TradeMarket.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserIdentityController : ControllerBase
    {

        private readonly IUserIdentityService ser;
        private readonly UserManager<Person> userManager;
        private readonly SmtpService smtp;
        private readonly ILogger<UserIdentityController> logger;
        public UserIdentityController(IUserIdentityService se, UserManager<Person> userManager, SmtpService smtp, ILogger<UserIdentityController> logger)
        {
            this.ser = se;
            this.userManager = userManager;
            this.smtp = smtp;
            this.logger = logger;
        }

        [HttpGet]
        [Route(nameof(GetEmailVerificationMessage))]
        [ApiExplorerSettings(IgnoreApi = true)]
        [AllowAnonymous]
        public async Task<ActionResult> GetEmailVerificationMessage([FromQuery] string? securitySchema, string? UserName)
        {

            var res = await ser.ConfirmMail(UserName, securitySchema);
            return
                Content(
                res
                    ? "<div style='text-align: center;'><h1 style='color: green; font-weight: bold; font-size: 24px;'>Congratulations!</h1><p style='font-size: 16px;'>Your email has been verified successfully.</p></div>"
                    : "<h1 style='text-align: center; font-weight: bold; font-size: 24px;color:red;'>Link has ben expired!</h1>", "text/html");
        }

        /// <summary>
        /// Sign in Method - set cookie 
        /// </summary>
        /// <remarks>
        /// allow **anymous**
        /// </remarks>
        /// <param name="mod"></param>
        /// <returns name="(SignInResult, string)"></returns>
        [HttpPost]
        [Route(nameof(SignIn))]
        [AllowAnonymous]
        public async Task<ActionResult<(SignInResult, string)>> SignIn([FromBody] SignInModel mod)
        {
            var res = await ser.SignInAsync(mod);
            return Ok(res.Item2);
        }

        /// <summary>
        /// Registration - add user to Db 
        /// </summary>
        /// <remarks>
        /// allow **anymous**
        /// </remarks>
        [HttpPost]
        [Route(nameof(Registration))]
        [AllowAnonymous]
        public async Task<ActionResult<IdentityResult>> Registration([FromBody] UserRegistrationModel user)
        {
            if (!ModelState.IsValid)
            {
                throw new MarketException(user.Persons.UserName);
            }
            var res = await ser.RegisterUserAsync(user.Persons, user.Password);
            return Ok(res);
        }

        [HttpPost]
        [Route("[action]")]
        [ApiExplorerSettings(IgnoreApi = true)]
        public async Task<ActionResult<bool>> RefreshToken([FromQuery] string token)
        {
            if (!ModelState.IsValid)
            {
                throw new MarketException(token);
            }
            if (User.Identity is { Name: not null, IsAuthenticated: true })
            {
                var res = await ser.RefreshToken(User.Identity.Name, token);
                return Ok(res);
            }
            else
            {
                return BadRequest(ErrorKeys.BadRequest);
            }
        }


        /// <summary>
        /// Reset password - forget password 
        /// </summary>
        /// <remarks>
        ///  allow **anymous**
        /// </remarks>
        [HttpGet]
        [Route(nameof(ResetPasswordNow))]
        [AllowAnonymous]
        public async Task<ActionResult<string>> ResetPasswordNow(string email, string newPassword)
        {
            if (!await ser.IsUserExist(email))
            {
                return BadRequest(ErrorKeys.BadRequest);
            }
            var link = Url.ActionLink(nameof(ForgetPassword), "UserIdentity", new { Email = email, Password = newPassword }, Request.Scheme);
            if (link is null) return BadRequest();
            var body = $@"
                  <div align='center' style='font-family: Arial, sans-serif;'>
                  <p style='font-size: 16px;'>გადადი ლინკზე რათა შეცვალო პაროლი:</p>
                 <p style='font-size: 16px;'>
                 <a href='{link}' style='display: inline-block; padding: 10px 20px; background-color: #007bff; color: #ffffff; text-decoration: none; border-radius: 5px;'>შეცვალე პაროლი
                 </a>
                 </p>
                 <p style='font-size: 16px;'>ლინკი ვალიდურია 24 საათის განავლობაში</p>
                 <p style='font-size: 16px;'>ჩვენი ჯგუფი გიხდის მადლობას..</p>
                  <h2 style='font-size: 16px;color:red;'>თუ თქვენ  არ გამოგიგზავნიათ მოთხოვნა, გთხოვთ დაგვიკავშირდეთ!</h2>
                </div>";
            smtp.SendMessage(email, "პაროლის შეცვლის მოთხოვნა" + '_' + DateTime.Now.Hour + ':' + DateTime.Now.Minute, body);
            return Ok(email);
        }


        [HttpGet]
        [Route(nameof(ForgetPassword))]
        [ApiExplorerSettings(IgnoreApi = true)]
        [AllowAnonymous]
        public async Task<ActionResult> ForgetPassword([FromQuery] string email, [FromQuery] string password)
        {
            if (!ModelState.IsValid)
            {
                throw new MarketException(email);
            }
            var res = await ser.ForgetPassword(email, password);
            return Content(res ? "<html><body><h1>Password Reset Successfully!</h1></body></html>" : "<html><body><h1>Password Reset Failed</h1></body></html>", "text/html");
        }


        /// <summary>
        /// change password - when you laready know old password
        /// </summary>
        /// <remarks>
        /// allow **customer**
        /// </remarks>
        [HttpPost]
        [Route(nameof(ResetPassword))]
        [Authorize(Roles = "customer")]
        public async Task<ActionResult<IdentityResult>> ResetPassword([FromBody] PasswordResetModel arg)
        {
            if (!ModelState.IsValid)
            {
                throw new MarketException(arg.NewPassword);
            }

            if (User.Identity is not { Name: not null, IsAuthenticated: true })
                return BadRequest(ErrorKeys.BadRequest);

            var res = await ser.ResetPasswordAsync(arg, User.Identity.Name);
            return Ok(arg);
        }


        /// <summary>
        /// Info about current user 
        /// </summary>
        /// <remarks>
        /// **authorized** user have access it
        /// </remarks>
        [HttpGet]
        [Route(nameof(Info))]
        [Authorize]
        public async Task<ActionResult<PersonModel>> Info()
        {
            if (User?.Identity is not { Name: not null, IsAuthenticated: true })
                return BadRequest(ErrorKeys.BadRequest);
            var res = await ser.Info(User.Identity.Name);
            return Ok(res);
        }


        /// <summary>
        /// Confirm email address  
        /// </summary>
        /// <remarks>
        /// for **authorized** user
        /// </remarks>
        [HttpGet]
        [Route(nameof(ConfirmEmail))]
        [Authorize]
        public async Task<ActionResult<string>> ConfirmEmail()
        {
            if (User.Identity is not null && User.Identity.Name != null && User.Identity.IsAuthenticated)
            {
                if (await ser.IsEmailConfirmed(User.Identity.Name))
                {
                    throw new ArgumentException("Email is already Confirmed!");
                }

                var user = await userManager.FindByNameAsync(User.Identity.Name);
                if (user == null) return BadRequest(ErrorKeys.BadRequest);

                var rek = await userManager.GenerateEmailConfirmationTokenAsync(user);
                var link = Url.ActionLink(nameof(GetEmailVerificationMessage), "UserIdentity",
                    new { SecuritySchema = rek, UserName = User.Identity.Name }, Request.Scheme);
                if (link == null) return BadRequest("Linki ara  validuri");
                await ser.SendLinkToUser(User.Identity.Name, link);
                return Ok(link);
            }
            return NotFound(ErrorKeys.BadRequest);
        }

        /// <summary>
        /// SignOut from system 
        /// </summary>
        /// <remarks>
        /// **authorize** user have access for it
        /// </remarks>
        [HttpPost]
        [Route(nameof(SignOutNow))]
        [Authorize]
        public async Task<ActionResult<bool>> SignOutNow()
        {
            if (User.Identity is null || !User.Identity.IsAuthenticated || User.Identity.Name is null)
                return BadRequest(ErrorKeys.BadRequest);
            var res = await ser.SignOutAsync(User.Identity.Name);
            return Ok(res);
        }


        /// <summary>
        /// Add new role to database 
        /// </summary>
        /// <remarks>
        /// only for **admins**
        /// </remarks>
        [HttpGet]
        [Route("[action]")]
        [Authorize(Roles = "admin")]
        public async Task<ActionResult<IEnumerable<RoleModel>>> Roles()
        {
            if (!User.IsInRole("admin"))
            {
                throw new UnauthorizedAccessException("You do not have the required 'admin' role.");
            }
            var res = await ser.GetAllRoles();
            return Ok(res);
        }

        /// <summary>
        ///Get all users details  from DB 
        /// </summary>
        /// <remarks>
        /// only for **admins**
        /// </remarks>
        [HttpGet]
        [Route("[action]")]
        [Authorize(Roles = "admin")]
        public async Task<ActionResult<IEnumerable<PersonModel>>> Users()
        {
            var res = await ser.GetAllUser();
            return Ok(res);
        }

        /// <summary>
        /// Delete specify Role from DB
        /// </summary>
        /// <remarks>
        ///  only for **admin**
        /// </remarks>
        [HttpDelete]
        [Route("Role/{role:alpha}/[action]")]
        [Authorize(Roles = "admin")]
        public async Task<ActionResult<IdentityResult>> Delete([FromRoute] string role)
        {
            var res = await ser.DeleteRole(role);
            return Ok(res);
        }


        /// <summary>
        /// Add new role to DB
        /// </summary>
        /// <remarks>
        /// only for **admin**
        /// </remarks>
        [HttpPost]
        [Route("Role/{role:alpha}/[action]")]
        [Authorize(Roles = "admin")]
        public async Task<ActionResult<IdentityResult>> Add([FromRoute] string role)
        {
            if (!ModelState.IsValid)
            {
                throw new MarketException(role);
            }
            var res = await ser.AddRolesAsync(role);
            return Ok(res);
        }


        /// <summary>
        /// Delete specify User from DB
        /// </summary>
        /// <remarks>
        ///  only for **admin**
        /// </remarks>
        [HttpDelete]
        [Authorize]
        [Route("User/{id}/[action]")]
        [Authorize(Roles = "admin")]
        public async Task<ActionResult<IdentityResult>> DeleteUser([FromRoute] string id)
        {
            if (!ModelState.IsValid)
            {
                throw new MarketException(id);
            }
            var res = await ser.DeleteUser(id);
            return Ok(res);
        }


        /// <summary>
        /// Assign specify role to specify user
        /// </summary>
        /// <remarks>
        /// can use for **admin**
        /// </remarks>
        [HttpPost]
        [Route("User/{userid}[action]/{role:alpha}")]
        [Authorize]
        public async Task<ActionResult<IdentityResult>> Role([FromRoute] string userid, [FromRoute] string role)
        {
            if (!ModelState.IsValid)
            {
                throw new MarketException(role);
            }
            var res = await ser.AssignRoleToUserAsync(userid, role);
            return Ok(res);
        }
    }
}
