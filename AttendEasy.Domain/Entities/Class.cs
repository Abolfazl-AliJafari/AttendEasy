using AttendEasy.Domain.ValueObjects;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AttendEasy.Domain.Entities
{
    public class Class
    {
        public Class(Level level,
            Field? field,
            Tag? tag)
        {
            Id = Guid.NewGuid();
            if(field is not null)
            {
                Field = field;
                if (tag is not null)
                {
                    Title = string.Join(" ", level.Title, field.Title, tag.Title);
                }
                else
                {
                    Title = string.Join(" ", level.Title, field.Title);
                }
            }
            else
            {
                if (tag is not null)
                {
                    Title = string.Join(" ", level.Title, tag.Title);
                }
                else
                {
                    Title = (string)level.Title;
                }
            }
            if (level is null)
            {
                throw new Exception("Class Level Can Not Null.");
            }
            if (tag is not null)
            {
                Tag = tag;
            }
            Level= level;
        }

        [Required]
        public Guid Id { get; }
        //Title Of Class For Example : کلاس نهم الف , دوازدهم شبکه و نرم افزار
        [Required]
        [DisplayName("عنوان")]
        public Title Title { get; private set; }
        [Required]
        [DisplayName("پایه")]
        //Level Of This Class For Example : 12,1 (پایه مورد نظر)
        public Level Level { get; private set; }
        [DisplayName("رشته")]
        //Feild Of This Class For Example : شبکه و نرم افزار (Optional)
        public Field? Field { get; private set; }
        //Tag Of This Class For Example : کلاس الف , کلاس ب (Optional)
        [DisplayName("برچسب")]
        public Tag? Tag { get; private set; }
         
        public void UpdateTitle(Level level,
            Field? field,
            Tag? tag)
        {
            if (field is not null)
            {
                if (tag is not null)
                {
                    Title = string.Join(" ", level.Title, field.Title, tag.Title);
                }
                else
                {
                    Title = string.Join(" ", level.Title, field.Title);
                }
            }
            else
            {
                if (tag is not null)
                {
                    Title = string.Join(" ", level.Title, tag.Title);
                }
                else
                {
                    Title = (string)level.Title;
                }
            }
        }
    }
    
}