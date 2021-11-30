using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Web;

namespace BL.Models
{
    public class QuestionAnswer
    {
        public int AnswerID { get; set; }
        public string Title { get; set; }
        public int QuestionID { get; set; }

    }
}