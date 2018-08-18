using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Blog.Models
{
    public interface IUserRoleRepositories
    {
        List<UserRoles> GetAllUserRole();
    }
}