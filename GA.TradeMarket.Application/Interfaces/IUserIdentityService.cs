using GA.TradeMarket.Application.Models;
using Microsoft.AspNetCore.Identity;

namespace GA.TradeMarket.Application.Interfaces
{
    public interface IUserIdentityService
    {
        Task<IdentityResult> DeleteRole(string role);
        Task<PersonModel> Info(string username);
        Task<bool> ForgetPassword(string email, string newPassword);
        Task<bool> RefreshToken(string username, string token);
        Task<IdentityResult> RegisterUserAsync(PersonModel user, string password);
        Task<(SignInResult, string)> SignInAsync(SignInModel mod);
        Task<IdentityResult> AddRolesAsync(string roleName);
        Task<IdentityResult> AssignRoleToUserAsync(string userId, string role);
        Task<IdentityResult> ResetPasswordAsync(PasswordResetModel arg, string username);
        Task<bool> SignOutAsync(string username);
        Task<IdentityResult> DeleteUser(string id);
        Task<IEnumerable<RoleModel>> GetAllRoles();
        Task<IEnumerable<PersonModel>> GetAllUser();
        Task<bool> IsEmailConfirmed(string email);
        Task<bool> ConfirmMail(string username, string mail);
        Task<bool> SendLinkToUser(string name, string link);
        Task<bool> IsUserExist(string email);
    }
}
