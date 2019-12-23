using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ImageUploadViewDemo.Models
{
    public class Employee
    {
        [Key,Column(Order=0)]
        public int ID { get; set; }

        [Column(Order=1)]
        [Required(ErrorMessage ="Employee Name Required")]
        public string EmployeeName { get; set; }

        [Column(Order=2)]
        [Required(ErrorMessage = "Employee Age Required")]
        public int Age { get; set; }


        [Column(Order=3)]
        [Required(ErrorMessage = "Employee Qualification Required")]
        public string Qualification { get; set; }


        [Column(Order=4)]
        public string ImagePath { get; set; }

        [NotMapped]
        public HttpPostedFileBase ImageFile { get; set; }

    }
}