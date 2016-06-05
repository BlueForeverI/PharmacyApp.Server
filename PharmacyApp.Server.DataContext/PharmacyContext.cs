using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PharmacyApp.Server.Models;

namespace PharmacyApp.Server.DataContext
{
    public class PharmacyContext : DbContext
    {
        public PharmacyContext() : base("pharmacyDbConnection")
        {
        }

        public DbSet<NomenclatureInput> NomenclatureInputs { get; set; }
    }
}
