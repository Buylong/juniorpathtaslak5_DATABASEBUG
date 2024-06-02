using System;
using System.Collections.Generic;
using juniorpathtaslak5.Models;

namespace juniorpathtaslak5.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public ICollection<DailyData> DailyActivities { get; set; }

        // Yaşı hesaplayan bir özellik ekleyelim
        public int Age
        {
            get
            {
                return DateTime.Now.Year - DateOfBirth.Year;
            }
        }
    }
}
