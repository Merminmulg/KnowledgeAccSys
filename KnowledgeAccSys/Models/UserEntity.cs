using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace KnowledgeAccSys.Models
{
    public class UserEntity
    {
        //public UserEntity(int userid, string login, string password, bool admin=false, bool manager=false)
        //{
        //    UserID = userid;
        //    Login = login;
        //    Password = password;
        //    Admin = admin;
        //    Manager = manager;
        //}
        public int UserID { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public bool Admin { get; set; }
        public bool Manager { get; set; }
    }
}