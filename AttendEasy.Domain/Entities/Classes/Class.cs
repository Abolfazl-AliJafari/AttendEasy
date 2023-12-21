using AttendEasy.Domain.Entities.Classes.ValueObjects;
using AttendEasy.Domain.Entities.Fieldes;
using AttendEasy.Domain.Entities.Leveles;
using AttendEasy.Domain.Entities.Tags;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

namespace AttendEasy.Domain.Entities.Classes
{
    public class Class
    {
        public Class(Level level,
            Field? feild)
        {
            Id = Guid.NewGuid();
            if(feild is not null)
            {
                Title = string.Join(" ", level.Title, feild.Title);
            }
            else
            {
                Title = (string)level.Title;
            }
            if(level is not null)
            {
                Level = level;
            }
            else
            {
                throw new Exception("Level Cant Null.");
            }
            Feild = feild;
        }

        [Required]
        public Guid Id { get; }
        //Title Of Class For Example : کلاس نهم الف , دوازدهم شبکه و نرم افزار
        [Required]
        public Title Title { get; private set; }
        [Required]
        //Level Of This Class For Example : 12,1 (پایه مورد نظر)
        public Level Level { get; private set; }
        //Feild Of This Class For Example : شبکه و نرم افزار (Optional)
        public Field? Feild { get; private set; }
        //Tag Of This Class For Example : کلاس الف , کلاس ب (Optional)
        public Tag? Tag { get; private set; }
         
        public void UpdateTitle(string title)
        {
            if(title is not null)
            {
                Title = title;
            }
            else
            {
                throw new Exception("New Title Cant Empty.");
            }
        }
    }
    
}