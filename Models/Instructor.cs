using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DNC567.Models
{
    public class Instructor : User
    {
        [MinLength(3)]
        [Display (Name="Instructor Name")]
        public string InstructorName {get;set;}
    }
}