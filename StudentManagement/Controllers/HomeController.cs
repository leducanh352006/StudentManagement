using Microsoft.AspNetCore.Mvc;
using StudentManagement.Models;
using System.Diagnostics;

namespace StudentManagement.Controllers
{
    public class HomeController : Controller
    {
     
            // 1. Action Index: Xử lý khi người dùng truy cập /Home/Index
            public string Index()
            {
                return "Welcome to ASP.NET MVC";
            }

            // 2. Action About: Xử lý khi người dùng truy cập /Home/About
            public string About()
            {
                return "Sinh viên: Lê Nguyễn Phương Anh";
            }

            // 3. Action Contact: Xử lý khi người dùng truy cập /Home/Contact
            public string Contact()
            {
                return "Email: phuonganh.qh2025@vnu.edu.vn";
            }
        }
    }