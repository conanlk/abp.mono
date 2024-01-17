using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace abp.mono.Interfaces;

public interface ITestService : IApplicationService
{
    Task PublishEvent111111();
}