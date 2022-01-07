using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PoderAPI.Data.Configurations
{
    public interface IDatabaseConfig
    {
        string DatabaseName { get; set; }

        string ConnectionString { get; set; }
    }
}
