using Azure;
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
    [Authorize]
    public class UserIdentityController : ControllerBase
    {

        private readonly IUserIdentityService ser;
        private readonly UserManager<Person> userManager;
        private readonly SmtpService smtp;
        public UserIdentityController(IUserIdentityService se, UserManager<Person> userManager, SmtpService smtp)
        {
            this.ser = se;
            this.userManager = userManager;
            this.smtp = smtp;
        }

        [HttpGet]
        [Route(nameof(GetEmailVerificationMessage))]
        [ApiExplorerSettings(IgnoreApi = true)]
        [AllowAnonymous]
        public async Task<ActionResult> GetEmailVerificationMessage([FromQuery] string? securitySchema,string? UserName)
        {
            try
            {

                var res = await ser.ConfirmMail(UserName, securitySchema);
                return
                    Content(
                    res
                        ? "<div style='text-align: center;'><h1 style='color: green; font-weight: bold; font-size: 24px;'>Congratulations!</h1><p style='font-size: 16px;'>Your email has been verified successfully.</p></div>"
                        : "<h1>somethings strange</h1>", "text/html");

            }
            catch (Exception exp)
            {
                return Content($"Error: {exp.Message}", "text/html");
            }
        }

        [HttpPost]
        [Route(nameof(SignIn))]
        [AllowAnonymous]
        public async Task<ActionResult<(SignInResult, string)>> SignIn([FromBody] SignInModel mod)
        {
            try
            {

                var res = await ser.SignInAsync(mod);
                return Ok(res.Item2);
            }
            catch (Exception exp)
            {
                return BadRequest(exp.Message);
            }
        }

        [HttpPost]
        [Route(nameof(Registration))]
        [AllowAnonymous]
        public async Task<ActionResult<IdentityResult>> Registration([FromBody] UserRegistrationModel user)
        {

            try
            {
                if (!ModelState.IsValid)
                {
                    throw new MarketException(user.Persons.UserName);
                }
                var res = await ser.RegisterUserAsync(user.Persons, user.Password);
                return Ok(res);
            }
            catch (Exception exp)
            {
                return BadRequest(exp.Message);
            }
        }

        [HttpPost]
        [Route("[action]")]
        [ApiExplorerSettings(IgnoreApi = true)]
        public async Task<ActionResult<bool>> RefreshToken([FromQuery] string token)
        {
            try
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
            catch (Exception exp)
            {
                return BadRequest(exp.Message);
            }
        }

        [HttpGet]
        [Route(nameof(ResetPasswordNow))]
        [AllowAnonymous]
        public async Task<ActionResult<string>> ResetPasswordNow(string email, string newPassword)
        {
            try
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
            catch (Exception exp)
            {
                return BadRequest(exp.Message);
            }
        }


        [HttpGet]
        [Route(nameof(ForgetPassword))]
        [ApiExplorerSettings(IgnoreApi = true)]
        [AllowAnonymous]
        public async Task<ActionResult> ForgetPassword([FromQuery] string email, [FromQuery] string password)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    throw new MarketException(email);
                }
                var res = await ser.ForgetPassword(email, password);
                return Content(res ? "<html><body><h1>Password Reset Successfully!</h1></body></html>" : "<html><body><h1>Password Reset Failed</h1></body></html>", "text/html");
            }
            catch (Exception exp)
            {
                return BadRequest(exp.Message);
            }
        }


        [HttpPost]
        [Route(nameof(ResetPassword))]
        public async Task<ActionResult<IdentityResult>> ResetPassword([FromBody] PasswordResetModel arg)
        {
            try
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
            catch (Exception exp)
            {
                return BadRequest(exp.Message);
            }
        }

        [HttpGet]
        [Route(nameof(Info))]
        public async Task<ActionResult<PersonModel>> Info()
        {
            try
            {
                if (User?.Identity is not { Name: not null, IsAuthenticated: true })
                    return BadRequest(ErrorKeys.BadRequest);
                var res = await ser.Info(User.Identity.Name);
                return Ok(res);

            }
            catch (Exception exp)
            {
                return BadRequest(exp.Message);
            }
        }

        [HttpGet]
        [Route(nameof(ConfirmEmail))]
        public async Task<ActionResult<string>> ConfirmEmail()
        {
            try
            {

                if (User.Identity is not null && User.Identity.Name != null && User.Identity.IsAuthenticated)
                {
                    if (await ser.IsEmailConfirmed(User.Identity.Name))
                    {
                        throw new ArgumentException("there is error");
                    }

                    var user = await userManager.FindByNameAsync(User.Identity.Name);
                    if (user == null) return BadRequest(ErrorKeys.BadRequest);

                    var rek = await userManager.GenerateEmailConfirmationTokenAsync(user);
                    var link = Url.ActionLink(nameof(GetEmailVerificationMessage), "UserIdentity",
                        new { SecuritySchema = rek, UserName= User.Identity.Name}, Request.Scheme);
                    if (link == null) return BadRequest("Linki ara  validuri");
                    await ser.SendLinkToUser(User.Identity.Name, link);
                    return Ok(link);
                }

                return NotFound(ErrorKeys.BadRequest);

            }
            catch (Exception exp)
            {
                return BadRequest(exp.Message);
            }
        }

        [HttpPost]
        [Route(nameof(SignOutNow))]
        public async Task<ActionResult<bool>> SignOutNow()
        {
            try
            {
                if (User.Identity is null || !User.Identity.IsAuthenticated || User.Identity.Name is null)
                    return BadRequest(ErrorKeys.BadRequest);
                var res = await ser.SignOutAsync(User.Identity.Name);
                return Ok(res);
            }
            catch (Exception exp)
            {
                return BadRequest(exp.Message);
            }
        }

        [HttpGet]
        [Route("[action]")]
        public async Task<ActionResult<IEnumerable<RoleModel>>> Roles()
        {
            try
            {
                var res = await ser.GetAllRoles();
                return Ok(res);
            }
            catch (Exception exp)
            {
                return BadRequest(exp.Message);
            }
        }

        [HttpGet]
        [Route("[action]")]
        public async Task<ActionResult<IEnumerable<PersonModel>>> Users()
        {
            try
            {
                var res = await ser.GetAllUser();
                return Ok(res);
            }
            catch (Exception exp)
            {
                return BadRequest(exp.Message);
            }
        }

        [HttpDelete]
        [Route("Role/{role:alpha}/[action]")]
        public async Task<ActionResult<IdentityResult>> Delete([FromRoute] string role)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ErrorKeys.BadRequest);
                }
                var res = await ser.DeleteRole(role);
                return Ok(res);
            }
            catch (Exception exp)
            {
                return BadRequest(exp.Message);
            }
        }

        [HttpPost]
        [Route("Role/{role:alpha}/[action]")]
        public async Task<ActionResult<IdentityResult>> Add([FromRoute] string role)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    throw new MarketException(role);
                }
                var res = await ser.AddRolesAsync(role);
                return Ok(res);
            }
            catch (Exception exp)
            {
                return BadRequest(exp.Message);
            }
        }

        [HttpDelete]
        [Route("User/{id}/[action]")]
        public async Task<ActionResult<IdentityResult>> DeleteUser([FromRoute] string id)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    throw new MarketException(id);
                }
                var res = await ser.DeleteUser(id);
                return Ok(res);
            }
            catch (Exception exp)
            {
                return BadRequest(exp.Message);
            }
        }

        [HttpPost]
        [Route("User/{userid}[action]/{role:alpha}")]
        public async Task<ActionResult<IdentityResult>> Role([FromRoute] string userid, [FromRoute] string role)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    throw new MarketException(role);
                }
                var res = await ser.AssignRoleToUserAsync(userid, role);
                return Ok(res);
            }
            catch (Exception exp)
            {
                return BadRequest(exp.Message);
            }
        }
    }
}
