
//using Microsoft.AspNetCore.Authorization;
//using Microsoft.AspNetCore.Identity;
//using Microsoft.EntityFrameworkCore;

//namespace E_CommerceBooksStore.Domain.Identity
//{
//    public class IdentityService : IIdentityService
//    {
//        private readonly UserManager<ApplicationUser> _userManager;
//        private readonly IAuthorizationService _authorizationService;
//        private readonly IUserClaimsPrincipalFactory<ApplicationUser> _userClaimsPrincipalFactory;

//        public IdentityService(UserManager<ApplicationUser> userManager, IAuthorizationService authorizationService, IUserClaimsPrincipalFactory<ApplicationUser> userClaimsPrincipalFactory)
//        {
//            this._userManager = userManager;
//            this._authorizationService = authorizationService;
//            this._userClaimsPrincipalFactory = userClaimsPrincipalFactory;
//        }


//        public async Task<bool> AuthorizeAsync(string userId, string policyName)
//        {

//            var user = await _userManager.Users.SingleOrDefaultAsync(u => u.Id == userId);

//            if (user == null) return false;

//            var principal = await _userClaimsPrincipalFactory.CreateAsync(user);//????
//            var result = await _authorizationService.AuthorizeAsync(principal, policyName);
//            return result.Succeeded;

//        }

//        public async Task<(Result Result, string UserId)> CreateUserAsync(string userName, string password)
//        {
//            var user = new ApplicationUser
//            {
//                UserName = userName,
//                Email = userName
//            };

//            var result = await _userManager.CreateAsync(user, password);
//            return (result.ToApplicationResult(), user.Id);
//        }

//        public async Task<Result> DeleteUserAsync(string userId)
//        {
//            var user = await _userManager.Users.SingleOrDefaultAsync(u => u.Id == userId);
//            return user != null ? await DeleteUserAsync(user) : Result.Success();
//        }

//        public async Task<Result> DeleteUserAsync(ApplicationUser user)
//        {
//            var result = await _userManager.DeleteAsync(user);
//            return result.ToApplicationResult();
//        }

//        public async Task<IEnumerable<UserDto>> GetAll()
//        {
//            return await _userManager.Users.Select(u => new UserDto
//            {
//                UserName = u.UserName,
//                Email = u.Email
//            }).ToListAsync();
//        }

//        public async Task<string> GetUserNameAsync(string userId)
//        {
//            var user = await _userManager.Users.SingleOrDefaultAsync(u => u.Id == userId);
//            if (user == null) return String.Empty;
//            return user.UserName;
//        }

//        public async Task<bool> IsInRoleAsync(string userId, string roleName)
//        {
//            var user = await _userManager.Users.SingleOrDefaultAsync(u => u.Id == userId);
//            return user != null && await _userManager.IsInRoleAsync(user, roleName);
//        }
//    }
//}
