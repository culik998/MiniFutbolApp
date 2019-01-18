using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniFutbolApp.Models
{
   public class LoginModel
    {
        [Required(ErrorMessage ="Check Name again")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Check Password again")]
        public string Password { get; set; }
    }
}
