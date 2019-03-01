using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace demoapp.Models
{
    public class Student
    {
        [Required(ErrorMessage="required")]
    [Display(Name="student name")]

        public string sname { get; set; }

        [Display(Name = "student address")]
        [DataType(DataType.MultilineText)]

        [Required(ErrorMessage = "required")]
        public string saddress { get; set; }
        [DataType(DataType.EmailAddress)]
        [Display(Name = "student email")]
        [Required(ErrorMessage = "required")]

        public string semail{ get; set; }
        public  string  Gender { get; set; }
        public Course CourseList { get; set; }

       
        public string username { get; set; }
        [Display(Name = "password")]
        [Required(ErrorMessage = "required")]
        
      
        public string password { get; set; }

        [Display(Name = "confirm password")]
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "required")]
        public string confirmpassword { get; set; }

        public bool isagree { get; set; }
    }
   
    public enum Course
    {
        MCA,MBA,Mtech,Btech
    }
    
}
