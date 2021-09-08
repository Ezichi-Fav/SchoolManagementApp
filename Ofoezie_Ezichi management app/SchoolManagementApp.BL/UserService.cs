using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolManagementApp.Models;
using SchoolManagementApp.DataStore;
namespace SchoolManagementApp.BL

public class UserService
{
    UserRepository UserRepository = new UserRepository
        public User Add(string name, User user)
    {
        User user = new User
        {
            Id = id,
            FirstName = firstname,
            LastName = lastname,
            DOB =dob,
            Gender = gender,
            Roles = roles
        };
        return UserRepository.Add(user);

    }
    public bool Remove(int userId)
    {

        return UserRepository.Remove(userId);

    }

   
}
