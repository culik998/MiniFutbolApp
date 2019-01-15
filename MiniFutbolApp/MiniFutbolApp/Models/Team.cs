using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniFutbolApp.Models
{
    public class Team
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Point { get; set; }
        public Team()
        {
            players = new HashSet<User>();
        }

        public ICollection<User> players { get; set; }
    
    }
}
