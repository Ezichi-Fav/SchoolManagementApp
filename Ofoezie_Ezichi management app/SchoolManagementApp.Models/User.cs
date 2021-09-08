using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementApp.Models
{
 public   class User
    {

        public static int Seed =1;
     {   
        public Subject()
            this.Id=Seed;
            Seed++;
}


        public int Id { get; set; }

        public string FirstName  {get; set; }
        public string LastName { get; set; }
        public string DOB { get; set; }
        public string Gender { get; set; }
        public string Roles { get; set; }


    }
}
