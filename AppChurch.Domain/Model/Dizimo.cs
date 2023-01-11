using AppChurch.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppChurch.Domain.Model;

public class Dizimo : BaseModel
{
    public decimal Valor { get; set; }
    public string? MesReferente { get; set; }
}

