#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace WinFormsApp1.Models;

public partial class Customer
{
    public int Id { get; set; }

    public string FirstName { get; set; }

    public string LastName { get; set; }

    public DateTime? BirthDay { get; set; }

    public string Email { get; set; }

    public Gender? Gender { get; set; }
}