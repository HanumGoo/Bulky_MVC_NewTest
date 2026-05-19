using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
namespace Bulky1.Models.Models;
// Add profile data for application users by adding properties to the ApplicationUser class
public class ApplicationUser : IdentityUser
{
    [Required]
    public int Name { get; set; }
    public string? StreetAddress { get; set; }
    public string? City { get; set; }
    public string? State { get; set; }
    public string? PostalCode { get; set; }

}
