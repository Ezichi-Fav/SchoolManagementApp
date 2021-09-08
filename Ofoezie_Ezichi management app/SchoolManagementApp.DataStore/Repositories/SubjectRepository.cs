using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolManagementApp.Models;


namespace SchoolManagementApp.DataStore.Repositories
{


	public class SubjectRepository
	{ 

		public SubjectRepository Add(Subject subject)
		{
			DataStore.Subject.Add(subject);
			return subject;
		}

		public bool Remove(int subjectId)
		{

			var user = DataStore.Users.Find(subject => subjectId == subjectId);
			return DataStore.Users.Remove(subject);


		}


		public bool AddStudentsTakingThisSubject(ClassLevel level, int numberOfStudents)
		{

			var subject = DataStore.Subjects.Find(subject => subjectId == subjectId);
			//jss1 +3
			if (subject.StudentsPerClass.ContainsKey(level))
            {


subject.StudentsPerClass(level))+= numberOfStudents;

					else

                    {

					subject.StudentsPerClass.Add(level, numberOfStudents);


				}
				return true;


			}


			



		}


	}
}
