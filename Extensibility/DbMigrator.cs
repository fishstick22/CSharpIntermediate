using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpIntermediate.Extensibility
{
    public class DbMigrator
    {
        private readonly ILogger _logger;

        public DbMigrator(ILogger logger)
        {
            _logger = logger;
        }

        public void Migrate()
        {
            _logger.LogInfo("Migrationg started at {0}", DateTime.Now);

            // Details of migrating the database
            _logger.LogError("OOPS, something went sideways...");

            _logger.LogInfo("Migrationg finished at {0}", DateTime.Now);
        }
    }
}
