using AppChurch.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppChurch.Domain.Model
{
    public class EnderecoModel : BaseModel
    {
        public string? Logradoro { get; set; }
        public int numero { get; set; }
        public int CEP { get; set; }
        public string? Complemento { get; set; }
    }
}
