using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace H3ProjektAPITest.Models
{
    public class UserLog
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(255)")]
        public string Username { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(255)")]
        public string UserChoice { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(500)")]
        public string Token { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(255)")]
        public string StatusMessage { get; set; }
        public string LogTime { get; set; }

    }
}
