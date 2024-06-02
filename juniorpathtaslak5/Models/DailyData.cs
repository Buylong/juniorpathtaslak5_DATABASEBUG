using System;
using juniorpathtaslak5.Models;

namespace juniorpathtaslak5.Models
{
    public class DailyData
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string ActivityDescription { get; set; }
        public int StudentId { get; set; }
        public Student Student { get; set; }
    }
}
