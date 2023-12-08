using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendEasy.Domain.Entities
{
    public class Student
    {

        [Required]
        public int Id { get; set; }
        [Required]
        public string NationalCode { get; set; }
        [Required]
        public string StudentCode { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        //Url Of Profile Photo
        public string? Profile { get; set; }
        public string? MobileNumber { get; set; }
        public string? HomeNumber { get; set; }
        public string? FatherName { get; set; }
        public string? FatherJob { get; set; }
        public string? MotherJob { get; set; }
        public string? FatherMobile { get; set; }
        public string? MotherMobile { get; set; }
        //Foat valedeyan
        public string? DeadParent { get; set; }
        //Jodai valedeyan
        public bool? LeftParent { get; set; }
        //Extra Field For Others 
        public string? Discription { get; set; }
        public string? Address { get; set; }
        [Required]
        public byte Score { get; set; } = 20;
        [Required]
        public DateTime RegisterDate { get; set; }
        //Class Of Student
        [Required]
        public Clas Class { get; set; }
    }
}
