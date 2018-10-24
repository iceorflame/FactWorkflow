using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace FactWorkflow.Models
{
    public class RegisterModel
    {
        public string Email { get; set; }

        public string Name { get; set; }

        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }

        [DataType(DataType.Password)]
        public string Token { get; set; }
    }
}
