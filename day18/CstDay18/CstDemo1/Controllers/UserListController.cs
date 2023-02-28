using CstDemo1.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace CstDemo1.Controllers
{
    public class UserListController : Controller
    {
        // GET: UserList
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult List()
        {
            var _user = new UserInfo { UserID = 10, UserName = "Tom",UserEmail = "tom@cstcollege.ca",UserMobile="647-833-8777" };
            
            
            string testStr = "Welcome to CST College!!!";

            ViewData["testStr"] = testStr;

            ViewBag.myName = "Cst College Student Xun Dai.";
            TempData["cstName"] = "Hello CST College!!!";

            return View(_user);
        }

        public ActionResult Show()
        {
            string connStr = SqlHelper.GetConnectionString();
            string sqlTxt = "Select * from userinfo where delflag=0";
            using (SqlDataAdapter adapter=new SqlDataAdapter(sqlTxt,connStr))
            {
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                ViewData["dt"] = dt;
            }
                return View();
        }

        public ActionResult AddUser()
        {
            return View();
        }
    }
}