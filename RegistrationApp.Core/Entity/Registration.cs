using System.ComponentModel.DataAnnotations;

namespace RegistrationApp.Core.Entity
{
    public class Registration
    {
        [Key]
        public int Id { get; set; }
        public int Title { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int Gender { get; set; }
        public string Password { get; set; }
        public string Remark { get; set; }
        
    }
}
