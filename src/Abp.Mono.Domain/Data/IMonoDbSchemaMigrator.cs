using System.Threading.Tasks;

namespace Abp.Mono.Data;

public interface IMonoDbSchemaMigrator
{
    Task MigrateAsync();
}
