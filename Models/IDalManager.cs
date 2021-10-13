using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace H3ProjektAPITest.Models
{
    interface IDalManager
    {
        string GenerateSalt();
        bool CheckUsername(string username, LoginDBContext context);
        string CreateHashedPassword(string password, string salt);
        string GetSaltFromDB(string username, LoginDBContext context);
        string GetHashedPasswordFromDB(string username, LoginDBContext context);
        bool ValidatePassword(string password, string username, string salt, string HashedPassword);
        void LogDbLogin(string username, string userChoice, string token, string statusMessage, LoginDBContext context);

    }
}
