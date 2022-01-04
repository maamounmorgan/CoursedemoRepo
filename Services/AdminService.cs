using CourseDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CourseDemo.Services
{
    public interface IAdminService
    {
        bool Login(string Email, string Password);
        bool ChangePassword(string Email ,string Password );
        bool ForgotPassword(string Email);
    }
    public class AdminService : IAdminService
    {
        public ApplicationDbContext db { get; set; }
        public AdminService()
        {
            db = new ApplicationDbContext();
        }
        public bool Login(string Email, string Password)
        {
            return db.Adms.Where(x => x.Email == Email && x.Password == Password).Any();
        }
        public bool ChangePassword(string Email, string Password)
        {
            throw new NotImplementedException();
        }

        public bool ForgotPassword(string Email)
        {
            throw new NotImplementedException();
        }


    }
}