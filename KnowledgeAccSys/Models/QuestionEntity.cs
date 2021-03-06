using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace KnowledgeAccSys.Models
{
    public class QuestionEntity
    {
        [Key]
        public int QuestionID { get; set; }
        public string Title { get; set; }
        public int TaskID { get; set; }
        public int RightAnswer { get; set; }

        public virtual ICollection<QuestionAnswerEntity> QuestionAnswers { get; set; }
        public virtual TaskEntity Task { get; set; }
    }
}