using HomeService.Service.Configurations;
using HomeService.WebApi.Models.Users;
using Org.BouncyCastle.Crypto;

namespace HomeService.WebApi.ApiServices.Users;

public interface IUserApiService
{
    ValueTask<UserViewModel> PostAsync(UserCreateModel createModel);
    ValueTask<UserViewModel> PutAsync(long id, UserUpdateModel createModel);
    ValueTask<bool> DeleteAsync(long id);
    ValueTask<UserViewModel> GetAsync(long id);
    ValueTask<IEnumerable<UserViewModel>> GetAsync(PaginationParams @params, Filter filter, string search = null);
    ValueTask<UserViewModel> ChangePasswordAsync(UserChangePasswordModel changePasswordModel);
}
