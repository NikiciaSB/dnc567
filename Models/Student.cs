using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DNC567.Models
{
    public class Student : User
    {
        [Required]
        [MinLength(3)]
        public string NickName {get;set;}

    }
}