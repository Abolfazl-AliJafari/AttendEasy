using System.ComponentModel.DataAnnotations;

namespace AttendEasy.Domain.Entities
{
    public class Field
    {
        [Required]
        public int Id { get; set; }
        //Title Of Feild for Example : شبکه و نرم افزار ,  ریاضی فیزیک
        [Required]
        public string Title { get; set; }
    }
}