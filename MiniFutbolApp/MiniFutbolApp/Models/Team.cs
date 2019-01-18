using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniFutbolApp.Models
{
    public class Team
    {
        public int Id { get; set; }


        [Required ]
        public string Name { get; set; }


        [Required ]
        public DateTime CreatedDate { get; set; }



        public string Point { get; set; }




        [Required]
        public string PhotoPath { get; set; }
        public Team()
        {
            players = new HashSet<User>();
        }

        public ICollection<User> players { get; set; }
    
    }
}
