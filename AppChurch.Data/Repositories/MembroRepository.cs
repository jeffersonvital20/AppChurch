using AppChurch.Data.Context;
using AppChurch.Domain.Model;
using AppChurch.Domain.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppChurch.Data.Repositories
{
    public class MembroRepository : BaseRepository<MembroModel>, IMembroRepository
    {
        public MembroRepository(AppDbContext context) : base(context)
        {
        }
    }
}
