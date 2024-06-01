using GA.TradeMarket.Application.Models;
using GA.TradeMarket.Domain.Entitites;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA.TradeMarket.Application.Interfaces
{
    public interface IUserIdentityService
    {
        Task SignIn(SignInModel usr);
        Task Signout();
        Task<IdentityResult> Register(UserRegistrationModel mod);
        Task createRole(string role);
        Task DeleteRole(string role);
        Task AssignRoleToUser(string userid,string role);
    }
}
