using System;
using System.Collections.Generic;
using System.Text;

namespace EgitimPortalProject.Entities.Messages
{

    //TODO buradaki mesaj yapısının daha iyisi var  mı sorulabilir ?
   public enum Messages
    {
        UsernameAlreadyExist = 101,
        EmailAlreadyExist = 102,
        UserIsNotActive = 151,
        UsernameOrPassWrong = 152,
        CheckYourEmail = 153,
        UserAlreadyActive = 154,
        ActivateIdDoesNotExist = 155
    }
}
