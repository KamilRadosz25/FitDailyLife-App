using System;
using System.Collections.Generic;

namespace FitDailyLife.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string Nationality { get; set; }
        public string PasswordHash { get; set; }
        public bool IsAdmin { get; set; }
        public virtual List<BodyParameters> BodyParameters { get; set; }




    }
}
