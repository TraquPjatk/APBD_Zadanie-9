using APBD_Zadanie_6.Models;

namespace APBD_Zadanie_6.Response;

public class PrescriptionRequestDTO
{
    public Patient Patient { get; set; }
    public DateTime Date { get; set; }
    public DateTime DueDate { get; set; }
}