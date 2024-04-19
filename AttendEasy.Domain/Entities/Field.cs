using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using AttendEasy.Domain.ValueObjects;

namespace AttendEasy.Domain.Entities
{
    public class Field : Entity<int>
    {
        public Field(Title title)
        {
           
            if(title is null)
            {
                throw new ArgumentNullException("Field Title Can Not Null.");
            }
            Title = title;
        }
        //Title Of Feild for Example : شبکه و نرم افزار ,  ریاضی فیزیک

        public Title Title { get; private set; }
    }
}