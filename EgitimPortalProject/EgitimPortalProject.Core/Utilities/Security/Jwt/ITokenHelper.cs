using EgitimPortalProject.Core.Entities.Concrete;
using System.Collections.Generic;

namespace EgitimPortalProject.Core.Utilities.Security.Jwt
{
    public interface ITokenHelper
    {
        AccessToken CreateToken(Users user, List<Roles> operationClaims);
    }
}