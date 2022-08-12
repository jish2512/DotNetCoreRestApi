using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCoreRestApi.Models
{
    public class UserData
    {
        [Key]
        public int ID { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        [Required]
        [MaxLength(250)]
        public string Email { get; set; }
        [Required]
        [MaxLength(250)]
        public string Password { get; set; }
        [Required]
        public bool IsAdmin { get; set; }

    }
}
