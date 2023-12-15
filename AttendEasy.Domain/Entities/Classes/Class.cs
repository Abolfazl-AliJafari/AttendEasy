using AttendEasy.Domain.Entities.Fieldes;
using System.ComponentModel.DataAnnotations;

namespace AttendEasy.Domain.Entities.Classes
{
    public class Class
    {
        [Required]
        public Guid Id { get; }
        //Title Of Class For Example : کلاس نهم الف , دوازدهم شبکه و نرم افزار
        [Required]
        public string Title { get; private set; }
        //Feild Of This Class For Example : شبکه و نرم افزار (Optional)
        public Field? Feild { get; private set; }
    }
    
}