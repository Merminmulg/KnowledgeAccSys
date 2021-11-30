using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BL.Models
{
    public class Question
    {
        public int QuestionID { get; set; }
        public string Title { get; set; }
        public int TaskID { get; set; }
        public int RightAnswer { get; set; }

        public IEnumerable<QuestionAnswer> QuestionAnswers { get; set; }
    }
}