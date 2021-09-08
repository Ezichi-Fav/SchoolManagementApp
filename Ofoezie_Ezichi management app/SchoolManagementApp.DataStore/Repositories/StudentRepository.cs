using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolManagementApp.Models;


namespace SchoolManagementApp.DataStore.Repositories
{


	public class StudentRepository
	{

		public StudentRepository Add(Student student)
		{
			dataStore.Student.Add(student);
			return student;
		}

		public bool Remove(int studentId)
		{

			var user = dataStore.Student.Find(student => studentId == studentId);
			return DataStore.student.Remove(student);


		}
	}
}