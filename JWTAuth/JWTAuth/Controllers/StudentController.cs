using Microsoft.AspNetCore.Mvc;
using MyApi.Models;

namespace MyApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : Controller
    {
        
        //GET: /student/index
        [HttpGet]
        public string Index()
        {
            Student obj = new Student();
            obj.Id = 121;
            obj.Name = "Abhishek";
            obj.Age = 22;
            obj.Address = "Mumbai";
            string data = "Student Id : " + obj.Id + "\nStudent Name : " + obj.Name + "\nStudent Age : " + obj.Age + "\nStudent Address : " + obj.Address;
            return data; ;
        }
    }
}
