using System.Threading.Tasks;

namespace abp.mono.Data;

public interface ImonoDbSchemaMigrator
{
    Task MigrateAsync();
}
