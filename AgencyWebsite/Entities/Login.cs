using Microsoft.EntityFrameworkCore;

namespace AgencyWebsite.Entities
{
    public class Login
    {
        public int LoginId { get; set; }
        public string? Username { get; set; }
        public string? Password { get; set; }
    }
}
