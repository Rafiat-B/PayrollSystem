using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    public class User
    {
        public User(string userId, string password, bool isAdmin)
        {
            UserId = userId;
            Password = password;
            IsAdmin = isAdmin;
        }

        public User(string userId, long empId, string name, string password, string email, string phone, DateTime dobirth, string address, bool isAdmin)
        {
            UserId = userId;
            EmpId = empId;
            Name = name;
            Password = password;
            Email = email;
            Phone = phone;
            Dobirth = dobirth;
            Address = address;
            IsAdmin = isAdmin;
        }

        public string UserId { get; set; }
        public long EmpId { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime Dobirth { get; set; }
        public string Address { get; set; }
        public bool IsAdmin { get; set; }

        public override bool Equals(object obj)
        {
            return obj is User user &&
                   UserId == user.UserId;
        }
    }
}
