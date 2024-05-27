using APBD_Zadanie_6.Models;
using APBD_Zadanie_6.Repositories.Interfaces;
using APBD_Zadanie_6.Response;

namespace APBD_Zadanie_6.Repositories.Implementations;

public class HospitalRepository : IHospitalRepository
{
    private readonly Context _context;
    
    public HospitalRepository(Context context)
    {
        _context = context;
    }

    public async Task<string> AddPrescriptionAsync(PrescriptionRequestDTO request)
    {
        var patientExists = _context.Patients.FirstOrDefault(e => e.IdPatient == request.Patient.IdPatient);

        if (patientExists == null)
        {
            await _context.Patients.AddAsync(request.Patient);
        }

        //? = new Prescription();
    }
    
}