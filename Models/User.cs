using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace H3ProjektAPITest.Models
{
    //User class to retrieve data from the website and map it to the DbUser class for database mapping
    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }

    }
}
