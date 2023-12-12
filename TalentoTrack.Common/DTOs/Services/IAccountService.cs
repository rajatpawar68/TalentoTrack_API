using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TalentoTrack.Common.DTOs.Account;

namespace TalentoTrack.Common.DTOs.Services
{
    public interface IAccountService
    {
        LoginResponse VerifyLoginDetails(LoginRequest Request);
    }
}
