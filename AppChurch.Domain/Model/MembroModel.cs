using AppChurch.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppChurch.Domain.Model
{
    public class MembroModel : BaseModel
    {
        public string? Nome { get; set; }
        public int Idade { get; set; }
        public string? sexo { get; set; }
        public DateTime DataConversao { get; set; }
        public DateTime DataBatismo { get; set; }
        public DateTime DataNascimento { get; set; }
        public Guid EnrecoId { get; set; }
        public EnderecoModel? Endereco { get; set; }
        public Guid DizimoId { get; set; }
        public DizimoModel? Dizimo { get; set; }

    }
}
