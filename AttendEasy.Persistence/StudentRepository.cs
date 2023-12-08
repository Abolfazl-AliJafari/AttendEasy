using AttendEasy.Application.Interfaces;
using AttendEasy.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendEasy.Persistence
{
    public class StudentRepository : IStudentRepository
    {

        public List<Student> GetList()
        {
            List<Student> listStudents = new List<Student>();
            for (int i = 0; i < 10; i++)
            {
                listStudents.Add(new Student()
                {
                    Id = i,
                    FirstName = "Abolfazl",
                    LastName = "Alijafari",
                    NationalCode = "1111111111",
                    StudentCode = "1111111111",
                    Class = new Domain.Entities.Clas()
                    {
                        Id = i,
                        Title = "کلاس دوازدهم شبکه",
                        Feild = new Domain.Entities.Field()
                        {
                            Id = i,
                            Title = "شبکه و نرم افزار"
                        }
                    },
                    RegisterDate = DateTime.Now,
                    Address = "کاشان"
                });
            }
            return listStudents;
        }
    }
}
