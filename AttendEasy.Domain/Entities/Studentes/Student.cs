using AttendEasy.Domain.Entities.Classes;
using AttendEasy.Domain.Entities.Studentes.Enums;
using AttendEasy.Domain.Entities.Studentes.ValueObjects;
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
            DeadParentStatus deadParent = DeadParentStatus.None,
            bool leftParent = false,
            string discription = "",
            string address = "")
        {
            Id = Guid.NewGuid();
            if(string.IsNullOrWhiteSpace(nationalCode))
            {
                throw new Exception("NationalCode Is Required.");
            }
            if (string.IsNullOrWhiteSpace(studentCode))
            {
                throw new Exception("StudentCode Is Required.");
            }
            if (string.IsNullOrWhiteSpace(FirstName))
            {
                throw new Exception("FirstName Is Required.");
            }
            if (string.IsNullOrWhiteSpace(LastName))
            {
                throw new Exception("LastName Is Required.");
            }
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
            RegisterDate = DateTime.Now;
        }

        [Required]
        public Guid Id { get;  }
        [Required]
        public NationalCode NationalCode { get;  } = string.Empty;
        [Required]
        public StudentCode StudentCode { get;  } = string.Empty;
        [Required]
        public FirstName FirstName { get; set; } = string.Empty;
        [Required]
        public LastName LastName { get; set; } = string.Empty;
        //Url Of Profile Photo
        public string? Profile { get; set; }
        public MobileNumber? MobileNumber { get; set; }
        public HomeNumber? HomeNumber { get; set; }
        public FirstName? FatherName { get; set; }
        public Job? FatherJob { get; set; }
        public Job? MotherJob { get; set; }
        public MobileNumber? FatherMobile { get; set; }
        public MobileNumber? MotherMobile { get; set; }
        //Foat valedeyan
        public DeadParentStatus? DeadParent { get; set; }
        //Jodai valedeyan
        public bool? LeftParent { get; set; }
        //Extra Field For Others 
        public string? Discription { get; set; }
        public string? Address { get; set; }
        [Required]
        public Score Score { get; private set; } = 20;
        [Required]
        public DateTime RegisterDate { get; set; }
        //Class Of Student
        [Required]
        public Class Class { get; set; } = new Class();

        public void 
    }
}
