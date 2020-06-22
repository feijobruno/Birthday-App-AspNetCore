using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BirthdayApp.Models
{
    public class People
    {
        public Guid Id { get; set; }
        [Required(ErrorMessage = "Required field")]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Birthday { get; set; }

        public int CalculateAge()
        {
            int age = DateTime.Now.Year - Birthday.Year;
            if (DateTime.Now.DayOfYear < Birthday.DayOfYear)
            {
                age = age - 1;
            }
            return age;
        }

        public DateTime NextBirthday()
        {
            var date = Birthday;
            var year = date.Month < DateTime.Now.Month || (date.Month == DateTime.Now.Month && date.Day < DateTime.Now.Day) ? DateTime.Now.Year + 1 : DateTime.Now.Year;
            var NextBirthday = new DateTime(year, date.Month, date.Day);
            return NextBirthday;
        }
    }


}
