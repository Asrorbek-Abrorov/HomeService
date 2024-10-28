using HomeService.WebApi.Models.Permissions;
using HomeService.WebApi.Models.UserRoles;

namespace HomeService.WebApi.Models.RolePermissions;

public class RolePermissionViewModel
{
    public long Id { get; set; }
    public UserRoleViewModel Role { get; set; }
    public PermissionViewModel Permission { get; set; }
}
