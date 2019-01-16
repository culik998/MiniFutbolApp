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
        public string Name { get; set; }
        public string SurName { get; set; }
        public DateTime RegisterDate { get; set; }
        public DateTime BirthDay { get; set; }
        public Team Team { get; set; }
        [ForeignKey("Team")]

        public int? TeamId { get; set; }
        [Required]
        public string Password { get; set; }
        [Compare("Password")]
        public string ConfirmPassword { get; set; }

        public string PhotoPath { get; set; }
    }
}
