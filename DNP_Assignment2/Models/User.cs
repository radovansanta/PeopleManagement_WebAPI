using System.Text.Json.Serialization;

namespace DNP_Assignment2.Models
{
    public class User
    {
        public string Email { get; set; }
        
        public string Password { get; set; }
        
        public string FirstName { get; set; }
        
        public string LastName { get; set; }
    }
}