using System;
using System.Threading.Tasks;
using abp.mono.Interfaces;
using Volo.Abp.Application.Services;
using Volo.Abp.DependencyInjection;
using Volo.Abp.EventBus;
using Volo.Abp.EventBus.Distributed;

namespace abp.mono.Services;

public class TestService (IDistributedEventBus distributedEventBus) : ApplicationService, ITestService
{
    public async Task PublishEvent111111()
    {
        var abd = string.Empty;
        await distributedEventBus.PublishAsync(new TestEvent
        {
            Id = Guid.NewGuid()
        });
    }
}

public class MyHandler
    : IDistributedEventHandler<TestEvent>,
        ITransientDependency
{
    public async Task HandleEventAsync(TestEvent eventData)
    {
        Console.WriteLine($"test event : {eventData.Id}");
    }
}

[EventName("MyApp.Test.StockChange")]
public class TestEvent
{
    public Guid Id { get; set; }
}

