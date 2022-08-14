using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCoreRestApi.DTO
{
    public class UserDetailsUpdateDTO
    {
        [Required]
        [MaxLength(250)]
        public string Name { get; set; }
        [Required]
        [MaxLength(250)]
        public string Email { get; set; }
        [Required]
        public bool IsAdmin { get; set; }
        [Required]
        [MaxLength(250)]
        public string Password { get; set; }
    }
}
