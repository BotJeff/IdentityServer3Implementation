using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IdSrv3.Models;

namespace IdSrv3.MembershipReboot.Registration
{
    interface IRegisterUser
    {
        void Register(LocalRegistrationModel model);
    }
}
