using EgitimPortalProject.Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace EgitimPortalProject.Core.Utilities.Security.Jwt
{
 public   interface ITokenHelper
    {
        AccessToken CreateToken(Users user, List<Roles> operationClaims);
    }
}
