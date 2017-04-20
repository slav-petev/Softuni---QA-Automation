using System;
using System.Collections.Generic;

namespace ToolsQA.Tests.Models
{
    public class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MartialStatus { get; set; }
        public IEnumerable<string> Hobbies { get; set; }
        public string Country { get; set; }
        public DateTime Birthday { get; set; }
        public string PhoneNumber { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Picture { get; set; }
        public string Description { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
    }
}
