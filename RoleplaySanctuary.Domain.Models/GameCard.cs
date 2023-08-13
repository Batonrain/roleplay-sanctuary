namespace RoleplaySanctuary.Domain.Models;

public class GameCard
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string ImageUrl { get; set; }
    public string Description { get; set; }
    public string Time { get; set; }
    public TimeZoneInfo TimeZone { get; set; }
    public bool IsOnline { get; set; }  
    public bool IsPaid { get; set; }
    public City? City { get; set; }
    public string Setting { get; set; }
    public System System { get; set; }
    public List<Tags> Tags { get; set; }

    public int UserId { get; set; }
    public User.User User { get; set; }
}

