using System;
using System.Collections.Generic;
using System.Text;
using BL.Models;
using DAL.Models;
using System.Linq;

namespace BL
{
    public static class DataBaseExtensions
    {
        public static User ToUser(this UserEntity userEntity)
        {
            User user = new User
            {
                Login = userEntity.Login,
                Admin = userEntity.Admin,
                Password = userEntity.Password,
                UserID = userEntity.UserID,
                Manager = userEntity.Manager
            };
            return user;
        }
        public static IEnumerable<User> ToUser(this IEnumerable<UserEntity> userEntities)
        {
            return userEntities.Select(u => u.ToUser());
        }

        public static Task ToTask(this TaskEntity taskEntity)
        {
            Task task = new Task
            {
                TaskID = taskEntity.TaskID,
                Title = taskEntity.Title,
                Discription = taskEntity.Discription,
                MaxScore = taskEntity.MaxScore,
                Questions = taskEntity.Questions.ToQuestion(),
            };
            return task;
        }
        public static IEnumerable<User> ToTask(this IEnumerable<UserEntity> taskEntities)
        {
            return taskEntities.Select(u => u.ToUser());
        }

        public static Question ToQuestion(this QuestionEntity questionEntity)
        {
            Question question = new Question
            {
                QuestionAnswers = questionEntity.QuestionAnswers.ToQuestionAnswer(),
                QuestionID = questionEntity.QuestionID,
                RightAnswer = questionEntity.RightAnswer,
                TaskID = questionEntity.TaskID,
                Title = questionEntity.Title,

            };
            return question;
        }
        public static IEnumerable<Question> ToQuestion(this IEnumerable<QuestionEntity> questionEntities)
        {
            return questionEntities.Select(u => u.ToQuestion());
        }

        public static QuestionAnswer ToQuestionAnswer(this QuestionAnswerEntity questionAnswerEntity)
        {
            QuestionAnswer user = new QuestionAnswer
            {
                QuestionID = questionAnswerEntity.QuestionID,
                AnswerID = questionAnswerEntity.AnswerID,
                Title = questionAnswerEntity.Title,
            };
            return user;
        }
        public static IEnumerable<QuestionAnswer> ToQuestionAnswer(this IEnumerable<QuestionAnswerEntity> questionAnswerEntities)
        {
            return questionAnswerEntities.Select(u => u.ToQuestionAnswer());
        }
    }
}
