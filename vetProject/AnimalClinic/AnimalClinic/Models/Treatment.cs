using System.ComponentModel.DataAnnotations;

public class Treatment
{
    public int TreatmentID { get; set; }

    [Required(ErrorMessage = "Appointment ID is required")]
    public int AppointmentID { get; set; }

    [Required(ErrorMessage = "Description is required")]
    [StringLength(500, ErrorMessage = "Description cannot be longer than 500 characters")]
    public string Description { get; set; }

    [Range(0, double.MaxValue, ErrorMessage = "Cost must be a positive value")]
    public decimal Cost { get; set; }

    public Appointment Appointment { get; set; }
}
