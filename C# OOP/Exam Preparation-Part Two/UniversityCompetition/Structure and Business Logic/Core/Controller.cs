using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityCompetition.Core.Contracts;
using UniversityCompetition.Models;
using UniversityCompetition.Models.Contracts;
using UniversityCompetition.Repositories.Contracts;

namespace UniversityCompetition.Core
{
    public class Controller : IController
    {
        private SubjectRepository subjects;
        private StudentRepository students;
        private UniversityRepository universities;
        private string[] allowedCategories = new string[] { "TechnicalSubject", "HumanitySubject", "EconomicalSubjecy" };

        public Controller()
        {
            subjects = new SubjectRepository();
            students = new StudentRepository();
            universities = new UniversityRepository();
        }

        public string AddStudent(string firstName, string lastName)
        {
            if (students.FindByName($"{firstName} {lastName}") != null)
            {
                return $"{firstName} {lastName} is already added in the repository.";
            }

            IStudent student = new Student(0, firstName, lastName);

            students.AddModel(student);

            return $"Student {firstName} {lastName} is added to the {typeof(StudentRepository).Name}!";
        }

        public string AddSubject(string subjectName, string subjectType)
        {
            ISubject subject = null;

            if (subjectType != nameof(TechnicalSubject) && subjectType != nameof(EconomicalSubject) && subjectType != nameof(HumanitySubject))
            {
                return $"Subject type {subjectType} is not available in the application!";
            }

            if (subjects.FindByName(subjectName) != null)
            {
                return $"{subjectName} is already added in the repository.";
            }

            if (subjectType == typeof(TechnicalSubject).Name)
            {
                subject = new TechnicalSubject(0, subjectName);
            }
            else if (subjectType == typeof(EconomicalSubject).Name)
            {
                subject = new EconomicalSubject(0, subjectName);
            }
            else if (subjectType == typeof(HumanitySubject).Name)
            {
                subject = new HumanitySubject(0, subjectName);
            }

            subjects.AddModel(subject);

            return $"{subjectType} {subjectName} is created and added to the {typeof(SubjectRepository).Name}!";
        }

        public string AddUniversity(string universityName, string category, int capacity, List<string> requiredSubjects)
        {
            if (universities.FindByName(universityName) != null)
            {
                return $"{universityName} is already added in the repository.";
            }

            List<int> requiredSubjectsAsInts = requiredSubjects.Select(s => subjects.FindByName(s).Id).ToList();

            IUniversity university = new University(0, universityName, category, capacity, requiredSubjectsAsInts);

            universities.AddModel(university);

            return $"{universityName} university is created and added to the {typeof(UniversityRepository).Name}!";
        }

        public string ApplyToUniversity(string studentName, string universityName)
        {
            string[] splitted = studentName.Split(" ");
            string firstName = splitted[0];
            string lastName = splitted[1];

            IStudent student = students.FindByName($"{firstName} {lastName}");
            IUniversity university = universities.FindByName(universityName);

            if (student == null)
            {
                return $"{firstName} {lastName} is not registered in the application!";
            }

            if (university == null)
            {
                return $"{universityName} is not registered in the application!";
            }

            foreach (var requiredExam in university.RequiredSubjects)
            {
                if (!student.CoveredExams.Contains(requiredExam))
                {
                    return $"{studentName} has not covered all the required exams for {universityName} university!";
                }
            }

            if (student.University != null && student.University.Name == university.Name)
            {
                return $"{firstName} {lastName} has already joined {universityName}.";
            }

            student.JoinUniversity(university);

            return $"{firstName} {lastName} joined {universityName} university!";
        }

        public string TakeExam(int studentId, int subjectId)
        {
            IStudent student = students.FindById(studentId);
            ISubject subject = subjects.FindById(subjectId);    

            if (student == null)
            {
                return $"Invalid student ID!";
            }

            if (subject == null)
            {
                return $"Invalid subject ID!";
            }

            if (student.CoveredExams.Contains(subjectId))
            {
                return $"{student.FirstName} {student.LastName} has already covered exam of {subject.Name}.";
            }

            student.CoverExam(subject);

            return $"{student.FirstName} {student.LastName} covered {subject.Name} exam!";
        }

        public string UniversityReport(int universityId)
        {
            IUniversity university = universities.FindById(universityId);

            StringBuilder sb = new StringBuilder();

            int admittedStudents = CountStudentsForUniversity(university);

            sb.AppendLine($"*** {university.Name} ***");
            sb.AppendLine($"Profile: {university.Category}");
            sb.AppendLine($"Students admitted: {admittedStudents}");
            sb.AppendLine($"University vacancy: {university.Capacity - admittedStudents}");

            return sb.ToString().TrimEnd();
        }

        private int CountStudentsForUniversity(IUniversity university) 
        {
            int count = 0;  

            foreach (var student in students.Models)
            {
                if (student.University?.Id == university.Id)
                {
                    count++;
                }
            }

            return count;
        }
    }
}
