using System;
using System.Collections.Generic;
using System.Text;
using DAL.DAL;
using BL.Models;
using System.Linq;
using System.Data.Entity;
using DAL.Models;


namespace BL
{
    public class DataBase
    {
        private SystemContext db = new SystemContext();

        //Getting database like a list
        //Getting database like a list
        //Getting database like a list
        public IEnumerable<Task> GetTasksList()
        {
            return db.Tasks.Select(e => e.ToTask());
        }
        public IEnumerable<QuestionAnswer> GetQuestionAnswersList()
        {
            return db.QuestionAnswers.Select(e => e.ToQuestionAnswer());
        }
        public IEnumerable<Question> GetQuestionsList()
        {
            return db.Questions.Select(e => e.ToQuestion());
        }
        public IEnumerable<User> GetUsersList()
        {
            return db.Users.Select(e => e.ToUser());
        }

        //Adding entities to Database
        //Adding entities to Database
        //Adding entities to Database
        public void AddUser(User userEntity)
        {
            db.Users.Add(new UserEntity()
            {
                Login = userEntity.Login,
                Admin = userEntity.Admin,
                Password = userEntity.Password,
                UserID = userEntity.UserID,
                Manager = userEntity.Manager
            });
            db.SaveChanges();
        }
        public void AddTask(TaskEntity taskEntity)
        {

            db.Tasks.Add(taskEntity);
            db.SaveChanges();
        }
        public void AddQuestion(QuestionEntity questionEntity)
        {
            db.Questions.Add(questionEntity);
            db.SaveChanges();
        }
        public void AddQuestionAnswer(QuestionAnswerEntity questionAnswerEntity)
        {
            db.QuestionAnswers.Add(questionAnswerEntity);
            db.SaveChanges();
        }

        //Changing database entities
        //Changing database entities
        //Changing database entities
        public void EditUser(User userEntity)
        {
            db.Entry(new UserEntity()
            {
                Login = userEntity.Login,
                Admin = userEntity.Admin,
                Password = userEntity.Password,
                UserID = userEntity.UserID,
                Manager = userEntity.Manager
            }).State = EntityState.Modified;
            db.SaveChanges();
        }
        public void EditTask(TaskEntity taskEntity)
        {
            db.Entry(taskEntity).State = EntityState.Modified;
            db.SaveChanges();
        }
        public void EditQuestion(QuestionEntity questionEntity)
        {
            db.Entry(questionEntity).State = EntityState.Modified;
            db.SaveChanges();
        }
        public void EditQuestionAnswer(QuestionAnswerEntity questionAnswerEntity)
        {
            db.Entry(questionAnswerEntity).State = EntityState.Modified;
            db.SaveChanges();
        }
        public void DeleteUser(User userEntity)
        {
            db.Users.Remove(new UserEntity()
            {
                Login = userEntity.Login,
                Admin = userEntity.Admin,
                Password = userEntity.Password,
                UserID = userEntity.UserID,
                Manager = userEntity.Manager
            });
            db.SaveChanges();
        }
        public void BDDispose()
        {
            db.Dispose();
        }
    }
}
