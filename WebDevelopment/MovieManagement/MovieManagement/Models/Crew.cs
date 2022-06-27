namespace MovieManagement.Models
{
    public class Crew
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Role { get; set; }
        public string Phone { get; set; } = string.Empty;
        public DateTime Dob { get; set; }
    }
}
