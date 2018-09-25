namespace Admin_tools.Models
{
    public class AppUser
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string FullName { get; set; }
        public bool? Superuser { get; set; }
        public string Email { get; set; }
        public string Telephone { get; set; }
        public string Token { get; set; }

        public bool IsAdmin {get;set;}

    }
}