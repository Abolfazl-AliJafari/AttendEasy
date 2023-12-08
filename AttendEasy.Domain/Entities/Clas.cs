using System.ComponentModel.DataAnnotations;

namespace AttendEasy.Domain.Entities
{
    public class Clas
    {
        [Required]
        public int Id { get; set; }
        //Title Of Class For Example : کلاس نهم الف , دوازدهم شبکه و نرم افزار
        [Required]
        public string Title { get; set; }
        //Feild Of This Class For Example : شبکه و نرم افزار (Optional)
        public Field? Feild { get; set; }
    }
}