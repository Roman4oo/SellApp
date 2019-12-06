using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.DTOs
{
    public class UserDTO
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int? RoleId { get; set; }
    }
}
