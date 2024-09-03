using System.ComponentModel.DataAnnotations;

public class Animal
{
    public int AnimalID { get; set; }

    [Required(ErrorMessage = "Owner ID is required")]
    public int OwnerID { get; set; }

    [Required(ErrorMessage = "Name is required")]
    [StringLength(100, ErrorMessage = "Name cannot be longer than 100 characters")]
    public string Name { get; set; }

    [Required(ErrorMessage = "Species is required")]
    [StringLength(50, ErrorMessage = "Species cannot be longer than 50 characters")]
    public string Species { get; set; }

    [StringLength(50, ErrorMessage = "Breed cannot be longer than 50 characters")]
    public string Breed { get; set; }

    [Range(0, 30, ErrorMessage = "Age must be between 0 and 30")]
    public int Age { get; set; }

    public string MedicalHistory { get; set; }

    public Owner Owner { get; set; }
    public ICollection<Appointment> Appointments { get; set; }
}
