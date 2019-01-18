using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniFutbolApp.Models
{
    public class User
    {


        public int Id { get; set; }



         [Required(ErrorMessage ="Name is invalid")]
         [StringLength(10,MinimumLength =3, ErrorMessage = "Invalid Name Length ")]
          public string Name { get; set; }



        
        [Required(ErrorMessage = "Surname is invalid")]
        [StringLength(15, MinimumLength = 3, ErrorMessage = "Invalid Surname Length ")]
        public string SurName { get; set; }






        public DateTime RegisterDate { get; set; }



        public DateTime BirthDay { get; set; }



        public Team Team { get; set; }



        [ForeignKey("Team")]
        public int? TeamId { get; set; }



        [Required(ErrorMessage ="Password is invalid")]
        public string Password { get; set; }



        [Compare("Password",ErrorMessage ="Passwords don't match")  ]    
        public string ConfirmPassword { get; set; }




        public string PhotoPath { get; set; }

        public Status Status { get; set; }
    }
}
