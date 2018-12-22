using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StoreFront.Models
{
    public class Player
    {
        public int PlayerID { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Position { get; set; }
        public string PlayerPosition { get; set; }
        public float Salary { get; set; }
        public int TeamID { get; set; }
        public string TeamName { get; set; }


    }
}