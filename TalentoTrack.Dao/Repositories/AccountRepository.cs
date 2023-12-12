using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TalentoTrack.Common.DTOs.Account;
using TalentoTrack.Dao.DB;
using TalentoTrack.Common.Entities;

namespace TalentoTrack.Dao.Repositories
{

    public class AccountRepository :IAccountRepository
    {
        public TalentoTrack_DbContext _dbContext;
        private object p;

        public AccountRepository(TalentoTrack_DbContext dbContext)
        { 
            _dbContext = dbContext; 
        }

        public async Task<LoginDetails>GetLoginDetails(string userName,string Password)
        {
           
            
                var dbRecord = await _dbContext.tbl_login_details.Where(p => p.UserName != null&& p.UserName.Equals(userName) && (Password != null && Password.Equals(Password))).FirstOrDefaultAsync();
                return  dbRecord;
        }
            
    }
}
