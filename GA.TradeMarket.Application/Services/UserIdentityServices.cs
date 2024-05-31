using AutoMapper;
using GA.TradeMarket.Application.Interfaces;
using GA.TradeMarket.Application.Models;
using GA.TradeMarket.Domain.Entitites;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA.TradeMarket.Application.Services
{
    public class UserIdentityServices : IUserIdentityService
    {
        private readonly UserManager<Person> usermanag;
        private readonly SignInManager<Person> signinManag;
        private readonly RoleManager<IdentityRole> roleManage;
        private readonly IMapper map;

        public UserIdentityServices(UserManager<Person> usermanag, SignInManager<Person> signinManag, RoleManager<IdentityRole> roleManage, IMapper map)
        {
            this.usermanag = usermanag;
            this.signinManag = signinManag;
            this.roleManage = roleManage;
            this.map = map;
           
        }
        public async  Task AssignRoleToUser(string userid, string role)
        {
          if(await roleManage.RoleExistsAsync(role.ToUpper())&&await usermanag.FindByIdAsync(userid)is not null)
            {
                var user =await  usermanag.FindByIdAsync(userid);
                if (user is not null)
                {
                    await usermanag.AddToRoleAsync(user, role);
                }
            }
        }

        public async Task createRole(string role)
        {
           if(!await  roleManage.RoleExistsAsync(role.ToUpper()))
            {
               await  roleManage.CreateAsync(new IdentityRole(role.ToUpper()));
            }
        }

        public async Task DeleteRole(string role)
        {
            if (!await roleManage.RoleExistsAsync(role.ToUpper()))
            {
                await roleManage.DeleteAsync(new IdentityRole(role.ToUpper()));
            }
        }

        
        public async Task<IdentityResult> Register(UserRegistrationModel mod)
        {
            ArgumentNullException.ThrowIfNull(mod);
            var person = map.Map<Person>(mod.Persons);
            var res = await usermanag.CreateAsync(person, mod.Password);
            if(res is not null)
            {
                return res;
            }
            throw new ArgumentException(" we have exception there");
        }

        public async Task SignIn(SignInModel usr)
        {
            ArgumentNullException.ThrowIfNull(usr);
            var user = await usermanag.FindByEmailAsync(usr.Email);
            if(user is not null)
            {
               var res=await usermanag.CheckPasswordAsync(user, usr.Password);
                if(res is false)
                {
                    throw new UnauthorizedAccessException(" access denied");
                }
            }
        }

        public async Task Signout()
        {
           await  signinManag.SignOutAsync();
        }
    }
}
