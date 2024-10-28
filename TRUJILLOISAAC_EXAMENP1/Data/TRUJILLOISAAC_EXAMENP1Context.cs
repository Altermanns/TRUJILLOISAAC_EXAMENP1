using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TRUJILLOISAAC_EXAMENP1.Models;

namespace TRUJILLOISAAC_EXAMENP1.Data
{
    public class TRUJILLOISAAC_EXAMENP1Context : DbContext
    {
        public TRUJILLOISAAC_EXAMENP1Context (DbContextOptions<TRUJILLOISAAC_EXAMENP1Context> options)
            : base(options)
        {
        }

        public DbSet<TRUJILLOISAAC_EXAMENP1.Models.ITrujillo> ITrujillo { get; set; } = default!;
        public DbSet<TRUJILLOISAAC_EXAMENP1.Models.Celular> Celular { get; set; } = default!;
    }
}
