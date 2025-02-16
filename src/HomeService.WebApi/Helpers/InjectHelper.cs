using HomeService.Service.Services.Permissions;
using HomeService.Service.Services.RolePermissions;
using HomeService.Service.Services.UserRoles;
using HomeService.Service.Services.Users;

namespace HomeService.WebApi.Helpers;

public static class InjectHelper
{
    public static IUserService UserService;
    public static IUserRoleService UserRoleService;
    public static IPermissionService PermissionService;
    public static IRolePermissionService RolePermissionService;
}
