using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Datalayer
{
    public class StudentRepository
    {
        private JtableDemoEntities _dbContext = new JtableDemoEntities();

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public IList<Student> GetAllStudents()
        {
            IList<Student> studentList = _dbContext.Student.ToList();
            return studentList;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public Student GetById(int Id)
        {
            try
            {
                var foundStudent = _dbContext.Student.FirstOrDefault(s => s.StudentId == Id);
                if (foundStudent != null)
                {
                    return foundStudent;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="student"></param>
        /// <returns></returns>
        public Student CreateStudent(Student student)
        {
            try
            {
                _dbContext.Student.AddObject(student);
                _dbContext.SaveChanges();
                return student;
            }
            catch (Exception ex)
            {
                //log
                return null;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="student"></param>
        /// <returns></returns>
        public Student UpdateStudent(Student student)
        {
            try
            {
                var foundStudent = _dbContext.Student.FirstOrDefault(s => s.StudentId == student.StudentId);
                if (foundStudent != null)
                {
                    foundStudent.FirstName = student.FirstName;
                    foundStudent.LastName = student.LastName;
                    foundStudent.Address = student.Address;
                    foundStudent.Age = student.Age;

                    _dbContext.Student.ApplyCurrentValues(foundStudent);
                    _dbContext.SaveChanges();
                    return foundStudent;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="studentId"></param>
        public void DeleteStudent(int studentId)
        {
            try
            {
                var foundStudent = _dbContext.Student.FirstOrDefault(s => s.StudentId == studentId);
                if (foundStudent != null)
                {
                    _dbContext.Student.DeleteObject(foundStudent);
                    _dbContext.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                //log
            }
        }
    }
}
