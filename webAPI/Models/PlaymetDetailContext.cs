using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace webAPI.Models {
    public class PlaymetDetailContext : DbContext
    {
        public PlaymetDetailContext(DbContextOptions<PlaymetDetailContext> options):base(options) 
        {

        }

        public DbSet<PaymentDetail> PaymentDetails { get; set; }
    }
}
