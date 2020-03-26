using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiaStore_BackEnd.Models
{
    public class User
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public float Weight { get; set; }
        public float Height { get; set; }
        public float CarbsToInsulinUnit { get; set; }
        public float BloodSugarToInsulinUnit { get; set; }
        public DateTime BirthDate { get; set; }
    }
}
