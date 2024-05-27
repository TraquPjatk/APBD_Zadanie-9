using APBD_Zadanie_6.Models;
using APBD_Zadanie_6.Repositories.Implementations;
using APBD_Zadanie_6.Repositories.Interfaces;
using APBD_Zadanie_6.Response;
using Microsoft.AspNetCore.Mvc;

namespace APBD_Zadanie_6.Controllers;
[ApiController]
[Route("api/hospital")]
public class HospitalController : ControllerBase
{
    private readonly IHospitalRepository _repository;

   

}