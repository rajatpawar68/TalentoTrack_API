


using TalentoTrack.Common.DTOs.Account;
using TalentoTrack.Common.DTOs.Services;
using TalentoTrack.Common.Repositories;
using TalentoTrack.Dao.Repositories;

namespace TalentoTrack.Service
{
    public class AccountService : IAccountService
    {

        public readonly IAccountRepository _accountRepository;

        public AccountService(AccountRepository accountRepository)
        {
            _accountRepository = accountRepository;
        }
        public async Task<LoginResponse> VerifyLoginDetails(LoginRequest request)
        {
            LoginResponse response = new LoginResponse();
            try
            {
                var dbUser = await _accountRepository.GetLoginDetails(request.Username!, request.Password!);
                if (dbUser == null)
                {
                    response.Success=false;
                    response.ErrorMessage = "Invalid Credentils";

                }
                else
                { 
                    response.Success = true; 
                }

            }
            catch (Exception ex)
            {
                //TODO:Log Error
                throw;
            }
        }
    }
}