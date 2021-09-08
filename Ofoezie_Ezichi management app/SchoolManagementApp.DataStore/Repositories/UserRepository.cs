using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolManagementApp.Models;


namespace SchoolManagementApp.DataStore.Repositories
{ 


public class UserRepository
	{ 
	 
	public UserRepository Add(User user)
	{
			dataStore.Users.Add(user);
			return user;
	}

		public bool Remove(int userId)
        {

			var user = dataStore.Users.Find(user => userId == userId);
			return dataStore.Users.Remove(user);


        }


}
}