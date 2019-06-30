using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UserStoryOnline.Models
{
    public class Users
    {

        public int User_id {get; set;}
        public string FirstName {get; set;}
        public string Surname { get; set; }
        public string Username { get; set; }

        public string Email { get; set; }
        public string Password { get; set; }

       

    }
}
