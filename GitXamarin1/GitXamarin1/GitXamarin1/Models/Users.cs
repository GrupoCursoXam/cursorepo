using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace GitXamarin1.Models
{
    public class Users
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string FirsName { get; set; }
        public string LastName { get; set; }
        public string Country { get; set; }

        public string Age { get; set; }


        public DateTime CreationDate { get; set; }



    }
}
