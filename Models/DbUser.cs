using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace H3ProjektAPITest.Models
{
    //The Entity Framework class to create the Users table in the database
    public class DbUser
    {
        [Key]
        [Column(TypeName = "nvarchar(255)")]
        public string Username { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(500)")]
        public string HashedPassword { get; set; }
        [Required]
        [Column(TypeName ="nvarchar(255)")]
        public string Salt { get; set; }
    }
}
