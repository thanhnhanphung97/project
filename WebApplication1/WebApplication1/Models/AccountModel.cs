using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    
    public class AccountModel
    {
        private dataEntities context = null;

        public AccountModel()
        {
            context = new dataEntities();
        }
        public bool Login(string userName, string password)
        {
            object[] sqlParams =
            {
                new SqlParameter("@UserName",userName),
                new SqlParameter("@Password",password),
            };
            var res = context.Database.SqlQuery<bool>("Sp_Account_Login @UserName,@Password", sqlParams).SingleOrDefault();
            return res;
        }
    }
}