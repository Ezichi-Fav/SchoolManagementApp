using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolManagementApp.Models;
using SchoolManagementApp.DataStore;
namespace SchoolManagementApp.BL
{
    public class SubjectService
    {

        SubjectRepository SubjectRepository = new SubjectRepository
        public Subject Add(string name, User teacher)
        {
            Subject subject = new Subject
            {
                Name = name,
                Teacher = teacher
            } ;
            return SubjectRepository.Add(subject);

        }
public bool Remove (int subjectId)
        {

            return SubjectRepository.Remove(subjectId);

        }

        public bool AddStudentsTakingThisSubject(ClassLevel level, int numberOfStudents)
        {

            var subject = DataStore.Subjects.Find(subject => subjectId == subjectId);

            return SubjectRepository.AddStudentsTakingThisSubject (int subjectId, ClassLevel level, int numberOfStudents);



        }





    }
}
