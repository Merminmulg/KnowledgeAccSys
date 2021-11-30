using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Web;

namespace DAL.Models
{
    public class QuestionAnswerEntity
    {
        [Key]
        public int AnswerID { get; set; }
        public string Title { get; set; }
        public int QuestionID { get; set; }

        public QuestionEntity Question { get; set; }
    }
}