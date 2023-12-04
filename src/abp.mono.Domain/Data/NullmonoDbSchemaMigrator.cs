using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace abp.mono.Data;

/* This is used if database provider does't define
 * ImonoDbSchemaMigrator implementation.
 */
public class NullmonoDbSchemaMigrator : ImonoDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
