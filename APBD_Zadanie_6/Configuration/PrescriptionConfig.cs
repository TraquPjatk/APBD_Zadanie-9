using APBD_Zadanie_6.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace APBD_Zadanie_6.Configuration;

public class PrescriptionConfig : IEntityTypeConfiguration<Prescription>
{
    public void Configure(EntityTypeBuilder<Prescription> builder)
    {
        builder.HasKey(e => e.IdPrescription).HasName("IdPrescription_PK");
        builder.Property(e => e.IdPrescription).UseIdentityColumn();

        builder.Property(e => e.Date).IsRequired();
        builder.Property(e => e.DueDate).IsRequired();
    
//        [...]
    }
}