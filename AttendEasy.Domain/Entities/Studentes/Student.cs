using AttendEasy.Domain.Entities.Classes;
using AttendEasy.Domain.Entities.Studentes.Enums;
using AttendEasy.Domain.Entities.Studentes.ValueObjects;
using AttendEasy.Domain.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace AttendEasy.Domain.Entities.Studentes
{
    public class Student
    {
        public Student(
            NationalCode nationalCode,
            StudentCode studentCode,
            FirstName firstName,
            LastName lastName,
            DateTime registerDate,
            Class @class,
            string profile ,
            [Optional] MobileNumber mobileNumber ,
            [Optional] HomeNumber homeNumber ,
            [Optional] FirstName fatherName,
            [Optional] Job fatherJob,
            [Optional] Job motherJob,
            [Optional] MobileNumber fatherMobile,
            [Optional] MobileNumber motherMobile,
            DeadParentStatus deadParent = DeadParentStatus.None,
            bool leftParent = false,
            string description = "",
            string address = "")
        {
            Id = Guid.NewGuid();
            if(string.IsNullOrWhiteSpace(nationalCode))
            {
                throw new ArgumentException("NationalCode Is Required.");
            }
            if (string.IsNullOrWhiteSpace(studentCode))
            {
                throw new ArgumentException("StudentCode Is Required.");
            }
            if (string.IsNullOrWhiteSpace(FirstName))
            {
                throw new ArgumentException("FirstName Is Required.");
            }
            if (string.IsNullOrWhiteSpace(LastName))
            {
                throw new ArgumentException("LastName Is Required.");
            }
            if (@class is null)
            {
                throw new ArgumentException("Class Is Required.");
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
            Description= description;
            Address = address;
            Class = @class;

        }

        [Required]
        public Guid Id { get;  }
        [Required]
        public NationalCode NationalCode { get;  }
        [Required]
        public StudentCode StudentCode { get;  } 
        [Required]
        public FirstName FirstName { get;  set; }
        [Required]
        public LastName LastName { get;  set; }
        //Url Of Profile Photo
        public string? Profile { get;  set; }
        public MobileNumber? MobileNumber { get;  set; }
        public HomeNumber? HomeNumber { get;  set; }
        public FirstName? FatherName { get;  set; }
        public Job? FatherJob { get;  set; }
        public Job? MotherJob { get;  set; }
        public MobileNumber? FatherMobile { get;  set; }
        public MobileNumber? MotherMobile { get;  set; }
        //Foat valedeyan
        public DeadParentStatus? DeadParent { get; set; }
        //Jodai valedeyan
        public bool? LeftParent { get; set; }
        //Extra Field For Others 
        public string? Description { get; set; }
        public string? Address { get;  set; }
        [Required]
        public Score Score { get; private set; } = 20;
        //[Required]
        //public DateTime RegisterDate { get;}
        //Class Of Student
        [Required]
        public Class Class { get; set; }

        //public Result Update(
        //    [Optional] Class @class,
        //    DeadParentStatus? deadParent = null,
        //    string firstName = "",
        //    string lastName = "",
        //    string profile = "",
        //    string mobileNumber = "",
        //    string homeNumber = "",
        //    string fatherName = "",
        //    string fatherJob = "",
        //    string motherJob = "",
        //    string fatherMobile = "",
        //    string motherMobile = "",
        //    bool leftParent = false,
        //    string description = "",
        //    string address = "")
        //{
        //    if (@class is not null)
        //    {
        //        Class = @class;
        //    }
        //    if (!string.IsNullOrEmpty(firstName))
        //    {
        //        FirstName = firstName;
        //    }
        //    if (!string.IsNullOrEmpty(lastName))
        //    {
        //        LastName = lastName;
        //    }
        //    if (!string.IsNullOrEmpty(profile))
        //    {
        //        Profile = profile;
        //    }
        //    if (!string.IsNullOrEmpty(mobileNumber))
        //    {
        //        MobileNumber = mobileNumber;
        //    }
        //    if (!string.IsNullOrEmpty(homeNumber))
        //    {
        //        HomeNumber = homeNumber;
        //    }
        //    if (!string.IsNullOrEmpty(fatherName))
        //    {
        //        FatherName = fatherName;
        //    }
        //    if (!string.IsNullOrEmpty(fatherJob))
        //    {
        //        FatherJob = fatherJob;
        //    }
        //    if (!string.IsNullOrEmpty(motherJob))
        //    {
        //        MotherJob = motherJob;
        //    }
        //    if (!string.IsNullOrEmpty(fatherMobile))
        //    {
        //        FatherMobile = fatherMobile;
        //    }
        //    if (!string.IsNullOrEmpty(motherMobile))
        //    {
        //        MotherMobile = motherMobile;
        //    }
        //    if (deadParent is not null)
        //    {
        //        DeadParent = deadParent;
        //    }
        //    if (leftParent is not false)
        //    {
        //        LeftParent = leftParent;
        //    }
        //    if (!string.IsNullOrEmpty(description))
        //    {
        //        Description = description;
        //    }
        //    if (!string.IsNullOrEmpty(address))
        //    {
        //        Address = address;
        //    }
        //    return new Result(true);
        //}

        public Result UpdateScore(float score , ScoreUpdateType scoreUpdateType)
        {
            if (score is not 0)
            {
                if (scoreUpdateType == ScoreUpdateType.Plus)
                {
                    Score += score;
                    return new Result(true);
                }
                Score -= score;
                return new Result(true);
            }
            return new Result(false,"UpdateScore Value Cant Be 0.");
        }
    }
}
