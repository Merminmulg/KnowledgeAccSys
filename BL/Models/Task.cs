using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BL.Models
{
    public class Task
    {
        public int TaskID { get; set; }
        public string Title { get; set; }
        public string Discription { get; set; }
        public int MaxScore { get; set; }

        public IEnumerable<Question> Questions { get; set; }
    }
}