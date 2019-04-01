using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FactWorkflow.Models
{
    public class User
    {
        [Key]
        public int UId { get; set; }
        public string UMail { get; set; }
        public string UPassword { get; set; }
        public string UName { get; set; }

        public int? RId { get; set; }
        public Role Role { get; set; }

        public List<History> Histories { get; set; }

        public User()
        {
            Histories = new List<History>();
        }
    }

    public class DTOUser
    {
        public int UId { get; set; }
        public string UName { get; set; }

        public DTOUser()
        {

        }

        public DTOUser(User user)
        {
            this.UId = user.UId;
            this.UName = user.UName;
        }
    }

    public class Role
    {
        [Key]
        public int RId { get; set; }
        public string RName { get; set; }
        public string RAlterName { get; set; }

        public List<User> Users { get; set; }

        public Role()
        {
            Users = new List<User>();
        }
    }
}
