using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementApp.Models
{
   public  class Subject
    {
public static int Seed =1;
     {  
        public Subject()
            this.Id=Seed;
            Seed++;
}

        public Dictionary<ClassLevel, int> StudentsPerClass{ get; set; } 
        public string Name { get; set; }
        public User Teacher { get; set; }
    }
}
