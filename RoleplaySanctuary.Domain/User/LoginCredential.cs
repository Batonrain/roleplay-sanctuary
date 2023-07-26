namespace RoleplaySanctuary.Domain.User
{
    public class LoginCredential
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public User User { get; set; }
    }
}
