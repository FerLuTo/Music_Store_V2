using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using InstruBankV2.Models;





namespace InstruBankV2.Data
{
    public class InstrumentDBContext:DbContext
    {
        public InstrumentDBContext(DbContextOptions<InstrumentDBContext> options): base(options)
        {

        }

        public DbSet<Instrument> Instruments { get; set; }
    }
}
