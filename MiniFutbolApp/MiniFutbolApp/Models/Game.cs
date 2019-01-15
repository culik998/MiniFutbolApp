using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniFutbolApp.Models
{
   public  class Game
    {
        public int Id { get; set; }
        public Team HomeTeam { get; set; } 
        public Team AwayTeam { get; set; }
        [ForeignKey("HomeTeam")]
        public int HomeTeamId { get; set; }
        [ForeignKey("AwayTeam")]
        public int AwayTeamId { get; set; }
        public DateTime StartDate { get; set; }
        public string Score { get; set; }
        public byte HomeTeamGoals { get; set; }
        public byte GuestTeamGoals { get; set; }
        public byte HomeTeamScore { get; set; }
        public byte AwayTeamScore { get; set; }

    }
}
