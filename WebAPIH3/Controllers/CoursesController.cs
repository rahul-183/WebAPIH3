using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPIH3.Models;


namespace WebAPIH3.Controllers
{

    public class CoursesController : ApiController
    {
        static List<Course> courses = new List<Course>()
        {
          new Course(){ CourseId=1,CourseName="Android",Trainer="Shawn",Fees=12000,
              CourseDescription="Android Mobile operating system development software"},
          new Course(){ CourseId=2,CourseName="ASP.Net",Trainer="Kevin",Fees=22000,
              CourseDescription="ASP.net is a open source framework" },
          new Course(){ CourseId=3,CourseName="JSP",Trainer="Debaratha",Fees=15000,
              CourseDescription="Java Server page is a technology used for developng web applications"},
           new Course(){ CourseId=4,CourseName="Xamarin.forms",Trainer="Mari Johns",Fees=25000,
              CourseDescription="Xamarin forms are class platform ui tools"}
        };
        // GET api/Courses/1
        public HttpResponseMessage GetCourse(string courseName)
        {
            var course = courses.Where(s => s.CourseName == courseName).FirstOrDefault<Course>();
            if (course != null)
            {
                return Request.CreateResponse<Course>
                    (HttpStatusCode.OK, (Course)course);

            }
            else
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Courses Not Found");
            }

        }
        public HttpResponseMessage Post([FromBody]Course course)
        {
            using(WebAPIContext con=new WebAPIContext())
            {
                con.Courses.Add(course);
                con.SaveChanges();
                var msg = Request.CreateResponse(HttpStatusCode.Created, course);
                return msg;
            }
        }

    }
}
