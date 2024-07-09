using Lombiq.Hosting.Tenants.IdleTenantManagement.Tests.UI.Extensions;
using Lombiq.OSOCE.Tests.UI.Helpers;
using Lombiq.Tests.UI.Extensions;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;

namespace Lombiq.OSOCE.Tests.UI.Tests.ModuleTests;

public class BehaviorIdleTenantsTests : UITestBase
{
    public BehaviorIdleTenantsTests(ITestOutputHelper testOutputHelper)
        : base(testOutputHelper)
    {
    }

    [Fact]
    public Task ShuttingDownIdleTenantsShouldWork() =>
        ExecuteTestAfterSetupAsync(
            async context =>
            {
                await context.SignInDirectlyAsync();

                await context.TestIdleTenantManagerBehaviorAsync();

                context.Configuration.AssertAppLogsAsync = async webApplicationInstance =>
                {
                    await webApplicationInstance.OsoceLogsShouldBeEmptyAsync();
                    await webApplicationInstance.AssertAppLogsWithIdleCheckAsync();
                };
            },
            configuration => configuration.SetMaxIdleMinutesAndLoggingForUITest());
}
