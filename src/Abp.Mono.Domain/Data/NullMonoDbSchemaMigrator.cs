using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Abp.Mono.Data;

/* This is used if database provider does't define
 * IMonoDbSchemaMigrator implementation.
 */
public class NullMonoDbSchemaMigrator : IMonoDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
