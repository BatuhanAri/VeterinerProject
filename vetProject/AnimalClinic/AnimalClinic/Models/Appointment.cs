using System.ComponentModel.DataAnnotations;

public class Appointment
{
    public int AppointmentID { get; set; }

    [Required(ErrorMessage = "Animal ID is required")]
    public int AnimalID { get; set; }

    [Required(ErrorMessage = "Date is required")]
    public DateTime Date { get; set; }

    [Required(ErrorMessage = "Reason is required")]
    [StringLength(200, ErrorMessage = "Reason cannot be longer than 200 characters")]
    public string Reason { get; set; }

    public Animal Animal { get; set; }
    public ICollection<Treatment> Treatments { get; set; }
}
