using AttendEasy.Domain.Entities.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendEasy.Domain.Entities.Studentes
{
    public class Student
    {
        public Student(
            string nationalCode,
            string studentCode,
            string firstName,
            string lastName,
            DateTime registerDate,
            Class @class,
            string profile = "",
            string mobileNumber = "",
            string homeNumber = "",
            string fatherName = "",
            string fatherJob = "",
            string motherJob = "",
            string fatherMobile = "",
            string motherMobile = "",
            string deadParent = "",
            bool leftParent = false,
            string discription = "",
            string address = "")
        {
            Id = Guid.NewGuid();
            NationalCode = nationalCode;
            StudentCode = studentCode;
            FirstName = firstName;
            LastName = lastName;
            Profile = profile;
            MobileNumber = mobileNumber;
            HomeNumber = homeNumber;
            FatherName = fatherName;
            FatherJob = fatherJob;
            MotherJob = motherJob;
            FatherMobile = fatherMobile;
            MotherMobile = motherMobile;
            DeadParent = deadParent;
            LeftParent = leftParent;
            Discription = discription;
            Address = address;
            RegisterDate = registerDate;
            Class = @class;
        }

        [Required]
        public Guid Id { get;  }
        [Required]
        public string NationalCode { get;  } = string.Empty;
        [Required]
        public string StudentCode { get;  } = string.Empty;
        [Required]
        public string FirstName { get; private set; } = string.Empty;
        [Required]
        public string LastName { get; private set; } = string.Empty;
        //Url Of Profile Photo
        public string? Profile { get; private set; }
        public string? MobileNumber { get; private set; }
        public string? HomeNumber { get; private set; }
        public string? FatherName { get; private set; }
        public string? FatherJob { get; private set; }
        public string? MotherJob { get; private set; }
        public string? FatherMobile { get; private set; }
        public string? MotherMobile { get; private set; }
        //Foat valedeyan
        public string? DeadParent { get; private set; }
        //Jodai valedeyan
        public bool? LeftParent { get; private set; }
        //Extra Field For Others 
        public string? Discription { get; private set; }
        public string? Address { get; private set; }
        [Required]
        public byte Score { get; private set; } = 20;
        [Required]
        public DateTime RegisterDate { get; private set; }
        //Class Of Student
        [Required]
        public Class Class { get; private set; } = new Class();
    }
}
