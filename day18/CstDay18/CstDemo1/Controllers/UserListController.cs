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
            //var userInfo = new UserInfo();
            //userInfo.UserID = 10;
            //userInfo.UserName = "Tom";
            //userInfo.UserEmail = "tom@cstcollege.ca";
            //userInfo.UserMobile = "647-833-8777";

            string testStr = "Welcome to CST College!!!";

            ViewData["testStr"] = testStr;

            ViewBag.myName = "Cst College Student Xun Dai.";
            TempData["cstName"] = "Hello CST College!!!";

            return View();
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

        //respond by get.
        public ActionResult AddUser()
        {
            return View();
        }

        public ActionResult ProcessAddUser(FormCollection collection)
        {
            // return Content("add action respond!!!");

            string userName = Request["UserName"];
            int userAge = int.Parse(Request["UserAge"]??"10");
            string userEmail = Request["UserEmail"];
            string userMobile = Request["UserMobile"];
            // save record to database. NoQuery

            string insertSql = "insert UserInfo (UserName,UserPassword,UserAge,UserEmail,UserMobile) values (@UserName,'Cst100.com',@UserAge,'1123@gmail.com',@UserMobile)";

            SqlHelper.ExecuteNoQuery(insertSql, new SqlParameter("@UserName", userName), new SqlParameter("@UserAge", userAge), new SqlParameter("@UserMobile", userMobile), new SqlParameter("@UserEmail", userEmail));

            //, new SqlParameter("@UserEmail", userEmail), new SqlParameter("@UserMobile", userMobile)

            return RedirectToAction("Show");
        }

        public ActionResult Delete(int ID)
        {
            //return Content("delete user");
            string deleteSql = "delete from userinfo where userID=@userid";

            SqlHelper.ExecuteNoQuery(deleteSql, new SqlParameter("@userid", ID));

            return RedirectToAction("Show");
        }

        public ActionResult AddwithValid()
        {
            //return RedirectToAction("Show");
            return View();
        }
    }
}