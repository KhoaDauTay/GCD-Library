using Microsoft.AspNetCore.Mvc;
using MvcMovie.Models;

namespace MvcMovie.Controllers;

public class StudentController : Controller
{
    // GET
    public Student Index()
    {
        Student studentKhoa = new Student();
        return studentKhoa;
    }

    public string Khoa()
    {
        Student studentKhoa = new Student();
        
        return "kdkskdskd";
        
    }
    public IActionResult List()
    {
        Student studentKhoa1 = new Student();
        Student studentKhoa2 = new Student();
        Student studentKhoa3 = new Student();

        Student[] listStudent = { studentKhoa1, studentKhoa2, studentKhoa3 };
        return View(listStudent);
        
    }
    
}