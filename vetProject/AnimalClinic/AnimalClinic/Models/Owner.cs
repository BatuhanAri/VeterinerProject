using System.ComponentModel.DataAnnotations;

public class Owner
{
    public int OwnerID { get; set; }

    [Required(ErrorMessage = "Name is required")]
    [StringLength(100, ErrorMessage = "Name cannot be longer than 100 characters")]
    public string Name { get; set; }

    [Required(ErrorMessage = "Contact Info is required")]
    [StringLength(200, ErrorMessage = "Contact Info cannot be longer than 200 characters")]
    public string ContactInfo { get; set; }

    public ICollection<Animal> Animals { get; set; }
}
