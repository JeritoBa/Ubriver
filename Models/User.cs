namespace Ubriver.Models;

using Microsoft.AspNetCore.Identity;
using Ubriver.Models.Enums;

public class User : IdentityUser
{
    public string FullName { get; set; } = string.Empty;
    public UserRole Role { get; set; } = UserRole.Client;
}