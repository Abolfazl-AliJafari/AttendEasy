
using AttendEasy.Domain.Enumerations;
using AttendEasy.Domain.ValueObjects;
using AttendEasy.Domain.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace AttendEasy.Domain.Entities
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
            if (string.IsNullOrWhiteSpace(firstName))
            {
                throw new ArgumentException("FirstName Is Required.");
            }
            if (string.IsNullOrWhiteSpace(lastName))
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
        [DisplayName("کد ملی")]
        public NationalCode NationalCode { get;  }
        [Required]
        [DisplayName("کد دانش آموزی")]
        public StudentCode StudentCode { get;  } 
        [Required]
        [DisplayName("نام")]
        public FirstName FirstName { get;  private set; }
        [Required]
        [DisplayName("نام خانوادگی")]
        public LastName LastName { get; private set; }
        [Required]
        [DisplayName("تاریخ تولد")]
        public BirthDayDate BirthDayDate { get; private set; }
        //Url Of Profile Photo
        [DisplayName("پروفایل")]
        public string? Profile { get; private set; }
        [DisplayName("شماره تلفن همراه")]
        public MobileNumber? MobileNumber { get; private set; }
        [DisplayName("شماره تلفن ثابت")]
        public HomeNumber? HomeNumber { get; private set; }
        [DisplayName("نام پدر")]
        public FirstName? FatherName { get; private set; }
        [DisplayName("شغل پدر")]
        public Job? FatherJob { get; private set; }
        [DisplayName("شغل مادر")]
        public Job? MotherJob { get; private set; }
        [DisplayName("شماره موبایل پدر")]
        public MobileNumber? FatherMobile { get; private set; }
        [DisplayName("شماره موبایل مادر")]
        public MobileNumber? MotherMobile { get; private set; }
        //Foat valedeyan
        [DisplayName("فوت والدین")]
        public DeadParentStatus? DeadParent { get; private set; }
        //Jodai valedeyan
        [DisplayName("جدایی والدین")]
        public bool? LeftParent { get; private set; }
        //Extra Field For Others 
        [DisplayName("توضیحات بیشتر")]
        public string? Description { get; private set; }
        [DisplayName("آدرس محل سکونت")]
        public string? Address { get; private set; }
        [Required]
        [DisplayName("نمره انضباطی")]
        public Score Score { get; private set; } = 20;

        [Required]
        [DisplayName("دین")]
        public Religion Religion { get; private set; }

        [Required]
        [DisplayName("ملیت")]
        public Nationality Nationality { get; private set; }
        //[Required]
        //public DateTime RegisterDate { get;}
        //Class Of Student
        [DisplayName("اثر انگشت")]
        public byte[] FingerPrint { get; private set; }

        public Class Class { get; private set; }
        public IReadOnlyCollection<AttendAndAbsenceStatus> AttendAndAbsenceStatuses { get; init; }
        public IReadOnlyCollection<AttendAndAbsenceTraffic> Traffics { get; init; }
        public IReadOnlyCollection<DisciplinaryStatus> DisciplinaryStatuses { get; init; }




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


        public Result SetFingerPrint(byte[] fingerPrint)
        {
            //validate FingerPrint
            FingerPrint= fingerPrint;
            return new Result(true);
        }

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
