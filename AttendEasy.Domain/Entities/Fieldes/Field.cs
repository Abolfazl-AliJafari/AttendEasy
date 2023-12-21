using System.ComponentModel.DataAnnotations;
using AttendEasy.Domain.Entities.Fieldes.ValueObjects;

namespace AttendEasy.Domain.Entities.Fieldes
{
    public class Field
    {
        public Field(Title title)
        {
            Id = Guid.NewGuid();
            Title = title;
        }
        [Required]
        public Guid Id { get; }
        //Title Of Feild for Example : شبکه و نرم افزار ,  ریاضی فیزیک
        [Required]
        public Title Title { get; private set; }
    }
}