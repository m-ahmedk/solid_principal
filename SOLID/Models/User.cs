using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;
using Microsoft.CodeAnalysis.Scripting;

namespace SOLID.Models
{
    public class User
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserId { get; set; }

        [StringLength(300)]
        public string? Name { get; set; }

        public string? Address { get; set; }

        [StringLength(200)]
        public string? Email { get; set; }

        public string? Password { get; set; }

        public User()
        {

        }

        public User(string email, string password)
        {
            Email = email;
            Password = HashPassword(password);
        }
        
        private string HashPassword(string password)
        {
            return BCrypt.Net.BCrypt.HashPassword(password);
        }

        public bool VerifyPassword(string password)
        {
            return BCrypt.Net.BCrypt.Verify(password, Password);
        }
    }
}