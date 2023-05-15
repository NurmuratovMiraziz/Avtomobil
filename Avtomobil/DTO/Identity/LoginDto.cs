using System.ComponentModel.DataAnnotations;

namespace Avtomobil.DTO.Identity
{
    public class LoginDto
    {
        public string Username { get; set; }

        [StringLength(15, ErrorMessage = "Your password is limited to {2} to {1}", MinimumLength = 3)]
        public string Password { get; set; }
    }
}
