
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplicationDemo1.Models
{
    public class Student
    {
        [Key]
        public int id { get; set; }
        [DisplayName("Name")]
        //[Required(ErrorMessage = "Student name is required")]
        public string name { get; set; }
        [DisplayName("Class")]
        public string _class { get; set; }
        [DisplayName("School")]
        public string school { get; set; }
    }

    public class StudentContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
    }
}