using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using AttendEasy.Domain.ValueObjects;

namespace AttendEasy.Domain.Entities
{
    public class Field
    {
        public Field(Title title)
        {
            Id = Guid.NewGuid();
            if(title is null)
            {
                throw new ArgumentNullException("Field Title Can Not Null.");
            }
            Title = title;
        }
        [Required]
        public Guid Id { get; }
        //Title Of Feild for Example : شبکه و نرم افزار ,  ریاضی فیزیک
        [Required]
        [DisplayName("عنوان")]
        public Title Title { get; private set; }
    }
}