using System.ComponentModel.DataAnnotations;

namespace AttendEasy.Domain.Entities.Fieldes
{
    public class Field
    {
        [Required]
        public Guid Id { get; }
        //Title Of Feild for Example : شبکه و نرم افزار ,  ریاضی فیزیک
        [Required]
        public string Title { get; private set; }
    }
}