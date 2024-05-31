using GA.TradeMarket.Application.Interfaces;
using GA.TradeMarket.Application.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace GA.TradeMarket.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserIdentityController : ControllerBase
    {

        private readonly IUserIdentityService ser;

        public UserIdentityController(IUserIdentityService se)
        {
            this.ser = se;
        }

        [HttpPost]
        [Route(nameof(SignIn))]
        public async Task<ActionResult> SignIn([FromBody]SignInModel usr)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    throw new ArgumentException("Model state is not valid");
                }
                await ser.SignIn(usr);
                return Ok();
            }
            catch (Exception exp)
            {
                return BadRequest(exp.Message);
            }
        }

        [HttpGet]
        [Route(nameof(SignOut))]
        public async Task<ActionResult> Signout()
        {
            try
            {
                if(!User.Identity.IsAuthenticated)
                {
                    return BadRequest("First YOu must Authorize!");
                }
                await ser.Signout();
                return Ok();
            }
            catch (Exception exp)
            {
                return BadRequest(exp.Message);
            }
        }

        [HttpPost]
        [Route(nameof(Register))]
        public async Task<ActionResult<IdentityResult>> Register([FromBody]UserRegistrationModel mod)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    throw new ArgumentException("Model state is not valid");
                }
                var res = await ser.Register(mod);
                if(res is null)
                {
                    return BadRequest("Unsuccesfull");

                }
                return Ok(res);
            }
            catch (Exception exp)
            {

                return BadRequest(exp.Message);
            }
        }

        [HttpPost]
        [Route("role/{role:alpha}")]
        public async  Task<ActionResult> Role([FromRoute]string role)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    throw new ArgumentException("Model state is not valid");
                }
                await ser.createRole(role);
                return Ok(role);
            }
            catch (Exception exp)
            {
                return BadRequest(exp.Message);
            }
        }

        [HttpDelete]
        [Route("Role/{role:alpha}")]
        public async Task<ActionResult> DeleteRole([FromRoute]string role)
        {

            try
            {
                if (!ModelState.IsValid)
                {
                    throw new ArgumentException("Model state is not valid");
                }
                await ser.DeleteRole(role);
                return Ok(role);
            }
            catch (Exception exp)
            {
                return BadRequest(exp.Message);
            }

        }
        [HttpPost]
        [Route("{userid:alpha}/role/{role:alpha}")]
        public async Task<ActionResult> AssignRoleToUser([FromRoute]string userid,[FromRoute] string role)
        {

            try
            {
                if (!ModelState.IsValid)
                {
                    throw new ArgumentException("Model state is not valid");
                }
                await ser.AssignRoleToUser(userid,role);
                return Ok(role);
            }
            catch (Exception exp)
            {
                return BadRequest(exp.Message);
            }

        }
    }
}
