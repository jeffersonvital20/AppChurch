using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppChrch.Shared.ViewModel
{
    public class MembrosViewModel
    {
        public string? Nome { get; set; }
        public int Idade { get; set; }
        public string? sexo { get; set; }
        public DateTime DataConversao { get; set; }
        public DateTime DataBatismo { get; set; }
        public DateTime DataNascimento { get; set; }
    }
}
