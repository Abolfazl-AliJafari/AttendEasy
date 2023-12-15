using AttendEasy.Domain.Entities.Classes;
using System.ComponentModel.DataAnnotations;

namespace AttendEasy.Presentation.Models.VeiwModels.Student
{
    public class StudentRegisterViewModel
    {
        [Required]
        public string NationalCode { get; set; }
        [Required]
        public string StudentCode { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        public string? Profile { get; set; }
        public string? MobileNumber { get; set; }
        public string? HomeNumber { get; set; }
        public string? FatherName { get; set; }
        public string? FatherJob { get; set; }
        public string? MotherJob { get; set; }
        public string? FatherMobile { get; set; }
        public string? MotherMobile { get; set; }
        public string? DeadParent { get; set; }
        public bool? LeftParent { get; set; }
        public string? Discription { get; set; }
        public string? Address { get; set; }
        [Required]
        public Class Class { get; set; }
    }
}
