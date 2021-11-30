using DAL.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;


namespace DAL.DAL
{
    interface ISystemContext
    {
        DbSet<UserEntity> Users { get; set; }
        DbSet<TaskEntity> Tasks { get; set; }
        DbSet<QuestionEntity> Questions { get; set; }
        DbSet<QuestionAnswerEntity> QuestionAnswers { get; set; }
    }
}
