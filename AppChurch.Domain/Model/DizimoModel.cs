using AppChurch.Domain.Entities;

namespace AppChurch.Domain.Model;

public class DizimoModel : BaseModel
{
    public decimal Valor { get; set; }
    public string? MesReferente { get; set; }

    public Guid MembroId { get; set; }
}

